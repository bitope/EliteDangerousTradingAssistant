namespace EliteDangerousTradingAssistant
{
    partial class AddEditCommodityDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditCommodityDialog));
            this.SystemLabel = new System.Windows.Forms.Label();
            this.SystemTextBox = new System.Windows.Forms.TextBox();
            this.StationLabel = new System.Windows.Forms.Label();
            this.StationTextBox = new System.Windows.Forms.TextBox();
            this.CommodityLabel = new System.Windows.Forms.Label();
            this.BuyLabel = new System.Windows.Forms.Label();
            this.SellLabel = new System.Windows.Forms.Label();
            this.SupplyLabel = new System.Windows.Forms.Label();
            this.BuyTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SellTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SupplyTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.CommodityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SystemLabel
            // 
            this.SystemLabel.AutoSize = true;
            this.SystemLabel.Location = new System.Drawing.Point(17, 16);
            this.SystemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SystemLabel.Name = "SystemLabel";
            this.SystemLabel.Size = new System.Drawing.Size(54, 17);
            this.SystemLabel.TabIndex = 0;
            this.SystemLabel.Text = "System";
            // 
            // SystemTextBox
            // 
            this.SystemTextBox.Enabled = false;
            this.SystemTextBox.Location = new System.Drawing.Point(103, 12);
            this.SystemTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SystemTextBox.Name = "SystemTextBox";
            this.SystemTextBox.Size = new System.Drawing.Size(329, 22);
            this.SystemTextBox.TabIndex = 0;
            // 
            // StationLabel
            // 
            this.StationLabel.AutoSize = true;
            this.StationLabel.Location = new System.Drawing.Point(17, 49);
            this.StationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StationLabel.Name = "StationLabel";
            this.StationLabel.Size = new System.Drawing.Size(52, 17);
            this.StationLabel.TabIndex = 2;
            this.StationLabel.Text = "Station";
            // 
            // StationTextBox
            // 
            this.StationTextBox.Enabled = false;
            this.StationTextBox.Location = new System.Drawing.Point(103, 44);
            this.StationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StationTextBox.Name = "StationTextBox";
            this.StationTextBox.Size = new System.Drawing.Size(329, 22);
            this.StationTextBox.TabIndex = 1;
            // 
            // CommodityLabel
            // 
            this.CommodityLabel.AutoSize = true;
            this.CommodityLabel.Location = new System.Drawing.Point(17, 82);
            this.CommodityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CommodityLabel.Name = "CommodityLabel";
            this.CommodityLabel.Size = new System.Drawing.Size(77, 17);
            this.CommodityLabel.TabIndex = 5;
            this.CommodityLabel.Text = "Commodity";
            // 
            // BuyLabel
            // 
            this.BuyLabel.AutoSize = true;
            this.BuyLabel.Location = new System.Drawing.Point(211, 144);
            this.BuyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BuyLabel.Name = "BuyLabel";
            this.BuyLabel.Size = new System.Drawing.Size(32, 17);
            this.BuyLabel.TabIndex = 9;
            this.BuyLabel.Text = "Buy";
            // 
            // SellLabel
            // 
            this.SellLabel.AutoSize = true;
            this.SellLabel.Location = new System.Drawing.Point(99, 144);
            this.SellLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SellLabel.Name = "SellLabel";
            this.SellLabel.Size = new System.Drawing.Size(31, 17);
            this.SellLabel.TabIndex = 10;
            this.SellLabel.Text = "Sell";
            // 
            // SupplyLabel
            // 
            this.SupplyLabel.AutoSize = true;
            this.SupplyLabel.Location = new System.Drawing.Point(324, 144);
            this.SupplyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SupplyLabel.Name = "SupplyLabel";
            this.SupplyLabel.Size = new System.Drawing.Size(51, 17);
            this.SupplyLabel.TabIndex = 11;
            this.SupplyLabel.Text = "Supply";
            // 
            // BuyTextBox
            // 
            this.BuyTextBox.Location = new System.Drawing.Point(215, 165);
            this.BuyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BuyTextBox.Mask = "0000000";
            this.BuyTextBox.Name = "BuyTextBox";
            this.BuyTextBox.Size = new System.Drawing.Size(104, 22);
            this.BuyTextBox.TabIndex = 5;
            this.BuyTextBox.Text = "0";
            this.BuyTextBox.ValidatingType = typeof(int);
            this.BuyTextBox.TextChanged += new System.EventHandler(this.BuyTextBox_TextChanged);
            // 
            // SellTextBox
            // 
            this.SellTextBox.Location = new System.Drawing.Point(103, 165);
            this.SellTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SellTextBox.Mask = "0000000";
            this.SellTextBox.Name = "SellTextBox";
            this.SellTextBox.Size = new System.Drawing.Size(104, 22);
            this.SellTextBox.TabIndex = 4;
            this.SellTextBox.Text = "0";
            this.SellTextBox.ValidatingType = typeof(int);
            // 
            // SupplyTextBox
            // 
            this.SupplyTextBox.Location = new System.Drawing.Point(328, 165);
            this.SupplyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SupplyTextBox.Mask = "0000000";
            this.SupplyTextBox.Name = "SupplyTextBox";
            this.SupplyTextBox.Size = new System.Drawing.Size(104, 22);
            this.SupplyTextBox.TabIndex = 6;
            this.SupplyTextBox.Text = "0";
            this.SupplyTextBox.ValidatingType = typeof(int);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(103, 198);
            this.SaveChangesButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(331, 28);
            this.SaveChangesButton.TabIndex = 7;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // CommodityTextBox
            // 
            this.CommodityTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CommodityTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CommodityTextBox.Location = new System.Drawing.Point(103, 79);
            this.CommodityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CommodityTextBox.Name = "CommodityTextBox";
            this.CommodityTextBox.Size = new System.Drawing.Size(329, 22);
            this.CommodityTextBox.TabIndex = 2;
            // 
            // AddEditCommodityDialog
            // 
            this.AcceptButton = this.SaveChangesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 253);
            this.Controls.Add(this.CommodityTextBox);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.SupplyTextBox);
            this.Controls.Add(this.SellTextBox);
            this.Controls.Add(this.BuyTextBox);
            this.Controls.Add(this.SupplyLabel);
            this.Controls.Add(this.SellLabel);
            this.Controls.Add(this.BuyLabel);
            this.Controls.Add(this.CommodityLabel);
            this.Controls.Add(this.StationTextBox);
            this.Controls.Add(this.StationLabel);
            this.Controls.Add(this.SystemTextBox);
            this.Controls.Add(this.SystemLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEditCommodityDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add / Edit Commodity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SystemLabel;
        private System.Windows.Forms.TextBox SystemTextBox;
        private System.Windows.Forms.Label StationLabel;
        private System.Windows.Forms.TextBox StationTextBox;
        private System.Windows.Forms.Label CommodityLabel;
        private System.Windows.Forms.Label BuyLabel;
        private System.Windows.Forms.Label SellLabel;
        private System.Windows.Forms.Label SupplyLabel;
        private System.Windows.Forms.MaskedTextBox BuyTextBox;
        private System.Windows.Forms.MaskedTextBox SellTextBox;
        private System.Windows.Forms.MaskedTextBox SupplyTextBox;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.TextBox CommodityTextBox;
    }
}