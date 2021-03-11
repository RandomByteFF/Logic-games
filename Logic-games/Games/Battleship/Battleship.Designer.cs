using System;
using System.Drawing;

namespace Logic_games
{
    partial class Battleship
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Battleship));
            this.menuStartButton = new System.Windows.Forms.Button();
            this.menuBackButton = new System.Windows.Forms.Button();
            this.menuErrorLabel = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.winCupPicturebox = new System.Windows.Forms.PictureBox();
            this.winStatisticsLabel = new System.Windows.Forms.Label();
            this.winnerLb = new System.Windows.Forms.Label();
            this.titlePicturebox = new System.Windows.Forms.PictureBox();
            this.winContiniueButton = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winCupPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlePicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStartButton
            // 
            this.menuStartButton.Location = new System.Drawing.Point(13, 72);
            this.menuStartButton.Name = "menuStartButton";
            this.menuStartButton.Size = new System.Drawing.Size(272, 25);
            this.menuStartButton.TabIndex = 0;
            this.menuStartButton.Text = "Start game";
            this.menuStartButton.UseVisualStyleBackColor = true;
            this.menuStartButton.Click += new System.EventHandler(this.menuStartButton_Click);
            // 
            // menuBackButton
            // 
            this.menuBackButton.Location = new System.Drawing.Point(13, 103);
            this.menuBackButton.Name = "menuBackButton";
            this.menuBackButton.Size = new System.Drawing.Size(269, 21);
            this.menuBackButton.TabIndex = 3;
            this.menuBackButton.Text = "Back";
            this.menuBackButton.UseVisualStyleBackColor = true;
            this.menuBackButton.Click += new System.EventHandler(this.menuBackButton_Click);
            // 
            // menuErrorLabel
            // 
            this.menuErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuErrorLabel.AutoSize = true;
            this.menuErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.menuErrorLabel.Location = new System.Drawing.Point(40, 100);
            this.menuErrorLabel.Name = "menuErrorLabel";
            this.menuErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.menuErrorLabel.TabIndex = 4;
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.menuErrorLabel);
            this.menuPanel.Controls.Add(this.menuBackButton);
            this.menuPanel.Controls.Add(this.menuStartButton);
            this.menuPanel.Controls.Add(this.winCupPicturebox);
            this.menuPanel.Controls.Add(this.winStatisticsLabel);
            this.menuPanel.Controls.Add(this.winnerLb);
            this.menuPanel.Controls.Add(this.titlePicturebox);
            this.menuPanel.Controls.Add(this.winContiniueButton);
            this.menuPanel.Location = new System.Drawing.Point(214, 106);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(10);
            this.menuPanel.Size = new System.Drawing.Size(297, 201);
            this.menuPanel.TabIndex = 3;
            // 
            // winCupPicturebox
            // 
            this.winCupPicturebox.BackgroundImage = global::Logic_games.Properties.Resources.record;
            this.winCupPicturebox.Location = new System.Drawing.Point(57, 109);
            this.winCupPicturebox.Name = "winCupPicturebox";
            this.winCupPicturebox.Size = new System.Drawing.Size(32, 39);
            this.winCupPicturebox.TabIndex = 8;
            this.winCupPicturebox.TabStop = false;
            // 
            // winStatisticsLabel
            // 
            this.winStatisticsLabel.AutoSize = true;
            this.winStatisticsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.winStatisticsLabel.Location = new System.Drawing.Point(95, 125);
            this.winStatisticsLabel.Name = "winStatisticsLabel";
            this.winStatisticsLabel.Size = new System.Drawing.Size(44, 20);
            this.winStatisticsLabel.TabIndex = 7;
            this.winStatisticsLabel.Text = "wins:";
            this.winStatisticsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // winnerLb
            // 
            this.winnerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.winnerLb.Location = new System.Drawing.Point(-1, 66);
            this.winnerLb.Name = "winnerLb";
            this.winnerLb.Size = new System.Drawing.Size(297, 47);
            this.winnerLb.TabIndex = 6;
            this.winnerLb.Text = "Winner";
            this.winnerLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titlePicturebox
            // 
            this.titlePicturebox.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.titlePicturebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titlePicturebox.BackColor = System.Drawing.Color.Transparent;
            this.titlePicturebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titlePicturebox.BackgroundImage")));
            this.titlePicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titlePicturebox.Location = new System.Drawing.Point(11, 13);
            this.titlePicturebox.Name = "titlePicturebox";
            this.titlePicturebox.Size = new System.Drawing.Size(272, 43);
            this.titlePicturebox.TabIndex = 5;
            this.titlePicturebox.TabStop = false;
            // 
            // winContiniueButton
            // 
            this.winContiniueButton.Location = new System.Drawing.Point(99, 161);
            this.winContiniueButton.Name = "winContiniueButton";
            this.winContiniueButton.Size = new System.Drawing.Size(95, 24);
            this.winContiniueButton.TabIndex = 3;
            this.winContiniueButton.Text = "Continue";
            this.winContiniueButton.UseVisualStyleBackColor = true;
            this.winContiniueButton.Click += new System.EventHandler(this.winContiniueButton_Click);
            // 
            // Battleship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 415);
            this.Controls.Add(this.menuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Battleship";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battleship";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winCupPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlePicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuStartButton;
        private System.Windows.Forms.Button menuBackButton;
        private System.Windows.Forms.Label menuErrorLabel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox winCupPicturebox;
        private System.Windows.Forms.Label winStatisticsLabel;
        private System.Windows.Forms.Label winnerLb;
        private System.Windows.Forms.PictureBox titlePicturebox;
        private System.Windows.Forms.Button winContiniueButton;
    }
}