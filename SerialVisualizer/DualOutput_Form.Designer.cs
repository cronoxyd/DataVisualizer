namespace SerialVisualizer
{
    partial class DualOutput_Form
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
            this.Upper_darkGroupBox = new DarkUI.Controls.DarkGroupBox();
            this.Lower_darkGroupBox = new DarkUI.Controls.DarkGroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Close_darkButton = new DarkUI.Controls.DarkButton();
            this.darkSeparator1 = new DarkUI.Controls.DarkSeparator();
            this.Upper_darkTextBox = new DarkUI.Controls.DarkTextBox();
            this.Lower_darkTextBox = new DarkUI.Controls.DarkTextBox();
            this.Upper_darkGroupBox.SuspendLayout();
            this.Lower_darkGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Upper_darkGroupBox
            // 
            this.Upper_darkGroupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Upper_darkGroupBox.Controls.Add(this.Upper_darkTextBox);
            this.Upper_darkGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Upper_darkGroupBox.Location = new System.Drawing.Point(0, 0);
            this.Upper_darkGroupBox.Name = "Upper_darkGroupBox";
            this.Upper_darkGroupBox.Size = new System.Drawing.Size(774, 219);
            this.Upper_darkGroupBox.TabIndex = 0;
            this.Upper_darkGroupBox.TabStop = false;
            this.Upper_darkGroupBox.Text = "Text A";
            // 
            // Lower_darkGroupBox
            // 
            this.Lower_darkGroupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Lower_darkGroupBox.Controls.Add(this.Lower_darkTextBox);
            this.Lower_darkGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lower_darkGroupBox.Location = new System.Drawing.Point(0, 0);
            this.Lower_darkGroupBox.Name = "Lower_darkGroupBox";
            this.Lower_darkGroupBox.Size = new System.Drawing.Size(774, 306);
            this.Lower_darkGroupBox.TabIndex = 1;
            this.Lower_darkGroupBox.TabStop = false;
            this.Lower_darkGroupBox.Text = "Text B";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Upper_darkGroupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Lower_darkGroupBox);
            this.splitContainer1.Size = new System.Drawing.Size(774, 529);
            this.splitContainer1.SplitterDistance = 219;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.Close_darkButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 447);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(774, 82);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Close_darkButton
            // 
            this.Close_darkButton.Location = new System.Drawing.Point(591, 18);
            this.Close_darkButton.Name = "Close_darkButton";
            this.Close_darkButton.Padding = new System.Windows.Forms.Padding(5);
            this.Close_darkButton.Size = new System.Drawing.Size(150, 46);
            this.Close_darkButton.TabIndex = 0;
            this.Close_darkButton.Text = "Close";
            this.Close_darkButton.Click += new System.EventHandler(this.Close_darkButton_Click);
            // 
            // darkSeparator1
            // 
            this.darkSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.darkSeparator1.Location = new System.Drawing.Point(0, 439);
            this.darkSeparator1.Name = "darkSeparator1";
            this.darkSeparator1.Size = new System.Drawing.Size(774, 8);
            this.darkSeparator1.TabIndex = 4;
            this.darkSeparator1.Text = "darkSeparator1";
            // 
            // Upper_darkTextBox
            // 
            this.Upper_darkTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.Upper_darkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Upper_darkTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Upper_darkTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Upper_darkTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Upper_darkTextBox.Location = new System.Drawing.Point(3, 35);
            this.Upper_darkTextBox.Multiline = true;
            this.Upper_darkTextBox.Name = "Upper_darkTextBox";
            this.Upper_darkTextBox.ReadOnly = true;
            this.Upper_darkTextBox.Size = new System.Drawing.Size(768, 181);
            this.Upper_darkTextBox.TabIndex = 0;
            // 
            // Lower_darkTextBox
            // 
            this.Lower_darkTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.Lower_darkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lower_darkTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lower_darkTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lower_darkTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Lower_darkTextBox.Location = new System.Drawing.Point(3, 35);
            this.Lower_darkTextBox.Multiline = true;
            this.Lower_darkTextBox.Name = "Lower_darkTextBox";
            this.Lower_darkTextBox.ReadOnly = true;
            this.Lower_darkTextBox.Size = new System.Drawing.Size(768, 268);
            this.Lower_darkTextBox.TabIndex = 0;
            // 
            // DualOutput_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.darkSeparator1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DualOutput_Form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Output";
            this.Shown += new System.EventHandler(this.DualOutput_Form_Shown);
            this.Upper_darkGroupBox.ResumeLayout(false);
            this.Upper_darkGroupBox.PerformLayout();
            this.Lower_darkGroupBox.ResumeLayout(false);
            this.Lower_darkGroupBox.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkGroupBox Upper_darkGroupBox;
        private DarkUI.Controls.DarkGroupBox Lower_darkGroupBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DarkUI.Controls.DarkSeparator darkSeparator1;
        private DarkUI.Controls.DarkButton Close_darkButton;
        private DarkUI.Controls.DarkTextBox Upper_darkTextBox;
        private DarkUI.Controls.DarkTextBox Lower_darkTextBox;
    }
}