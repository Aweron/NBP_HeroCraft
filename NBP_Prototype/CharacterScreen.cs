using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

public enum Stat { Str, Dex, Con, Int, Wis, Cha }

namespace NBP_Prototype
{
    public partial class CharacterScreen : Form
    {
        private Profile profile;
        private Character character;

        private int pointsAvailable;
        private string status;

        private Button[] statDecrease;
        private Button[] statIncrease;
        private TextBox[] baseStats;
        private Label[] racialStats;
        private TextBox[] totalStats;

        public CharacterScreen(Profile profile)
        {
            InitializeComponent();

            statDecrease = new Button []{ btnStrDec, btnDexDec, btnConDec, btnIntDec, btnWisDec, btnChaDec };
            statIncrease = new Button []{ btnStrInc, btnDexInc, btnConInc, btnIntInc, btnWisInc, btnChaInc };
            baseStats    = new TextBox[]{ txtStrBase, txtDexBase, txtConBase, txtIntBase, txtWisBase, txtChaBase };
            racialStats  = new Label  []{ lblRaceStr, lblRaceDex, lblRaceCon, lblRaceInt, lblRaceWis, lblRaceCha };
            totalStats   = new TextBox[]{ txtStr, txtDex, txtCon, txtInt, txtWis, txtCha };

            this.profile = profile;

            character = new Character();
            status = "New";

            pointsAvailable = 27;
            txtPointsAvail.Text = pointsAvailable.ToString();
        }

        public CharacterScreen(Profile profile, Character _character)
        {
            InitializeComponent();

            statDecrease = new Button [] { btnStrDec, btnDexDec, btnConDec, btnIntDec, btnWisDec, btnChaDec };
            statIncrease = new Button [] { btnStrInc, btnDexInc, btnConInc, btnIntInc, btnWisInc, btnChaInc };
            baseStats    = new TextBox[] { txtStrBase, txtDexBase, txtConBase, txtIntBase, txtWisBase, txtChaBase };
            racialStats  = new Label  [] { lblRaceStr, lblRaceDex, lblRaceCon, lblRaceInt, lblRaceWis, lblRaceCha };
            totalStats   = new TextBox[] { txtStr, txtDex, txtCon, txtInt, txtWis, txtCha };

            this.profile = profile;

            character = new Character(_character);
            status = "Updated";

            pointsAvailable = character.Points;
            txtPointsAvail.Text = pointsAvailable.ToString();

            picCharacter.Image = character.Picture;
            txtDescription.Text = character.Description;

            txtName.Text = character.Name;
            cmbRace.Text = character.Race;
            cmbClass.Text = character.Class;

            UpdateRacial(cmbRace.Text);
            UpdateName();

            for (int i = 0; i < 6; i++)
            {
                totalStats[i].Text = _character.stats[i].ToString();
                int res = _character.stats[i] - Convert.ToInt32(racialStats[i].Text);
                baseStats[i].Text = res.ToString();
                EnableDisableButtons(Convert.ToInt32(baseStats[i].Text), i, true);
                EnableDisableButtons(Convert.ToInt32(baseStats[i].Text), i, false);
            }
        }
        
        private void txtName_Leave(object sender, EventArgs e)
        {
            character.Name = txtName.Text;
            UpdateName();
        }

        private void cmbRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            character.Race = cmbRace.Text;
            UpdateRacial(cmbRace.Text);
            UpdateName();
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            character.Class = cmbClass.Text;
            UpdateName();
        }

        #region Stat Increase

        private void btnStrInc_Click(object sender, EventArgs e)
        {
            IncreaseStat(txtStrBase, (int)Stat.Str);
        }

        private void btnDexInc_Click(object sender, EventArgs e)
        {
            IncreaseStat(txtDexBase, (int)Stat.Dex);
        }

        private void btnConInc_Click(object sender, EventArgs e)
        {
            IncreaseStat(txtConBase, (int)Stat.Con);
        }

