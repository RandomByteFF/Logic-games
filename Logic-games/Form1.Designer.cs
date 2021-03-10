namespace Logic_games
{
    partial class LogicGames
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
            this.sudokuButton = new System.Windows.Forms.Button();
            this.snakeButton = new System.Windows.Forms.Button();
            this.battleshipButton = new System.Windows.Forms.Button();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sudokuButton
            // 
            this.sudokuButton.BackColor = System.Drawing.Color.Khaki;
            this.sudokuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sudokuButton.FlatAppearance.BorderSize = 0;
            this.sudokuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sudokuButton.Location = new System.Drawing.Point(200, 120);
            this.sudokuButton.Name = "sudokuButton";
            this.sudokuButton.Size = new System.Drawing.Size(100, 40);
            this.sudokuButton.TabIndex = 0;
            this.sudokuButton.Text = "Sudoku";
            this.sudokuButton.UseVisualStyleBackColor = false;
            this.sudokuButton.Click += new System.EventHandler(this.sudokuButton_Click);
            // 
            // snakeButton
            // 
            this.snakeButton.BackColor = System.Drawing.Color.Khaki;
            this.snakeButton.FlatAppearance.BorderSize = 0;
            this.snakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snakeButton.Location = new System.Drawing.Point(200, 180);
            this.snakeButton.Name = "snakeButton";
            this.snakeButton.Size = new System.Drawing.Size(100, 40);
            this.snakeButton.TabIndex = 1;
            this.snakeButton.Text = "Snake";
            this.snakeButton.UseVisualStyleBackColor = false;
            this.snakeButton.Click += new System.EventHandler(this.snakeButton_Click);
            // 
            // battleshipButton
            // 
            this.battleshipButton.BackColor = System.Drawing.Color.Khaki;
            this.battleshipButton.FlatAppearance.BorderSize = 0;
            this.battleshipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.battleshipButton.Location = new System.Drawing.Point(200, 240);
            this.battleshipButton.Name = "battleshipButton";
            this.battleshipButton.Size = new System.Drawing.Size(100, 40);
            this.battleshipButton.TabIndex = 2;
            this.battleshipButton.Text = "Battleship";
            this.battleshipButton.UseVisualStyleBackColor = false;
            this.battleshipButton.Click += new System.EventHandler(this.battleshipButton_Click);
            // 
            // statisticsButton
            // 
            this.statisticsButton.BackColor = System.Drawing.Color.Khaki;
            this.statisticsButton.FlatAppearance.BorderSize = 0;
            this.statisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statisticsButton.Location = new System.Drawing.Point(432, 339);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(40, 40);
            this.statisticsButton.TabIndex = 3;
            this.statisticsButton.Text = "Stats";
            this.statisticsButton.UseVisualStyleBackColor = false;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // LogicGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(484, 391);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.battleshipButton);
            this.Controls.Add(this.snakeButton);
            this.Controls.Add(this.sudokuButton);
            this.Name = "LogicGames";
            this.Text = "Logic Games";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sudokuButton;
        private System.Windows.Forms.Button snakeButton;
        private System.Windows.Forms.Button battleshipButton;
        private System.Windows.Forms.Button statisticsButton;
    }
}

