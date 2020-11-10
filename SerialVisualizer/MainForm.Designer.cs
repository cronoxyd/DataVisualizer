namespace SerialVisualizer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PortList_comboBox = new DarkUI.Controls.DarkComboBox();
            this.OpenClose_button = new DarkUI.Controls.DarkButton();
            this.RefreshList_button = new DarkUI.Controls.DarkButton();
            this.label1 = new DarkUI.Controls.DarkLabel();
            this.BaudRate_numericUpDown = new DarkUI.Controls.DarkNumericUpDown();
            this.label2 = new DarkUI.Controls.DarkLabel();
            this.label3 = new DarkUI.Controls.DarkLabel();
            this.groupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.ResetMinMax_darkButton = new DarkUI.Controls.DarkButton();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.HistogramMin_darkNumericUpDown = new DarkUI.Controls.DarkNumericUpDown();
            this.HistogramAutoMin_darkCheckBox = new DarkUI.Controls.DarkCheckBox();
            this.MinMaxHold_checkBox = new DarkUI.Controls.DarkCheckBox();
            this.HistogramAutoMax_checkBox = new DarkUI.Controls.DarkCheckBox();
            this.HistogramMax_numericUpDown = new DarkUI.Controls.DarkNumericUpDown();
            this.histogramViewer1 = new SerialVisualizer.HistogramViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GetArrays_darkButton = new DarkUI.Controls.DarkButton();
            ((System.ComponentModel.ISupportInitialize)(this.BaudRate_numericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramMin_darkNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramMax_numericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortList_comboBox
            // 
            this.PortList_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortList_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.PortList_comboBox.FormattingEnabled = true;
            this.PortList_comboBox.Location = new System.Drawing.Point(150, 19);
            this.PortList_comboBox.Name = "PortList_comboBox";
            this.PortList_comboBox.Size = new System.Drawing.Size(613, 40);
            this.PortList_comboBox.TabIndex = 1;
            this.PortList_comboBox.SelectedIndexChanged += new System.EventHandler(this.PortList_comboBox_SelectedIndexChanged);
            // 
            // OpenClose_button
            // 
            this.OpenClose_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenClose_button.Enabled = false;
            this.OpenClose_button.Location = new System.Drawing.Point(769, 15);
            this.OpenClose_button.Name = "OpenClose_button";
            this.OpenClose_button.Padding = new System.Windows.Forms.Padding(5);
            this.OpenClose_button.Size = new System.Drawing.Size(150, 46);
            this.OpenClose_button.TabIndex = 2;
            this.OpenClose_button.Text = "Open";
            this.OpenClose_button.Click += new System.EventHandler(this.OpenList_button_Click);
            // 
            // RefreshList_button
            // 
            this.RefreshList_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshList_button.Location = new System.Drawing.Point(925, 15);
            this.RefreshList_button.Name = "RefreshList_button";
            this.RefreshList_button.Padding = new System.Windows.Forms.Padding(5);
            this.RefreshList_button.Size = new System.Drawing.Size(150, 46);
            this.RefreshList_button.TabIndex = 3;
            this.RefreshList_button.Text = "Refresh";
            this.RefreshList_button.Click += new System.EventHandler(this.RefreshList_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Baud rate:";
            // 
            // BaudRate_numericUpDown
            // 
            this.BaudRate_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaudRate_numericUpDown.Location = new System.Drawing.Point(150, 65);
            this.BaudRate_numericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.BaudRate_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BaudRate_numericUpDown.Name = "BaudRate_numericUpDown";
            this.BaudRate_numericUpDown.Size = new System.Drawing.Size(613, 39);
            this.BaudRate_numericUpDown.TabIndex = 5;
            this.BaudRate_numericUpDown.Value = new decimal(new int[] {
            115200,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label3.Location = new System.Drawing.Point(488, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Maximum:";
            // 
            // groupBox1
            // 
            this.groupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox1.Controls.Add(this.GetArrays_darkButton);
            this.groupBox1.Controls.Add(this.ResetMinMax_darkButton);
            this.groupBox1.Controls.Add(this.darkLabel1);
            this.groupBox1.Controls.Add(this.HistogramMin_darkNumericUpDown);
            this.groupBox1.Controls.Add(this.HistogramAutoMin_darkCheckBox);
            this.groupBox1.Controls.Add(this.MinMaxHold_checkBox);
            this.groupBox1.Controls.Add(this.HistogramAutoMax_checkBox);
            this.groupBox1.Controls.Add(this.HistogramMax_numericUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 548);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1087, 146);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Histogram";
            // 
            // ResetMinMax_darkButton
            // 
            this.ResetMinMax_darkButton.Location = new System.Drawing.Point(371, 83);
            this.ResetMinMax_darkButton.Name = "ResetMinMax_darkButton";
            this.ResetMinMax_darkButton.Padding = new System.Windows.Forms.Padding(5);
            this.ResetMinMax_darkButton.Size = new System.Drawing.Size(86, 46);
            this.ResetMinMax_darkButton.TabIndex = 11;
            this.ResetMinMax_darkButton.Text = "Reset";
            this.ResetMinMax_darkButton.Click += new System.EventHandler(this.ResetMinMax_darkButton_Click);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(12, 40);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(123, 32);
            this.darkLabel1.TabIndex = 7;
            this.darkLabel1.Text = "Minimum:";
            // 
            // HistogramMin_darkNumericUpDown
            // 
            this.HistogramMin_darkNumericUpDown.Enabled = false;
            this.HistogramMin_darkNumericUpDown.Location = new System.Drawing.Point(144, 38);
            this.HistogramMin_darkNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.HistogramMin_darkNumericUpDown.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.HistogramMin_darkNumericUpDown.Name = "HistogramMin_darkNumericUpDown";
            this.HistogramMin_darkNumericUpDown.Size = new System.Drawing.Size(235, 39);
            this.HistogramMin_darkNumericUpDown.TabIndex = 8;
            this.HistogramMin_darkNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HistogramMin_darkNumericUpDown.ValueChanged += new System.EventHandler(this.HistogramMin_darkNumericUpDown_ValueChanged);
            // 
            // HistogramAutoMin_darkCheckBox
            // 
            this.HistogramAutoMin_darkCheckBox.AutoSize = true;
            this.HistogramAutoMin_darkCheckBox.Enabled = false;
            this.HistogramAutoMin_darkCheckBox.Location = new System.Drawing.Point(385, 39);
            this.HistogramAutoMin_darkCheckBox.Name = "HistogramAutoMin_darkCheckBox";
            this.HistogramAutoMin_darkCheckBox.Size = new System.Drawing.Size(97, 36);
            this.HistogramAutoMin_darkCheckBox.TabIndex = 9;
            this.HistogramAutoMin_darkCheckBox.Text = "Auto";
            // 
            // MinMaxHold_checkBox
            // 
            this.MinMaxHold_checkBox.AutoSize = true;
            this.MinMaxHold_checkBox.Location = new System.Drawing.Point(12, 89);
            this.MinMaxHold_checkBox.Name = "MinMaxHold_checkBox";
            this.MinMaxHold_checkBox.Size = new System.Drawing.Size(197, 36);
            this.MinMaxHold_checkBox.TabIndex = 10;
            this.MinMaxHold_checkBox.Text = "Min/Max hold";
            this.MinMaxHold_checkBox.CheckedChanged += new System.EventHandler(this.MinMaxHold_checkBox_CheckedChanged);
            // 
            // HistogramAutoMax_checkBox
            // 
            this.HistogramAutoMax_checkBox.AutoSize = true;
            this.HistogramAutoMax_checkBox.Checked = true;
            this.HistogramAutoMax_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HistogramAutoMax_checkBox.Location = new System.Drawing.Point(861, 39);
            this.HistogramAutoMax_checkBox.Name = "HistogramAutoMax_checkBox";
            this.HistogramAutoMax_checkBox.Size = new System.Drawing.Size(97, 36);
            this.HistogramAutoMax_checkBox.TabIndex = 9;
            this.HistogramAutoMax_checkBox.Text = "Auto";
            this.HistogramAutoMax_checkBox.CheckedChanged += new System.EventHandler(this.HistogramAutoMax_checkBox_CheckedChanged);
            // 
            // HistogramMax_numericUpDown
            // 
            this.HistogramMax_numericUpDown.Enabled = false;
            this.HistogramMax_numericUpDown.Location = new System.Drawing.Point(620, 38);
            this.HistogramMax_numericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.HistogramMax_numericUpDown.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.HistogramMax_numericUpDown.Name = "HistogramMax_numericUpDown";
            this.HistogramMax_numericUpDown.Size = new System.Drawing.Size(235, 39);
            this.HistogramMax_numericUpDown.TabIndex = 8;
            this.HistogramMax_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HistogramMax_numericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HistogramMax_numericUpDown.ValueChanged += new System.EventHandler(this.HistogramMax_numericUpDown_ValueChanged);
            // 
            // histogramViewer1
            // 
            this.histogramViewer1.AutoMax = true;
            this.histogramViewer1.AutoMin = false;
            this.histogramViewer1.BarColor = System.Drawing.Color.Black;
            this.histogramViewer1.ColorMinMax = true;
            this.histogramViewer1.Data = new float[] {
        1F,
        2F,
        4F,
        8F,
        16F,
        32F};
            this.histogramViewer1.DisplayMinMax = true;
            this.histogramViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histogramViewer1.ForeColor = System.Drawing.Color.Orange;
            this.histogramViewer1.Location = new System.Drawing.Point(0, 118);
            this.histogramViewer1.MaxColor = System.Drawing.Color.Red;
            this.histogramViewer1.Maximum = 1000F;
            this.histogramViewer1.MinColor = System.Drawing.Color.Blue;
            this.histogramViewer1.Minimum = 0F;
            this.histogramViewer1.MinMaxHold = false;
            this.histogramViewer1.Name = "histogramViewer1";
            this.histogramViewer1.Size = new System.Drawing.Size(1087, 430);
            this.histogramViewer1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PortList_comboBox);
            this.panel1.Controls.Add(this.OpenClose_button);
            this.panel1.Controls.Add(this.RefreshList_button);
            this.panel1.Controls.Add(this.BaudRate_numericUpDown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 118);
            this.panel1.TabIndex = 10;
            // 
            // GetArrays_darkButton
            // 
            this.GetArrays_darkButton.Enabled = false;
            this.GetArrays_darkButton.Location = new System.Drawing.Point(215, 83);
            this.GetArrays_darkButton.Name = "GetArrays_darkButton";
            this.GetArrays_darkButton.Padding = new System.Windows.Forms.Padding(5);
            this.GetArrays_darkButton.Size = new System.Drawing.Size(150, 46);
            this.GetArrays_darkButton.TabIndex = 12;
            this.GetArrays_darkButton.Text = "Get arrays";
            this.GetArrays_darkButton.Click += new System.EventHandler(this.GetArrays_darkButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 694);
            this.Controls.Add(this.histogramViewer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Serial visualizer";
            ((System.ComponentModel.ISupportInitialize)(this.BaudRate_numericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramMin_darkNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramMax_numericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkComboBox PortList_comboBox;
        private DarkUI.Controls.DarkButton OpenClose_button;
        private DarkUI.Controls.DarkButton RefreshList_button;
        private DarkUI.Controls.DarkLabel label1;
        private DarkUI.Controls.DarkNumericUpDown BaudRate_numericUpDown;
        private DarkUI.Controls.DarkLabel label2;
        private DarkUI.Controls.DarkLabel label3;
        private DarkUI.Controls.DarkGroupBox groupBox1;
        private DarkUI.Controls.DarkNumericUpDown HistogramMax_numericUpDown;
        private DarkUI.Controls.DarkCheckBox HistogramAutoMax_checkBox;
        private HistogramViewer histogramViewer1;
        private DarkUI.Controls.DarkCheckBox MinMaxHold_checkBox;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkNumericUpDown HistogramMin_darkNumericUpDown;
        private DarkUI.Controls.DarkCheckBox HistogramAutoMin_darkCheckBox;
        private System.Windows.Forms.Panel panel1;
        private DarkUI.Controls.DarkButton ResetMinMax_darkButton;
        private DarkUI.Controls.DarkButton GetArrays_darkButton;
    }
}

