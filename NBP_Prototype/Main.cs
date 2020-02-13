using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace NBP_Prototype
{
    public partial class Main : Form
    {
        private Profile profile;

        private List<Character> characters;
        private List<Character> allCharacters;

        private Character selectedCharacter;
        private Character player1;
        private Character player2;

        private MongoManager mongo;

        public Main(Profile profile)
        {
            InitializeComponent();

            lblSignedIn.Text = profile.Username;

            mongo = new MongoManager();
            this.profile = profile;

            RefreshList();
            listCharacters.DisplayMember = "Title";
            listResult.DisplayMember = "Title";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CharacterScreen nextForm = new CharacterScreen(profile);
            this.Hide();
            nextForm.ShowDialog();
            this.Show();
            RefreshList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            Character character = (Character) listCharacters.SelectedItem;
            CharacterScreen nextForm = new CharacterScreen(profile, character);
            this.Hide();
            nextForm.ShowDialog();
            this.Show();
            RefreshList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        { 
            var confirmResult = MessageBox.Show("Are you sure you want to delete this character?", "Warning", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                mongo.DeleteCharacter((Character) listCharacters.SelectedItem); //TO DO: fix entry parameter
                profile = mongo.GetProfileData(profile.Username);
                RefreshList();
            }
        }

        private void listCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCharacter = characters.Find(x => x == listCharacters.SelectedItem);
            if (selectedCharacter != null)
                DisplayCharacter(selectedCharacter);
        }

        private void DisplayCharacter(Character character)
        {
            lblName.Text = character.Title;
            lblStr.Text = character.stats[0].ToString();
            lblDex.Text = character.stats[1].ToString();
            lblCon.Text = character.stats[2].ToString();
            lblInt.Text = character.stats[3].ToString();
            lblWis.Text = character.stats[4].ToString();
            lblCha.Text = character.stats[5].ToString();
            txtDescription.Text = character.Description;
            picCharacter.Image = character.Picture;
        }

        private void linkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            characters = mongo.GetCharacters(profile);
            listCharacters.DataSource = characters;
            listCharacters.Update();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            allCharacters = mongo.SearchCharacters(txtName.Text, cmbRace.Text, cmbClass.Text);

            listResult.DataSource = allCharacters;
            listResult.Update();
        }

        private void listResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCharacter = characters.Find(x => x == listResult.SelectedItem);
            if (selectedCharacter != null)
                DisplayCharacter(selectedCharacter);
        }

        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            if (selectedCharacter != null)
            {
                player1 = selectedCharacter;
                lblPlayer1.Text = selectedCharacter.Title;
            }
        }

        private void btnPlayer2_Click(object sender, EventArgs e)
        {
            if (selectedCharacter != null)
            {
                player2 = selectedCharacter;
                lblPlayer2.Text = selectedCharacter.Title;
            }
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            if (player1 != null && player2 != null)
            {
                Arena nextForm = new Arena(player1, player2);
                this.Hide();
                nextForm.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("You must select two characters first.", "Error");
        }
    }
}
