namespace NBP_Prototype
{
    partial class CharacterScreen
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
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.lblStats = new System.Windows.Forms.Label();
            this.labelStrength = new System.Windows.Forms.Label();
            this.labelDexterity = new System.Windows.Forms.Label();
            this.labelIntelligence = new System.Windows.Forms.Label();
            this.labelConstitution = new System.Windows.Forms.Label();
            this.labelWisdom = new System.Windows.Forms.Label();
            this.labelCharisma = new System.Windows.Forms.Label();
            this.picCharacter = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRacial = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblRaceStr = new System.Windows.Forms.Label();
            this.lblRaceDex = new System.Windows.Forms.Label();
            this.lblRaceCon = new System.Windows.Forms.Label();
            this.lblRaceInt = new System.Windows.Forms.Label();
            this.lblRaceWis = new System.Windows.Forms.Label();
            this.lblRaceCha = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.txtDex = new System.Windows.Forms.TextBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.txtWis = new System.Windows.Forms.TextBox();
            this.txtCha = new System.Windows.Forms.TextBox();
            this.txtPointsAvail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStrBase = new System.Windows.Forms.TextBox();
            this.txtDexBase = new System.Windows.Forms.TextBox();
            this.txtConBase = new System.Windows.Forms.TextBox();
            this.txtIntBase = new System.Windows.Forms.TextBox();
            this.txtWisBase = new System.Windows.Forms.TextBox();
            this.txtChaBase = new System.Windows.Forms.TextBox();
            this.btnStrInc = new System.Windows.Forms.Button();
            this.btnStrDec = new System.Windows.Forms.Button();
            this.btnChaDec = new System.Windows.Forms.Button();
            this.btnWisDec = new System.Windows.Forms.Button();
            this.btnIntDec = new System.Windows.Forms.Button();
            this.btnConDec = new System.Windows.Forms.Button();
            this.btnDexDec = new System.Windows.Forms.Button();
            this.btnChaInc = new System.Windows.Forms.Button();
            this.btnWisInc = new System.Windows.Forms.Button();
            this.btnIntInc = new System.Windows.Forms.Button();
            this.btnConInc = new System.Windows.Forms.Button();
            this.btnDexInc = new System.Windows.Forms.Button();
            this.lblBase = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbClass
            // 
            this.cmbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            "Wizard"});
            this.cmbClass.Location = new System.Drawing.Point(254, 339);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(126, 24);
            this.cmbClass.TabIndex = 27;
            this.cmbClass.Text = "Choose a Class...";
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(228, 312);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(60, 24);
            this.lblClass.TabIndex = 61;
            this.lblClass.Text = "Class:";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRace.Location = new System.Drawing.Point(228, 258);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(59, 24);
            this.lblRace.TabIndex = 60;
            this.lblRace.Text = "Race:";
            // 
            // cmbRace
            // 
            this.cmbRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            "Tiefling"});
            this.cmbRace.Location = new System.Drawing.Point(255, 285);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(126, 24);
            this.cmbRace.TabIndex = 26;
            this.cmbRace.Text = "Choose a Race...";
            this.cmbRace.SelectedIndexChanged += new System.EventHandler(this.cmbRace_SelectedIndexChanged);
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.Location = new System.Drawing.Point(228, 64);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(54, 24);
            this.lblStats.TabIndex = 18;
            this.lblStats.Text = "Stats:";
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStrength.Location = new System.Drawing.Point(240, 88);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(85, 24);
            this.labelStrength.TabIndex = 22;
            this.labelStrength.Text = "Strength:";
            // 
            // labelDexterity
            // 
            this.labelDexterity.AutoSize = true;
            this.labelDexterity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDexterity.Location = new System.Drawing.Point(238, 112);
            this.labelDexterity.Name = "labelDexterity";
            this.labelDexterity.Size = new System.Drawing.Size(87, 24);
            this.labelDexterity.TabIndex = 23;
            this.labelDexterity.Text = "Dexterity:";
            // 
            // labelIntelligence
            // 
            this.labelIntelligence.AutoSize = true;
            this.labelIntelligence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntelligence.Location = new System.Drawing.Point(214, 160);
            this.labelIntelligence.Name = "labelIntelligence";
            this.labelIntelligence.Size = new System.Drawing.Size(111, 24);
            this.labelIntelligence.TabIndex = 25;
            this.labelIntelligence.Text = "Intelligence:";
            // 
            // labelConstitution
            // 
            this.labelConstitution.AutoSize = true;
            this.labelConstitution.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConstitution.Location = new System.Drawing.Point(213, 136);
            this.labelConstitution.Name = "labelConstitution";
            this.labelConstitution.Size = new System.Drawing.Size(112, 24);
            this.labelConstitution.TabIndex = 24;
            this.labelConstitution.Text = "Constitution:";
            // 
            // labelWisdom
            // 
            this.labelWisdom.AutoSize = true;
            this.labelWisdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWisdom.Location = new System.Drawing.Point(241, 184);
            this.labelWisdom.Name = "labelWisdom";
            this.labelWisdom.Size = new System.Drawing.Size(84, 24);
            this.labelWisdom.TabIndex = 26;
            this.labelWisdom.Text = "Wisdom:";
            // 
            // labelCharisma
            // 
            this.labelCharisma.AutoSize = true;
            this.labelCharisma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharisma.Location = new System.Drawing.Point(231, 208);
            this.labelCharisma.Name = "labelCharisma";
            this.labelCharisma.Size = new System.Drawing.Size(94, 24);
            this.labelCharisma.TabIndex = 27;
            this.labelCharisma.Text = "Charisma:";
            // 
            // picCharacter
            // 
            this.picCharacter.Location = new System.Drawing.Point(6, 19);
            this.picCharacter.Name = "picCharacter";
            this.picCharacter.Size = new System.Drawing.Size(184, 184);
            this.picCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCharacter.TabIndex = 11;
            this.picCharacter.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 269);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 58;
            this.lblDescription.Text = "Description:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(228, 366);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 24);
            this.lblName.TabIndex = 59;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(254, 393);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 22);
            this.txtName.TabIndex = 25;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(440, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblRacial
            // 
            this.lblRacial.AutoSize = true;
            this.lblRacial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRacial.Location = new System.Drawing.Point(407, 64);
            this.lblRacial.Name = "lblRacial";
            this.lblRacial.Size = new System.Drawing.Size(61, 24);
            this.lblRacial.TabIndex = 20;
            this.lblRacial.Text = "Racial";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(479, 64);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 24);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total";
            // 
            // lblRaceStr
            // 
            this.lblRaceStr.AutoSize = true;
            this.lblRaceStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaceStr.Location = new System.Drawing.Point(434, 95);
            this.lblRaceStr.Name = "lblRaceStr";
            this.lblRaceStr.Size = new System.Drawing.Size(15, 16);
            this.lblRaceStr.TabIndex = 40;
            this.lblRaceStr.Text = "0";
            // 
            // lblRaceDex
            // 
            this.lblRaceDex.AutoSize = true;
            this.lblRaceDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaceDex.Location = new System.Drawing.Point(434, 119);
            this.lblRaceDex.Name = "lblRaceDex";
            this.lblRaceDex.Size = new System.Drawing.Size(15, 16);
            this.lblRaceDex.TabIndex = 41;
            this.lblRaceDex.Text = "0";
            // 
            // lblRaceCon
            // 
            this.lblRaceCon.AutoSize = true;
            this.lblRaceCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaceCon.Location = new System.Drawing.Point(434, 143);
            this.lblRaceCon.Name = "lblRaceCon";
            this.lblRaceCon.Size = new System.Drawing.Size(15, 16);
            this.lblRaceCon.TabIndex = 42;
            this.lblRaceCon.Text = "0";
            // 
            // lblRaceInt
            // 
            this.lblRaceInt.AutoSize = true;
            this.lblRaceInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaceInt.Location = new System.Drawing.Point(434, 167);
            this.lblRaceInt.Name = "lblRaceInt";
            this.lblRaceInt.Size = new System.Drawing.Size(15, 16);
            this.lblRaceInt.TabIndex = 43;
            this.lblRaceInt.Text = "0";
            // 
            // lblRaceWis
            // 
            this.lblRaceWis.AutoSize = true;
            this.lblRaceWis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaceWis.Location = new System.Drawing.Point(434, 191);
            this.lblRaceWis.Name = "lblRaceWis";
            this.lblRaceWis.Size = new System.Drawing.Size(15, 16);
            this.lblRaceWis.TabIndex = 44;
            this.lblRaceWis.Text = "0";
            // 
            // lblRaceCha
            // 
            this.lblRaceCha.AutoSize = true;
            this.lblRaceCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaceCha.Location = new System.Drawing.Point(434, 215);
            this.lblRaceCha.Name = "lblRaceCha";
            this.lblRaceCha.Size = new System.Drawing.Size(15, 16);
            this.lblRaceCha.TabIndex = 45;
            this.lblRaceCha.Text = "0";
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Location = new System.Drawing.Point(464, 96);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(16, 13);
            this.lblEquals.TabIndex = 46;
            this.lblEquals.Text = "= ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "= ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "= ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(464, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "= ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(464, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "= ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(464, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "= ";
            // 
            // txtStr
            // 
            this.txtStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStr.Location = new System.Drawing.Point(493, 92);
            this.txtStr.Name = "txtStr";
            this.txtStr.ReadOnly = true;
            this.txtStr.Size = new System.Drawing.Size(22, 22);
            this.txtStr.TabIndex = 19;
            this.txtStr.Text = "8";
            this.txtStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDex
            // 
            this.txtDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDex.Location = new System.Drawing.Point(493, 116);
            this.txtDex.Name = "txtDex";
            this.txtDex.ReadOnly = true;
            this.txtDex.Size = new System.Drawing.Size(22, 22);
            this.txtDex.TabIndex = 20;
            this.txtDex.Text = "8";
            this.txtDex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCon
            // 
            this.txtCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCon.Location = new System.Drawing.Point(493, 140);
            this.txtCon.Name = "txtCon";
            this.txtCon.ReadOnly = true;
            this.txtCon.Size = new System.Drawing.Size(22, 22);
            this.txtCon.TabIndex = 21;
            this.txtCon.Text = "8";
            this.txtCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInt
            // 
            this.txtInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInt.Location = new System.Drawing.Point(493, 164);
            this.txtInt.Name = "txtInt";
            this.txtInt.ReadOnly = true;
            this.txtInt.Size = new System.Drawing.Size(22, 22);
            this.txtInt.TabIndex = 22;
            this.txtInt.Text = "8";
            this.txtInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWis
            // 
            this.txtWis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWis.Location = new System.Drawing.Point(493, 188);
            this.txtWis.Name = "txtWis";
            this.txtWis.ReadOnly = true;
            this.txtWis.Size = new System.Drawing.Size(22, 22);
            this.txtWis.TabIndex = 23;
            this.txtWis.Text = "8";
            this.txtWis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCha
            // 
            this.txtCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCha.Location = new System.Drawing.Point(493, 212);
            this.txtCha.Name = "txtCha";
            this.txtCha.ReadOnly = true;
            this.txtCha.Size = new System.Drawing.Size(22, 22);
            this.txtCha.TabIndex = 24;
            this.txtCha.Text = "8";
            this.txtCha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPointsAvail
            // 
            this.txtPointsAvail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPointsAvail.Location = new System.Drawing.Point(232, 34);
            this.txtPointsAvail.Name = "txtPointsAvail";
            this.txtPointsAvail.ReadOnly = true;
            this.txtPointsAvail.Size = new System.Drawing.Size(22, 22);
            this.txtPointsAvail.TabIndex = 0;
            this.txtPointsAvail.Text = "27";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(259, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Points available";
            // 
            // txtStrBase
            // 
            this.txtStrBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStrBase.Location = new System.Drawing.Point(359, 92);
            this.txtStrBase.Name = "txtStrBase";
            this.txtStrBase.ReadOnly = true;
            this.txtStrBase.Size = new System.Drawing.Size(22, 22);
            this.txtStrBase.TabIndex = 2;
            this.txtStrBase.Text = "8";
            this.txtStrBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDexBase
            // 
            this.txtDexBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDexBase.Location = new System.Drawing.Point(359, 116);
            this.txtDexBase.Name = "txtDexBase";
            this.txtDexBase.ReadOnly = true;
            this.txtDexBase.Size = new System.Drawing.Size(22, 22);
            this.txtDexBase.TabIndex = 5;
            this.txtDexBase.Text = "8";
            this.txtDexBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConBase
            // 
            this.txtConBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConBase.Location = new System.Drawing.Point(359, 140);
            this.txtConBase.Name = "txtConBase";
            this.txtConBase.ReadOnly = true;
            this.txtConBase.Size = new System.Drawing.Size(22, 22);
            this.txtConBase.TabIndex = 8;
            this.txtConBase.Text = "8";
            this.txtConBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIntBase
            // 
            this.txtIntBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntBase.Location = new System.Drawing.Point(359, 164);
            this.txtIntBase.Name = "txtIntBase";
            this.txtIntBase.ReadOnly = true;
            this.txtIntBase.Size = new System.Drawing.Size(22, 22);
            this.txtIntBase.TabIndex = 11;
            this.txtIntBase.Text = "8";
            this.txtIntBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWisBase
            // 
            this.txtWisBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWisBase.Location = new System.Drawing.Point(359, 188);
            this.txtWisBase.Name = "txtWisBase";
            this.txtWisBase.ReadOnly = true;
            this.txtWisBase.Size = new System.Drawing.Size(22, 22);
            this.txtWisBase.TabIndex = 14;
            this.txtWisBase.Text = "8";
            this.txtWisBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChaBase
            // 
            this.txtChaBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChaBase.Location = new System.Drawing.Point(359, 212);
            this.txtChaBase.Name = "txtChaBase";
            this.txtChaBase.ReadOnly = true;
            this.txtChaBase.Size = new System.Drawing.Size(22, 22);
            this.txtChaBase.TabIndex = 17;
            this.txtChaBase.Text = "8";
            this.txtChaBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStrInc
            // 
            this.btnStrInc.Location = new System.Drawing.Point(387, 91);
            this.btnStrInc.Name = "btnStrInc";
            this.btnStrInc.Size = new System.Drawing.Size(22, 22);
            this.btnStrInc.TabIndex = 3;
            this.btnStrInc.Text = "+";
            this.btnStrInc.UseVisualStyleBackColor = true;
            this.btnStrInc.Click += new System.EventHandler(this.btnStrInc_Click);
            // 
            // btnStrDec
            // 
            this.btnStrDec.Enabled = false;
            this.btnStrDec.Location = new System.Drawing.Point(331, 91);
            this.btnStrDec.Name = "btnStrDec";
            this.btnStrDec.Size = new System.Drawing.Size(22, 22);
            this.btnStrDec.TabIndex = 1;
            this.btnStrDec.Text = "-";
            this.btnStrDec.UseVisualStyleBackColor = true;
            this.btnStrDec.Click += new System.EventHandler(this.btnStrDec_Click);
            // 
            // btnChaDec
            // 
            this.btnChaDec.Enabled = false;
            this.btnChaDec.Location = new System.Drawing.Point(331, 212);
            this.btnChaDec.Name = "btnChaDec";
            this.btnChaDec.Size = new System.Drawing.Size(22, 22);
            this.btnChaDec.TabIndex = 16;
            this.btnChaDec.Text = "-";
            this.btnChaDec.UseVisualStyleBackColor = true;
            this.btnChaDec.Click += new System.EventHandler(this.btnChaDec_Click);
            // 
            // btnWisDec
            // 
            this.btnWisDec.Enabled = false;
            this.btnWisDec.Location = new System.Drawing.Point(331, 188);
            this.btnWisDec.Name = "btnWisDec";
            this.btnWisDec.Size = new System.Drawing.Size(22, 22);
            this.btnWisDec.TabIndex = 13;
            this.btnWisDec.Text = "-";
            this.btnWisDec.UseVisualStyleBackColor = true;
            this.btnWisDec.Click += new System.EventHandler(this.btnWisDec_Click);
            // 
            // btnIntDec
            // 
            this.btnIntDec.Enabled = false;
            this.btnIntDec.Location = new System.Drawing.Point(331, 164);
            this.btnIntDec.Name = "btnIntDec";
            this.btnIntDec.Size = new System.Drawing.Size(22, 22);
            this.btnIntDec.TabIndex = 10;
            this.btnIntDec.Text = "-";
            this.btnIntDec.UseVisualStyleBackColor = true;
            this.btnIntDec.Click += new System.EventHandler(this.btnIntDec_Click);
            // 
            // btnConDec
            // 
            this.btnConDec.Enabled = false;
            this.btnConDec.Location = new System.Drawing.Point(331, 140);
            this.btnConDec.Name = "btnConDec";
            this.btnConDec.Size = new System.Drawing.Size(22, 22);
            this.btnConDec.TabIndex = 7;
            this.btnConDec.Text = "-";
            this.btnConDec.UseVisualStyleBackColor = true;
            this.btnConDec.Click += new System.EventHandler(this.btnConDec_Click);
            // 
            // btnDexDec
            // 
            this.btnDexDec.Enabled = false;
            this.btnDexDec.Location = new System.Drawing.Point(331, 116);
            this.btnDexDec.Name = "btnDexDec";
            this.btnDexDec.Size = new System.Drawing.Size(22, 22);
            this.btnDexDec.TabIndex = 4;
            this.btnDexDec.Text = "-";
            this.btnDexDec.UseVisualStyleBackColor = true;
            this.btnDexDec.Click += new System.EventHandler(this.btnDexDec_Click);
            // 
            // btnChaInc
            // 
            this.btnChaInc.Location = new System.Drawing.Point(387, 212);
            this.btnChaInc.Name = "btnChaInc";
            this.btnChaInc.Size = new System.Drawing.Size(22, 22);
            this.btnChaInc.TabIndex = 18;
            this.btnChaInc.Text = "+";
            this.btnChaInc.UseVisualStyleBackColor = true;
            this.btnChaInc.Click += new System.EventHandler(this.btnChaInc_Click);
            // 
            // btnWisInc
            // 
            this.btnWisInc.Location = new System.Drawing.Point(387, 187);
            this.btnWisInc.Name = "btnWisInc";
            this.btnWisInc.Size = new System.Drawing.Size(22, 22);
            this.btnWisInc.TabIndex = 15;
            this.btnWisInc.Text = "+";
            this.btnWisInc.UseVisualStyleBackColor = true;
            this.btnWisInc.Click += new System.EventHandler(this.btnWisInc_Click);
            // 
            // btnIntInc
            // 
            this.btnIntInc.Location = new System.Drawing.Point(387, 164);
            this.btnIntInc.Name = "btnIntInc";
            this.btnIntInc.Size = new System.Drawing.Size(22, 22);
            this.btnIntInc.TabIndex = 12;
            this.btnIntInc.Text = "+";
            this.btnIntInc.UseVisualStyleBackColor = true;
            this.btnIntInc.Click += new System.EventHandler(this.btnIntInc_Click);
            // 
            // btnConInc
            // 
            this.btnConInc.Location = new System.Drawing.Point(387, 140);
            this.btnConInc.Name = "btnConInc";
            this.btnConInc.Size = new System.Drawing.Size(22, 22);
            this.btnConInc.TabIndex = 9;
            this.btnConInc.Text = "+";
            this.btnConInc.UseVisualStyleBackColor = true;
            this.btnConInc.Click += new System.EventHandler(this.btnConInc_Click);
            // 
            // btnDexInc
            // 
            this.btnDexInc.Location = new System.Drawing.Point(387, 116);
            this.btnDexInc.Name = "btnDexInc";
            this.btnDexInc.Size = new System.Drawing.Size(22, 22);
            this.btnDexInc.TabIndex = 6;
            this.btnDexInc.Text = "+";
            this.btnDexInc.UseVisualStyleBackColor = true;
            this.btnDexInc.Click += new System.EventHandler(this.btnDexInc_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(340, 64);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(52, 24);
            this.lblBase.TabIndex = 19;
            this.lblBase.Text = "Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(415, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(415, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "+";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(415, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 16);
            this.label13.TabIndex = 35;
            this.label13.Text = "+";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(12, 9);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(49, 16);
            this.lblFullName.TabIndex = 62;
            this.lblFullName.Text = "Name";
            this.lblFullName.Visible = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(6, 209);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(86, 23);
            this.btnUpload.TabIndex = 73;
            this.btnUpload.Text = "Upload Picture";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 285);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(196, 164);
            this.txtDescription.TabIndex = 74;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picCharacter);
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 238);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            // 
            // CharacterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.btnDexInc);
            this.Controls.Add(this.btnConInc);
            this.Controls.Add(this.btnIntInc);
            this.Controls.Add(this.btnWisInc);
            this.Controls.Add(this.btnChaInc);
            this.Controls.Add(this.btnDexDec);
            this.Controls.Add(this.btnConDec);
            this.Controls.Add(this.btnIntDec);
            this.Controls.Add(this.btnWisDec);
            this.Controls.Add(this.btnChaDec);
            this.Controls.Add(this.btnStrDec);
            this.Controls.Add(this.btnStrInc);
            this.Controls.Add(this.txtChaBase);
            this.Controls.Add(this.txtWisBase);
            this.Controls.Add(this.txtIntBase);
            this.Controls.Add(this.txtConBase);
            this.Controls.Add(this.txtDexBase);
            this.Controls.Add(this.txtStrBase);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPointsAvail);
            this.Controls.Add(this.txtCha);
            this.Controls.Add(this.txtWis);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.txtCon);
            this.Controls.Add(this.txtDex);
            this.Controls.Add(this.txtStr);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblRaceCha);
            this.Controls.Add(this.lblRaceWis);
            this.Controls.Add(this.lblRaceInt);
            this.Controls.Add(this.lblRaceCon);
            this.Controls.Add(this.lblRaceDex);
            this.Controls.Add(this.lblRaceStr);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblRacial);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.labelCharisma);
            this.Controls.Add(this.labelWisdom);
            this.Controls.Add(this.labelConstitution);
            this.Controls.Add(this.labelIntelligence);
            this.Controls.Add(this.labelDexterity);
            this.Controls.Add(this.labelStrength);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.cmbRace);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cmbClass);
            this.Name = "CharacterScreen";
            this.Text = "Character Creation";
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Label labelDexterity;
        private System.Windows.Forms.Label labelIntelligence;
        private System.Windows.Forms.Label labelConstitution;
        private System.Windows.Forms.Label labelWisdom;
        private System.Windows.Forms.Label labelCharisma;
        private System.Windows.Forms.PictureBox picCharacter;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRacial;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblRaceStr;
        private System.Windows.Forms.Label lblRaceDex;
        private System.Windows.Forms.Label lblRaceCon;
        private System.Windows.Forms.Label lblRaceInt;
        private System.Windows.Forms.Label lblRaceWis;
        private System.Windows.Forms.Label lblRaceCha;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.TextBox txtDex;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.TextBox txtWis;
        private System.Windows.Forms.TextBox txtCha;
        private System.Windows.Forms.TextBox txtPointsAvail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStrBase;
        private System.Windows.Forms.TextBox txtDexBase;
        private System.Windows.Forms.TextBox txtConBase;
        private System.Windows.Forms.TextBox txtIntBase;
        private System.Windows.Forms.TextBox txtWisBase;
        private System.Windows.Forms.TextBox txtChaBase;
        private System.Windows.Forms.Button btnStrInc;
        private System.Windows.Forms.Button btnStrDec;
        private System.Windows.Forms.Button btnChaDec;
        private System.Windows.Forms.Button btnWisDec;
        private System.Windows.Forms.Button btnIntDec;
        private System.Windows.Forms.Button btnConDec;
        private System.Windows.Forms.Button btnDexDec;
        private System.Windows.Forms.Button btnChaInc;
        private System.Windows.Forms.Button btnWisInc;
        private System.Windows.Forms.Button btnIntInc;
        private System.Windows.Forms.Button btnConInc;
        private System.Windows.Forms.Button btnDexInc;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

