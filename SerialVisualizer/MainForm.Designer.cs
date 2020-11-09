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
            this.PortList_comboBox = new System.Windows.Forms.ComboBox();
            this.OpenClose_button = new System.Windows.Forms.Button();
            this.RefreshList_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BaudRate_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HistogramAutoMax_checkBox = new System.Windows.Forms.CheckBox();
            this.HistogramMax_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.histogramViewer1 = new SerialVisualizer.HistogramViewer();
            this.MinMaxHold_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.BaudRate_numericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramMax_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PortList_comboBox
            // 
            this.PortList_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortList_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortList_comboBox.FormattingEnabled = true;
            this.PortList_comboBox.Location = new System.Drawing.Point(146, 20);
            this.PortList_comboBox.Name = "PortList_comboBox";
            this.PortList_comboBox.Size = new System.Drawing.Size(617, 40);
            this.PortList_comboBox.TabIndex = 1;
            this.PortList_comboBox.SelectedIndexChanged += new System.EventHandler(this.PortList_comboBox_SelectedIndexChanged);
            // 
            // OpenClose_button
            // 
            this.OpenClose_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenClose_button.Enabled = false;
            this.OpenClose_button.Location = new System.Drawing.Point(769, 16);
            this.OpenClose_button.Name = "OpenClose_button";
            this.OpenClose_button.Size = new System.Drawing.Size(150, 46);
            this.OpenClose_button.TabIndex = 2;
            this.OpenClose_button.Text = "Open";
            this.OpenClose_button.UseVisualStyleBackColor = true;
            this.OpenClose_button.Click += new System.EventHandler(this.OpenList_button_Click);
            // 
            // RefreshList_button
            // 
            this.RefreshList_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshList_button.Location = new System.Drawing.Point(925, 16);
            this.RefreshList_button.Name = "RefreshList_button";
            this.RefreshList_button.Size = new System.Drawing.Size(150, 46);
            this.RefreshList_button.TabIndex = 3;
            this.RefreshList_button.Text = "Refresh";
            this.RefreshList_button.UseVisualStyleBackColor = true;
            this.RefreshList_button.Click += new System.EventHandler(this.RefreshList_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Baud rate:";
            // 
            // BaudRate_numericUpDown
            // 
            this.BaudRate_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaudRate_numericUpDown.Location = new System.Drawing.Point(146, 66);
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
            this.BaudRate_numericUpDown.Size = new System.Drawing.Size(617, 39);
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
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Maximum:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.MinMaxHold_checkBox);
            this.groupBox1.Controls.Add(this.HistogramAutoMax_checkBox);
            this.groupBox1.Controls.Add(this.HistogramMax_numericUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 592);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1063, 90);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Histogram";
            // 
            // HistogramAutoMax_checkBox
            // 
            this.HistogramAutoMax_checkBox.AutoSize = true;
            this.HistogramAutoMax_checkBox.Checked = true;
            this.HistogramAutoMax_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HistogramAutoMax_checkBox.Location = new System.Drawing.Point(379, 39);
            this.HistogramAutoMax_checkBox.Name = "HistogramAutoMax_checkBox";
            this.HistogramAutoMax_checkBox.Size = new System.Drawing.Size(97, 36);
            this.HistogramAutoMax_checkBox.TabIndex = 9;
            this.HistogramAutoMax_checkBox.Text = "Auto";
            this.HistogramAutoMax_checkBox.UseVisualStyleBackColor = true;
            this.HistogramAutoMax_checkBox.CheckedChanged += new System.EventHandler(this.HistogramAutoMax_checkBox_CheckedChanged);
            // 
            // HistogramMax_numericUpDown
            // 
            this.HistogramMax_numericUpDown.Enabled = false;
            this.HistogramMax_numericUpDown.Location = new System.Drawing.Point(138, 38);
            this.HistogramMax_numericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.HistogramMax_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.histogramViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histogramViewer1.AutoMax = true;
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
            this.histogramViewer1.ForeColor = System.Drawing.Color.Orange;
            this.histogramViewer1.Location = new System.Drawing.Point(12, 111);
            this.histogramViewer1.MaxColor = System.Drawing.Color.Red;
            this.histogramViewer1.Maximum = 1000F;
            this.histogramViewer1.MinColor = System.Drawing.Color.Blue;
            this.histogramViewer1.MinMaxHold = false;
            this.histogramViewer1.Name = "histogramViewer1";
            this.histogramViewer1.Size = new System.Drawing.Size(1063, 475);
            this.histogramViewer1.TabIndex = 9;
            // 
            // MinMaxHold_checkBox
            // 
            this.MinMaxHold_checkBox.AutoSize = true;
            this.MinMaxHold_checkBox.Location = new System.Drawing.Point(482, 41);
            this.MinMaxHold_checkBox.Name = "MinMaxHold_checkBox";
            this.MinMaxHold_checkBox.Size = new System.Drawing.Size(197, 36);
            this.MinMaxHold_checkBox.TabIndex = 10;
            this.MinMaxHold_checkBox.Text = "Min/Max hold";
            this.MinMaxHold_checkBox.UseVisualStyleBackColor = true;
            this.MinMaxHold_checkBox.CheckedChanged += new System.EventHandler(this.MinMaxHold_checkBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 694);
            this.Controls.Add(this.histogramViewer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BaudRate_numericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RefreshList_button);
            this.Controls.Add(this.OpenClose_button);
            this.Controls.Add(this.PortList_comboBox);
            this.Name = "MainForm";
            this.Text = "Serial visualizer";
            ((System.ComponentModel.ISupportInitialize)(this.BaudRate_numericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramMax_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox PortList_comboBox;
        private System.Windows.Forms.Button OpenClose_button;
        private System.Windows.Forms.Button RefreshList_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown BaudRate_numericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown HistogramMax_numericUpDown;
        private System.Windows.Forms.CheckBox HistogramAutoMax_checkBox;
        private HistogramViewer histogramViewer1;
        private System.Windows.Forms.CheckBox MinMaxHold_checkBox;
    }
}

