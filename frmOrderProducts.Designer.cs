
namespace Shop_Management
{
    partial class frmOrderProducts
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
            this.dataGridViewOrderProducts = new System.Windows.Forms.DataGridView();
            this.lblOrderProducts = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtByProduct = new System.Windows.Forms.TextBox();
            this.txtByName = new System.Windows.Forms.TextBox();
            this.lblByProduct = new System.Windows.Forms.Label();
            this.lblByName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrderProducts
            // 
            this.dataGridViewOrderProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderProducts.Location = new System.Drawing.Point(38, 137);
            this.dataGridViewOrderProducts.Name = "dataGridViewOrderProducts";
            this.dataGridViewOrderProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrderProducts.Size = new System.Drawing.Size(733, 301);
            this.dataGridViewOrderProducts.TabIndex = 0;
            this.dataGridViewOrderProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrderProducts_CellClick);
            // 
            // lblOrderProducts
            // 
            this.lblOrderProducts.AutoSize = true;
            this.lblOrderProducts.BackColor = System.Drawing.Color.Maroon;
            this.lblOrderProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderProducts.ForeColor = System.Drawing.Color.White;
            this.lblOrderProducts.Location = new System.Drawing.Point(274, 9);
            this.lblOrderProducts.Name = "lblOrderProducts";
            this.lblOrderProducts.Size = new System.Drawing.Size(198, 31);
            this.lblOrderProducts.TabIndex = 1;
            this.lblOrderProducts.Text = "Order Products";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Blue;
            this.btnSearch.Location = new System.Drawing.Point(338, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 37);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtByProduct
            // 
            this.txtByProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByProduct.Location = new System.Drawing.Point(177, 102);
            this.txtByProduct.Name = "txtByProduct";
            this.txtByProduct.Size = new System.Drawing.Size(128, 23);
            this.txtByProduct.TabIndex = 10;
            // 
            // txtByName
            // 
            this.txtByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByName.Location = new System.Drawing.Point(177, 63);
            this.txtByName.Name = "txtByName";
            this.txtByName.Size = new System.Drawing.Size(128, 23);
            this.txtByName.TabIndex = 9;
            this.txtByName.Enter += new System.EventHandler(this.txtByName_Enter);
            // 
            // lblByProduct
            // 
            this.lblByProduct.AutoSize = true;
            this.lblByProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblByProduct.Location = new System.Drawing.Point(35, 105);
            this.lblByProduct.Name = "lblByProduct";
            this.lblByProduct.Size = new System.Drawing.Size(134, 17);
            this.lblByProduct.TabIndex = 8;
            this.lblByProduct.Text = "Search By Product :";
            // 
            // lblByName
            // 
            this.lblByName.AutoSize = true;
            this.lblByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblByName.Location = new System.Drawing.Point(35, 66);
            this.lblByName.Name = "lblByName";
            this.lblByName.Size = new System.Drawing.Size(122, 17);
            this.lblByName.TabIndex = 7;
            this.lblByName.Text = "Search By Name :";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Blue;
            this.btnDelete.Location = new System.Drawing.Point(441, 75);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 37);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmOrderProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtByProduct);
            this.Controls.Add(this.txtByName);
            this.Controls.Add(this.lblByProduct);
            this.Controls.Add(this.lblByName);
            this.Controls.Add(this.lblOrderProducts);
            this.Controls.Add(this.dataGridViewOrderProducts);
            this.Name = "frmOrderProducts";
            this.Text = "frmOrderProducts";
            this.Load += new System.EventHandler(this.frmOrderProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrderProducts;
        private System.Windows.Forms.Label lblOrderProducts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtByProduct;
        private System.Windows.Forms.TextBox txtByName;
        private System.Windows.Forms.Label lblByProduct;
        private System.Windows.Forms.Label lblByName;
        private System.Windows.Forms.Button btnDelete;
    }
}