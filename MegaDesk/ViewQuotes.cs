using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class ViewQuotes : Form
    {
        public ViewQuotes()
        {
            InitializeComponent();
        }

        private void ViewQuotes_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString();
            WidthReq.Text = "Your width must be between 24 and 96 inches.";
        }
    }
}
