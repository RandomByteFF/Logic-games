
namespace Logic_games
{
    partial class Statistics
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.gamesPlayedLabel = new System.Windows.Forms.Label();
            this.snakeLabel = new System.Windows.Forms.Label();
            this.sudokuLabel = new System.Windows.Forms.Label();
            this.battleshipLabel = new System.Windows.Forms.Label();
            this.playTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(84, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Statistics";
            // 
            // gamesPlayedLabel
            // 
            this.gamesPlayedLabel.AutoSize = true;
            this.gamesPlayedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gamesPlayedLabel.Location = new System.Drawing.Point(28, 38);
            this.gamesPlayedLabel.Name = "gamesPlayedLabel";
            this.gamesPlayedLabel.Size = new System.Drawing.Size(97, 16);
            this.gamesPlayedLabel.TabIndex = 1;
            this.gamesPlayedLabel.Text = "Games played";
            // 
            // snakeLabel
            // 
            this.snakeLabel.AutoSize = true;
            this.snakeLabel.Location = new System.Drawing.Point(34, 62);
            this.snakeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.snakeLabel.Name = "snakeLabel";
            this.snakeLabel.Size = new System.Drawing.Size(44, 13);
            this.snakeLabel.TabIndex = 2;
            this.snakeLabel.Text = "Snake -";
            // 
            // sudokuLabel
            // 
            this.sudokuLabel.AutoSize = true;
            this.sudokuLabel.Location = new System.Drawing.Point(34, 81);
            this.sudokuLabel.Margin = new System.Windows.Forms.Padding(3);
            this.sudokuLabel.Name = "sudokuLabel";
            this.sudokuLabel.Size = new System.Drawing.Size(50, 13);
            this.sudokuLabel.TabIndex = 3;
            this.sudokuLabel.Text = "Sudoku -";
            // 
            // battleshipLabel
            // 
            this.battleshipLabel.AutoSize = true;
            this.battleshipLabel.Location = new System.Drawing.Point(34, 100);
            this.battleshipLabel.Margin = new System.Windows.Forms.Padding(3);
            this.battleshipLabel.Name = "battleshipLabel";
            this.battleshipLabel.Size = new System.Drawing.Size(59, 13);
            this.battleshipLabel.TabIndex = 4;
            this.battleshipLabel.Text = "Battleship -";
            // 
            // playTimeLabel
            // 
            this.playTimeLabel.AutoSize = true;
            this.playTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playTimeLabel.Location = new System.Drawing.Point(28, 126);
            this.playTimeLabel.Name = "playTimeLabel";
            this.playTimeLabel.Size = new System.Drawing.Size(60, 15);
            this.playTimeLabel.TabIndex = 5;
            this.playTimeLabel.Text = "Play time:";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(366, 203);
            this.Controls.Add(this.playTimeLabel);
            this.Controls.Add(this.battleshipLabel);
            this.Controls.Add(this.sudokuLabel);
            this.Controls.Add(this.snakeLabel);
            this.Controls.Add(this.gamesPlayedLabel);
            this.Controls.Add(this.titleLabel);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label gamesPlayedLabel;
        private System.Windows.Forms.Label snakeLabel;
        private System.Windows.Forms.Label sudokuLabel;
        private System.Windows.Forms.Label battleshipLabel;
        private System.Windows.Forms.Label playTimeLabel;
    }
}