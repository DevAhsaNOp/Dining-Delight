using System;
using System.Net;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Dining_Delight.Models;
using System.ComponentModel;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dining_Delight.Properties;
using System.Collections.Generic;


namespace Dining_Delight
{
    public partial class Form1 : Form
    {
        string constring = "Server=127.0.0.1;Port=3306;Database=dinningdelight;Uid=root@;Pwd=";

        public Form1()
        {
            InitializeComponent();
        }

        public static bool CheckInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private List<CartItem> shoppingCart = new List<CartItem>();
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            string orderNumber;
            bool isOrderNumAlreadyExist = true;

            while (isOrderNumAlreadyExist)
            {
                orderNumber = GenerateOrderNumber();

                isOrderNumAlreadyExist = CheckIfOrderNumberExists(orderNumber);

                OrderNumberTextBox.Text = orderNumber;
            }
            NewOrderButton.Enabled = false;
            PrintOrderButton.Enabled = true;
            PrintPreviewButton.Enabled = true;
            CancelOrderButton.Enabled = true;
            ItemGroupBox.Enabled = true;
            ClientNameTextBox.Focus();
        }

        private bool CheckIfOrderNumberExists(string orderNumber)
        {
            bool doesOrderNumberExist = false;

            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Orders WHERE OrderNumber=@OrderNumber", conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@OrderNumber", orderNumber);

                    DataTable dtAnyData = new DataTable();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtAnyData.Load(reader);

