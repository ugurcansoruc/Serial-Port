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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Data1Button = new System.Windows.Forms.Button();
            this.Data2Button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Data1Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Data2Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data1Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data2Chart)).BeginInit();
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
            this.DataTextBox.Location = new System.Drawing.Point(494, 113);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(577, 22);
            this.DataTextBox.TabIndex = 10;
            // 
            // ControlLabel
            // 
            this.ControlLabel.AutoSize = true;
            this.ControlLabel.Location = new System.Drawing.Point(299, 118);
            this.ControlLabel.Name = "ControlLabel";
            this.ControlLabel.Size = new System.Drawing.Size(32, 17);
            this.ControlLabel.TabIndex = 11;
            this.ControlLabel.Text = "000";
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Location = new System.Drawing.Point(207, 118);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(48, 17);
            this.DataLabel.TabIndex = 12;
            this.DataLabel.Text = "Status";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 52);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // Data1Button
            // 
            this.Data1Button.Location = new System.Drawing.Point(88, 181);
            this.Data1Button.Name = "Data1Button";
            this.Data1Button.Size = new System.Drawing.Size(75, 23);
            this.Data1Button.TabIndex = 14;
            this.Data1Button.Text = "Data1";
            this.Data1Button.UseVisualStyleBackColor = true;
            this.Data1Button.Click += new System.EventHandler(this.Data1Button_Click);
            // 
            // Data2Button
            // 
            this.Data2Button.Location = new System.Drawing.Point(210, 181);
            this.Data2Button.Name = "Data2Button";
            this.Data2Button.Size = new System.Drawing.Size(75, 23);
            this.Data2Button.TabIndex = 15;
            this.Data2Button.Text = "Data 2";
            this.Data2Button.UseVisualStyleBackColor = true;
            this.Data2Button.Click += new System.EventHandler(this.Data2Button_Click);
            // 
            // Data1Chart
            // 
            chartArea5.Name = "ChartArea1";
            this.Data1Chart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.Data1Chart.Legends.Add(legend5);
            this.Data1Chart.Location = new System.Drawing.Point(88, 232);
            this.Data1Chart.Name = "Data1Chart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Data1";
            this.Data1Chart.Series.Add(series5);
            this.Data1Chart.Size = new System.Drawing.Size(534, 324);
            this.Data1Chart.TabIndex = 0;
            this.Data1Chart.Text = "Data1";
            // 
            // Data2Chart
            // 
            chartArea6.Name = "ChartArea1";
            this.Data2Chart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.Data2Chart.Legends.Add(legend6);
            this.Data2Chart.Location = new System.Drawing.Point(88, 232);
            this.Data2Chart.Name = "Data2Chart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Data2";
            this.Data2Chart.Series.Add(series6);
            this.Data2Chart.Size = new System.Drawing.Size(534, 324);
            this.Data2Chart.TabIndex = 0;
            this.Data2Chart.Text = "Data2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 577);
            this.Controls.Add(this.Data2Chart);
            this.Controls.Add(this.Data1Chart);
            this.Controls.Add(this.Data2Button);
            this.Controls.Add(this.Data1Button);
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
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data1Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data2Chart)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button Data1Button;
        private System.Windows.Forms.Button Data2Button;
        private System.Windows.Forms.DataVisualization.Charting.Chart Data1Chart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Data2Chart;
    }
}

