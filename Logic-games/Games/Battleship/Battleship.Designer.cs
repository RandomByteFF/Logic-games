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
            this.zeroPB = new System.Windows.Forms.PictureBox();
            this.ShipsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.shipTLP = new System.Windows.Forms.TableLayoutPanel();
            this.ShipsLb = new System.Windows.Forms.Label();
            this.RemainingLb = new System.Windows.Forms.Label();
            this.CarrierLb = new System.Windows.Forms.Label();
            this.BattleshipLb = new System.Windows.Forms.Label();
            this.SubmarineLb = new System.Windows.Forms.Label();
            this.DestroyerLb = new System.Windows.Forms.Label();
            this.PatrolBoatLb = new System.Windows.Forms.Label();
            this.CarrierPB = new System.Windows.Forms.PictureBox();
            this.BattleshipPB = new System.Windows.Forms.PictureBox();
            this.SubmarinePB = new System.Windows.Forms.PictureBox();
            this.DestroyerPB = new System.Windows.Forms.PictureBox();
            this.PatrolBoatPB = new System.Windows.Forms.PictureBox();
            this.RotatePanel = new System.Windows.Forms.TableLayoutPanel();
            this.RotateLeftBtn = new System.Windows.Forms.Button();
            this.RotateRightBtn = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).BeginInit();
            this.gameLP1.SuspendLayout();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zeroPB)).BeginInit();
            this.ShipsLayoutPanel.SuspendLayout();
            this.shipTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarrierPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BattleshipPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubmarinePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestroyerPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatrolBoatPB)).BeginInit();
            this.RotatePanel.SuspendLayout();
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
            "Local",
            "Online"});
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
            this.gameLP1.Controls.Add(this.ShipsLayoutPanel, 1, 0);
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
            this.gamePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gamePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gamePanel.BackgroundImage")));
            this.gamePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.gamePanel.ColumnCount = 11;
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.gamePanel.Controls.Add(this.zeroPB, 0, 0);
            this.gamePanel.Location = new System.Drawing.Point(40, 10);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.RowCount = 11;
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.gamePanel.Size = new System.Drawing.Size(400, 400);
            this.gamePanel.TabIndex = 6;
            // 
            // zeroPB
            // 
            this.zeroPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zeroPB.BackColor = System.Drawing.Color.Gray;
            this.zeroPB.Location = new System.Drawing.Point(1, 1);
            this.zeroPB.Margin = new System.Windows.Forms.Padding(0);
            this.zeroPB.Name = "zeroPB";
            this.zeroPB.Size = new System.Drawing.Size(19, 19);
            this.zeroPB.TabIndex = 0;
            this.zeroPB.TabStop = false;
            // 
            // ShipsLayoutPanel
            // 
            this.ShipsLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShipsLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.ShipsLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.ShipsLayoutPanel.ColumnCount = 1;
            this.ShipsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ShipsLayoutPanel.Controls.Add(this.label1, 0, 2);
            this.ShipsLayoutPanel.Controls.Add(this.shipTLP, 0, 0);
            this.ShipsLayoutPanel.Controls.Add(this.RotatePanel, 0, 1);
            this.ShipsLayoutPanel.Location = new System.Drawing.Point(481, 0);
            this.ShipsLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ShipsLayoutPanel.Name = "ShipsLayoutPanel";
            this.ShipsLayoutPanel.RowCount = 3;
            this.ShipsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ShipsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ShipsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ShipsLayoutPanel.Size = new System.Drawing.Size(248, 421);
            this.ShipsLayoutPanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shipTLP
            // 
            this.shipTLP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shipTLP.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.shipTLP.ColumnCount = 2;
            this.shipTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.shipTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.shipTLP.Controls.Add(this.PatrolBoatPB, 0, 5);
            this.shipTLP.Controls.Add(this.DestroyerPB, 0, 4);
            this.shipTLP.Controls.Add(this.SubmarinePB, 0, 3);
            this.shipTLP.Controls.Add(this.BattleshipPB, 0, 2);
            this.shipTLP.Controls.Add(this.RemainingLb, 1, 0);
            this.shipTLP.Controls.Add(this.ShipsLb, 0, 0);
            this.shipTLP.Controls.Add(this.CarrierLb, 1, 1);
            this.shipTLP.Controls.Add(this.BattleshipLb, 1, 2);
            this.shipTLP.Controls.Add(this.SubmarineLb, 1, 3);
            this.shipTLP.Controls.Add(this.DestroyerLb, 1, 4);
            this.shipTLP.Controls.Add(this.PatrolBoatLb, 1, 5);
            this.shipTLP.Controls.Add(this.CarrierPB, 0, 1);
            this.shipTLP.Location = new System.Drawing.Point(2, 2);
            this.shipTLP.Margin = new System.Windows.Forms.Padding(0);
            this.shipTLP.Name = "shipTLP";
            this.shipTLP.RowCount = 6;
            this.shipTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.shipTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.shipTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.shipTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.shipTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.shipTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.shipTLP.Size = new System.Drawing.Size(244, 196);
            this.shipTLP.TabIndex = 7;
            // 
            // ShipsLb
            // 
            this.ShipsLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShipsLb.AutoSize = true;
            this.ShipsLb.BackColor = System.Drawing.Color.DimGray;
            this.ShipsLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShipsLb.ForeColor = System.Drawing.SystemColors.Control;
            this.ShipsLb.Location = new System.Drawing.Point(2, 2);
            this.ShipsLb.Margin = new System.Windows.Forms.Padding(0);
            this.ShipsLb.Name = "ShipsLb";
            this.ShipsLb.Size = new System.Drawing.Size(166, 18);
            this.ShipsLb.TabIndex = 0;
            this.ShipsLb.Text = "Ships";
            this.ShipsLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemainingLb
            // 
            this.RemainingLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemainingLb.AutoSize = true;
            this.RemainingLb.BackColor = System.Drawing.Color.DimGray;
            this.RemainingLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemainingLb.ForeColor = System.Drawing.SystemColors.Control;
            this.RemainingLb.Location = new System.Drawing.Point(170, 2);
            this.RemainingLb.Margin = new System.Windows.Forms.Padding(0);
            this.RemainingLb.Name = "RemainingLb";
            this.RemainingLb.Size = new System.Drawing.Size(72, 18);
            this.RemainingLb.TabIndex = 1;
            this.RemainingLb.Text = "No.";
            this.RemainingLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CarrierLb
            // 
            this.CarrierLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarrierLb.AutoSize = true;
            this.CarrierLb.BackColor = System.Drawing.Color.Gray;
            this.CarrierLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CarrierLb.ForeColor = System.Drawing.SystemColors.Control;
            this.CarrierLb.Location = new System.Drawing.Point(170, 22);
            this.CarrierLb.Margin = new System.Windows.Forms.Padding(0);
            this.CarrierLb.Name = "CarrierLb";
            this.CarrierLb.Size = new System.Drawing.Size(72, 32);
            this.CarrierLb.TabIndex = 2;
            this.CarrierLb.Text = "1";
            this.CarrierLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BattleshipLb
            // 
            this.BattleshipLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BattleshipLb.AutoSize = true;
            this.BattleshipLb.BackColor = System.Drawing.Color.Gray;
            this.BattleshipLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BattleshipLb.ForeColor = System.Drawing.SystemColors.Control;
            this.BattleshipLb.Location = new System.Drawing.Point(170, 56);
            this.BattleshipLb.Margin = new System.Windows.Forms.Padding(0);
            this.BattleshipLb.Name = "BattleshipLb";
            this.BattleshipLb.Size = new System.Drawing.Size(72, 32);
            this.BattleshipLb.TabIndex = 3;
            this.BattleshipLb.Text = "2";
            this.BattleshipLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubmarineLb
            // 
            this.SubmarineLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmarineLb.AutoSize = true;
            this.SubmarineLb.BackColor = System.Drawing.Color.Gray;
            this.SubmarineLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SubmarineLb.ForeColor = System.Drawing.SystemColors.Control;
            this.SubmarineLb.Location = new System.Drawing.Point(170, 90);
            this.SubmarineLb.Margin = new System.Windows.Forms.Padding(0);
            this.SubmarineLb.Name = "SubmarineLb";
            this.SubmarineLb.Size = new System.Drawing.Size(72, 32);
            this.SubmarineLb.TabIndex = 4;
            this.SubmarineLb.Text = "3";
            this.SubmarineLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DestroyerLb
            // 
            this.DestroyerLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestroyerLb.AutoSize = true;
            this.DestroyerLb.BackColor = System.Drawing.Color.Gray;
            this.DestroyerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DestroyerLb.ForeColor = System.Drawing.SystemColors.Control;
            this.DestroyerLb.Location = new System.Drawing.Point(170, 124);
            this.DestroyerLb.Margin = new System.Windows.Forms.Padding(0);
            this.DestroyerLb.Name = "DestroyerLb";
            this.DestroyerLb.Size = new System.Drawing.Size(72, 32);
            this.DestroyerLb.TabIndex = 5;
            this.DestroyerLb.Text = "4";
            this.DestroyerLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatrolBoatLb
            // 
            this.PatrolBoatLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatrolBoatLb.AutoSize = true;
            this.PatrolBoatLb.BackColor = System.Drawing.Color.Gray;
            this.PatrolBoatLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PatrolBoatLb.ForeColor = System.Drawing.SystemColors.Control;
            this.PatrolBoatLb.Location = new System.Drawing.Point(170, 158);
            this.PatrolBoatLb.Margin = new System.Windows.Forms.Padding(0);
            this.PatrolBoatLb.Name = "PatrolBoatLb";
            this.PatrolBoatLb.Size = new System.Drawing.Size(72, 36);
            this.PatrolBoatLb.TabIndex = 6;
            this.PatrolBoatLb.Text = "5";
            this.PatrolBoatLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CarrierPB
            // 
            this.CarrierPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarrierPB.BackColor = System.Drawing.Color.Silver;
            this.CarrierPB.Location = new System.Drawing.Point(2, 22);
            this.CarrierPB.Margin = new System.Windows.Forms.Padding(0);
            this.CarrierPB.Name = "CarrierPB";
            this.CarrierPB.Size = new System.Drawing.Size(166, 32);
            this.CarrierPB.TabIndex = 7;
            this.CarrierPB.TabStop = false;
            // 
            // BattleshipPB
            // 
            this.BattleshipPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BattleshipPB.BackColor = System.Drawing.Color.Silver;
            this.BattleshipPB.Location = new System.Drawing.Point(2, 56);
            this.BattleshipPB.Margin = new System.Windows.Forms.Padding(0);
            this.BattleshipPB.Name = "BattleshipPB";
            this.BattleshipPB.Size = new System.Drawing.Size(166, 32);
            this.BattleshipPB.TabIndex = 8;
            this.BattleshipPB.TabStop = false;
            // 
            // SubmarinePB
            // 
            this.SubmarinePB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmarinePB.BackColor = System.Drawing.Color.Silver;
            this.SubmarinePB.Location = new System.Drawing.Point(2, 90);
            this.SubmarinePB.Margin = new System.Windows.Forms.Padding(0);
            this.SubmarinePB.Name = "SubmarinePB";
            this.SubmarinePB.Size = new System.Drawing.Size(166, 32);
            this.SubmarinePB.TabIndex = 9;
            this.SubmarinePB.TabStop = false;
            // 
            // DestroyerPB
            // 
            this.DestroyerPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestroyerPB.BackColor = System.Drawing.Color.Silver;
            this.DestroyerPB.Location = new System.Drawing.Point(2, 124);
            this.DestroyerPB.Margin = new System.Windows.Forms.Padding(0);
            this.DestroyerPB.Name = "DestroyerPB";
            this.DestroyerPB.Size = new System.Drawing.Size(166, 32);
            this.DestroyerPB.TabIndex = 10;
            this.DestroyerPB.TabStop = false;
            // 
            // PatrolBoatPB
            // 
            this.PatrolBoatPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatrolBoatPB.BackColor = System.Drawing.Color.Silver;
            this.PatrolBoatPB.Location = new System.Drawing.Point(2, 158);
            this.PatrolBoatPB.Margin = new System.Windows.Forms.Padding(0);
            this.PatrolBoatPB.Name = "PatrolBoatPB";
            this.PatrolBoatPB.Size = new System.Drawing.Size(166, 36);
            this.PatrolBoatPB.TabIndex = 11;
            this.PatrolBoatPB.TabStop = false;
            // 
            // RotatePanel
            // 
            this.RotatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RotatePanel.BackColor = System.Drawing.Color.Silver;
            this.RotatePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.RotatePanel.ColumnCount = 3;
            this.RotatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.RotatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.RotatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.RotatePanel.Controls.Add(this.RotateRightBtn, 2, 0);
            this.RotatePanel.Controls.Add(this.RotateLeftBtn, 0, 0);
            this.RotatePanel.Location = new System.Drawing.Point(2, 200);
            this.RotatePanel.Margin = new System.Windows.Forms.Padding(0);
            this.RotatePanel.Name = "RotatePanel";
            this.RotatePanel.RowCount = 1;
            this.RotatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.RotatePanel.Size = new System.Drawing.Size(244, 196);
            this.RotatePanel.TabIndex = 8;
            // 
            // RotateLeftBtn
            // 
            this.RotateLeftBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RotateLeftBtn.Location = new System.Drawing.Point(1, 1);
            this.RotateLeftBtn.Margin = new System.Windows.Forms.Padding(0);
            this.RotateLeftBtn.Name = "RotateLeftBtn";
            this.RotateLeftBtn.Size = new System.Drawing.Size(36, 194);
            this.RotateLeftBtn.TabIndex = 1;
            this.RotateLeftBtn.UseVisualStyleBackColor = true;
            // 
            // RotateRightBtn
            // 
            this.RotateRightBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RotateRightBtn.Location = new System.Drawing.Point(207, 1);
            this.RotateRightBtn.Margin = new System.Windows.Forms.Padding(0);
            this.RotateRightBtn.Name = "RotateRightBtn";
            this.RotateRightBtn.Size = new System.Drawing.Size(36, 194);
            this.RotateRightBtn.TabIndex = 2;
            this.RotateRightBtn.UseVisualStyleBackColor = true;
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
            this.Text = "a";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).EndInit();
            this.gameLP1.ResumeLayout(false);
            this.gamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zeroPB)).EndInit();
            this.ShipsLayoutPanel.ResumeLayout(false);
            this.ShipsLayoutPanel.PerformLayout();
            this.shipTLP.ResumeLayout(false);
            this.shipTLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarrierPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BattleshipPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubmarinePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestroyerPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatrolBoatPB)).EndInit();
            this.RotatePanel.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox zeroPB;
        private System.Windows.Forms.TableLayoutPanel ShipsLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel shipTLP;
        private System.Windows.Forms.Label RemainingLb;
        private System.Windows.Forms.Label ShipsLb;
        private System.Windows.Forms.Label CarrierLb;
        private System.Windows.Forms.Label BattleshipLb;
        private System.Windows.Forms.Label SubmarineLb;
        private System.Windows.Forms.Label DestroyerLb;
        private System.Windows.Forms.Label PatrolBoatLb;
        private System.Windows.Forms.PictureBox PatrolBoatPB;
        private System.Windows.Forms.PictureBox DestroyerPB;
        private System.Windows.Forms.PictureBox SubmarinePB;
        private System.Windows.Forms.PictureBox BattleshipPB;
        private System.Windows.Forms.PictureBox CarrierPB;
        private System.Windows.Forms.TableLayoutPanel RotatePanel;
        private System.Windows.Forms.Button RotateRightBtn;
        private System.Windows.Forms.Button RotateLeftBtn;
    }
}