        private void btnIntInc_Click(object sender, EventArgs e)
        {
            IncreaseStat(txtIntBase, (int)Stat.Int);
        }

        private void btnWisInc_Click(object sender, EventArgs e)
        {
            IncreaseStat(txtWisBase, (int)Stat.Wis);
        }

        private void btnChaInc_Click(object sender, EventArgs e)
        {
            IncreaseStat(txtChaBase, (int)Stat.Cha);
        }

        #endregion

        #region Stat Decrease

        private void btnStrDec_Click(object sender, EventArgs e)
        {
            DecreaseStat(txtStrBase, (int)Stat.Str);
        }

        private void btnDexDec_Click(object sender, EventArgs e)
        {
            DecreaseStat(txtDexBase, (int)Stat.Dex);
        }

        private void btnConDec_Click(object sender, EventArgs e)
        {
            DecreaseStat(txtConBase, (int)Stat.Con);
        }

        private void btnIntDec_Click(object sender, EventArgs e)
        {
            DecreaseStat(txtIntBase, (int)Stat.Int);
        }

        private void btnWisDec_Click(object sender, EventArgs e)
        {
            DecreaseStat(txtWisBase, (int)Stat.Wis);
        }

        private void btnChaDec_Click(object sender, EventArgs e)
        {
            DecreaseStat(txtChaBase, (int)Stat.Cha);
        }

