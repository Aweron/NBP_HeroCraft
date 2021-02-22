namespace NBP_Prototype
{
    partial class Arena
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
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.btnPrimary1 = new System.Windows.Forms.Button();
            this.btnPrimary2 = new System.Windows.Forms.Button();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.txtCombatLog = new System.Windows.Forms.TextBox();
            this.btnSecondary1 = new System.Windows.Forms.Button();
            this.btnSecondary2 = new System.Windows.Forms.Button();
            this.btnEndRound = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurrentHP1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMaxHP1 = new System.Windows.Forms.Label();
            this.lblMaxResource1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCurrentResource1 = new System.Windows.Forms.Label();
            this.lblAC1 = new System.Windows.Forms.Label();
            this.lblAC2 = new System.Windows.Forms.Label();
            this.lblMaxResource2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCurrentResource2 = new System.Windows.Forms.Label();
            this.lblMaxHP2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCurrentHP2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.btnSurr1 = new System.Windows.Forms.Button();
            this.btnSurr2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayer1
            // 
            this.picPlayer1.Location = new System.Drawing.Point(12, 32);
            this.picPlayer1.Name = "picPlayer1";
            this.picPlayer1.Size = new System.Drawing.Size(200, 200);
            this.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer1.TabIndex = 0;
            this.picPlayer1.TabStop = false;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(12, 9);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(57, 20);
            this.lblPlayer1.TabIndex = 1;
            this.lblPlayer1.Text = "label1";
            // 
            // btnPrimary1
            // 
            this.btnPrimary1.Location = new System.Drawing.Point(12, 304);
            this.btnPrimary1.Name = "btnPrimary1";
            this.btnPrimary1.Size = new System.Drawing.Size(200, 60);
            this.btnPrimary1.TabIndex = 5;
            this.btnPrimary1.Text = "Primary";
            this.btnPrimary1.UseVisualStyleBackColor = true;
            this.btnPrimary1.Click += new System.EventHandler(this.btnPrimary1_Click);
            // 
            // btnPrimary2
            // 
            this.btnPrimary2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrimary2.Location = new System.Drawing.Point(616, 304);
            this.btnPrimary2.Name = "btnPrimary2";
            this.btnPrimary2.Size = new System.Drawing.Size(200, 60);
            this.btnPrimary2.TabIndex = 6;
            this.btnPrimary2.Text = "Primary";
            this.btnPrimary2.UseVisualStyleBackColor = true;
            this.btnPrimary2.Click += new System.EventHandler(this.btnPrimary2_Click);
            // 
            // picPlayer2
            // 
            this.picPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picPlayer2.Location = new System.Drawing.Point(616, 32);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(200, 200);
            this.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer2.TabIndex = 8;
            this.picPlayer2.TabStop = false;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(503, 9);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPlayer2.Size = new System.Drawing.Size(313, 20);
            this.lblPlayer2.TabIndex = 2;
            this.lblPlayer2.Text = "label2";
            // 
            // txtCombatLog
            // 
            this.txtCombatLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCombatLog.Location = new System.Drawing.Point(218, 32);
            this.txtCombatLog.Multiline = true;
            this.txtCombatLog.Name = "txtCombatLog";
            this.txtCombatLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCombatLog.Size = new System.Drawing.Size(392, 397);
            this.txtCombatLog.TabIndex = 9;
            this.txtCombatLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSecondary1
            // 
            this.btnSecondary1.Location = new System.Drawing.Point(12, 370);
            this.btnSecondary1.Name = "btnSecondary1";
            this.btnSecondary1.Size = new System.Drawing.Size(200, 60);
            this.btnSecondary1.TabIndex = 10;
            this.btnSecondary1.Text = "Secondary";
            this.btnSecondary1.UseVisualStyleBackColor = true;
            // 
            // btnSecondary2
            // 
            this.btnSecondary2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSecondary2.Location = new System.Drawing.Point(616, 370);
            this.btnSecondary2.Name = "btnSecondary2";
            this.btnSecondary2.Size = new System.Drawing.Size(200, 60);
            this.btnSecondary2.TabIndex = 11;
            this.btnSecondary2.Text = "Secondary";
            this.btnSecondary2.UseVisualStyleBackColor = true;
            // 
            // btnEndRound
            // 
            this.btnEndRound.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEndRound.Location = new System.Drawing.Point(297, 476);
            this.btnEndRound.Name = "btnEndRound";
            this.btnEndRound.Size = new System.Drawing.Size(234, 60);
            this.btnEndRound.TabIndex = 12;
            this.btnEndRound.Text = "End Round";
            this.btnEndRound.UseVisualStyleBackColor = true;
            this.btnEndRound.Click += new System.EventHandler(this.btnEndRound_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Health:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Resource:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Armor Class:";
            // 
            // lblCurrentHP1
            // 
            this.lblCurrentHP1.AutoSize = true;
            this.lblCurrentHP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentHP1.Location = new System.Drawing.Point(131, 235);
            this.lblCurrentHP1.Name = "lblCurrentHP1";
            this.lblCurrentHP1.Size = new System.Drawing.Size(18, 20);
            this.lblCurrentHP1.TabIndex = 21;
            this.lblCurrentHP1.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(155, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "/";
            // 
            // lblMaxHP1
            // 
            this.lblMaxHP1.AutoSize = true;
            this.lblMaxHP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxHP1.Location = new System.Drawing.Point(174, 235);
            this.lblMaxHP1.Name = "lblMaxHP1";
            this.lblMaxHP1.Size = new System.Drawing.Size(38, 20);
            this.lblMaxHP1.TabIndex = 23;
            this.lblMaxHP1.Text = "max";
            // 
            // lblMaxResource1
            // 
            this.lblMaxResource1.AutoSize = true;
            this.lblMaxResource1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxResource1.Location = new System.Drawing.Point(174, 255);
            this.lblMaxResource1.Name = "lblMaxResource1";
            this.lblMaxResource1.Size = new System.Drawing.Size(38, 20);
            this.lblMaxResource1.TabIndex = 26;
            this.lblMaxResource1.Text = "max";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(155, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "/";
            // 
            // lblCurrentResource1
            // 
            this.lblCurrentResource1.AutoSize = true;
            this.lblCurrentResource1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentResource1.Location = new System.Drawing.Point(131, 255);
            this.lblCurrentResource1.Name = "lblCurrentResource1";
            this.lblCurrentResource1.Size = new System.Drawing.Size(18, 20);
            this.lblCurrentResource1.TabIndex = 24;
            this.lblCurrentResource1.Text = "0";
            // 
            // lblAC1
            // 
            this.lblAC1.AutoSize = true;
            this.lblAC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAC1.Location = new System.Drawing.Point(131, 275);
            this.lblAC1.Name = "lblAC1";
            this.lblAC1.Size = new System.Drawing.Size(18, 20);
            this.lblAC1.TabIndex = 33;
            this.lblAC1.Text = "0";
            // 
            // lblAC2
            // 
            this.lblAC2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAC2.AutoSize = true;
            this.lblAC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAC2.Location = new System.Drawing.Point(735, 275);
            this.lblAC2.Name = "lblAC2";
            this.lblAC2.Size = new System.Drawing.Size(18, 20);
            this.lblAC2.TabIndex = 43;
            this.lblAC2.Text = "0";
            // 
            // lblMaxResource2
            // 
            this.lblMaxResource2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxResource2.AutoSize = true;
            this.lblMaxResource2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxResource2.Location = new System.Drawing.Point(778, 255);
            this.lblMaxResource2.Name = "lblMaxResource2";
            this.lblMaxResource2.Size = new System.Drawing.Size(38, 20);
            this.lblMaxResource2.TabIndex = 42;
            this.lblMaxResource2.Text = "max";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(759, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "/";
            // 
            // lblCurrentResource2
            // 
            this.lblCurrentResource2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentResource2.AutoSize = true;
            this.lblCurrentResource2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentResource2.Location = new System.Drawing.Point(735, 255);
            this.lblCurrentResource2.Name = "lblCurrentResource2";
            this.lblCurrentResource2.Size = new System.Drawing.Size(18, 20);
            this.lblCurrentResource2.TabIndex = 40;
            this.lblCurrentResource2.Text = "0";
            // 
            // lblMaxHP2
            // 
            this.lblMaxHP2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxHP2.AutoSize = true;
            this.lblMaxHP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxHP2.Location = new System.Drawing.Point(778, 235);
            this.lblMaxHP2.Name = "lblMaxHP2";
            this.lblMaxHP2.Size = new System.Drawing.Size(38, 20);
            this.lblMaxHP2.TabIndex = 39;
            this.lblMaxHP2.Text = "max";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(759, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 20);
            this.label15.TabIndex = 38;
            this.label15.Text = "/";
            // 
            // lblCurrentHP2
            // 
            this.lblCurrentHP2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentHP2.AutoSize = true;
            this.lblCurrentHP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentHP2.Location = new System.Drawing.Point(735, 235);
            this.lblCurrentHP2.Name = "lblCurrentHP2";
            this.lblCurrentHP2.Size = new System.Drawing.Size(18, 20);
            this.lblCurrentHP2.TabIndex = 37;
            this.lblCurrentHP2.Text = "0";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(616, 275);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 20);
            this.label17.TabIndex = 36;
            this.label17.Text = "Armor Class:";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(616, 255);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 20);
            this.label18.TabIndex = 35;
            this.label18.Text = "Resource:";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(616, 235);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 20);
            this.label19.TabIndex = 34;
            this.label19.Text = "Health:";
            // 
            // lblAction
            // 
            this.lblAction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.Location = new System.Drawing.Point(480, 453);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(19, 20);
            this.lblAction.TabIndex = 45;
            this.lblAction.Text = "1";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Action Available: ";
            // 
            // lblTurn
            // 
            this.lblTurn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(366, 432);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(99, 20);
            this.lblTurn.TabIndex = 46;
            this.lblTurn.Text = "Player\'s turn.";
            // 
            // btnSurr1
            // 
            this.btnSurr1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSurr1.Location = new System.Drawing.Point(12, 513);
            this.btnSurr1.Name = "btnSurr1";
            this.btnSurr1.Size = new System.Drawing.Size(75, 23);
            this.btnSurr1.TabIndex = 47;
            this.btnSurr1.Text = "Surrender";
            this.btnSurr1.UseVisualStyleBackColor = true;
            this.btnSurr1.Click += new System.EventHandler(this.btnSurr1_Click);
            // 
            // btnSurr2
            // 
            this.btnSurr2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSurr2.Location = new System.Drawing.Point(741, 513);
            this.btnSurr2.Name = "btnSurr2";
            this.btnSurr2.Size = new System.Drawing.Size(75, 23);
            this.btnSurr2.TabIndex = 48;
            this.btnSurr2.Text = "Surrender";
            this.btnSurr2.UseVisualStyleBackColor = true;
            this.btnSurr2.Click += new System.EventHandler(this.btnSurr2_Click);
            // 
            // Arena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 548);
            this.Controls.Add(this.btnSurr2);
            this.Controls.Add(this.btnSurr1);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAC2);
            this.Controls.Add(this.lblMaxResource2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCurrentResource2);
            this.Controls.Add(this.lblMaxHP2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblCurrentHP2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblAC1);
            this.Controls.Add(this.lblMaxResource1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblCurrentResource1);
            this.Controls.Add(this.lblMaxHP1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCurrentHP1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEndRound);
            this.Controls.Add(this.btnSecondary2);
            this.Controls.Add(this.btnSecondary1);
            this.Controls.Add(this.txtCombatLog);
            this.Controls.Add(this.picPlayer2);
            this.Controls.Add(this.btnPrimary2);
            this.Controls.Add(this.btnPrimary1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.picPlayer1);
            this.Name = "Arena";
            this.Text = "Arena";
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer1;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Button btnPrimary1;
        private System.Windows.Forms.Button btnPrimary2;
        private System.Windows.Forms.PictureBox picPlayer2;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.TextBox txtCombatLog;
        private System.Windows.Forms.Button btnSecondary1;
        private System.Windows.Forms.Button btnSecondary2;
        private System.Windows.Forms.Button btnEndRound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCurrentHP1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMaxHP1;
        private System.Windows.Forms.Label lblMaxResource1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCurrentResource1;
        private System.Windows.Forms.Label lblAC1;
        private System.Windows.Forms.Label lblAC2;
        private System.Windows.Forms.Label lblMaxResource2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCurrentResource2;
        private System.Windows.Forms.Label lblMaxHP2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblCurrentHP2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Button btnSurr1;
        private System.Windows.Forms.Button btnSurr2;
    }
}