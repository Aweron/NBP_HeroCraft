using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBP_Prototype
{
    public partial class Arena : Form
    {
        private Character player1, player2;
        private CharacterClass player1Class, player2Class;
        private bool isPlayer1sTurn;

        RedisManager redis;

        public Arena(Character player1, Character player2)
        {
            InitializeComponent();
            redis = new RedisManager();
            
            // Names
            lblPlayer1.Text = player1.Title;
            lblPlayer2.Text = player2.Title;

            // Pictures
            picPlayer1.Image = player1.Picture;
            picPlayer2.Image = player2.Picture;

            // Characters
            this.player1 = player1;
            this.player2 = player2;

            // Character Classes
            player1Class = new CharacterClass(player1);
            player2Class = new CharacterClass(player2);

            // Max Health
            lblMaxHP1.Text = player1Class.MaxHealth.ToString();
            lblMaxHP2.Text = player2Class.MaxHealth.ToString();

            // Max Resources
            lblMaxResource1.Text = player1Class.MaxResource.ToString();
            lblMaxResource2.Text = player2Class.MaxResource.ToString();

            // Armor Class
            lblAC1.Text = player1Class.ArmorClass.ToString();
            lblAC2.Text = player2Class.ArmorClass.ToString();

            // Ability Names
            btnPrimary1.Text = player1Class.PrimaryName;
            btnPrimary2.Text = player2Class.PrimaryName;
            btnSecondary1.Text = player1Class.SecondaryName;
            btnSecondary2.Text = player2Class.SecondaryName;

            // Check if match is started for the first time
            if (!redis.MatchIsInProgress())
            {
                redis.MatchStart(player1Class, player2Class);

                // Roll Initiative

                if (player1Class.RollDie(20) >= player2Class.RollDie(20))
                {
                    redis.SetTurn(true);
                    redis.AddToCombatLog("Player 1 plays first.");
                    lblTurn.Text = "<< Player 1's turn.";
                    //btnPrimary1.Enabled = true;
                    //btnSecondary1.Enabled = true;
                    btnPrimary2.Enabled = false;
                    btnSecondary2.Enabled = false;
                }
                else
                {
                    redis.SetTurn(false);
                    redis.AddToCombatLog("Player 2 plays first.");
                    lblTurn.Text = "Player 2's turn. >>";
                    btnPrimary1.Enabled = false;
                    btnSecondary1.Enabled = false;
                    //btnPrimary2.Enabled = true;
                    //btnSecondary2.Enabled = true;
                }
            }
            else
            {
                
            }

            // Combat Log  
            txtCombatLog.Text = redis.GetCombatLog();

            // Action
            lblAction.Text = redis.GetAction().ToString();

            // Current Health
            lblCurrentHP1.Text = redis.GetHP(true).ToString();
            lblCurrentHP2.Text = redis.GetHP(false).ToString();

            // Current Resource
            lblCurrentResource1.Text = redis.GetResource(true).ToString();
            lblCurrentResource2.Text = redis.GetResource(false).ToString();

        }

        private void btnEndRound_Click(object sender, EventArgs e)
        {
            isPlayer1sTurn = redis.GetTurn();
            redis.SetTurn(!isPlayer1sTurn);
            //isPlayer1sTurn = !isPlayer1sTurn;

            if (redis.GetTurn()) // Player 1's Turn
            {
                lblTurn.Text = "<< Player 1's turn.";

                btnPrimary2.Enabled = false;
                btnSecondary2.Enabled = false;

                if (redis.CheckIfEffectActive(isPlayer1sTurn, "Incapacitated"))
                {
                    if (player1Class.RollSpellSave((int)Stat.Cha, (int)Stat.Wis, player2Class))
                    {
                        redis.IncrementAction();
                        redis.AddToCombatLog(player1.Name + " is no longer incapacitated!");

                        btnPrimary1.Enabled = true;
                        btnSecondary1.Enabled = true;
                    }
                    else
                    {
                        redis.AddToCombatLog(player1.Name + " is still incapacitated! They lose their turn.");

                        btnPrimary1.Enabled = false;
                        btnSecondary1.Enabled = false;
                    }
                }
                else
                {
                    redis.IncrementAction();
                    redis.AddToCombatLog(player1.Name + "'s turn.");

                    btnPrimary1.Enabled = true;
                    btnSecondary1.Enabled = true;
                }
            }
            else // Player 2's Turn
            {
                lblTurn.Text = "Player 2's turn. >>";

                btnPrimary1.Enabled = false;
                btnSecondary1.Enabled = false;
                

                if (redis.CheckIfEffectActive(isPlayer1sTurn, "Incapacitated"))
                {
                    if (player2Class.RollSpellSave((int)Stat.Cha, (int)Stat.Wis, player1Class))
                    {
                        redis.IncrementAction();
                        redis.AddToCombatLog(player1.Name + " is no longer incapacitated!");

                        btnPrimary2.Enabled = true;
                        btnSecondary2.Enabled = true;
                    }
                    else
                    {
                        redis.AddToCombatLog(player1.Name + " is still incapacitated! They lose their turn.");

                        btnPrimary2.Enabled = false;
                        btnSecondary2.Enabled = false;
                    }
                }
                else
                {
                    redis.IncrementAction();
                    redis.AddToCombatLog(player1.Name + "'s turn.");

                    btnPrimary2.Enabled = true;
                    btnSecondary2.Enabled = true;
                }
            }

            RefreshUI();
        }

        private void btnPrimary1_Click(object sender, EventArgs e)
        {
            player1Class.PrimaryAttack(true, player2Class);
            btnPrimary1.Enabled = false;

            RefreshUI();

        }

        private void btnPrimary2_Click(object sender, EventArgs e)
        {
            player2Class.PrimaryAttack(false, player1Class);
            btnPrimary2.Enabled = false;
            RefreshUI();
        }

        private void btnSurr1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you wish to surrender?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                redis.MatchOver();

                MessageBox.Show("Player 2 wins!", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnSurr2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you wish to surrender?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                redis.MatchOver();

                MessageBox.Show("Player 1 wins!", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void RefreshUI()
        {
            lblCurrentHP1.Text = redis.GetHP(true).ToString();
            lblCurrentHP2.Text = redis.GetHP(false).ToString();

            lblCurrentResource1.Text = redis.GetResource(true).ToString();
            lblCurrentResource2.Text = redis.GetResource(false).ToString();

            lblAction.Text = redis.GetAction().ToString();

            txtCombatLog.Text = redis.GetCombatLog();
        }

        private void IsGameOver()
        {
            if (redis.GetHP(true) == 0)
            {
                redis.MatchOver();

                MessageBox.Show("Player 2 wins!", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (redis.GetHP(false) == 0)
            {
                redis.MatchOver();

                MessageBox.Show("Player 1 wins!", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }


    }
}
