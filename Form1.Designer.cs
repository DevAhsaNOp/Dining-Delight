
namespace Dining_Delight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.TotalToPayTextBox = new System.Windows.Forms.TextBox();
            this.TotalToPayLabel = new System.Windows.Forms.Label();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.TotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.CartDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.UnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.ItemGroupBox = new System.Windows.Forms.GroupBox();
            this.TransactionDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CurrentStockTextBox = new System.Windows.Forms.TextBox();
            this.OrderNumberTextBox = new System.Windows.Forms.TextBox();
            this.TransactionDateLabel = new System.Windows.Forms.Label();
            this.CurrentStockLabel = new System.Windows.Forms.Label();
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.CancelOrderButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PrintPreviewButton = new System.Windows.Forms.Button();
            this.PrintOrderButton = new System.Windows.Forms.Button();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).BeginInit();
            this.ItemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeQuantityToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 54);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // changeQuantityToolStripMenuItem
            // 
            this.changeQuantityToolStripMenuItem.Name = "changeQuantityToolStripMenuItem";
            this.changeQuantityToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changeQuantityToolStripMenuItem.Text = "&Change Quantity";
            this.changeQuantityToolStripMenuItem.Click += new System.EventHandler(this.changeQuantityToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // TotalToPayTextBox
            // 
            this.TotalToPayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalToPayTextBox.Location = new System.Drawing.Point(848, 477);
            this.TotalToPayTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalToPayTextBox.Name = "TotalToPayTextBox";
            this.TotalToPayTextBox.ReadOnly = true;
            this.TotalToPayTextBox.Size = new System.Drawing.Size(126, 20);
            this.TotalToPayTextBox.TabIndex = 24;
            this.TotalToPayTextBox.Text = "0";
            this.TotalToPayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalToPayLabel
            // 
            this.TotalToPayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalToPayLabel.AutoSize = true;
            this.TotalToPayLabel.Location = new System.Drawing.Point(706, 480);
            this.TotalToPayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalToPayLabel.Name = "TotalToPayLabel";
            this.TotalToPayLabel.Size = new System.Drawing.Size(93, 13);
            this.TotalToPayLabel.TabIndex = 12;
            this.TotalToPayLabel.Text = "Total To Pay (Rs):";
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesTaxTextBox.Location = new System.Drawing.Point(848, 446);
            this.SalesTaxTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(126, 20);
            this.SalesTaxTextBox.TabIndex = 23;
            this.SalesTaxTextBox.Text = "0";
            this.SalesTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(706, 449);
            this.SalesTaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(108, 13);
            this.SalesTaxLabel.TabIndex = 13;
            this.SalesTaxLabel.Text = "Sales Tax (16%) (Rs):";
            // 
            // TotalAmountTextBox
            // 
            this.TotalAmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalAmountTextBox.Location = new System.Drawing.Point(848, 415);
            this.TotalAmountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalAmountTextBox.Name = "TotalAmountTextBox";
            this.TotalAmountTextBox.ReadOnly = true;
            this.TotalAmountTextBox.Size = new System.Drawing.Size(126, 20);
            this.TotalAmountTextBox.TabIndex = 22;
            this.TotalAmountTextBox.Text = "0";
            this.TotalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Location = new System.Drawing.Point(706, 418);
            this.TotalAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(95, 13);
            this.TotalAmountLabel.TabIndex = 14;
            this.TotalAmountLabel.Text = "Total Amount (Rs):";
            // 
            // CartDataGridView
            // 
            this.CartDataGridView.AllowUserToAddRows = false;
            this.CartDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CartDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.CartDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartDataGridView.Location = new System.Drawing.Point(35, 225);
            this.CartDataGridView.MultiSelect = false;
            this.CartDataGridView.Name = "CartDataGridView";
            this.CartDataGridView.ReadOnly = true;
            this.CartDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartDataGridView.Size = new System.Drawing.Size(939, 173);
            this.CartDataGridView.TabIndex = 17;
            this.CartDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CartDataGridView_MouseDown_1);
            // 
            // ItemNameComboBox
            // 
            this.ItemNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemNameComboBox.FormattingEnabled = true;
            this.ItemNameComboBox.Location = new System.Drawing.Point(32, 109);
            this.ItemNameComboBox.Name = "ItemNameComboBox";
            this.ItemNameComboBox.Size = new System.Drawing.Size(232, 21);
            this.ItemNameComboBox.TabIndex = 1;
            this.ItemNameComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemNameComboBox_SelectedIndexChanged);
            this.ItemNameComboBox.SelectedValueChanged += new System.EventHandler(this.ItemNameComboBox_SelectedValueChanged);
            // 
            // UnitPriceTextBox
            // 
            this.UnitPriceTextBox.Location = new System.Drawing.Point(537, 109);
            this.UnitPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UnitPriceTextBox.Name = "UnitPriceTextBox";
            this.UnitPriceTextBox.ReadOnly = true;
            this.UnitPriceTextBox.Size = new System.Drawing.Size(93, 20);
            this.UnitPriceTextBox.TabIndex = 3;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(294, 109);
            this.QuantityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(93, 20);
            this.QuantityTextBox.TabIndex = 2;
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(128, 50);
            this.ClientNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(432, 20);
            this.ClientNameTextBox.TabIndex = 0;
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.Location = new System.Drawing.Point(553, 86);
            this.UnitPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(56, 13);
            this.UnitPriceLabel.TabIndex = 0;
            this.UnitPriceLabel.Text = "Unit Price:";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(311, 86);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(49, 13);
            this.QuantityLabel.TabIndex = 0;
            this.QuantityLabel.Text = "Quantity:";
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(29, 86);
            this.ItemNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(61, 13);
            this.ItemNameLabel.TabIndex = 0;
            this.ItemNameLabel.Text = "Item Name:";
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Location = new System.Drawing.Point(29, 53);
            this.ClientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(67, 13);
            this.ClientNameLabel.TabIndex = 0;
            this.ClientNameLabel.Text = "Client Name:";
            // 
            // ItemGroupBox
            // 
            this.ItemGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemGroupBox.Controls.Add(this.TransactionDateDateTimePicker);
            this.ItemGroupBox.Controls.Add(this.CurrentStockTextBox);
            this.ItemGroupBox.Controls.Add(this.OrderNumberTextBox);
            this.ItemGroupBox.Controls.Add(this.TransactionDateLabel);
            this.ItemGroupBox.Controls.Add(this.CurrentStockLabel);
            this.ItemGroupBox.Controls.Add(this.OrderNumberLabel);
            this.ItemGroupBox.Controls.Add(this.AddToCartButton);
            this.ItemGroupBox.Controls.Add(this.ItemNameComboBox);
            this.ItemGroupBox.Controls.Add(this.UnitPriceTextBox);
            this.ItemGroupBox.Controls.Add(this.QuantityTextBox);
            this.ItemGroupBox.Controls.Add(this.ClientNameTextBox);
            this.ItemGroupBox.Controls.Add(this.UnitPriceLabel);
            this.ItemGroupBox.Controls.Add(this.QuantityLabel);
            this.ItemGroupBox.Controls.Add(this.ItemNameLabel);
            this.ItemGroupBox.Controls.Add(this.ClientNameLabel);
            this.ItemGroupBox.Enabled = false;
            this.ItemGroupBox.Location = new System.Drawing.Point(35, 62);
            this.ItemGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemGroupBox.Name = "ItemGroupBox";
            this.ItemGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ItemGroupBox.Size = new System.Drawing.Size(766, 143);
            this.ItemGroupBox.TabIndex = 16;
            this.ItemGroupBox.TabStop = false;
            // 
            // TransactionDateDateTimePicker
            // 
            this.TransactionDateDateTimePicker.Location = new System.Drawing.Point(475, 12);
            this.TransactionDateDateTimePicker.Name = "TransactionDateDateTimePicker";
            this.TransactionDateDateTimePicker.Size = new System.Drawing.Size(155, 20);
            this.TransactionDateDateTimePicker.TabIndex = 28;
            // 
            // CurrentStockTextBox
            // 
            this.CurrentStockTextBox.Location = new System.Drawing.Point(412, 109);
            this.CurrentStockTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CurrentStockTextBox.Name = "CurrentStockTextBox";
            this.CurrentStockTextBox.ReadOnly = true;
            this.CurrentStockTextBox.Size = new System.Drawing.Size(93, 20);
            this.CurrentStockTextBox.TabIndex = 6;
            // 
            // OrderNumberTextBox
            // 
            this.OrderNumberTextBox.Location = new System.Drawing.Point(128, 12);
            this.OrderNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.OrderNumberTextBox.Name = "OrderNumberTextBox";
            this.OrderNumberTextBox.ReadOnly = true;
            this.OrderNumberTextBox.Size = new System.Drawing.Size(162, 20);
            this.OrderNumberTextBox.TabIndex = 27;
            // 
            // TransactionDateLabel
            // 
            this.TransactionDateLabel.AutoSize = true;
            this.TransactionDateLabel.Location = new System.Drawing.Point(347, 15);
            this.TransactionDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TransactionDateLabel.Name = "TransactionDateLabel";
            this.TransactionDateLabel.Size = new System.Drawing.Size(92, 13);
            this.TransactionDateLabel.TabIndex = 25;
            this.TransactionDateLabel.Text = "Transaction Date:";
            // 
            // CurrentStockLabel
            // 
            this.CurrentStockLabel.AutoSize = true;
            this.CurrentStockLabel.Location = new System.Drawing.Point(418, 86);
            this.CurrentStockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentStockLabel.Name = "CurrentStockLabel";
            this.CurrentStockLabel.Size = new System.Drawing.Size(75, 13);
            this.CurrentStockLabel.TabIndex = 5;
            this.CurrentStockLabel.Text = "Current Stock:";
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.Location = new System.Drawing.Point(29, 15);
            this.OrderNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(76, 13);
            this.OrderNumberLabel.TabIndex = 26;
            this.OrderNumberLabel.Text = "Order Number:";
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Image = ((System.Drawing.Image)(resources.GetObject("AddToCartButton.Image")));
            this.AddToCartButton.Location = new System.Drawing.Point(653, 38);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(106, 96);
            this.AddToCartButton.TabIndex = 4;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddToCartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // CancelOrderButton
            // 
            this.CancelOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelOrderButton.Enabled = false;
            this.CancelOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelOrderButton.Image")));
            this.CancelOrderButton.Location = new System.Drawing.Point(35, 412);
            this.CancelOrderButton.Name = "CancelOrderButton";
            this.CancelOrderButton.Size = new System.Drawing.Size(151, 38);
            this.CancelOrderButton.TabIndex = 21;
            this.CancelOrderButton.Text = "Cancel Order";
            this.CancelOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelOrderButton.UseVisualStyleBackColor = true;
            this.CancelOrderButton.Click += new System.EventHandler(this.CancelOrderButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::Dining_Delight.Properties.Resources.Form_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(291, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // PrintPreviewButton
            // 
            this.PrintPreviewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintPreviewButton.Enabled = false;
            this.PrintPreviewButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintPreviewButton.Image")));
            this.PrintPreviewButton.Location = new System.Drawing.Point(824, 166);
            this.PrintPreviewButton.Name = "PrintPreviewButton";
            this.PrintPreviewButton.Size = new System.Drawing.Size(151, 38);
            this.PrintPreviewButton.TabIndex = 20;
            this.PrintPreviewButton.Text = "Print Preview";
            this.PrintPreviewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintPreviewButton.UseVisualStyleBackColor = true;
            this.PrintPreviewButton.Click += new System.EventHandler(this.PrintPreviewButton_Click);
            // 
            // PrintOrderButton
            // 
            this.PrintOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintOrderButton.Enabled = false;
            this.PrintOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintOrderButton.Image")));
            this.PrintOrderButton.Location = new System.Drawing.Point(824, 118);
            this.PrintOrderButton.Name = "PrintOrderButton";
            this.PrintOrderButton.Size = new System.Drawing.Size(151, 38);
            this.PrintOrderButton.TabIndex = 19;
            this.PrintOrderButton.Text = "Print Order";
            this.PrintOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintOrderButton.UseVisualStyleBackColor = true;
            this.PrintOrderButton.Click += new System.EventHandler(this.PrintOrderButton_Click);
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("NewOrderButton.Image")));
            this.NewOrderButton.Location = new System.Drawing.Point(824, 70);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(151, 38);
            this.NewOrderButton.TabIndex = 18;
            this.NewOrderButton.Text = "New Order";
            this.NewOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewOrderButton.UseVisualStyleBackColor = true;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 528);
            this.Controls.Add(this.TotalToPayTextBox);
            this.Controls.Add(this.TotalToPayLabel);
            this.Controls.Add(this.SalesTaxTextBox);
            this.Controls.Add(this.SalesTaxLabel);
            this.Controls.Add(this.TotalAmountTextBox);
            this.Controls.Add(this.TotalAmountLabel);
            this.Controls.Add(this.CancelOrderButton);
            this.Controls.Add(this.CartDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PrintPreviewButton);
            this.Controls.Add(this.PrintOrderButton);
            this.Controls.Add(this.NewOrderButton);
            this.Controls.Add(this.ItemGroupBox);
            this.Name = "Form1";
            this.Text = "Dining Delight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).EndInit();
            this.ItemGroupBox.ResumeLayout(false);
            this.ItemGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TotalToPayTextBox;
        private System.Windows.Forms.Label TotalToPayLabel;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.TextBox TotalAmountTextBox;
        private System.Windows.Forms.Label TotalAmountLabel;
        private System.Windows.Forms.Button CancelOrderButton;
        private System.Windows.Forms.DataGridView CartDataGridView;
        private System.Windows.Forms.Button PrintPreviewButton;
        private System.Windows.Forms.Button PrintOrderButton;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.ComboBox ItemNameComboBox;
        private System.Windows.Forms.TextBox UnitPriceTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.Label UnitPriceLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.GroupBox ItemGroupBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem changeQuantityToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.TextBox CurrentStockTextBox;
        private System.Windows.Forms.Label CurrentStockLabel;
        private System.Windows.Forms.DateTimePicker TransactionDateDateTimePicker;
        private System.Windows.Forms.TextBox OrderNumberTextBox;
        private System.Windows.Forms.Label TransactionDateLabel;
        private System.Windows.Forms.Label OrderNumberLabel;
    }
}

