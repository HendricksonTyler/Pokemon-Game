namespace Pokémon_Game
{
    partial class Display
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
            this.btnMasterBall = new System.Windows.Forms.Button();
            this.btnUltraBall = new System.Windows.Forms.Button();
            this.btnGreatBall = new System.Windows.Forms.Button();
            this.btnPokeBall = new System.Windows.Forms.Button();
            this.btnMaxPotion = new System.Windows.Forms.Button();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblDisclaimer = new System.Windows.Forms.Label();
            this.txtDialog = new System.Windows.Forms.TextBox();
            this.btnFlamethrower = new System.Windows.Forms.Button();
            this.btnAirSlash = new System.Windows.Forms.Button();
            this.btnSolarBeam = new System.Windows.Forms.Button();
            this.btnSlash = new System.Windows.Forms.Button();
            this.lblSlashPP = new System.Windows.Forms.Label();
            this.lblSolarBeamPP = new System.Windows.Forms.Label();
            this.lblFlamethrowerPP = new System.Windows.Forms.Label();
            this.lblAirSlashPP = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.gboMewtwo = new System.Windows.Forms.GroupBox();
            this.lblMewtwoMaxHP = new System.Windows.Forms.Label();
            this.lblMewtwoHP = new System.Windows.Forms.Label();
            this.lblMewtwoLv = new System.Windows.Forms.Label();
            this.progMewtwoHP = new System.Windows.Forms.ProgressBar();
            this.imgMewtwo = new System.Windows.Forms.PictureBox();
            this.imgCharizard = new System.Windows.Forms.PictureBox();
            this.gboCharizard = new System.Windows.Forms.GroupBox();
            this.lblCharizardMaxHP = new System.Windows.Forms.Label();
            this.lblCharizardHP = new System.Windows.Forms.Label();
            this.lblCharizardLv = new System.Windows.Forms.Label();
            this.progCharizardHP = new System.Windows.Forms.ProgressBar();
            this.lblBurned = new System.Windows.Forms.Label();
            this.gboMewtwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMewtwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharizard)).BeginInit();
            this.gboCharizard.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMasterBall
            // 
            this.btnMasterBall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasterBall.Image = global::Pokémon_Game.Properties.Resources.masterball;
            this.btnMasterBall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterBall.Location = new System.Drawing.Point(267, 12);
            this.btnMasterBall.Name = "btnMasterBall";
            this.btnMasterBall.Size = new System.Drawing.Size(75, 53);
            this.btnMasterBall.TabIndex = 0;
            this.btnMasterBall.Text = "x1";
            this.btnMasterBall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMasterBall.UseVisualStyleBackColor = true;
            this.btnMasterBall.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUltraBall
            // 
            this.btnUltraBall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUltraBall.Image = global::Pokémon_Game.Properties.Resources.ultraball;
            this.btnUltraBall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUltraBall.Location = new System.Drawing.Point(267, 71);
            this.btnUltraBall.Name = "btnUltraBall";
            this.btnUltraBall.Size = new System.Drawing.Size(75, 53);
            this.btnUltraBall.TabIndex = 1;
            this.btnUltraBall.Text = "x2";
            this.btnUltraBall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUltraBall.UseVisualStyleBackColor = true;
            this.btnUltraBall.Click += new System.EventHandler(this.btnUltraBall_Click);
            // 
            // btnGreatBall
            // 
            this.btnGreatBall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGreatBall.Image = global::Pokémon_Game.Properties.Resources.greatball;
            this.btnGreatBall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreatBall.Location = new System.Drawing.Point(267, 130);
            this.btnGreatBall.Name = "btnGreatBall";
            this.btnGreatBall.Size = new System.Drawing.Size(75, 53);
            this.btnGreatBall.TabIndex = 2;
            this.btnGreatBall.Text = "x5";
            this.btnGreatBall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreatBall.UseVisualStyleBackColor = true;
            this.btnGreatBall.Click += new System.EventHandler(this.btnGreatBall_Click);
            // 
            // btnPokeBall
            // 
            this.btnPokeBall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPokeBall.Image = global::Pokémon_Game.Properties.Resources.pokeball;
            this.btnPokeBall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPokeBall.Location = new System.Drawing.Point(267, 189);
            this.btnPokeBall.Name = "btnPokeBall";
            this.btnPokeBall.Size = new System.Drawing.Size(75, 53);
            this.btnPokeBall.TabIndex = 3;
            this.btnPokeBall.Text = "x20";
            this.btnPokeBall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPokeBall.UseVisualStyleBackColor = true;
            this.btnPokeBall.Click += new System.EventHandler(this.btnPokeBall_Click);
            // 
            // btnMaxPotion
            // 
            this.btnMaxPotion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxPotion.Image = global::Pokémon_Game.Properties.Resources.maxpotion;
            this.btnMaxPotion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaxPotion.Location = new System.Drawing.Point(267, 248);
            this.btnMaxPotion.Name = "btnMaxPotion";
            this.btnMaxPotion.Size = new System.Drawing.Size(75, 53);
            this.btnMaxPotion.TabIndex = 4;
            this.btnMaxPotion.Text = "x4";
            this.btnMaxPotion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaxPotion.UseVisualStyleBackColor = true;
            this.btnMaxPotion.Click += new System.EventHandler(this.btnMaxPotion_Click);
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Location = new System.Drawing.Point(111, 423);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(147, 13);
            this.lblCreator.TabIndex = 5;
            this.lblCreator.Text = "Created by Tyler Hendrickson";
            // 
            // lblDisclaimer
            // 
            this.lblDisclaimer.AutoSize = true;
            this.lblDisclaimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisclaimer.Location = new System.Drawing.Point(28, 439);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.Size = new System.Drawing.Size(297, 9);
            this.lblDisclaimer.TabIndex = 6;
            this.lblDisclaimer.Text = "Pokémon and all respective names are trademark and copyright of Nintendo 1996-201" +
    "2";
            // 
            // txtDialog
            // 
            this.txtDialog.AcceptsReturn = true;
            this.txtDialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDialog.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDialog.Location = new System.Drawing.Point(12, 203);
            this.txtDialog.Multiline = true;
            this.txtDialog.Name = "txtDialog";
            this.txtDialog.Size = new System.Drawing.Size(234, 73);
            this.txtDialog.TabIndex = 11;
            this.txtDialog.Text = "A wild Mewtwo appeared!";
            this.txtDialog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFlamethrower
            // 
            this.btnFlamethrower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlamethrower.Location = new System.Drawing.Point(12, 301);
            this.btnFlamethrower.Name = "btnFlamethrower";
            this.btnFlamethrower.Size = new System.Drawing.Size(112, 45);
            this.btnFlamethrower.TabIndex = 12;
            this.btnFlamethrower.Text = "Flamethrower";
            this.btnFlamethrower.UseVisualStyleBackColor = true;
            this.btnFlamethrower.Click += new System.EventHandler(this.btnFlamethrower_Click);
            // 
            // btnAirSlash
            // 
            this.btnAirSlash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAirSlash.Location = new System.Drawing.Point(134, 301);
            this.btnAirSlash.Name = "btnAirSlash";
            this.btnAirSlash.Size = new System.Drawing.Size(112, 45);
            this.btnAirSlash.TabIndex = 13;
            this.btnAirSlash.Text = "Air Slash";
            this.btnAirSlash.UseVisualStyleBackColor = true;
            this.btnAirSlash.Click += new System.EventHandler(this.btnAirSlash_Click);
            // 
            // btnSolarBeam
            // 
            this.btnSolarBeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolarBeam.Location = new System.Drawing.Point(12, 352);
            this.btnSolarBeam.Name = "btnSolarBeam";
            this.btnSolarBeam.Size = new System.Drawing.Size(112, 45);
            this.btnSolarBeam.TabIndex = 14;
            this.btnSolarBeam.Text = "Solar Beam";
            this.btnSolarBeam.UseVisualStyleBackColor = true;
            this.btnSolarBeam.Click += new System.EventHandler(this.btnSolarBeam_Click);
            // 
            // btnSlash
            // 
            this.btnSlash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlash.Location = new System.Drawing.Point(134, 352);
            this.btnSlash.Name = "btnSlash";
            this.btnSlash.Size = new System.Drawing.Size(112, 45);
            this.btnSlash.TabIndex = 15;
            this.btnSlash.Text = "Slash";
            this.btnSlash.UseVisualStyleBackColor = true;
            this.btnSlash.Click += new System.EventHandler(this.btnSlash_Click);
            // 
            // lblSlashPP
            // 
            this.lblSlashPP.AutoSize = true;
            this.lblSlashPP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSlashPP.Location = new System.Drawing.Point(171, 400);
            this.lblSlashPP.Name = "lblSlashPP";
            this.lblSlashPP.Size = new System.Drawing.Size(36, 13);
            this.lblSlashPP.TabIndex = 16;
            this.lblSlashPP.Text = "20 PP";
            // 
            // lblSolarBeamPP
            // 
            this.lblSolarBeamPP.AutoSize = true;
            this.lblSolarBeamPP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSolarBeamPP.Location = new System.Drawing.Point(48, 400);
            this.lblSolarBeamPP.Name = "lblSolarBeamPP";
            this.lblSolarBeamPP.Size = new System.Drawing.Size(36, 13);
            this.lblSolarBeamPP.TabIndex = 17;
            this.lblSolarBeamPP.Text = "10 PP";
            // 
            // lblFlamethrowerPP
            // 
            this.lblFlamethrowerPP.AutoSize = true;
            this.lblFlamethrowerPP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFlamethrowerPP.Location = new System.Drawing.Point(48, 285);
            this.lblFlamethrowerPP.Name = "lblFlamethrowerPP";
            this.lblFlamethrowerPP.Size = new System.Drawing.Size(36, 13);
            this.lblFlamethrowerPP.TabIndex = 18;
            this.lblFlamethrowerPP.Text = "15 PP";
            // 
            // lblAirSlashPP
            // 
            this.lblAirSlashPP.AutoSize = true;
            this.lblAirSlashPP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAirSlashPP.Location = new System.Drawing.Point(171, 285);
            this.lblAirSlashPP.Name = "lblAirSlashPP";
            this.lblAirSlashPP.Size = new System.Drawing.Size(36, 13);
            this.lblAirSlashPP.TabIndex = 19;
            this.lblAirSlashPP.Text = "18 PP";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.IndianRed;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Snow;
            this.btnRestart.Location = new System.Drawing.Point(267, 400);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 20;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnA.Location = new System.Drawing.Point(267, 330);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 43);
            this.btnA.TabIndex = 21;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // gboMewtwo
            // 
            this.gboMewtwo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gboMewtwo.Controls.Add(this.lblBurned);
            this.gboMewtwo.Controls.Add(this.lblMewtwoMaxHP);
            this.gboMewtwo.Controls.Add(this.lblMewtwoHP);
            this.gboMewtwo.Controls.Add(this.lblMewtwoLv);
            this.gboMewtwo.Controls.Add(this.progMewtwoHP);
            this.gboMewtwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboMewtwo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gboMewtwo.Location = new System.Drawing.Point(12, 12);
            this.gboMewtwo.Name = "gboMewtwo";
            this.gboMewtwo.Size = new System.Drawing.Size(117, 53);
            this.gboMewtwo.TabIndex = 22;
            this.gboMewtwo.TabStop = false;
            this.gboMewtwo.Text = "Mewtwo";
            // 
            // lblMewtwoMaxHP
            // 
            this.lblMewtwoMaxHP.AutoSize = true;
            this.lblMewtwoMaxHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMewtwoMaxHP.Location = new System.Drawing.Point(57, 34);
            this.lblMewtwoMaxHP.Name = "lblMewtwoMaxHP";
            this.lblMewtwoMaxHP.Size = new System.Drawing.Size(30, 12);
            this.lblMewtwoMaxHP.TabIndex = 25;
            this.lblMewtwoMaxHP.Text = "/ 353";
            // 
            // lblMewtwoHP
            // 
            this.lblMewtwoHP.AutoSize = true;
            this.lblMewtwoHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMewtwoHP.Location = new System.Drawing.Point(37, 34);
            this.lblMewtwoHP.Name = "lblMewtwoHP";
            this.lblMewtwoHP.Size = new System.Drawing.Size(23, 12);
            this.lblMewtwoHP.TabIndex = 24;
            this.lblMewtwoHP.Text = "353";
            this.lblMewtwoHP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMewtwoLv
            // 
            this.lblMewtwoLv.AutoSize = true;
            this.lblMewtwoLv.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMewtwoLv.Location = new System.Drawing.Point(69, 11);
            this.lblMewtwoLv.Name = "lblMewtwoLv";
            this.lblMewtwoLv.Size = new System.Drawing.Size(43, 12);
            this.lblMewtwoLv.TabIndex = 23;
            this.lblMewtwoLv.Text = "Lv. 100";
            // 
            // progMewtwoHP
            // 
            this.progMewtwoHP.Location = new System.Drawing.Point(6, 26);
            this.progMewtwoHP.Name = "progMewtwoHP";
            this.progMewtwoHP.Size = new System.Drawing.Size(106, 5);
            this.progMewtwoHP.TabIndex = 23;
            this.progMewtwoHP.Value = 100;
            // 
            // imgMewtwo
            // 
            this.imgMewtwo.BackColor = System.Drawing.Color.Transparent;
            this.imgMewtwo.Image = global::Pokémon_Game.Properties.Resources.mewtwo;
            this.imgMewtwo.Location = new System.Drawing.Point(162, 26);
            this.imgMewtwo.Name = "imgMewtwo";
            this.imgMewtwo.Size = new System.Drawing.Size(82, 86);
            this.imgMewtwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgMewtwo.TabIndex = 23;
            this.imgMewtwo.TabStop = false;
            // 
            // imgCharizard
            // 
            this.imgCharizard.BackColor = System.Drawing.Color.Transparent;
            this.imgCharizard.Image = global::Pokémon_Game.Properties.Resources.charizard;
            this.imgCharizard.Location = new System.Drawing.Point(-26, 49);
            this.imgCharizard.Name = "imgCharizard";
            this.imgCharizard.Size = new System.Drawing.Size(174, 129);
            this.imgCharizard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCharizard.TabIndex = 24;
            this.imgCharizard.TabStop = false;
            this.imgCharizard.Visible = false;
            // 
            // gboCharizard
            // 
            this.gboCharizard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gboCharizard.Controls.Add(this.lblCharizardMaxHP);
            this.gboCharizard.Controls.Add(this.lblCharizardHP);
            this.gboCharizard.Controls.Add(this.lblCharizardLv);
            this.gboCharizard.Controls.Add(this.progCharizardHP);
            this.gboCharizard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboCharizard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gboCharizard.Location = new System.Drawing.Point(129, 130);
            this.gboCharizard.Name = "gboCharizard";
            this.gboCharizard.Size = new System.Drawing.Size(117, 53);
            this.gboCharizard.TabIndex = 26;
            this.gboCharizard.TabStop = false;
            this.gboCharizard.Text = "Charizard";
            this.gboCharizard.Visible = false;
            // 
            // lblCharizardMaxHP
            // 
            this.lblCharizardMaxHP.AutoSize = true;
            this.lblCharizardMaxHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharizardMaxHP.Location = new System.Drawing.Point(57, 34);
            this.lblCharizardMaxHP.Name = "lblCharizardMaxHP";
            this.lblCharizardMaxHP.Size = new System.Drawing.Size(30, 12);
            this.lblCharizardMaxHP.TabIndex = 25;
            this.lblCharizardMaxHP.Text = "/ 330";
            // 
            // lblCharizardHP
            // 
            this.lblCharizardHP.AutoSize = true;
            this.lblCharizardHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharizardHP.Location = new System.Drawing.Point(37, 34);
            this.lblCharizardHP.Name = "lblCharizardHP";
            this.lblCharizardHP.Size = new System.Drawing.Size(23, 12);
            this.lblCharizardHP.TabIndex = 24;
            this.lblCharizardHP.Text = "330";
            this.lblCharizardHP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCharizardLv
            // 
            this.lblCharizardLv.AutoSize = true;
            this.lblCharizardLv.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharizardLv.Location = new System.Drawing.Point(69, 11);
            this.lblCharizardLv.Name = "lblCharizardLv";
            this.lblCharizardLv.Size = new System.Drawing.Size(43, 12);
            this.lblCharizardLv.TabIndex = 23;
            this.lblCharizardLv.Text = "Lv. 100";
            // 
            // progCharizardHP
            // 
            this.progCharizardHP.Location = new System.Drawing.Point(6, 26);
            this.progCharizardHP.Name = "progCharizardHP";
            this.progCharizardHP.Size = new System.Drawing.Size(106, 5);
            this.progCharizardHP.TabIndex = 23;
            this.progCharizardHP.Value = 100;
            // 
            // lblBurned
            // 
            this.lblBurned.AutoSize = true;
            this.lblBurned.BackColor = System.Drawing.Color.Firebrick;
            this.lblBurned.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBurned.Location = new System.Drawing.Point(68, 10);
            this.lblBurned.Name = "lblBurned";
            this.lblBurned.Size = new System.Drawing.Size(47, 13);
            this.lblBurned.TabIndex = 27;
            this.lblBurned.Text = "Burned";
            this.lblBurned.Visible = false;
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pokémon_Game.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.gboCharizard);
            this.Controls.Add(this.imgMewtwo);
            this.Controls.Add(this.gboMewtwo);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblAirSlashPP);
            this.Controls.Add(this.lblFlamethrowerPP);
            this.Controls.Add(this.lblSolarBeamPP);
            this.Controls.Add(this.lblSlashPP);
            this.Controls.Add(this.btnSlash);
            this.Controls.Add(this.btnSolarBeam);
            this.Controls.Add(this.btnAirSlash);
            this.Controls.Add(this.btnFlamethrower);
            this.Controls.Add(this.txtDialog);
            this.Controls.Add(this.lblDisclaimer);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.btnMaxPotion);
            this.Controls.Add(this.btnPokeBall);
            this.Controls.Add(this.btnGreatBall);
            this.Controls.Add(this.btnUltraBall);
            this.Controls.Add(this.btnMasterBall);
            this.Controls.Add(this.imgCharizard);
            this.Name = "Display";
            this.Text = "Pokémon Game";
            this.gboMewtwo.ResumeLayout(false);
            this.gboMewtwo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMewtwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharizard)).EndInit();
            this.gboCharizard.ResumeLayout(false);
            this.gboCharizard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMasterBall;
        private System.Windows.Forms.Button btnUltraBall;
        private System.Windows.Forms.Button btnGreatBall;
        private System.Windows.Forms.Button btnPokeBall;
        private System.Windows.Forms.Button btnMaxPotion;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Label lblDisclaimer;
        private System.Windows.Forms.TextBox txtDialog;
        private System.Windows.Forms.Button btnFlamethrower;
        private System.Windows.Forms.Button btnAirSlash;
        private System.Windows.Forms.Button btnSolarBeam;
        private System.Windows.Forms.Button btnSlash;
        private System.Windows.Forms.Label lblSlashPP;
        private System.Windows.Forms.Label lblSolarBeamPP;
        private System.Windows.Forms.Label lblFlamethrowerPP;
        private System.Windows.Forms.Label lblAirSlashPP;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.GroupBox gboMewtwo;
        private System.Windows.Forms.ProgressBar progMewtwoHP;
        private System.Windows.Forms.Label lblMewtwoLv;
        private System.Windows.Forms.Label lblMewtwoMaxHP;
        private System.Windows.Forms.Label lblMewtwoHP;
        private System.Windows.Forms.PictureBox imgMewtwo;
        private System.Windows.Forms.PictureBox imgCharizard;
        private System.Windows.Forms.GroupBox gboCharizard;
        private System.Windows.Forms.Label lblCharizardMaxHP;
        private System.Windows.Forms.Label lblCharizardHP;
        private System.Windows.Forms.Label lblCharizardLv;
        private System.Windows.Forms.ProgressBar progCharizardHP;
        private System.Windows.Forms.Label lblBurned;
    }
}

