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
            this.startBtn = new System.Windows.Forms.Button();
            this.gameModeCB = new System.Windows.Forms.ComboBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.errorLb = new System.Windows.Forms.Label();
            this.titlePicture = new System.Windows.Forms.PictureBox();
            this.nameTB1 = new System.Windows.Forms.TextBox();
            this.nameTB2 = new System.Windows.Forms.TextBox();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.winPanel = new System.Windows.Forms.Panel();
            this.cupPB = new System.Windows.Forms.PictureBox();
            this.statLb = new System.Windows.Forms.Label();
            this.winnerLb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ContiniueBTN = new System.Windows.Forms.Button();
            this.gameLP1 = new System.Windows.Forms.TableLayoutPanel();
            this.gamePanel = new System.Windows.Forms.TableLayoutPanel();
            this.rightMenuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gameLP2 = new System.Windows.Forms.TableLayoutPanel();
            this.waitPanel = new System.Windows.Forms.Panel();
            this.waitLB = new System.Windows.Forms.Label();
            this.waitBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.winPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cupPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gameLP1.SuspendLayout();
            this.waitPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(200, 71);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(85, 25);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start game";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // gameModeCB
            // 
            this.gameModeCB.FormattingEnabled = true;
            this.gameModeCB.Items.AddRange(new object[] {
            "Single player",
            "Local"});
            this.gameModeCB.Location = new System.Drawing.Point(11, 72);
            this.gameModeCB.Name = "gameModeCB";
            this.gameModeCB.Size = new System.Drawing.Size(183, 21);
            this.gameModeCB.TabIndex = 1;
            this.gameModeCB.Text = "Select game mode...";
            this.gameModeCB.SelectedIndexChanged += new System.EventHandler(this.gameModeCB_SelectedIndexChanged);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(224, 164);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(61, 21);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // errorLb
            // 
            this.errorLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLb.AutoSize = true;
            this.errorLb.ForeColor = System.Drawing.Color.Maroon;
            this.errorLb.Location = new System.Drawing.Point(40, 100);
            this.errorLb.Name = "errorLb";
            this.errorLb.Size = new System.Drawing.Size(0, 13);
            this.errorLb.TabIndex = 4;
            // 
            // titlePicture
            // 
            this.titlePicture.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.titlePicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titlePicture.BackColor = System.Drawing.Color.Transparent;
            this.titlePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titlePicture.BackgroundImage")));
            this.titlePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titlePicture.Location = new System.Drawing.Point(11, 13);
            this.titlePicture.Name = "titlePicture";
            this.titlePicture.Size = new System.Drawing.Size(272, 43);
            this.titlePicture.TabIndex = 5;
            this.titlePicture.TabStop = false;
            // 
            // nameTB1
            // 
            this.nameTB1.Location = new System.Drawing.Point(13, 109);
            this.nameTB1.MaxLength = 20;
            this.nameTB1.Name = "nameTB1";
            this.nameTB1.Size = new System.Drawing.Size(162, 20);
            this.nameTB1.TabIndex = 6;
            this.nameTB1.Text = "Player 1";
            this.nameTB1.Visible = false;
            // 
            // nameTB2
            // 
            this.nameTB2.Location = new System.Drawing.Point(13, 135);
            this.nameTB2.MaxLength = 20;
            this.nameTB2.Name = "nameTB2";
            this.nameTB2.Size = new System.Drawing.Size(162, 20);
            this.nameTB2.TabIndex = 7;
            this.nameTB2.Text = "Player 2";
            this.nameTB2.Visible = false;
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.winPanel);
            this.menuPanel.Controls.Add(this.nameTB2);
            this.menuPanel.Controls.Add(this.nameTB1);
            this.menuPanel.Controls.Add(this.titlePicture);
            this.menuPanel.Controls.Add(this.errorLb);
            this.menuPanel.Controls.Add(this.backBtn);
            this.menuPanel.Controls.Add(this.gameModeCB);
            this.menuPanel.Controls.Add(this.startBtn);
            this.menuPanel.Location = new System.Drawing.Point(214, 106);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(10);
            this.menuPanel.Size = new System.Drawing.Size(297, 201);
            this.menuPanel.TabIndex = 3;
            // 
            // winPanel
            // 
            this.winPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.winPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.winPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.winPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winPanel.Controls.Add(this.cupPB);
            this.winPanel.Controls.Add(this.statLb);
            this.winPanel.Controls.Add(this.winnerLb);
            this.winPanel.Controls.Add(this.pictureBox1);
            this.winPanel.Controls.Add(this.ContiniueBTN);
            this.winPanel.Location = new System.Drawing.Point(-1, -1);
            this.winPanel.Name = "winPanel";
            this.winPanel.Padding = new System.Windows.Forms.Padding(10);
            this.winPanel.Size = new System.Drawing.Size(297, 201);
            this.winPanel.TabIndex = 8;
            this.winPanel.Visible = false;
            // 
            // cupPB
            // 
            this.cupPB.BackgroundImage = global::Logic_games.Properties.Resources.record;
            this.cupPB.Location = new System.Drawing.Point(57, 109);
            this.cupPB.Name = "cupPB";
            this.cupPB.Size = new System.Drawing.Size(32, 39);
            this.cupPB.TabIndex = 8;
            this.cupPB.TabStop = false;
            // 
            // statLb
            // 
            this.statLb.AutoSize = true;
            this.statLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statLb.Location = new System.Drawing.Point(95, 125);
            this.statLb.Name = "statLb";
            this.statLb.Size = new System.Drawing.Size(44, 20);
            this.statLb.TabIndex = 7;
            this.statLb.Text = "wins:";
            this.statLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // winnerLb
            // 
            this.winnerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.winnerLb.Location = new System.Drawing.Point(-1, 59);
            this.winnerLb.Name = "winnerLb";
            this.winnerLb.Size = new System.Drawing.Size(297, 47);
            this.winnerLb.TabIndex = 6;
            this.winnerLb.Text = "Winner";
            this.winnerLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 43);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ContiniueBTN
            // 
            this.ContiniueBTN.Location = new System.Drawing.Point(99, 161);
            this.ContiniueBTN.Name = "ContiniueBTN";
            this.ContiniueBTN.Size = new System.Drawing.Size(95, 24);
            this.ContiniueBTN.TabIndex = 3;
            this.ContiniueBTN.Text = "Continue";
            this.ContiniueBTN.UseVisualStyleBackColor = true;
            this.ContiniueBTN.Click += new System.EventHandler(this.ContiniueBTN_Click);
            // 
            // gameLP1
            // 
            this.gameLP1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameLP1.BackColor = System.Drawing.Color.Navy;
            this.gameLP1.ColumnCount = 2;
            this.gameLP1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.gameLP1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.gameLP1.Controls.Add(this.gamePanel, 0, 0);
            this.gameLP1.Controls.Add(this.rightMenuPanel, 1, 0);
            this.gameLP1.Location = new System.Drawing.Point(0, 0);
            this.gameLP1.Margin = new System.Windows.Forms.Padding(0);
            this.gameLP1.Name = "gameLP1";
            this.gameLP1.RowCount = 1;
            this.gameLP1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gameLP1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 421F));
            this.gameLP1.Size = new System.Drawing.Size(729, 421);
            this.gameLP1.TabIndex = 4;
            // 
            // gamePanel
            // 
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.gamePanel.Location = new System.Drawing.Point(3, 3);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.gamePanel.Size = new System.Drawing.Size(200, 100);
            this.gamePanel.TabIndex = 6;
            // 
            // rightMenuPanel
            // 
            this.rightMenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.rightMenuPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.rightMenuPanel.ColumnCount = 1;
            this.rightMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightMenuPanel.Location = new System.Drawing.Point(481, 0);
            this.rightMenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rightMenuPanel.Name = "rightMenuPanel";
            this.rightMenuPanel.RowCount = 2;
            this.rightMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rightMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rightMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rightMenuPanel.Size = new System.Drawing.Size(248, 421);
            this.rightMenuPanel.TabIndex = 7;
            // 
            // gameLP2
            // 
            this.gameLP2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameLP2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gameLP2.ColumnCount = 2;
            this.gameLP2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameLP2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameLP2.Location = new System.Drawing.Point(0, 0);
            this.gameLP2.Margin = new System.Windows.Forms.Padding(0);
            this.gameLP2.Name = "gameLP2";
            this.gameLP2.RowCount = 2;
            this.gameLP2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gameLP2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.gameLP2.Size = new System.Drawing.Size(729, 422);
            this.gameLP2.TabIndex = 5;
            this.gameLP2.Visible = false;
            // 
            // waitPanel
            // 
            this.waitPanel.BackColor = System.Drawing.Color.Silver;
            this.waitPanel.Controls.Add(this.waitLB);
            this.waitPanel.Controls.Add(this.waitBTN);
            this.waitPanel.Location = new System.Drawing.Point(0, 0);
            this.waitPanel.Name = "waitPanel";
            this.waitPanel.Size = new System.Drawing.Size(730, 428);
            this.waitPanel.TabIndex = 7;
            this.waitPanel.Visible = false;
            // 
            // waitLB
            // 
            this.waitLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.waitLB.Location = new System.Drawing.Point(-5, 166);
            this.waitLB.Margin = new System.Windows.Forms.Padding(0);
            this.waitLB.Name = "waitLB";
            this.waitLB.Size = new System.Drawing.Size(730, 54);
            this.waitLB.TabIndex = 1;
            this.waitLB.Text = "wait";
            this.waitLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // waitBTN
            // 
            this.waitBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.waitBTN.BackColor = System.Drawing.Color.Gray;
            this.waitBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.waitBTN.Location = new System.Drawing.Point(-3, 365);
            this.waitBTN.Name = "waitBTN";
            this.waitBTN.Size = new System.Drawing.Size(736, 63);
            this.waitBTN.TabIndex = 0;
            this.waitBTN.Text = "OK";
            this.waitBTN.UseVisualStyleBackColor = false;
            // 
            // Battleship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 415);
            this.Controls.Add(this.waitPanel);
            this.Controls.Add(this.gameLP2);
            this.Controls.Add(this.gameLP1);
            this.Controls.Add(this.menuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 404);
            this.Name = "Battleship";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battleship";
            this.ResizeBegin += new System.EventHandler(this.Battleship_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Battleship_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.winPanel.ResumeLayout(false);
            this.winPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cupPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gameLP1.ResumeLayout(false);
            this.waitPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.ComboBox gameModeCB;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label errorLb;
        private System.Windows.Forms.PictureBox titlePicture;
        private System.Windows.Forms.TextBox nameTB1;
        private System.Windows.Forms.TextBox nameTB2;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.TableLayoutPanel gameLP1;
        private System.Windows.Forms.TableLayoutPanel gamePanel;
        private System.Windows.Forms.TableLayoutPanel rightMenuPanel;
        private System.Windows.Forms.TableLayoutPanel gameLP2;
        private System.Windows.Forms.Panel waitPanel;
        private System.Windows.Forms.Label waitLB;
        private System.Windows.Forms.Button waitBTN;
        private System.Windows.Forms.Panel winPanel;
        private System.Windows.Forms.PictureBox cupPB;
        private System.Windows.Forms.Label statLb;
        private System.Windows.Forms.Label winnerLb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ContiniueBTN;
    }
}