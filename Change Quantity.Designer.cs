
namespace Dining_Delight
{
    partial class Change_Quantity
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.NewQuantityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UpdateButton.Location = new System.Drawing.Point(148, 86);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTextBox.Location = new System.Drawing.Point(174, 35);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(100, 23);
            this.QuantityTextBox.TabIndex = 4;
            // 
            // NewQuantityLabel
            // 
            this.NewQuantityLabel.AutoSize = true;
            this.NewQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewQuantityLabel.Location = new System.Drawing.Point(73, 38);
            this.NewQuantityLabel.Name = "NewQuantityLabel";
            this.NewQuantityLabel.Size = new System.Drawing.Size(96, 17);
            this.NewQuantityLabel.TabIndex = 3;
            this.NewQuantityLabel.Text = "New Quantity:";
            // 
            // Change_Quantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 144);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.NewQuantityLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Change_Quantity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Quantity";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Change_Quantity_FormClosing);
            this.Load += new System.EventHandler(this.Change_Quantity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label NewQuantityLabel;
    }
}