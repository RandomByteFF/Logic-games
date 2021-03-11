
namespace Logic_games.Games.Battleship
{
    partial class BattleshipGuessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleshipGuessForm));
            this.gamePanel = new System.Windows.Forms.TableLayoutPanel();
            this.rightNameLabel = new System.Windows.Forms.Label();
            this.leftNameLabel = new System.Windows.Forms.Label();
            this.gamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Transparent;
            this.gamePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.gamePanel.ColumnCount = 2;
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gamePanel.Controls.Add(this.rightNameLabel, 0, 1);
            this.gamePanel.Controls.Add(this.leftNameLabel, 0, 1);
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.RowCount = 2;
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.gamePanel.Size = new System.Drawing.Size(800, 450);
            this.gamePanel.TabIndex = 0;
            // 
            // rightNameLabel
            // 
            this.rightNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightNameLabel.AutoSize = true;
            this.rightNameLabel.BackColor = System.Drawing.Color.DimGray;
            this.rightNameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rightNameLabel.Location = new System.Drawing.Point(401, 422);
            this.rightNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.rightNameLabel.Name = "rightNameLabel";
            this.rightNameLabel.Size = new System.Drawing.Size(396, 25);
            this.rightNameLabel.TabIndex = 13;
            this.rightNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftNameLabel
            // 
            this.leftNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftNameLabel.AutoSize = true;
            this.leftNameLabel.BackColor = System.Drawing.Color.DimGray;
            this.leftNameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.leftNameLabel.Location = new System.Drawing.Point(3, 422);
            this.leftNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.leftNameLabel.Name = "leftNameLabel";
            this.leftNameLabel.Size = new System.Drawing.Size(395, 25);
            this.leftNameLabel.TabIndex = 12;
            this.leftNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BattleshipGuessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gamePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "BattleshipGuessForm";
            this.Text = "Battleship";
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel gamePanel;
        private System.Windows.Forms.Label rightNameLabel;
        private System.Windows.Forms.Label leftNameLabel;
    }
}