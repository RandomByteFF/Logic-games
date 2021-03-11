
namespace Logic_games.Games.Battleship
{
    partial class BattleshipPlacement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleshipPlacement));
            this.placementPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rightMenuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rotatePanel = new System.Windows.Forms.TableLayoutPanel();
            this.rotateLeftButton = new System.Windows.Forms.Button();
            this.rotateRightButton = new System.Windows.Forms.Button();
            this.rotatePictureBox = new System.Windows.Forms.PictureBox();
            this.selectPanel = new System.Windows.Forms.TableLayoutPanel();
            this.patrolBoatLabel = new System.Windows.Forms.Label();
            this.submarineLabel = new System.Windows.Forms.Label();
            this.destroyerLabel = new System.Windows.Forms.Label();
            this.battleshipLabel = new System.Windows.Forms.Label();
            this.carrierLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.carrierPictureBox = new System.Windows.Forms.PictureBox();
            this.battleshipPictureBox = new System.Windows.Forms.PictureBox();
            this.destroyerPictureBox = new System.Windows.Forms.PictureBox();
            this.submarinePictureBox = new System.Windows.Forms.PictureBox();
            this.patrolBoatPictureBox = new System.Windows.Forms.PictureBox();
            this.shipLabel = new System.Windows.Forms.Label();
            this.placementPanel.SuspendLayout();
            this.rightMenuPanel.SuspendLayout();
            this.rotatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotatePictureBox)).BeginInit();
            this.selectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carrierPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.battleshipPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destroyerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.submarinePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patrolBoatPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // placementPanel
            // 
            this.placementPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.placementPanel.BackColor = System.Drawing.Color.Transparent;
            this.placementPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.placementPanel.ColumnCount = 2;
            this.placementPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.placementPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.placementPanel.Controls.Add(this.rightMenuPanel, 1, 0);
            this.placementPanel.Location = new System.Drawing.Point(-1, 0);
            this.placementPanel.Name = "placementPanel";
            this.placementPanel.RowCount = 1;
            this.placementPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.placementPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 449F));
            this.placementPanel.Size = new System.Drawing.Size(804, 451);
            this.placementPanel.TabIndex = 0;
            // 
            // rightMenuPanel
            // 
            this.rightMenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightMenuPanel.AutoSize = true;
            this.rightMenuPanel.BackColor = System.Drawing.Color.Teal;
            this.rightMenuPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.rightMenuPanel.ColumnCount = 1;
            this.rightMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightMenuPanel.Controls.Add(this.rotatePanel, 0, 1);
            this.rightMenuPanel.Controls.Add(this.selectPanel, 0, 0);
            this.rightMenuPanel.Location = new System.Drawing.Point(546, 2);
            this.rightMenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rightMenuPanel.Name = "rightMenuPanel";
            this.rightMenuPanel.RowCount = 2;
            this.rightMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.rightMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.rightMenuPanel.Size = new System.Drawing.Size(256, 447);
            this.rightMenuPanel.TabIndex = 0;
            // 
            // rotatePanel
            // 
            this.rotatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotatePanel.ColumnCount = 3;
            this.rotatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.rotatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.rotatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.rotatePanel.Controls.Add(this.rotateLeftButton, 0, 0);
            this.rotatePanel.Controls.Add(this.rotateRightButton, 2, 0);
            this.rotatePanel.Controls.Add(this.rotatePictureBox, 1, 0);
            this.rotatePanel.Location = new System.Drawing.Point(2, 268);
            this.rotatePanel.Margin = new System.Windows.Forms.Padding(0);
            this.rotatePanel.Name = "rotatePanel";
            this.rotatePanel.RowCount = 1;
            this.rotatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rotatePanel.Size = new System.Drawing.Size(252, 177);
            this.rotatePanel.TabIndex = 0;
            // 
            // rotateLeftButton
            // 
            this.rotateLeftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotateLeftButton.AutoSize = true;
            this.rotateLeftButton.BackgroundImage = global::Logic_games.Properties.Resources.arrow2;
            this.rotateLeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rotateLeftButton.Location = new System.Drawing.Point(0, 0);
            this.rotateLeftButton.Margin = new System.Windows.Forms.Padding(0);
            this.rotateLeftButton.Name = "rotateLeftButton";
            this.rotateLeftButton.Size = new System.Drawing.Size(37, 177);
            this.rotateLeftButton.TabIndex = 0;
            this.rotateLeftButton.UseVisualStyleBackColor = true;
            this.rotateLeftButton.Click += new System.EventHandler(this.rotateLeftButton_Click);
            // 
            // rotateRightButton
            // 
            this.rotateRightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotateRightButton.AutoSize = true;
            this.rotateRightButton.BackgroundImage = global::Logic_games.Properties.Resources.arrow1;
            this.rotateRightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rotateRightButton.Location = new System.Drawing.Point(213, 0);
            this.rotateRightButton.Margin = new System.Windows.Forms.Padding(0);
            this.rotateRightButton.Name = "rotateRightButton";
            this.rotateRightButton.Size = new System.Drawing.Size(39, 177);
            this.rotateRightButton.TabIndex = 1;
            this.rotateRightButton.UseVisualStyleBackColor = true;
            this.rotateRightButton.Click += new System.EventHandler(this.rotateRightButton_Click);
            // 
            // rotatePictureBox
            // 
            this.rotatePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotatePictureBox.BackColor = System.Drawing.Color.LightGray;
            this.rotatePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rotatePictureBox.Location = new System.Drawing.Point(40, 3);
            this.rotatePictureBox.Name = "rotatePictureBox";
            this.rotatePictureBox.Size = new System.Drawing.Size(170, 171);
            this.rotatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rotatePictureBox.TabIndex = 2;
            this.rotatePictureBox.TabStop = false;
            // 
            // selectPanel
            // 
            this.selectPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.selectPanel.ColumnCount = 2;
            this.selectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.selectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.selectPanel.Controls.Add(this.patrolBoatLabel, 1, 5);
            this.selectPanel.Controls.Add(this.submarineLabel, 1, 4);
            this.selectPanel.Controls.Add(this.destroyerLabel, 1, 3);
            this.selectPanel.Controls.Add(this.battleshipLabel, 1, 2);
            this.selectPanel.Controls.Add(this.carrierLabel, 1, 1);
            this.selectPanel.Controls.Add(this.numberLabel, 1, 0);
            this.selectPanel.Controls.Add(this.carrierPictureBox, 0, 1);
            this.selectPanel.Controls.Add(this.battleshipPictureBox, 0, 2);
            this.selectPanel.Controls.Add(this.destroyerPictureBox, 0, 3);
            this.selectPanel.Controls.Add(this.submarinePictureBox, 0, 4);
            this.selectPanel.Controls.Add(this.patrolBoatPictureBox, 0, 5);
            this.selectPanel.Controls.Add(this.shipLabel, 0, 0);
            this.selectPanel.Location = new System.Drawing.Point(2, 2);
            this.selectPanel.Margin = new System.Windows.Forms.Padding(0);
            this.selectPanel.Name = "selectPanel";
            this.selectPanel.RowCount = 6;
            this.selectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.selectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.selectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.selectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.selectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.selectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.selectPanel.Size = new System.Drawing.Size(252, 264);
            this.selectPanel.TabIndex = 1;
            // 
            // patrolBoatLabel
            // 
            this.patrolBoatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patrolBoatLabel.AutoSize = true;
            this.patrolBoatLabel.BackColor = System.Drawing.Color.DimGray;
            this.patrolBoatLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.patrolBoatLabel.Location = new System.Drawing.Point(163, 215);
            this.patrolBoatLabel.Margin = new System.Windows.Forms.Padding(0);
            this.patrolBoatLabel.Name = "patrolBoatLabel";
            this.patrolBoatLabel.Size = new System.Drawing.Size(86, 46);
            this.patrolBoatLabel.TabIndex = 11;
            this.patrolBoatLabel.Text = "5";
            this.patrolBoatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submarineLabel
            // 
            this.submarineLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submarineLabel.AutoSize = true;
            this.submarineLabel.BackColor = System.Drawing.Color.DimGray;
            this.submarineLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.submarineLabel.Location = new System.Drawing.Point(163, 169);
            this.submarineLabel.Margin = new System.Windows.Forms.Padding(0);
            this.submarineLabel.Name = "submarineLabel";
            this.submarineLabel.Size = new System.Drawing.Size(86, 43);
            this.submarineLabel.TabIndex = 10;
            this.submarineLabel.Text = "4";
            this.submarineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // destroyerLabel
            // 
            this.destroyerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destroyerLabel.AutoSize = true;
            this.destroyerLabel.BackColor = System.Drawing.Color.DimGray;
            this.destroyerLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.destroyerLabel.Location = new System.Drawing.Point(163, 123);
            this.destroyerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.destroyerLabel.Name = "destroyerLabel";
            this.destroyerLabel.Size = new System.Drawing.Size(86, 43);
            this.destroyerLabel.TabIndex = 9;
            this.destroyerLabel.Text = "3";
            this.destroyerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // battleshipLabel
            // 
            this.battleshipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.battleshipLabel.AutoSize = true;
            this.battleshipLabel.BackColor = System.Drawing.Color.DimGray;
            this.battleshipLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.battleshipLabel.Location = new System.Drawing.Point(163, 77);
            this.battleshipLabel.Margin = new System.Windows.Forms.Padding(0);
            this.battleshipLabel.Name = "battleshipLabel";
            this.battleshipLabel.Size = new System.Drawing.Size(86, 43);
            this.battleshipLabel.TabIndex = 8;
            this.battleshipLabel.Text = "2";
            this.battleshipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carrierLabel
            // 
            this.carrierLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carrierLabel.AutoSize = true;
            this.carrierLabel.BackColor = System.Drawing.Color.DimGray;
            this.carrierLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.carrierLabel.Location = new System.Drawing.Point(163, 31);
            this.carrierLabel.Margin = new System.Windows.Forms.Padding(0);
            this.carrierLabel.Name = "carrierLabel";
            this.carrierLabel.Size = new System.Drawing.Size(86, 43);
            this.carrierLabel.TabIndex = 7;
            this.carrierLabel.Text = "1";
            this.carrierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberLabel
            // 
            this.numberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberLabel.AutoSize = true;
            this.numberLabel.BackColor = System.Drawing.Color.DimGray;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.numberLabel.Location = new System.Drawing.Point(163, 3);
            this.numberLabel.Margin = new System.Windows.Forms.Padding(0);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(86, 25);
            this.numberLabel.TabIndex = 6;
            this.numberLabel.Text = "N.o.";
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carrierPictureBox
            // 
            this.carrierPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carrierPictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.carrierPictureBox.BackgroundImage = global::Logic_games.Properties.Resources.Carrier;
            this.carrierPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.carrierPictureBox.Location = new System.Drawing.Point(3, 31);
            this.carrierPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.carrierPictureBox.Name = "carrierPictureBox";
            this.carrierPictureBox.Size = new System.Drawing.Size(157, 43);
            this.carrierPictureBox.TabIndex = 0;
            this.carrierPictureBox.TabStop = false;
            // 
            // battleshipPictureBox
            // 
            this.battleshipPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.battleshipPictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.battleshipPictureBox.BackgroundImage = global::Logic_games.Properties.Resources.Battleship;
            this.battleshipPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.battleshipPictureBox.Location = new System.Drawing.Point(3, 77);
            this.battleshipPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.battleshipPictureBox.Name = "battleshipPictureBox";
            this.battleshipPictureBox.Size = new System.Drawing.Size(157, 43);
            this.battleshipPictureBox.TabIndex = 1;
            this.battleshipPictureBox.TabStop = false;
            // 
            // destroyerPictureBox
            // 
            this.destroyerPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destroyerPictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.destroyerPictureBox.BackgroundImage = global::Logic_games.Properties.Resources.Destroyer;
            this.destroyerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.destroyerPictureBox.Location = new System.Drawing.Point(3, 123);
            this.destroyerPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.destroyerPictureBox.Name = "destroyerPictureBox";
            this.destroyerPictureBox.Size = new System.Drawing.Size(157, 43);
            this.destroyerPictureBox.TabIndex = 2;
            this.destroyerPictureBox.TabStop = false;
            // 
            // submarinePictureBox
            // 
            this.submarinePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submarinePictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.submarinePictureBox.BackgroundImage = global::Logic_games.Properties.Resources.Submarine;
            this.submarinePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.submarinePictureBox.Location = new System.Drawing.Point(3, 169);
            this.submarinePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.submarinePictureBox.Name = "submarinePictureBox";
            this.submarinePictureBox.Size = new System.Drawing.Size(157, 43);
            this.submarinePictureBox.TabIndex = 3;
            this.submarinePictureBox.TabStop = false;
            // 
            // patrolBoatPictureBox
            // 
            this.patrolBoatPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patrolBoatPictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.patrolBoatPictureBox.BackgroundImage = global::Logic_games.Properties.Resources.PatrolBoat;
            this.patrolBoatPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.patrolBoatPictureBox.Location = new System.Drawing.Point(3, 215);
            this.patrolBoatPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.patrolBoatPictureBox.Name = "patrolBoatPictureBox";
            this.patrolBoatPictureBox.Size = new System.Drawing.Size(157, 46);
            this.patrolBoatPictureBox.TabIndex = 4;
            this.patrolBoatPictureBox.TabStop = false;
            // 
            // shipLabel
            // 
            this.shipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shipLabel.AutoSize = true;
            this.shipLabel.BackColor = System.Drawing.Color.DimGray;
            this.shipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shipLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.shipLabel.Location = new System.Drawing.Point(3, 3);
            this.shipLabel.Margin = new System.Windows.Forms.Padding(0);
            this.shipLabel.Name = "shipLabel";
            this.shipLabel.Size = new System.Drawing.Size(157, 25);
            this.shipLabel.TabIndex = 5;
            this.shipLabel.Text = "Ships";
            this.shipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BattleshipPlacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.placementPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "BattleshipPlacement";
            this.Text = "Battleship";
            this.placementPanel.ResumeLayout(false);
            this.placementPanel.PerformLayout();
            this.rightMenuPanel.ResumeLayout(false);
            this.rotatePanel.ResumeLayout(false);
            this.rotatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotatePictureBox)).EndInit();
            this.selectPanel.ResumeLayout(false);
            this.selectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carrierPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.battleshipPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destroyerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.submarinePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patrolBoatPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel placementPanel;
        private System.Windows.Forms.TableLayoutPanel rightMenuPanel;
        private System.Windows.Forms.TableLayoutPanel rotatePanel;
        private System.Windows.Forms.Button rotateLeftButton;
        private System.Windows.Forms.Button rotateRightButton;
        private System.Windows.Forms.PictureBox rotatePictureBox;
        private System.Windows.Forms.TableLayoutPanel selectPanel;
        private System.Windows.Forms.Label patrolBoatLabel;
        private System.Windows.Forms.Label submarineLabel;
        private System.Windows.Forms.Label destroyerLabel;
        private System.Windows.Forms.Label battleshipLabel;
        private System.Windows.Forms.Label carrierLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.PictureBox carrierPictureBox;
        private System.Windows.Forms.PictureBox battleshipPictureBox;
        private System.Windows.Forms.PictureBox destroyerPictureBox;
        private System.Windows.Forms.PictureBox submarinePictureBox;
        private System.Windows.Forms.PictureBox patrolBoatPictureBox;
        private System.Windows.Forms.Label shipLabel;
    }
}