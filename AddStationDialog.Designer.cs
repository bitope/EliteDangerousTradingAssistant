namespace EliteDangerousTradingAssistant
{
    partial class AddStationDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStationDialog));
            this.SystemLabel = new System.Windows.Forms.Label();
            this.SystemTextBox = new System.Windows.Forms.TextBox();
            this.StationLabel = new System.Windows.Forms.Label();
            this.StationTextBox = new System.Windows.Forms.TextBox();
            this.AddStationButton = new System.Windows.Forms.Button();
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
            this.SystemTextBox.Location = new System.Drawing.Point(80, 12);
            this.SystemTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SystemTextBox.Name = "SystemTextBox";
            this.SystemTextBox.Size = new System.Drawing.Size(332, 22);
            this.SystemTextBox.TabIndex = 1;
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
            this.StationTextBox.Location = new System.Drawing.Point(80, 46);
            this.StationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StationTextBox.Name = "StationTextBox";
            this.StationTextBox.Size = new System.Drawing.Size(332, 22);
            this.StationTextBox.TabIndex = 3;
            // 
            // AddStationButton
            // 
            this.AddStationButton.Location = new System.Drawing.Point(80, 78);
            this.AddStationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddStationButton.Name = "AddStationButton";
            this.AddStationButton.Size = new System.Drawing.Size(333, 28);
            this.AddStationButton.TabIndex = 4;
            this.AddStationButton.Text = "Add Station";
            this.AddStationButton.UseVisualStyleBackColor = true;
            this.AddStationButton.Click += new System.EventHandler(this.AddStationButton_Click);
            // 
            // AddStationDialog
            // 
            this.AcceptButton = this.AddStationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 112);
            this.Controls.Add(this.AddStationButton);
            this.Controls.Add(this.StationTextBox);
            this.Controls.Add(this.StationLabel);
            this.Controls.Add(this.SystemTextBox);
            this.Controls.Add(this.SystemLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddStationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add a Station";
            this.Load += new System.EventHandler(this.AddStationDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SystemLabel;
        private System.Windows.Forms.TextBox SystemTextBox;
        private System.Windows.Forms.Label StationLabel;
        private System.Windows.Forms.TextBox StationTextBox;
        private System.Windows.Forms.Button AddStationButton;
    }
}