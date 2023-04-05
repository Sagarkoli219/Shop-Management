
namespace Shop_Management
{
    partial class frmUnOrderProduct
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
            this.dataGridViewUnOrder = new System.Windows.Forms.DataGridView();
            this.lblUnOrder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUnOrder
            // 
            this.dataGridViewUnOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnOrder.Location = new System.Drawing.Point(28, 84);
            this.dataGridViewUnOrder.Name = "dataGridViewUnOrder";
            this.dataGridViewUnOrder.Size = new System.Drawing.Size(749, 354);
            this.dataGridViewUnOrder.TabIndex = 0;
            // 
            // lblUnOrder
            // 
            this.lblUnOrder.AutoSize = true;
            this.lblUnOrder.BackColor = System.Drawing.Color.Maroon;
            this.lblUnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnOrder.ForeColor = System.Drawing.Color.White;
            this.lblUnOrder.Location = new System.Drawing.Point(291, 29);
            this.lblUnOrder.Name = "lblUnOrder";
            this.lblUnOrder.Size = new System.Drawing.Size(233, 31);
            this.lblUnOrder.TabIndex = 1;
            this.lblUnOrder.Text = "UnOrder Products";
            // 
            // frmUnOrderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUnOrder);
            this.Controls.Add(this.dataGridViewUnOrder);
            this.Name = "frmUnOrderProduct";
            this.Text = "frmUnOrderProduct";
            this.Load += new System.EventHandler(this.frmUnOrderProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUnOrder;
        private System.Windows.Forms.Label lblUnOrder;
    }
}