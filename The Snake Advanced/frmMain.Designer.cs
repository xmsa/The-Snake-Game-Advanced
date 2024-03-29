﻿namespace The_Snake_Advanced
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.coBoxLaw = new System.Windows.Forms.ComboBox();
            this.coBoxSnakeColor = new System.Windows.Forms.ComboBox();
            this.coBoxBackGroundColor = new System.Windows.Forms.ComboBox();
            this.chBoxFoodShiftSpeed = new System.Windows.Forms.CheckBox();
            this.chBoxWall = new System.Windows.Forms.CheckBox();
            this.lblLaw = new System.Windows.Forms.Label();
            this.lblSnakeSize = new System.Windows.Forms.Label();
            this.lblBackGroundColor = new System.Windows.Forms.Label();
            this.lblSnakeColor = new System.Windows.Forms.Label();
            this.lblFoodShiftSpeed = new System.Windows.Forms.Label();
            this.lblSnakeSpeed = new System.Windows.Forms.Label();
            this.trBarFoodShiftSpeed = new System.Windows.Forms.TrackBar();
            this.trBarSnakeSize = new System.Windows.Forms.TrackBar();
            this.trBarSnakeSpeed = new System.Windows.Forms.TrackBar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.playAgainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarLevel = new System.Windows.Forms.ProgressBar();
            this.timerMoveSnake = new System.Windows.Forms.Timer(this.components);
            this.timerShiftFood = new System.Windows.Forms.Timer(this.components);
            this.timerShiftStarFood = new System.Windows.Forms.Timer(this.components);
            this.panelSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBarFoodShiftSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarSnakeSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarSnakeSpeed)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSetting
            // 
            this.panelSetting.BackColor = System.Drawing.Color.Transparent;
            this.panelSetting.Controls.Add(this.btnPlay);
            this.panelSetting.Controls.Add(this.coBoxLaw);
            this.panelSetting.Controls.Add(this.coBoxSnakeColor);
            this.panelSetting.Controls.Add(this.coBoxBackGroundColor);
            this.panelSetting.Controls.Add(this.chBoxFoodShiftSpeed);
            this.panelSetting.Controls.Add(this.chBoxWall);
            this.panelSetting.Controls.Add(this.lblLaw);
            this.panelSetting.Controls.Add(this.lblSnakeSize);
            this.panelSetting.Controls.Add(this.lblBackGroundColor);
            this.panelSetting.Controls.Add(this.lblSnakeColor);
            this.panelSetting.Controls.Add(this.lblFoodShiftSpeed);
            this.panelSetting.Controls.Add(this.lblSnakeSpeed);
            this.panelSetting.Controls.Add(this.trBarFoodShiftSpeed);
            this.panelSetting.Controls.Add(this.trBarSnakeSize);
            this.panelSetting.Controls.Add(this.trBarSnakeSpeed);
            this.panelSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSetting.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F);
            this.panelSetting.Location = new System.Drawing.Point(700, 24);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(200, 576);
            this.panelSetting.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(3, 481);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(194, 92);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // coBoxLaw
            // 
            this.coBoxLaw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxLaw.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F);
            this.coBoxLaw.FormattingEnabled = true;
            this.coBoxLaw.Items.AddRange(new object[] {
            "Overfly",
            "Cuting Snake",
            "Not Cutting Snake",
            "Return On Snake"});
            this.coBoxLaw.Location = new System.Drawing.Point(3, 200);
            this.coBoxLaw.Name = "coBoxLaw";
            this.coBoxLaw.Size = new System.Drawing.Size(194, 34);
            this.coBoxLaw.TabIndex = 8;
            // 
            // coBoxSnakeColor
            // 
            this.coBoxSnakeColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxSnakeColor.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F);
            this.coBoxSnakeColor.FormattingEnabled = true;
            this.coBoxSnakeColor.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green"});
            this.coBoxSnakeColor.Location = new System.Drawing.Point(3, 98);
            this.coBoxSnakeColor.Name = "coBoxSnakeColor";
            this.coBoxSnakeColor.Size = new System.Drawing.Size(194, 34);
            this.coBoxSnakeColor.TabIndex = 7;
            this.coBoxSnakeColor.SelectedIndexChanged += new System.EventHandler(this.CoBoxSnakeColor_SelectedIndexChanged);
            // 
            // coBoxBackGroundColor
            // 
            this.coBoxBackGroundColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxBackGroundColor.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F);
            this.coBoxBackGroundColor.FormattingEnabled = true;
            this.coBoxBackGroundColor.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green"});
            this.coBoxBackGroundColor.Location = new System.Drawing.Point(3, 32);
            this.coBoxBackGroundColor.Name = "coBoxBackGroundColor";
            this.coBoxBackGroundColor.Size = new System.Drawing.Size(194, 34);
            this.coBoxBackGroundColor.TabIndex = 6;
            this.coBoxBackGroundColor.SelectedIndexChanged += new System.EventHandler(this.CoBoxBackGroundColor_SelectedIndexChanged);
            // 
            // chBoxFoodShiftSpeed
            // 
            this.chBoxFoodShiftSpeed.AutoSize = true;
            this.chBoxFoodShiftSpeed.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F);
            this.chBoxFoodShiftSpeed.Location = new System.Drawing.Point(173, 434);
            this.chBoxFoodShiftSpeed.Name = "chBoxFoodShiftSpeed";
            this.chBoxFoodShiftSpeed.Size = new System.Drawing.Size(15, 14);
            this.chBoxFoodShiftSpeed.TabIndex = 5;
            this.chBoxFoodShiftSpeed.UseVisualStyleBackColor = true;
            this.chBoxFoodShiftSpeed.CheckedChanged += new System.EventHandler(this.ChBoxFoodShiftSpeed_CheckedChanged);
            // 
            // chBoxWall
            // 
            this.chBoxWall.AutoSize = true;
            this.chBoxWall.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F);
            this.chBoxWall.Location = new System.Drawing.Point(20, 164);
            this.chBoxWall.Name = "chBoxWall";
            this.chBoxWall.Size = new System.Drawing.Size(56, 30);
            this.chBoxWall.TabIndex = 5;
            this.chBoxWall.Text = "Wall";
            this.chBoxWall.UseVisualStyleBackColor = true;
            // 
            // lblLaw
            // 
            this.lblLaw.AutoSize = true;
            this.lblLaw.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F);
            this.lblLaw.Location = new System.Drawing.Point(82, 135);
            this.lblLaw.Name = "lblLaw";
            this.lblLaw.Size = new System.Drawing.Size(34, 26);
            this.lblLaw.TabIndex = 4;
            this.lblLaw.Text = "Law";
            // 
            // lblSnakeSize
            // 
            this.lblSnakeSize.AutoSize = true;
            this.lblSnakeSize.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F);
            this.lblSnakeSize.Location = new System.Drawing.Point(3, 241);
            this.lblSnakeSize.Name = "lblSnakeSize";
            this.lblSnakeSize.Size = new System.Drawing.Size(76, 26);
            this.lblSnakeSize.TabIndex = 4;
            this.lblSnakeSize.Text = "Snake Size: ";
            // 
            // lblBackGroundColor
            // 
            this.lblBackGroundColor.AutoSize = true;
            this.lblBackGroundColor.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackGroundColor.Location = new System.Drawing.Point(42, 3);
            this.lblBackGroundColor.Name = "lblBackGroundColor";
            this.lblBackGroundColor.Size = new System.Drawing.Size(115, 26);
            this.lblBackGroundColor.TabIndex = 4;
            this.lblBackGroundColor.Text = "BackGround Color";
            // 
            // lblSnakeColor
            // 
            this.lblSnakeColor.AutoSize = true;
            this.lblSnakeColor.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F);
            this.lblSnakeColor.Location = new System.Drawing.Point(60, 69);
            this.lblSnakeColor.Name = "lblSnakeColor";
            this.lblSnakeColor.Size = new System.Drawing.Size(79, 26);
            this.lblSnakeColor.TabIndex = 4;
            this.lblSnakeColor.Text = "Snake Color";
            // 
            // lblFoodShiftSpeed
            // 
            this.lblFoodShiftSpeed.AutoSize = true;
            this.lblFoodShiftSpeed.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F);
            this.lblFoodShiftSpeed.Location = new System.Drawing.Point(3, 401);
            this.lblFoodShiftSpeed.Name = "lblFoodShiftSpeed";
            this.lblFoodShiftSpeed.Size = new System.Drawing.Size(110, 26);
            this.lblFoodShiftSpeed.TabIndex = 4;
            this.lblFoodShiftSpeed.Text = "Food Shift Speed: ";
            // 
            // lblSnakeSpeed
            // 
            this.lblSnakeSpeed.AutoSize = true;
            this.lblSnakeSpeed.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F);
            this.lblSnakeSpeed.Location = new System.Drawing.Point(3, 317);
            this.lblSnakeSpeed.Name = "lblSnakeSpeed";
            this.lblSnakeSpeed.Size = new System.Drawing.Size(87, 26);
            this.lblSnakeSpeed.TabIndex = 4;
            this.lblSnakeSpeed.Text = "Snake Speed: ";
            // 
            // trBarFoodShiftSpeed
            // 
            this.trBarFoodShiftSpeed.Location = new System.Drawing.Point(3, 430);
            this.trBarFoodShiftSpeed.Maximum = 6;
            this.trBarFoodShiftSpeed.Minimum = 1;
            this.trBarFoodShiftSpeed.Name = "trBarFoodShiftSpeed";
            this.trBarFoodShiftSpeed.Size = new System.Drawing.Size(164, 45);
            this.trBarFoodShiftSpeed.TabIndex = 3;
            this.trBarFoodShiftSpeed.Value = 3;
            // 
            // trBarSnakeSize
            // 
            this.trBarSnakeSize.Location = new System.Drawing.Point(3, 270);
            this.trBarSnakeSize.Maximum = 5;
            this.trBarSnakeSize.Minimum = 1;
            this.trBarSnakeSize.Name = "trBarSnakeSize";
            this.trBarSnakeSize.Size = new System.Drawing.Size(194, 45);
            this.trBarSnakeSize.TabIndex = 3;
            this.trBarSnakeSize.Value = 3;
            this.trBarSnakeSize.ValueChanged += new System.EventHandler(this.TrBarSnakeSize_ValueChanged);
            // 
            // trBarSnakeSpeed
            // 
            this.trBarSnakeSpeed.Location = new System.Drawing.Point(3, 346);
            this.trBarSnakeSpeed.Maximum = 6;
            this.trBarSnakeSpeed.Minimum = 1;
            this.trBarSnakeSpeed.Name = "trBarSnakeSpeed";
            this.trBarSnakeSpeed.Size = new System.Drawing.Size(194, 45);
            this.trBarSnakeSpeed.TabIndex = 3;
            this.trBarSnakeSpeed.Value = 3;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playAgainToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.helpMainToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(900, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            // 
            // playAgainToolStripMenuItem
            // 
            this.playAgainToolStripMenuItem.Name = "playAgainToolStripMenuItem";
            this.playAgainToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.playAgainToolStripMenuItem.Text = "PlayAgain";
            this.playAgainToolStripMenuItem.Click += new System.EventHandler(this.PlayStopToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.SettingToolStripMenuItem_Click);
            // 
            // helpMainToolStripMenuItem
            // 
            this.helpMainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem2,
            this.helpToolStripMenuItem});
            this.helpMainToolStripMenuItem.Name = "helpMainToolStripMenuItem";
            this.helpMainToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpMainToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // progressBarLevel
            // 
            this.progressBarLevel.Location = new System.Drawing.Point(220, 0);
            this.progressBarLevel.Name = "progressBarLevel";
            this.progressBarLevel.Size = new System.Drawing.Size(677, 24);
            this.progressBarLevel.TabIndex = 4;
            // 
            // timerMoveSnake
            // 
            this.timerMoveSnake.Tick += new System.EventHandler(this.TimerMoveSnake_Tick);
            // 
            // timerShiftFood
            // 
            this.timerShiftFood.Tick += new System.EventHandler(this.TimerShiftFood_Tick);
            // 
            // timerShiftStarFood
            // 
            this.timerShiftStarFood.Tick += new System.EventHandler(this.TimerShiftStarFood_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.progressBarLevel);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.panelSetting.ResumeLayout(false);
            this.panelSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBarFoodShiftSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarSnakeSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarSnakeSpeed)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem playAgainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TrackBar trBarSnakeSpeed;
        private System.Windows.Forms.Label lblSnakeSpeed;
        private System.Windows.Forms.TrackBar trBarFoodShiftSpeed;
        private System.Windows.Forms.TrackBar trBarSnakeSize;
        private System.Windows.Forms.ComboBox coBoxSnakeColor;
        private System.Windows.Forms.ComboBox coBoxBackGroundColor;
        private System.Windows.Forms.CheckBox chBoxWall;
        private System.Windows.Forms.Label lblLaw;
        private System.Windows.Forms.Label lblSnakeSize;
        private System.Windows.Forms.Label lblBackGroundColor;
        private System.Windows.Forms.Label lblSnakeColor;
        private System.Windows.Forms.Label lblFoodShiftSpeed;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.CheckBox chBoxFoodShiftSpeed;
        private System.Windows.Forms.Timer timerMoveSnake;
        private System.Windows.Forms.ComboBox coBoxLaw;
        private System.Windows.Forms.Timer timerShiftFood;
        private System.Windows.Forms.Timer timerShiftStarFood;
        public System.Windows.Forms.ProgressBar progressBarLevel;
    }
}

