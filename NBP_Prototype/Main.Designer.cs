namespace NBP_Prototype
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listCharacters = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.listResult = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSignedIn = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCha = new System.Windows.Forms.Label();
            this.lblWis = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblDex = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.labelCharisma = new System.Windows.Forms.Label();
            this.labelWisdom = new System.Windows.Forms.Label();
            this.labelConstitution = new System.Windows.Forms.Label();
            this.labelIntelligence = new System.Windows.Forms.Label();
            this.labelDexterity = new System.Windows.Forms.Label();
            this.labelStrength = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picCharacter = new System.Windows.Forms.PictureBox();
            this.linkSignOut = new System.Windows.Forms.LinkLabel();
            this.btnPlayer1 = new System.Windows.Forms.Button();
            this.btnPlayer2 = new System.Windows.Forms.Button();
            this.btnFight = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Characters:";
            // 
            // listCharacters
            // 
            this.listCharacters.FormattingEnabled = true;
            this.listCharacters.Location = new System.Drawing.Point(6, 19);
            this.listCharacters.Name = "listCharacters";
            this.listCharacters.Size = new System.Drawing.Size(250, 368);
            this.listCharacters.TabIndex = 3;
            this.listCharacters.SelectedIndexChanged += new System.EventHandler(this.listCharacters_SelectedIndexChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(262, 306);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create new";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(351, 424);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnCreate);
            this.tabPage1.Controls.Add(this.listCharacters);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(343, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage Characters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(262, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(262, 364);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(262, 335);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbRace);
            this.tabPage2.Controls.Add(this.cmbClass);
            this.tabPage2.Controls.Add(this.btnConfirm);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtName);
            this.tabPage2.Controls.Add(this.listResult);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(343, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search All";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbRace
            // 
            this.cmbRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Halfling",
            "Human",
            "Dragonborn",
            "Gnome",
            "Half-Elf",
            "Half-Orc",
            "Tiefling",
            "<Empty>"});
            this.cmbRace.Location = new System.Drawing.Point(6, 58);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(121, 21);
            this.cmbRace.TabIndex = 29;
            this.cmbRace.Text = "<Empty>";
            // 
            // cmbClass
            // 
            this.cmbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "Barbarian",
            "Bard",
            "Cleric",
            "Druid",
            "Fighter",
            "Monk",
            "Paladin",
            "Ranger",
            "Rogue",
            "Sorcerer",
            "Warlock",
            "Wizard",
            "<Empty>"});
            this.cmbClass.Location = new System.Drawing.Point(133, 58);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 21);
            this.cmbClass.TabIndex = 28;
            this.cmbClass.Text = "<Empty>";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(262, 56);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Race:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Class:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 20);
            this.txtName.TabIndex = 5;
            // 
            // listResult
            // 
            this.listResult.FormattingEnabled = true;
            this.listResult.Location = new System.Drawing.Point(6, 85);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(250, 303);
            this.listResult.TabIndex = 4;
            this.listResult.SelectedIndexChanged += new System.EventHandler(this.listResult_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Signed in as:";
            // 
            // lblSignedIn
            // 
            this.lblSignedIn.AutoSize = true;
            this.lblSignedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignedIn.Location = new System.Drawing.Point(80, 9);
            this.lblSignedIn.Name = "lblSignedIn";
            this.lblSignedIn.Size = new System.Drawing.Size(0, 13);
            this.lblSignedIn.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(369, 230);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(403, 157);
            this.txtDescription.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 91;
            this.label4.Text = "Description:";
            // 
            // lblCha
            // 
            this.lblCha.AutoSize = true;
            this.lblCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCha.Location = new System.Drawing.Point(611, 180);
            this.lblCha.Name = "lblCha";
            this.lblCha.Size = new System.Drawing.Size(16, 18);
            this.lblCha.TabIndex = 90;
            this.lblCha.Text = "0";
            // 
            // lblWis
            // 
            this.lblWis.AutoSize = true;
            this.lblWis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWis.Location = new System.Drawing.Point(611, 162);
            this.lblWis.Name = "lblWis";
            this.lblWis.Size = new System.Drawing.Size(16, 18);
            this.lblWis.TabIndex = 89;
            this.lblWis.Text = "0";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInt.Location = new System.Drawing.Point(611, 144);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(16, 18);
            this.lblInt.TabIndex = 88;
            this.lblInt.Text = "0";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.Location = new System.Drawing.Point(611, 126);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(16, 18);
            this.lblCon.TabIndex = 87;
            this.lblCon.Text = "0";
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDex.Location = new System.Drawing.Point(611, 108);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(16, 18);
            this.lblDex.TabIndex = 86;
            this.lblDex.Text = "0";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStr.Location = new System.Drawing.Point(611, 90);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(16, 18);
            this.lblStr.TabIndex = 85;
            this.lblStr.Text = "0";
            // 
            // labelCharisma
            // 
            this.labelCharisma.AutoSize = true;
            this.labelCharisma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharisma.Location = new System.Drawing.Point(529, 180);
            this.labelCharisma.Margin = new System.Windows.Forms.Padding(3, 0, 4, 0);
            this.labelCharisma.Name = "labelCharisma";
            this.labelCharisma.Size = new System.Drawing.Size(76, 18);
            this.labelCharisma.TabIndex = 84;
            this.labelCharisma.Text = "Charisma:";
            // 
            // labelWisdom
            // 
            this.labelWisdom.AutoSize = true;
            this.labelWisdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWisdom.Location = new System.Drawing.Point(537, 162);
            this.labelWisdom.Margin = new System.Windows.Forms.Padding(3, 0, 4, 0);
            this.labelWisdom.Name = "labelWisdom";
            this.labelWisdom.Size = new System.Drawing.Size(68, 18);
            this.labelWisdom.TabIndex = 83;
            this.labelWisdom.Text = "Wisdom:";
            // 
            // labelConstitution
            // 
            this.labelConstitution.AutoSize = true;
            this.labelConstitution.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConstitution.Location = new System.Drawing.Point(514, 126);
            this.labelConstitution.Margin = new System.Windows.Forms.Padding(3, 0, 4, 0);
            this.labelConstitution.Name = "labelConstitution";
            this.labelConstitution.Size = new System.Drawing.Size(91, 18);
            this.labelConstitution.TabIndex = 81;
            this.labelConstitution.Text = "Constitution:";
            // 
            // labelIntelligence
            // 
            this.labelIntelligence.AutoSize = true;
            this.labelIntelligence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntelligence.Location = new System.Drawing.Point(521, 144);
            this.labelIntelligence.Margin = new System.Windows.Forms.Padding(3, 0, 4, 0);
            this.labelIntelligence.Name = "labelIntelligence";
            this.labelIntelligence.Size = new System.Drawing.Size(84, 18);
            this.labelIntelligence.TabIndex = 82;
            this.labelIntelligence.Text = "Intelligence:";
            // 
            // labelDexterity
            // 
            this.labelDexterity.AutoSize = true;
            this.labelDexterity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDexterity.Location = new System.Drawing.Point(536, 108);
            this.labelDexterity.Margin = new System.Windows.Forms.Padding(3, 0, 4, 0);
            this.labelDexterity.Name = "labelDexterity";
            this.labelDexterity.Size = new System.Drawing.Size(69, 18);
            this.labelDexterity.TabIndex = 80;
            this.labelDexterity.Text = "Dexterity:";
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStrength.Location = new System.Drawing.Point(538, 90);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(67, 18);
            this.labelStrength.TabIndex = 79;
            this.labelStrength.Text = "Strength:";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.Location = new System.Drawing.Point(515, 66);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(46, 18);
            this.lblStats.TabIndex = 78;
            this.lblStats.Text = "Stats:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(369, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 77;
            this.lblName.Text = "Name";
            // 
            // picCharacter
            // 
            this.picCharacter.Location = new System.Drawing.Point(369, 66);
            this.picCharacter.Name = "picCharacter";
            this.picCharacter.Size = new System.Drawing.Size(140, 140);
            this.picCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCharacter.TabIndex = 76;
            this.picCharacter.TabStop = false;
            // 
            // linkSignOut
            // 
            this.linkSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkSignOut.AutoSize = true;
            this.linkSignOut.Location = new System.Drawing.Point(726, 9);
            this.linkSignOut.Name = "linkSignOut";
            this.linkSignOut.Size = new System.Drawing.Size(46, 13);
            this.linkSignOut.TabIndex = 8;
            this.linkSignOut.TabStop = true;
            this.linkSignOut.Text = "Sign out";
            this.linkSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignOut_LinkClicked);
            // 
            // btnPlayer1
            // 
            this.btnPlayer1.Location = new System.Drawing.Point(369, 393);
            this.btnPlayer1.Name = "btnPlayer1";
            this.btnPlayer1.Size = new System.Drawing.Size(101, 23);
            this.btnPlayer1.TabIndex = 93;
            this.btnPlayer1.Text = "Select as Player 1";
            this.btnPlayer1.UseVisualStyleBackColor = true;
            this.btnPlayer1.Click += new System.EventHandler(this.btnPlayer1_Click);
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.Location = new System.Drawing.Point(369, 422);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(101, 23);
            this.btnPlayer2.TabIndex = 94;
            this.btnPlayer2.Text = "Select as Player 2";
            this.btnPlayer2.UseVisualStyleBackColor = true;
            this.btnPlayer2.Click += new System.EventHandler(this.btnPlayer2_Click);
            // 
            // btnFight
            // 
            this.btnFight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFight.Location = new System.Drawing.Point(697, 393);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(75, 56);
            this.btnFight.TabIndex = 95;
            this.btnFight.Text = "Fight!";
            this.btnFight.UseVisualStyleBackColor = true;
            this.btnFight.Click += new System.EventHandler(this.btnFight_Click);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(476, 398);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(57, 13);
            this.lblPlayer1.TabIndex = 96;
            this.lblPlayer1.Text = "<Player 1>";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(476, 427);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(57, 13);
            this.lblPlayer2.TabIndex = 97;
            this.lblPlayer2.Text = "<Player 2>";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.btnFight);
            this.Controls.Add(this.btnPlayer2);
            this.Controls.Add(this.btnPlayer1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCha);
            this.Controls.Add(this.lblWis);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.lblDex);
            this.Controls.Add(this.lblStr);
            this.Controls.Add(this.labelCharisma);
            this.Controls.Add(this.labelWisdom);
            this.Controls.Add(this.labelConstitution);
            this.Controls.Add(this.labelIntelligence);
            this.Controls.Add(this.labelDexterity);
            this.Controls.Add(this.labelStrength);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picCharacter);
            this.Controls.Add(this.linkSignOut);
            this.Controls.Add(this.lblSignedIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listCharacters;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSignedIn;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCha;
        private System.Windows.Forms.Label lblWis;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.Label labelCharisma;
        private System.Windows.Forms.Label labelWisdom;
        private System.Windows.Forms.Label labelConstitution;
        private System.Windows.Forms.Label labelIntelligence;
        private System.Windows.Forms.Label labelDexterity;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picCharacter;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.LinkLabel linkSignOut;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPlayer1;
        private System.Windows.Forms.Button btnPlayer2;
        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
    }
}