                    if (dtAnyData.Rows.Count > 0)
                    {
                        doesOrderNumberExist = true;
                    }
                }
            }

            return doesOrderNumberExist;
        }

        private string GenerateOrderNumber()
        {
            string orderNumber;

            // JI-XXXXXXXXX-XXXX
            Random rnd = new Random();
            long orderpart1 = rnd.Next(100000, 9999999);
            int orderpart2 = rnd.Next(1000, 9999);

            orderNumber = "DD-" + orderpart1 + "-" + orderpart2;

            return orderNumber;
        }

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            NewOrderButton.Enabled = true;
            PrintOrderButton.Enabled = false;
            PrintPreviewButton.Enabled = false;
            CancelOrderButton.Enabled = false;
            ItemGroupBox.Enabled = false;

            ClientNameTextBox.Clear();
            ItemNameComboBox.SelectedIndex = -1;
            QuantityTextBox.Clear();
            UnitPriceTextBox.Clear();
            CurrentStockTextBox.Clear();
            TotalAmountTextBox.Text = "0";
            SalesTaxTextBox.Text = "0";
            TotalToPayTextBox.Text = "0";

            CartDataGridView.DataSource = null;
            shoppingCart.Clear();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                if (Convert.ToInt16(QuantityTextBox.Text.Trim()) > Convert.ToInt16(CurrentStockTextBox.Text))
                {
                    MessageBox.Show("Quantity can't be greater than current stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool hasSameProductSelectedAgain = false;


                //If Product Is Reselected and Add it's value so update it's previous Value
                foreach (DataGridViewRow row in CartDataGridView.Rows)
                {
                    if (Convert.ToInt16(row.Cells["ItemId"].Value) == Convert.ToInt16(ItemNameComboBox.SelectedValue))
                    {
                        row.Cells["Quantity"].Value = Convert.ToInt16(row.Cells["Quantity"].Value) + Convert.ToInt16(QuantityTextBox.Text);
                        row.Cells["TotalPrice"].Value = Convert.ToInt16(row.Cells["Quantity"].Value) * Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                        hasSameProductSelectedAgain = true;
                    }
                }

                if (hasSameProductSelectedAgain == false)
                {
                    CartItem item = new CartItem()
                    {
                        ItemId = Convert.ToInt16(ItemNameComboBox.SelectedValue),
                        ItemName = ItemNameComboBox.Text,
                        Quantity = Convert.ToInt16(QuantityTextBox.Text.Trim()),
                        UnitPrice = Convert.ToDecimal(UnitPriceTextBox.Text.Trim()),
                        TotalPrice = Convert.ToInt16(QuantityTextBox.Text.Trim()) * Convert.ToDecimal(UnitPriceTextBox.Text.Trim())
                    };

                    // Array, Collection, List, DataTable and DataSet
                    shoppingCart.Add(item);

                    CartDataGridView.DataSource = null;
                    CartDataGridView.DataSource = shoppingCart;
                }

                decimal totalAmount = shoppingCart.Sum(x => x.TotalPrice);
                TotalAmountTextBox.Text = totalAmount.ToString();

                decimal totalSalesTax = (16 * totalAmount) / 100;
                SalesTaxTextBox.Text = totalSalesTax.ToString();

                decimal totalPay = totalAmount + totalSalesTax;
                TotalToPayTextBox.Text = totalPay.ToString();

                //update stock in MySQL
                int productId = Convert.ToInt16(ItemNameComboBox.SelectedValue);
                int quantity = Convert.ToInt16(QuantityTextBox.Text);
                UpdateStockLevel(productId, quantity);


                ItemNameComboBox.SelectedIndex = -1;
                QuantityTextBox.Clear();
                UnitPriceTextBox.Clear();
                CurrentStockTextBox.Clear();
            }
        }

        private void UpdateStockLevel(int productId, int quantity)
        {

            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand("UPDATE Products SET Stock = Stock - @Quantity WHERE ID=@Id", conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Id", productId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool IsValidated()
        {
            if (ClientNameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Client Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClientNameTextBox.Focus();
                return false;
            }

            if (ItemNameComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Item Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (QuantityTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Quantity is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuantityTextBox.Focus();
                return false;
            }

            else
            {
                int tempQuantity;
                bool isNumeric = int.TryParse(QuantityTextBox.Text.Trim(), out tempQuantity);

                if (!isNumeric)
                {
                    MessageBox.Show("Quantity should be integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QuantityTextBox.Clear();
                    QuantityTextBox.Focus();
                    return false;
                }
            }

            if (UnitPriceTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Unit Price is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UnitPriceTextBox.Focus();
                return false;
            }
            else
            {
                decimal n;
                bool isDecimal = decimal.TryParse(UnitPriceTextBox.Text.Trim(), out n);

                if (!isDecimal)
                {
                    MessageBox.Show("Unit Price should be decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UnitPriceTextBox.Clear();
                    UnitPriceTextBox.Focus();
                    return false;
                }
            }

            return true;
        }

        private void CartDataGridView_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        }

        private void PrintPreviewButton_Click(object sender, EventArgs e)
        {
            if (CartDataGridView.Rows.Count > 0)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Insert The Items First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void PrintOrderButton_Click(object sender, EventArgs e)
        {
            if (CartDataGridView.Rows.Count > 0)
            {
                string ItemName = string.Empty;
                foreach (DataGridViewRow Datarow in CartDataGridView.Rows)
                {
                    if (Datarow.Cells[1].Value != null && Datarow.Cells[2].Value != null)
                    {
                        ItemName = ItemName + Datarow.Cells[1].Value.ToString() + " , ";
                    }
                }
                string ItemQuantity = string.Empty;
                foreach (DataGridViewRow Datarow in CartDataGridView.Rows)
                {
                    if (Datarow.Cells[1].Value != null && Datarow.Cells[2].Value != null)
                    {
                        ItemQuantity = ItemQuantity + Datarow.Cells[2].Value.ToString() + " , ";
                    }
                }
                string OrderNameQuantityText = ItemName + " || " + ItemQuantity;

                //Inserting Client Information
                using (MySqlConnection conn = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Orders(OrderNumber, ClientName, OrderNameQuantity, Bill, Date) VALUES (@OrderNumber,@ClientName,@OrderNameQuantity,@TotalToPay,@TransactionDate)", conn))
                    {
                        conn.Open();

                        cmd.Parameters.AddWithValue("@OrderNumber", OrderNumberTextBox.Text);
                        cmd.Parameters.AddWithValue("@ClientName", ClientNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@OrderNameQuantity", OrderNameQuantityText.Trim());
                        cmd.Parameters.AddWithValue("@TotalToPay", TotalToPayTextBox.Text);
                        cmd.Parameters.AddWithValue("@TransactionDate", TransactionDateDateTimePicker.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                PrintDialog printDialog1 = new PrintDialog();
                printDialog1.Document = printDocument1;
                DialogResult result = printDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            else
            {
                MessageBox.Show("Please Insert The Items First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Resources.logo2;

            e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);

            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 170));

            e.Graphics.DrawString("Client Name: " + ClientNameTextBox.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 200));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 235));

            e.Graphics.DrawString("Item Name", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 255));
            e.Graphics.DrawString("Quantity", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(380, 255));
            e.Graphics.DrawString("Unit Price", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 255));
            e.Graphics.DrawString("Total Price", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(660, 255));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));

            int yPos = 295;

            for (int i = numberOfItemsPrintedSoFar; i < shoppingCart.Count; i++)
            {
                numberOfItemsPerPage++;

                if (numberOfItemsPerPage <= 25)
                {
                    numberOfItemsPrintedSoFar++;

                    if (numberOfItemsPrintedSoFar <= shoppingCart.Count)
                    {
                        e.Graphics.DrawString(shoppingCart[i].ItemName, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, yPos));
                        e.Graphics.DrawString(shoppingCart[i].Quantity.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, yPos));
                        e.Graphics.DrawString(shoppingCart[i].UnitPrice.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(525, yPos));
                        e.Graphics.DrawString(shoppingCart[i].TotalPrice.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(675, yPos));

                        yPos += 30;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
                else
                {
                    numberOfItemsPerPage = 0;
                    e.HasMorePages = true;
                    return;
                }
            }

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos));
            e.Graphics.DrawString("Total Amount:       Rs." + TotalAmountTextBox.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, yPos + 30));
            e.Graphics.DrawString("Sales Tax (16%):  Rs." + SalesTaxTextBox.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, yPos + 60));
            e.Graphics.DrawString("Total To Pay:        Rs." + TotalToPayTextBox.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, yPos + 90));

            // reset the variables
            numberOfItemsPerPage = 0;
            numberOfItemsPrintedSoFar = 0;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int index = CartDataGridView.CurrentCell.RowIndex;

            //update stock level
            int productId = Convert.ToInt16(CartDataGridView.Rows[index].Cells["ItemId"].Value);
            int quantity = Convert.ToInt16(CartDataGridView.Rows[index].Cells["Quantity"].Value) * -1;
            UpdateStockLevel(productId, quantity);

            shoppingCart.RemoveAt(index);

            CartDataGridView.DataSource = null;
            CartDataGridView.DataSource = shoppingCart;

            decimal totalAmount = shoppingCart.Sum(x => x.TotalPrice);
            TotalAmountTextBox.Text = totalAmount.ToString();

            decimal totalSalesTax = (16 * totalAmount) / 100;
            SalesTaxTextBox.Text = totalSalesTax.ToString();

            decimal totalPay = totalAmount + totalSalesTax;
            TotalToPayTextBox.Text = totalPay.ToString();
        }

        private void CartDataGridView_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (CartDataGridView.Rows.Count > 0)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    var hti = CartDataGridView.HitTest(e.X, e.Y);
                    CartDataGridView.Rows[hti.RowIndex].Selected = true;

                    contextMenuStrip1.Show(CartDataGridView, e.X, e.Y);
                }
            }
            else
            {
                MessageBox.Show("Please Insert The Items First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (CheckInternetConnection())
            {
                ItemNameComboBox.SelectedValueChanged -= ItemNameComboBox_SelectedValueChanged;

                ItemNameComboBox.DataSource = GetProductsName();
                ItemNameComboBox.DisplayMember = "ProductName";
                ItemNameComboBox.ValueMember = "ID";

                ItemNameComboBox.SelectedIndex = -1;

                ItemNameComboBox.SelectedValueChanged += ItemNameComboBox_SelectedValueChanged;
            }
            else
            {
                MessageBox.Show("Please Connect Your Internet First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private DataTable GetProductsName()
        {
            DataTable dtProducts = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT ID,ProductName FROM Products WHERE IsActive = 1", conn))
                {
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtProducts.Load(reader);
                }
            }

            return dtProducts;
        }

        private void ItemNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ItemNameComboBox.SelectedValue != null)
            {
                int productId = Convert.ToInt16(ItemNameComboBox.SelectedValue);

                DataTable dtProductPrice = GetProductDetails(productId);
                DataRow row = dtProductPrice.Rows[0];

                UnitPriceTextBox.Text = row["ProductPrice"].ToString();
                CurrentStockTextBox.Text = row["Stock"].ToString();
            }
        }
        private DataTable GetProductDetails(int productId)
        {
            DataTable dtProductDetails = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT ProductPrice, Stock FROM Products WHERE ID=@Id", conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@Id", productId);

                    // ExecuteReader
                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtProductDetails.Load(reader);
                }
            }

            return dtProductDetails;
        }

        private void changeQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = CartDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            using (Change_Quantity cqf = new Change_Quantity())
            {
                cqf.CurrentQuantity = Convert.ToInt16(CartDataGridView.Rows[index].Cells["Quantity"].Value);

                if (cqf.ShowDialog() == DialogResult.OK)
                {
                    CartDataGridView.Rows[index].Cells["Quantity"].Value = cqf.NewQuantity;
                    CartDataGridView.Rows[index].Cells["TotalPrice"].Value = cqf.NewQuantity * Convert.ToDecimal(CartDataGridView.Rows[index].Cells["UnitPrice"].Value);

                    UpdateStockLevel(Convert.ToInt16(CartDataGridView.Rows[index].Cells["ItemId"].Value), cqf.NewQuantity - cqf.CurrentQuantity);
                }
            }

            decimal totalAmount = shoppingCart.Sum(x => x.TotalPrice);
            TotalAmountTextBox.Text = totalAmount.ToString();

            decimal totalSalesTax = (16 * totalAmount) / 100;
            SalesTaxTextBox.Text = totalSalesTax.ToString();

            decimal totalPay = totalAmount + totalSalesTax;
            TotalToPayTextBox.Text = totalPay.ToString();
        }

        private void ItemNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelOrderButton_Click_1(object sender, EventArgs e)
        {
            NewOrderButton.Enabled = true;
            PrintOrderButton.Enabled = false;
            PrintPreviewButton.Enabled = false;
            CancelOrderButton.Enabled = false;
            ItemGroupBox.Enabled = false;

            ClientNameTextBox.Clear();
            ItemNameComboBox.SelectedIndex = -1;
            QuantityTextBox.Clear();
            UnitPriceTextBox.Clear();
            CurrentStockTextBox.Clear();
            OrderNumberTextBox.Clear();
            TotalAmountTextBox.Text = "0";
            SalesTaxTextBox.Text = "0";
            TotalToPayTextBox.Text = "0";

            // Update Stock level
            UpdateStocks();

            CartDataGridView.DataSource = null;
            shoppingCart.Clear();
        }

        private void UpdateStocks()
        {
            foreach (DataGridViewRow row in CartDataGridView.Rows)
            {
                int productId = Convert.ToInt16(row.Cells["ItemId"].Value);
                int quantity = Convert.ToInt16(row.Cells["Quantity"].Value) * -1;
                UpdateStockLevel(productId, quantity);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateStocks();
        }
    }
}