        #endregion

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                character.Picture = new Bitmap(fileDialog.FileName);
                picCharacter.Image = character.Picture;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateTotal();
            if (character.Name != "" && character.Race != "" && character.Class != "")
            {
                character.Points = Int32.Parse(txtPointsAvail.Text);
                character.Description = txtDescription.Text;

                MongoManager mongo = new MongoManager();

                if (status == "New")
                {
                    mongo.SaveCharacter(profile, character); 
                    mongo.UpdateProfileRefs(profile);
                }
                else    // "Updated"
                    mongo.UpdateCharacter(character);

                this.Close();
            }
            else MessageBox.Show("You must choose a name, race and class before saving.", "Error");
        }

        /////////////////////////////

        private void IncreaseStat(TextBox txtBox, int i)
        {
            int val = Convert.ToInt32(txtBox.Text);

            if (val < 15 && pointsAvailable >= 1)
            {
                if (val >= 13 && pointsAvailable >= 2)
                {
                    val++;
                    pointsAvailable -= 2;
                }
                else if (val < 13)
                {
                    val++;
                    pointsAvailable--;
                }
                txtBox.Text = val.ToString();
                txtPointsAvail.Text = pointsAvailable.ToString();
                UpdateTotal(i);
                EnableDisableButtons(val, i, true);
            }
        }

        private void DecreaseStat(TextBox txtBox, int i)
        {
            int val = Convert.ToInt32(txtBox.Text);

            if (val > 8)
            {
                if (val > 13)
                {
                    pointsAvailable += 2;
                }
                else
                    pointsAvailable++;

                val--;

                txtBox.Text = val.ToString();
                txtPointsAvail.Text = pointsAvailable.ToString();
                UpdateTotal(i);
                EnableDisableButtons(val, i, false);
            }
        }

        private void UpdateRacial(string race)
        {
            switch (race)
            {
                case "Human":
                    for (int i = 0; i < 6; i++)
                        racialStats[i].Text = "1";
                    break;
                case "Elf":
                    for (int i = 0; i < 6; i++)
                    {
                        if (i == (int)Stat.Dex)
                            racialStats[i].Text = "2";
                        else if (i == (int)Stat.Int)
                            racialStats[i].Text = "1";
                        else racialStats[i].Text = "0";
                    }
                    break;
                case "Half-Elf":
                    for (int i = 0; i < 6; i++)
                    {
                        if (i == (int)Stat.Cha)
                            racialStats[i].Text = "2";
                        else if (i == (int)Stat.Int || i == (int)Stat.Dex)
                            racialStats[i].Text = "1";
                        else racialStats[i].Text = "0";
                    }
                    break;
                case "Dwarf":
                    for (int i = 0; i < 6; i++)
                    {
                        if (i == (int)Stat.Con || i == (int)Stat.Str)
                            racialStats[i].Text = "2";
                        else racialStats[i].Text = "0";
                    }
                    break;
                case "Halfling":
                    for (int i = 0; i < 6; i++)
                    {
                        if (i == (int)Stat.Dex)
                            racialStats[i].Text = "2";
                        else if (i == (int)Stat.Cha)
                            racialStats[i].Text = "1";
                        else racialStats[i].Text = "0";
                    }
                    break;
                case "Gnome":
                    for (int i = 0; i < 6; i++)
                    {
                        if (i == (int)Stat.Int)
                            racialStats[i].Text = "2";
                        else if (i == (int)Stat.Con)
                            racialStats[i].Text = "1";
                        else racialStats[i].Text = "0";
                    }
                    break;
                case "Half-Orc":
                    for (int i = 0; i < 6; i++)
                    {
                        if (i == (int)Stat.Str)
                            racialStats[i].Text = "2";
                        else if (i == (int)Stat.Con)
                            racialStats[i].Text = "1";
                        else racialStats[i].Text = "0";
                    }
                    break;
                case "Dragonborn":
                    for (int i = 0; i < 6; i++)
                    {
                        if (i == (int)Stat.Str)
                            racialStats[i].Text = "2";
                        else if (i == (int)Stat.Cha)
                            racialStats[i].Text = "1";
                        else racialStats[i].Text = "0";
                    }
                    break;
                case "Tiefling":
                    for (int i = 0; i < 6; i++)
                    {
                        if (i == (int)Stat.Cha)
                            racialStats[i].Text = "2";
                        else if (i == (int)Stat.Int)
                            racialStats[i].Text = "1";
                        else racialStats[i].Text = "0";
                    }
                    break;
                default:
                    break;
            }
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            for (int i = 0; i < 6; i++)
                UpdateTotal(i);
        }

        private void UpdateTotal(int i)
        {
            int _base;
            int racial;
            int total;

            _base = Convert.ToInt32(baseStats[i].Text);
            racial = Convert.ToInt32(racialStats[i].Text);
            total = _base + racial;
            totalStats[i].Text = total.ToString();
            character.stats[i] = total;
        }

        private void EnableDisableButtons(int val, int i, bool increase)
        {
            if (increase)
            {
                if (val == 15)
                    statIncrease[i].Enabled = false;

                if (pointsAvailable < 2)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (pointsAvailable == 0)
                            statIncrease[j].Enabled = false;
                        else if (baseStats[j].Text == "14")
                            statIncrease[j].Enabled = false;
                    }
                }

                if (val == 9)
                    statDecrease[i].Enabled = true;
            }
            else
            {
                if (val == 8)
                    statDecrease[i].Enabled = false;
                if (val == 14)
                    statIncrease[i].Enabled = true;
                for (int j = 0; j < 6; j++)
                    if (baseStats[j].Text != "15")
                        statIncrease[j].Enabled = true;
            }
        }

        private void UpdateName()
        {
            lblFullName.Visible = true;
            if (cmbRace.Text != "Choose a Race..." && cmbClass.Text != "Choose a Class...")
                lblFullName.Text = character.Title;
            else if (cmbRace.Text == "Choose a Race..." && cmbClass.Text != "Choose a Class...")
                lblFullName.Text = character.Name + ", the " + " " + character.Class;
            else if (cmbRace.Text != "Choose a Race..." && cmbClass.Text == "Choose a Class...")
                lblFullName.Text = character.Name + ", the " + character.Race;
            else lblFullName.Text = character.Name;
        }


    }
}