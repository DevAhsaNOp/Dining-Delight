using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dining_Delight
{
    public partial class Change_Quantity : Form
    {
        public Change_Quantity()
        {
            InitializeComponent();
        }
        public int CurrentQuantity { get; set; }
        public int NewQuantity { get; set; }
        private bool HasValidationFailed { get; set; }
        private void Change_Quantity_Load(object sender, EventArgs e)
        {
            QuantityTextBox.Text = CurrentQuantity.ToString();
        }

        private bool IsValidated()
        {
            if (QuantityTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please add new quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuantityTextBox.Clear();
                QuantityTextBox.Focus();
                HasValidationFailed = true;
                return false;
            }

            int result = 0;
            bool isNumeric = int.TryParse(QuantityTextBox.Text.Trim(), out result);
            if (!isNumeric)
            {
                MessageBox.Show("Quantity should be interger (1,2,3,...).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuantityTextBox.Clear();
                QuantityTextBox.Focus();
                HasValidationFailed = true;
                return false;
            }

            return true;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                NewQuantity = Convert.ToInt16(QuantityTextBox.Text);
                HasValidationFailed = false;
            }
        }

        private void Change_Quantity_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = HasValidationFailed;
        }
    }
}
