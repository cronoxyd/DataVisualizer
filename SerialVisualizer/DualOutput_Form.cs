using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DarkUI.Forms;

namespace SerialVisualizer
{
    public partial class DualOutput_Form : DarkForm
    {
        public string UpperTitle
        {
            get => Upper_darkGroupBox.Text;
            set => Upper_darkGroupBox.Text = value;
        }

        public string LowerTitle
        {
            get => Lower_darkGroupBox.Text;
            set => Lower_darkGroupBox.Text = value;
        }

        public string UpperText
        {
            get => Upper_darkTextBox.Text;
            set => Upper_darkTextBox.Text = value;
        }

        public string LowerText
        {
            get => Lower_darkTextBox.Text;
            set => Lower_darkTextBox.Text = value;
        }

        public DualOutput_Form()
        {
            InitializeComponent();
        }

        private void DualOutput_Form_Shown(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = splitContainer1.Height / 2;
        }

        private void Close_darkButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
