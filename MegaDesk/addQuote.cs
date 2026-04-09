using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        private DeskQuote deskQuote = new DeskQuote();
        public AddQuote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void WidthBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                int newWidth;
                bool isNum = Int32.TryParse(input.Text, out newWidth);
                if (isNum)
                {
                    deskQuote.desk.Width = newWidth;
                    WidthErrorProvider.SetError(this.WidthBox, "");
                }
                else
                {
                    WidthErrorProvider.SetError(this.WidthBox, "Enter a number.");
                }
            }
            catch (Exception ex)
            {
                WidthErrorProvider.SetError(this.WidthBox, "Input must be between 24 and 96 inches.");
            }
        }

        private void NameBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(input.Text))
            {
                NameErrorProvider.SetError(this.NameBox, "Name is required.");
            }
            else
            {
                deskQuote.customerName = input.Text;
                NameErrorProvider.SetError(this.NameBox, "");
            }
        }

        private void DepthBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                int newDepth;
                bool isNum = Int32.TryParse(input.Text, out newDepth);
                if (isNum)
                {
                    deskQuote.desk.Depth = newDepth;
                    DepthErrorProvider.SetError(this.DepthBox, "");
                }
                else
                {
                    DepthErrorProvider.SetError(this.DepthBox, "Enter a number.");
                }
            }
            catch (Exception ex)
            {
                DepthErrorProvider.SetError(this.DepthBox, "Input must be between 12 and 48 inches.");
            }
        }

        private void DrawerComboBox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox input = (ComboBox)sender;

            if (input.SelectedItem == null)
            {
                DrawerErrorProvider.SetError(this.DrawerComboBox, "Select number of drawers.");
            }
            else
            {
                deskQuote.desk.NumberOfDrawers = Int32.Parse(input.SelectedItem.ToString());
                DrawerErrorProvider.SetError(this.DrawerComboBox, "");
            }
        }

        private void ShippingComboBox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox input = (ComboBox)sender;

            if (input.SelectedItem == null)
            {
                ShippingErrorProvider.SetError(this.ShippingComboBox, "Select shipping days.");
            }
            else
            {
                deskQuote.shippingDays = Int32.Parse(input.SelectedItem.ToString());
                ShippingErrorProvider.SetError(this.ShippingComboBox, "");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WidthBox.Text.Length == 0 || DepthBox.Text.Length == 0 || DrawerInput.Text.Length == 0) return;
            int surfaceArea = deskQuote.desk.getSurfaceArea();
            string orderDate = DateTime.Now.ToShortDateString();
            int shipping = deskQuote.desk.ShippingDays;
            DisplayQuote frm = new DisplayQuote(deskQuote);
            frm.Show();
            Close();
        }
    }
}
