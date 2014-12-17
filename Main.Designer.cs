namespace EliteDangerousTradingAssistant
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SystemComboBox = new System.Windows.Forms.ComboBox();
            this.SystemLabel = new System.Windows.Forms.Label();
            this.StationLabel = new System.Windows.Forms.Label();
            this.StationComboBox = new System.Windows.Forms.ComboBox();
            this.AddCommodityButton = new System.Windows.Forms.Button();
            this.AddSystemButton = new System.Windows.Forms.Button();
            this.AddStationButton = new System.Windows.Forms.Button();
            this.RemoveSystemButton = new System.Windows.Forms.Button();
            this.RemoveStationButton = new System.Windows.Forms.Button();
            this.CalculateAllTradesButton = new System.Windows.Forms.Button();
            this.CargoSlotsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CapitalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CapitalLabel = new System.Windows.Forms.Label();
            this.CargoSlotsLabel = new System.Windows.Forms.Label();
            this.CommoditiesGrid = new System.Windows.Forms.DataGridView();
            this.TimestampAllButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitWithSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAndExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.enableOCRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMoveStation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CargoSlotsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapitalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommoditiesGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemComboBox
            // 
            this.SystemComboBox.FormattingEnabled = true;
            this.SystemComboBox.Location = new System.Drawing.Point(76, 5);
            this.SystemComboBox.Name = "SystemComboBox";
            this.SystemComboBox.Size = new System.Drawing.Size(207, 21);
            this.SystemComboBox.TabIndex = 0;
            this.SystemComboBox.SelectedIndexChanged += new System.EventHandler(this.SystemComboBox_SelectedIndexChanged);
            // 
            // SystemLabel
            // 
            this.SystemLabel.AutoSize = true;
            this.SystemLabel.Location = new System.Drawing.Point(7, 8);
            this.SystemLabel.Name = "SystemLabel";
            this.SystemLabel.Size = new System.Drawing.Size(63, 13);
            this.SystemLabel.TabIndex = 1;
            this.SystemLabel.Text = "Star System";
            // 
            // StationLabel
            // 
            this.StationLabel.AutoSize = true;
            this.StationLabel.Location = new System.Drawing.Point(310, 8);
            this.StationLabel.Name = "StationLabel";
            this.StationLabel.Size = new System.Drawing.Size(40, 13);
            this.StationLabel.TabIndex = 2;
            this.StationLabel.Text = "Station";
            // 
            // StationComboBox
            // 
            this.StationComboBox.FormattingEnabled = true;
            this.StationComboBox.Location = new System.Drawing.Point(356, 5);
            this.StationComboBox.Name = "StationComboBox";
            this.StationComboBox.Size = new System.Drawing.Size(207, 21);
            this.StationComboBox.TabIndex = 3;
            this.StationComboBox.SelectedIndexChanged += new System.EventHandler(this.StationComboBox_SelectedIndexChanged);
            // 
            // AddCommodityButton
            // 
            this.AddCommodityButton.Location = new System.Drawing.Point(10, 87);
            this.AddCommodityButton.Name = "AddCommodityButton";
            this.AddCommodityButton.Size = new System.Drawing.Size(180, 23);
            this.AddCommodityButton.TabIndex = 8;
            this.AddCommodityButton.Text = "Add New Commodity";
            this.AddCommodityButton.UseVisualStyleBackColor = true;
            this.AddCommodityButton.Click += new System.EventHandler(this.AddCommodityButton_Click);
            // 
            // AddSystemButton
            // 
            this.AddSystemButton.Location = new System.Drawing.Point(76, 32);
            this.AddSystemButton.Name = "AddSystemButton";
            this.AddSystemButton.Size = new System.Drawing.Size(100, 23);
            this.AddSystemButton.TabIndex = 1;
            this.AddSystemButton.Text = "Add System";
            this.AddSystemButton.UseVisualStyleBackColor = true;
            this.AddSystemButton.Click += new System.EventHandler(this.AddSystemButton_Click);
            // 
            // AddStationButton
            // 
            this.AddStationButton.Location = new System.Drawing.Point(356, 32);
            this.AddStationButton.Name = "AddStationButton";
            this.AddStationButton.Size = new System.Drawing.Size(70, 23);
            this.AddStationButton.TabIndex = 4;
            this.AddStationButton.Text = "Add Station";
            this.AddStationButton.UseVisualStyleBackColor = true;
            this.AddStationButton.Click += new System.EventHandler(this.AddStationButton_Click);
            // 
            // RemoveSystemButton
            // 
            this.RemoveSystemButton.Location = new System.Drawing.Point(182, 32);
            this.RemoveSystemButton.Name = "RemoveSystemButton";
            this.RemoveSystemButton.Size = new System.Drawing.Size(101, 23);
            this.RemoveSystemButton.TabIndex = 2;
            this.RemoveSystemButton.Text = "Remove System";
            this.RemoveSystemButton.UseVisualStyleBackColor = true;
            this.RemoveSystemButton.Click += new System.EventHandler(this.RemoveSystemButton_Click);
            // 
            // RemoveStationButton
            // 
            this.RemoveStationButton.Location = new System.Drawing.Point(432, 32);
            this.RemoveStationButton.Name = "RemoveStationButton";
            this.RemoveStationButton.Size = new System.Drawing.Size(91, 23);
            this.RemoveStationButton.TabIndex = 5;
            this.RemoveStationButton.Text = "Remove Station";
            this.RemoveStationButton.UseVisualStyleBackColor = true;
            this.RemoveStationButton.Click += new System.EventHandler(this.RemoveStationButton_Click);
            // 
            // CalculateAllTradesButton
            // 
            this.CalculateAllTradesButton.Location = new System.Drawing.Point(196, 87);
            this.CalculateAllTradesButton.Name = "CalculateAllTradesButton";
            this.CalculateAllTradesButton.Size = new System.Drawing.Size(180, 23);
            this.CalculateAllTradesButton.TabIndex = 9;
            this.CalculateAllTradesButton.Text = "Calculate Trades";
            this.CalculateAllTradesButton.UseVisualStyleBackColor = true;
            this.CalculateAllTradesButton.Click += new System.EventHandler(this.CalculateAllTradesManifestsAndRoutesButton_Click);
            // 
            // CargoSlotsNumericUpDown
            // 
            this.CargoSlotsNumericUpDown.Location = new System.Drawing.Point(356, 61);
            this.CargoSlotsNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.CargoSlotsNumericUpDown.Name = "CargoSlotsNumericUpDown";
            this.CargoSlotsNumericUpDown.Size = new System.Drawing.Size(207, 20);
            this.CargoSlotsNumericUpDown.TabIndex = 7;
            this.CargoSlotsNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // CapitalNumericUpDown
            // 
            this.CapitalNumericUpDown.Location = new System.Drawing.Point(76, 61);
            this.CapitalNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.CapitalNumericUpDown.Name = "CapitalNumericUpDown";
            this.CapitalNumericUpDown.Size = new System.Drawing.Size(207, 20);
            this.CapitalNumericUpDown.TabIndex = 6;
            this.CapitalNumericUpDown.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // CapitalLabel
            // 
            this.CapitalLabel.AutoSize = true;
            this.CapitalLabel.Location = new System.Drawing.Point(31, 63);
            this.CapitalLabel.Name = "CapitalLabel";
            this.CapitalLabel.Size = new System.Drawing.Size(39, 13);
            this.CapitalLabel.TabIndex = 26;
            this.CapitalLabel.Text = "Capital";
            // 
            // CargoSlotsLabel
            // 
            this.CargoSlotsLabel.AutoSize = true;
            this.CargoSlotsLabel.Location = new System.Drawing.Point(289, 63);
            this.CargoSlotsLabel.Name = "CargoSlotsLabel";
            this.CargoSlotsLabel.Size = new System.Drawing.Size(61, 13);
            this.CargoSlotsLabel.TabIndex = 27;
            this.CargoSlotsLabel.Text = "Cargo Slots";
            // 
            // CommoditiesGrid
            // 
            this.CommoditiesGrid.AllowUserToAddRows = false;
            this.CommoditiesGrid.AllowUserToDeleteRows = false;
            this.CommoditiesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CommoditiesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommoditiesGrid.Location = new System.Drawing.Point(0, 145);
            this.CommoditiesGrid.Margin = new System.Windows.Forms.Padding(3, 406, 3, 3);
            this.CommoditiesGrid.Name = "CommoditiesGrid";
            this.CommoditiesGrid.Size = new System.Drawing.Size(650, 885);
            this.CommoditiesGrid.TabIndex = 0;
            this.CommoditiesGrid.TabStop = false;
            this.CommoditiesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CommoditiesGrid_CellContentClick);
            this.CommoditiesGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CommoditiesGrid_CellEndEdit);
            // 
            // TimestampAllButton
            // 
            this.TimestampAllButton.Location = new System.Drawing.Point(382, 87);
            this.TimestampAllButton.Name = "TimestampAllButton";
            this.TimestampAllButton.Size = new System.Drawing.Size(181, 23);
            this.TimestampAllButton.TabIndex = 28;
            this.TimestampAllButton.Text = "Timestamp All Commodities";
            this.TimestampAllButton.UseVisualStyleBackColor = true;
            this.TimestampAllButton.Click += new System.EventHandler(this.TimestampAllButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.importToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDataToolStripMenuItem,
            this.loadDataToolStripMenuItem,
            this.exitWithSaveToolStripMenuItem,
            this.saveAndExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveDataToolStripMenuItem
            // 
            this.saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            this.saveDataToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.saveDataToolStripMenuItem.Text = "&Save Data File";
            this.saveDataToolStripMenuItem.Click += new System.EventHandler(this.saveDataToolStripMenuItem_Click);
            // 
            // loadDataToolStripMenuItem
            // 
            this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            this.loadDataToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.loadDataToolStripMenuItem.Text = "&Open Data File";
            this.loadDataToolStripMenuItem.Click += new System.EventHandler(this.loadDataToolStripMenuItem_Click);
            // 
            // exitWithSaveToolStripMenuItem
            // 
            this.exitWithSaveToolStripMenuItem.Name = "exitWithSaveToolStripMenuItem";
            this.exitWithSaveToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitWithSaveToolStripMenuItem.Text = "S&ave and Exit";
            this.exitWithSaveToolStripMenuItem.Click += new System.EventHandler(this.exitWithSaveToolStripMenuItem_Click);
            // 
            // saveAndExitToolStripMenuItem
            // 
            this.saveAndExitToolStripMenuItem.Name = "saveAndExitToolStripMenuItem";
            this.saveAndExitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.saveAndExitToolStripMenuItem.Text = "E&xit";
            this.saveAndExitToolStripMenuItem.Click += new System.EventHandler(this.saveAndExitToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importCSVToolStripMenuItem,
            this.enableOCRToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // importCSVToolStripMenuItem
            // 
            this.importCSVToolStripMenuItem.Name = "importCSVToolStripMenuItem";
            this.importCSVToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importCSVToolStripMenuItem.Text = "Import CSV";
            this.importCSVToolStripMenuItem.Click += new System.EventHandler(this.importCSVToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnMoveStation);
            this.panel1.Controls.Add(this.SystemLabel);
            this.panel1.Controls.Add(this.TimestampAllButton);
            this.panel1.Controls.Add(this.SystemComboBox);
            this.panel1.Controls.Add(this.StationLabel);
            this.panel1.Controls.Add(this.CargoSlotsLabel);
            this.panel1.Controls.Add(this.StationComboBox);
            this.panel1.Controls.Add(this.CapitalLabel);
            this.panel1.Controls.Add(this.AddCommodityButton);
            this.panel1.Controls.Add(this.CapitalNumericUpDown);
            this.panel1.Controls.Add(this.AddSystemButton);
            this.panel1.Controls.Add(this.CargoSlotsNumericUpDown);
            this.panel1.Controls.Add(this.AddStationButton);
            this.panel1.Controls.Add(this.CalculateAllTradesButton);
            this.panel1.Controls.Add(this.RemoveSystemButton);
            this.panel1.Controls.Add(this.RemoveStationButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.panel1.Size = new System.Drawing.Size(650, 121);
            this.panel1.TabIndex = 30;
            // 
            // enableOCRToolStripMenuItem
            // 
            this.enableOCRToolStripMenuItem.CheckOnClick = true;
            this.enableOCRToolStripMenuItem.Name = "enableOCRToolStripMenuItem";
            this.enableOCRToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enableOCRToolStripMenuItem.Text = "Enable OCR";
            this.enableOCRToolStripMenuItem.CheckedChanged += new System.EventHandler(this.enableOCRToolStripMenuItem_CheckedChanged);
            // 
            // btnMoveStation
            // 
            this.btnMoveStation.Location = new System.Drawing.Point(530, 33);
            this.btnMoveStation.Name = "btnMoveStation";
            this.btnMoveStation.Size = new System.Drawing.Size(80, 23);
            this.btnMoveStation.TabIndex = 29;
            this.btnMoveStation.Text = "Move Station";
            this.btnMoveStation.UseVisualStyleBackColor = true;
            this.btnMoveStation.Click += new System.EventHandler(this.btnMoveStation_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.CalculateAllTradesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 1030);
            this.Controls.Add(this.CommoditiesGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Elite: Dangerous Trade Route Assistant";
            ((System.ComponentModel.ISupportInitialize)(this.CargoSlotsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapitalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommoditiesGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SystemComboBox;
        private System.Windows.Forms.Label SystemLabel;
        private System.Windows.Forms.Label StationLabel;
        private System.Windows.Forms.ComboBox StationComboBox;
        private System.Windows.Forms.Button AddCommodityButton;
        private System.Windows.Forms.Button AddSystemButton;
        private System.Windows.Forms.Button AddStationButton;
        private System.Windows.Forms.Button RemoveSystemButton;
        private System.Windows.Forms.Button RemoveStationButton;
        private System.Windows.Forms.Button CalculateAllTradesButton;
        private System.Windows.Forms.NumericUpDown CargoSlotsNumericUpDown;
        private System.Windows.Forms.NumericUpDown CapitalNumericUpDown;
        private System.Windows.Forms.Label CapitalLabel;
        private System.Windows.Forms.Label CargoSlotsLabel;
        private System.Windows.Forms.DataGridView CommoditiesGrid;
        private System.Windows.Forms.Button TimestampAllButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitWithSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAndExitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableOCRToolStripMenuItem;
        private System.Windows.Forms.Button btnMoveStation;
    }
}

