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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.titlePicture = new System.Windows.Forms.PictureBox();
            this.errorLb = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.gameModeCB = new System.Windows.Forms.ComboBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.gameLP1 = new System.Windows.Forms.TableLayoutPanel();
            this.gamePanel = new System.Windows.Forms.TableLayoutPanel();
            this.headerPB = new System.Windows.Forms.PictureBox();
            this.rightMenuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).BeginInit();
            this.gameLP1.SuspendLayout();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerPB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // errorLb
            // 
            this.errorLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLb.AutoSize = true;
            this.errorLb.ForeColor = System.Drawing.Color.Maroon;
            this.errorLb.Location = new System.Drawing.Point(89, 100);
            this.errorLb.Name = "errorLb";
            this.errorLb.Size = new System.Drawing.Size(0, 13);
            this.errorLb.TabIndex = 4;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(224, 164);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(61, 21);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // gameModeCB
            // 
            this.gameModeCB.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameModeCB.FormattingEnabled = true;
            this.gameModeCB.Items.AddRange(new object[] {
            "Single player",
            "Local"});
            this.gameModeCB.Location = new System.Drawing.Point(13, 72);
            this.gameModeCB.Name = "gameModeCB";
            this.gameModeCB.Size = new System.Drawing.Size(162, 25);
            this.gameModeCB.TabIndex = 1;
            this.gameModeCB.Text = "Select game mode...";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(181, 71);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(104, 25);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start game";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
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
            this.gameLP1.Size = new System.Drawing.Size(729, 421);
            this.gameLP1.TabIndex = 4;
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.headerPB, 0, 0);
            this.gamePanel.Location = new System.Drawing.Point(40, 10);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.TabIndex = 6;
            // 
            // headerPB
            // 
            this.headerPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPB.BackColor = System.Drawing.Color.Gray;
            this.headerPB.Location = new System.Drawing.Point(1, 1);
            this.headerPB.Margin = new System.Windows.Forms.Padding(0);
            this.headerPB.Name = "headerPB";
            this.headerPB.Size = new System.Drawing.Size(19, 19);
            this.headerPB.TabIndex = 0;
            this.headerPB.TabStop = false;
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
            // Battleship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 415);
            this.Controls.Add(this.gameLP1);
            this.Controls.Add(this.menuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(536, 402);
            this.Name = "Battleship";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battleship";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).EndInit();
            this.gameLP1.ResumeLayout(false);
            this.gamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox titlePicture;
        private System.Windows.Forms.Label errorLb;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox gameModeCB;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TableLayoutPanel gameLP1;
        private System.Windows.Forms.TableLayoutPanel gamePanel;
        private System.Windows.Forms.PictureBox headerPB;
        private System.Windows.Forms.TableLayoutPanel rightMenuPanel;
    }
}