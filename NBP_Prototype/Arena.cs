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

            btnPrimary1.Enabled = !btnPrimary1.Enabled;
            btnSecondary1.Enabled = !btnSecondary1.Enabled;
            btnPrimary2.Enabled = !btnPrimary2.Enabled;
            btnSecondary2.Enabled = !btnSecondary2.Enabled;

            if (isPlayer1sTurn)
            {
                if (redis.CheckIfEffectActive(isPlayer1sTurn, "Incapacitated"))
                    player1Class.RollSpellSave((int)Stat.Cha, (int)Stat.Wis, player2Class);
            }
            else if (redis.CheckIfEffectActive(isPlayer1sTurn, "Incapacitated"))
                player2Class.RollSpellSave((int)Stat.Cha, (int)Stat.Wis, player1Class);

            redis.IncrementAction();
            RefreshUI();
        }

        private void btnPrimary1_Click(object sender, EventArgs e)
        {
            player1Class.PrimaryAttack(true, player2Class);
            RefreshUI();

        }

        private void btnPrimary2_Click(object sender, EventArgs e)
        {
            player2Class.PrimaryAttack(false, player1Class);
            RefreshUI();
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

    }
}
