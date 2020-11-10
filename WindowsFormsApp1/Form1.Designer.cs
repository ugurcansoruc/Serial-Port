namespace WindowsFormsApp1
{
    partial class Form1
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
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.PortNameComboBox = new System.Windows.Forms.ComboBox();
            this.PortNameLabel = new System.Windows.Forms.Label();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.ParityLabel = new System.Windows.Forms.Label();
            this.ParityComboBox = new System.Windows.Forms.ComboBox();
            this.DataBitLabel = new System.Windows.Forms.Label();
            this.DataBitComboBox = new System.Windows.Forms.ComboBox();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.ControlLabel = new System.Windows.Forms.Label();
            this.DataLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(22, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(141, 61);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(22, 79);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(141, 61);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PortNameComboBox
            // 
            this.PortNameComboBox.FormattingEnabled = true;
            this.PortNameComboBox.Location = new System.Drawing.Point(210, 49);
            this.PortNameComboBox.Name = "PortNameComboBox";
            this.PortNameComboBox.Size = new System.Drawing.Size(121, 24);
            this.PortNameComboBox.TabIndex = 2;
            // 
            // PortNameLabel
            // 
            this.PortNameLabel.AutoSize = true;
            this.PortNameLabel.Location = new System.Drawing.Point(207, 12);
            this.PortNameLabel.Name = "PortNameLabel";
            this.PortNameLabel.Size = new System.Drawing.Size(75, 17);
            this.PortNameLabel.TabIndex = 3;
            this.PortNameLabel.Text = "Port Name";
            this.PortNameLabel.UseWaitCursor = true;
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Location = new System.Drawing.Point(362, 12);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(71, 17);
            this.BaudRateLabel.TabIndex = 4;
            this.BaudRateLabel.Text = "BaudRate";
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Location = new System.Drawing.Point(365, 49);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(121, 24);
            this.BaudRateComboBox.TabIndex = 5;
            // 
            // ParityLabel
            // 
            this.ParityLabel.AutoSize = true;
            this.ParityLabel.Location = new System.Drawing.Point(538, 13);
            this.ParityLabel.Name = "ParityLabel";
            this.ParityLabel.Size = new System.Drawing.Size(44, 17);
            this.ParityLabel.TabIndex = 6;
            this.ParityLabel.Text = "Parity";
            // 
            // ParityComboBox
            // 
            this.ParityComboBox.FormattingEnabled = true;
            this.ParityComboBox.Location = new System.Drawing.Point(541, 49);
            this.ParityComboBox.Name = "ParityComboBox";
            this.ParityComboBox.Size = new System.Drawing.Size(121, 24);
            this.ParityComboBox.TabIndex = 7;
            // 
            // DataBitLabel
            // 
            this.DataBitLabel.AutoSize = true;
            this.DataBitLabel.Location = new System.Drawing.Point(706, 12);
            this.DataBitLabel.Name = "DataBitLabel";
            this.DataBitLabel.Size = new System.Drawing.Size(65, 17);
            this.DataBitLabel.TabIndex = 8;
            this.DataBitLabel.Text = "Data Bits";
            // 
            // DataBitComboBox
            // 
            this.DataBitComboBox.FormattingEnabled = true;
            this.DataBitComboBox.Location = new System.Drawing.Point(709, 47);
            this.DataBitComboBox.Name = "DataBitComboBox";
            this.DataBitComboBox.Size = new System.Drawing.Size(121, 24);
            this.DataBitComboBox.TabIndex = 9;
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(279, 153);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(510, 22);
            this.DataTextBox.TabIndex = 10;
            // 
            // ControlLabel
            // 
            this.ControlLabel.AutoSize = true;
            this.ControlLabel.Location = new System.Drawing.Point(172, 241);
            this.ControlLabel.Name = "ControlLabel";
            this.ControlLabel.Size = new System.Drawing.Size(32, 17);
            this.ControlLabel.TabIndex = 11;
            this.ControlLabel.Text = "000";
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Location = new System.Drawing.Point(328, 241);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(46, 17);
            this.DataLabel.TabIndex = 12;
            this.DataLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 577);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.ControlLabel);
            this.Controls.Add(this.DataTextBox);
            this.Controls.Add(this.DataBitComboBox);
            this.Controls.Add(this.DataBitLabel);
            this.Controls.Add(this.ParityComboBox);
            this.Controls.Add(this.ParityLabel);
            this.Controls.Add(this.BaudRateComboBox);
            this.Controls.Add(this.BaudRateLabel);
            this.Controls.Add(this.PortNameLabel);
            this.Controls.Add(this.PortNameComboBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.ComboBox PortNameComboBox;
        private System.Windows.Forms.Label PortNameLabel;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.Label ParityLabel;
        private System.Windows.Forms.ComboBox ParityComboBox;
        private System.Windows.Forms.Label DataBitLabel;
        private System.Windows.Forms.ComboBox DataBitComboBox;
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.Label ControlLabel;
        private System.Windows.Forms.Label DataLabel;
    }
}

