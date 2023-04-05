
namespace Shop_Management
{
    partial class frmNotOrderCust
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
            this.lblNotOrderCust = new System.Windows.Forms.Label();
            this.dataGridViewNotOrderCust = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotOrderCust)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNotOrderCust
            // 
            this.lblNotOrderCust.AutoSize = true;
            this.lblNotOrderCust.BackColor = System.Drawing.Color.Maroon;
            this.lblNotOrderCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotOrderCust.ForeColor = System.Drawing.Color.White;
            this.lblNotOrderCust.Location = new System.Drawing.Point(256, 46);
            this.lblNotOrderCust.Name = "lblNotOrderCust";
            this.lblNotOrderCust.Size = new System.Drawing.Size(302, 31);
            this.lblNotOrderCust.TabIndex = 0;
            this.lblNotOrderCust.Text = "Not Ordered Customers";
            // 
            // dataGridViewNotOrderCust
            // 
            this.dataGridViewNotOrderCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotOrderCust.Location = new System.Drawing.Point(43, 102);
            this.dataGridViewNotOrderCust.Name = "dataGridViewNotOrderCust";
            this.dataGridViewNotOrderCust.Size = new System.Drawing.Size(725, 336);
            this.dataGridViewNotOrderCust.TabIndex = 1;
            // 
            // frmNotOrderCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewNotOrderCust);
            this.Controls.Add(this.lblNotOrderCust);
            this.Name = "frmNotOrderCust";
            this.Text = "frmNotOrderCust";
            this.Load += new System.EventHandler(this.frmNotOrderCust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotOrderCust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotOrderCust;
        private System.Windows.Forms.DataGridView dataGridViewNotOrderCust;
    }
}