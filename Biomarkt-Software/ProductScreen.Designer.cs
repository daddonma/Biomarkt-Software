﻿
namespace Biomarkt_Software
{
    partial class ProductScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxProductCategory = new System.Windows.Forms.ComboBox();
            this.btnProductSave = new System.Windows.Forms.Button();
            this.btnProductEdit = new System.Windows.Forms.Button();
            this.btnProductClear = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.productsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductName.ForeColor = System.Drawing.Color.White;
            this.textBoxProductName.Location = new System.Drawing.Point(149, 22);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(200, 20);
            this.textBoxProductName.TabIndex = 1;
            // 
            // textBoxProductBrand
            // 
            this.textBoxProductBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxProductBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProductBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductBrand.ForeColor = System.Drawing.Color.White;
            this.textBoxProductBrand.Location = new System.Drawing.Point(149, 48);
            this.textBoxProductBrand.Name = "textBoxProductBrand";
            this.textBoxProductBrand.Size = new System.Drawing.Size(200, 20);
            this.textBoxProductBrand.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategorie";
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductPrice.ForeColor = System.Drawing.Color.White;
            this.textBoxProductPrice.Location = new System.Drawing.Point(149, 101);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(200, 20);
            this.textBoxProductPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preis";
            // 
            // comboBoxProductCategory
            // 
            this.comboBoxProductCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxProductCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProductCategory.ForeColor = System.Drawing.Color.White;
            this.comboBoxProductCategory.FormattingEnabled = true;
            this.comboBoxProductCategory.Items.AddRange(new object[] {
            "Obst ",
            "Gemüse",
            "Fleisch",
            "Fisch",
            "Drogerie",
            "Getränke"});
            this.comboBoxProductCategory.Location = new System.Drawing.Point(149, 74);
            this.comboBoxProductCategory.Name = "comboBoxProductCategory";
            this.comboBoxProductCategory.Size = new System.Drawing.Size(200, 21);
            this.comboBoxProductCategory.TabIndex = 8;
            // 
            // btnProductSave
            // 
            this.btnProductSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProductSave.ForeColor = System.Drawing.Color.White;
            this.btnProductSave.Location = new System.Drawing.Point(146, 137);
            this.btnProductSave.Name = "btnProductSave";
            this.btnProductSave.Size = new System.Drawing.Size(75, 23);
            this.btnProductSave.TabIndex = 9;
            this.btnProductSave.Text = "Speichern";
            this.btnProductSave.UseVisualStyleBackColor = false;
            this.btnProductSave.Click += new System.EventHandler(this.btnProductSave_Click);
            // 
            // btnProductEdit
            // 
            this.btnProductEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProductEdit.ForeColor = System.Drawing.Color.White;
            this.btnProductEdit.Location = new System.Drawing.Point(227, 137);
            this.btnProductEdit.Name = "btnProductEdit";
            this.btnProductEdit.Size = new System.Drawing.Size(75, 23);
            this.btnProductEdit.TabIndex = 10;
            this.btnProductEdit.Text = "Bearbeiten";
            this.btnProductEdit.UseVisualStyleBackColor = false;
            this.btnProductEdit.Click += new System.EventHandler(this.btnProductEdit_Click);
            // 
            // btnProductClear
            // 
            this.btnProductClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProductClear.ForeColor = System.Drawing.Color.White;
            this.btnProductClear.Location = new System.Drawing.Point(308, 137);
            this.btnProductClear.Name = "btnProductClear";
            this.btnProductClear.Size = new System.Drawing.Size(75, 23);
            this.btnProductClear.TabIndex = 11;
            this.btnProductClear.Text = "leeren";
            this.btnProductClear.UseVisualStyleBackColor = false;
            this.btnProductClear.Click += new System.EventHandler(this.btnProductClear_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProductDelete.ForeColor = System.Drawing.Color.White;
            this.btnProductDelete.Location = new System.Drawing.Point(389, 137);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(75, 23);
            this.btnProductDelete.TabIndex = 12;
            this.btnProductDelete.Text = "Löschen";
            this.btnProductDelete.UseVisualStyleBackColor = false;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // productsDGV
            // 
            this.productsDGV.AllowUserToAddRows = false;
            this.productsDGV.AllowUserToDeleteRows = false;
            this.productsDGV.AllowUserToResizeColumns = false;
            this.productsDGV.AllowUserToResizeRows = false;
            this.productsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.productsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDGV.Location = new System.Drawing.Point(12, 195);
            this.productsDGV.Name = "productsDGV";
            this.productsDGV.RowHeadersVisible = false;
            this.productsDGV.RowHeadersWidth = 82;
            this.productsDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.productsDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.productsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.productsDGV.Size = new System.Drawing.Size(775, 254);
            this.productsDGV.TabIndex = 13;
            // 
            // ProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.productsDGV);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.btnProductClear);
            this.Controls.Add(this.btnProductEdit);
            this.Controls.Add(this.btnProductSave);
            this.Controls.Add(this.comboBoxProductCategory);
            this.Controls.Add(this.textBoxProductPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxProductBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ProductScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductScreen";
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxProductCategory;
        private System.Windows.Forms.Button btnProductSave;
        private System.Windows.Forms.Button btnProductEdit;
        private System.Windows.Forms.Button btnProductClear;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.DataGridView productsDGV;
    }
}