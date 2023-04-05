
namespace Shop_Management
{
    partial class frmAllProducts
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
            this.lblOPDetails = new System.Windows.Forms.Label();
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOPDetails
            // 
            this.lblOPDetails.AutoSize = true;
            this.lblOPDetails.BackColor = System.Drawing.Color.Maroon;
            this.lblOPDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPDetails.ForeColor = System.Drawing.Color.White;
            this.lblOPDetails.Location = new System.Drawing.Point(236, 9);
            this.lblOPDetails.Name = "lblOPDetails";
            this.lblOPDetails.Size = new System.Drawing.Size(327, 31);
            this.lblOPDetails.TabIndex = 0;
            this.lblOPDetails.Text = "Order Product Information";
            // 
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(40, 57);
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(720, 359);
            this.dataGridViewOrderDetails.TabIndex = 1;
            // 
            // frmAllProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewOrderDetails);
            this.Controls.Add(this.lblOPDetails);
            this.ForeColor = System.Drawing.Color.Olive;
            this.Name = "frmAllProducts";
            this.Text = "frmAllProducts";
            this.Load += new System.EventHandler(this.frmAllProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOPDetails;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
    }
}