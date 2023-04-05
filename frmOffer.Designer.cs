
namespace Shop_Management
{
    partial class frmOffer
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
            this.lblOffer = new System.Windows.Forms.Label();
            this.grpbxOfferInfo = new System.Windows.Forms.GroupBox();
            this.btnNewPrice = new System.Windows.Forms.Button();
            this.lblRs1 = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblRs = new System.Windows.Forms.Label();
            this.lblMRP = new System.Windows.Forms.Label();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnUpdatedPrice = new System.Windows.Forms.Button();
            this.lblOriginalPrice = new System.Windows.Forms.Label();
            this.lblDiscountPer = new System.Windows.Forms.Label();
            this.lblNewPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProName = new System.Windows.Forms.Label();
            this.grpbxOfferInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOffer
            // 
            this.lblOffer.AutoSize = true;
            this.lblOffer.BackColor = System.Drawing.Color.Maroon;
            this.lblOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffer.ForeColor = System.Drawing.Color.White;
            this.lblOffer.Location = new System.Drawing.Point(340, 18);
            this.lblOffer.Name = "lblOffer";
            this.lblOffer.Size = new System.Drawing.Size(145, 31);
            this.lblOffer.TabIndex = 0;
            this.lblOffer.Text = "Offer Form";
            // 
            // grpbxOfferInfo
            // 
            this.grpbxOfferInfo.Controls.Add(this.btnNewPrice);
            this.grpbxOfferInfo.Controls.Add(this.lblRs1);
            this.grpbxOfferInfo.Controls.Add(this.lblP);
            this.grpbxOfferInfo.Controls.Add(this.lblRs);
            this.grpbxOfferInfo.Controls.Add(this.lblMRP);
            this.grpbxOfferInfo.Controls.Add(this.txtNewPrice);
            this.grpbxOfferInfo.Controls.Add(this.txtDiscount);
            this.grpbxOfferInfo.Controls.Add(this.btnUpdatedPrice);
            this.grpbxOfferInfo.Controls.Add(this.lblOriginalPrice);
            this.grpbxOfferInfo.Controls.Add(this.lblDiscountPer);
            this.grpbxOfferInfo.Controls.Add(this.lblNewPrice);
            this.grpbxOfferInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxOfferInfo.Location = new System.Drawing.Point(159, 113);
            this.grpbxOfferInfo.Name = "grpbxOfferInfo";
            this.grpbxOfferInfo.Size = new System.Drawing.Size(505, 325);
            this.grpbxOfferInfo.TabIndex = 1;
            this.grpbxOfferInfo.TabStop = false;
            this.grpbxOfferInfo.Text = "Offer Information";
            // 
            // btnNewPrice
            // 
            this.btnNewPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPrice.ForeColor = System.Drawing.Color.Blue;
            this.btnNewPrice.Location = new System.Drawing.Point(293, 273);
            this.btnNewPrice.Name = "btnNewPrice";
            this.btnNewPrice.Size = new System.Drawing.Size(173, 38);
            this.btnNewPrice.TabIndex = 13;
            this.btnNewPrice.Text = "New Price";
            this.btnNewPrice.UseVisualStyleBackColor = true;
            this.btnNewPrice.Click += new System.EventHandler(this.btnNewPrice_Click);
            // 
            // lblRs1
            // 
            this.lblRs1.AutoSize = true;
            this.lblRs1.Location = new System.Drawing.Point(412, 196);
            this.lblRs1.Name = "lblRs1";
            this.lblRs1.Size = new System.Drawing.Size(40, 25);
            this.lblRs1.TabIndex = 12;
            this.lblRs1.Text = "Rs.";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(412, 132);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(30, 25);
            this.lblP.TabIndex = 11;
            this.lblP.Text = "%";
            // 
            // lblRs
            // 
            this.lblRs.AutoSize = true;
            this.lblRs.Location = new System.Drawing.Point(412, 73);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(40, 25);
            this.lblRs.TabIndex = 10;
            this.lblRs.Text = "Rs.";
            // 
            // lblMRP
            // 
            this.lblMRP.AutoSize = true;
            this.lblMRP.Location = new System.Drawing.Point(301, 73);
            this.lblMRP.Name = "lblMRP";
            this.lblMRP.Size = new System.Drawing.Size(55, 25);
            this.lblMRP.TabIndex = 9;
            this.lblMRP.Text = "MRP";
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Location = new System.Drawing.Point(306, 191);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(100, 30);
            this.txtNewPrice.TabIndex = 8;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(306, 129);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 30);
            this.txtDiscount.TabIndex = 7;
            // 
            // btnUpdatedPrice
            // 
            this.btnUpdatedPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatedPrice.ForeColor = System.Drawing.Color.Blue;
            this.btnUpdatedPrice.Location = new System.Drawing.Point(42, 273);
            this.btnUpdatedPrice.Name = "btnUpdatedPrice";
            this.btnUpdatedPrice.Size = new System.Drawing.Size(173, 38);
            this.btnUpdatedPrice.TabIndex = 5;
            this.btnUpdatedPrice.Text = "Updated Price";
            this.btnUpdatedPrice.UseVisualStyleBackColor = true;
            this.btnUpdatedPrice.Click += new System.EventHandler(this.btnUpdatedPrice_Click);
            // 
            // lblOriginalPrice
            // 
            this.lblOriginalPrice.AutoSize = true;
            this.lblOriginalPrice.Location = new System.Drawing.Point(66, 73);
            this.lblOriginalPrice.Name = "lblOriginalPrice";
            this.lblOriginalPrice.Size = new System.Drawing.Size(128, 25);
            this.lblOriginalPrice.TabIndex = 2;
            this.lblOriginalPrice.Text = "Original Price";
            // 
            // lblDiscountPer
            // 
            this.lblDiscountPer.AutoSize = true;
            this.lblDiscountPer.Location = new System.Drawing.Point(66, 132);
            this.lblDiscountPer.Name = "lblDiscountPer";
            this.lblDiscountPer.Size = new System.Drawing.Size(213, 25);
            this.lblDiscountPer.TabIndex = 3;
            this.lblDiscountPer.Text = "Discount in Percentage";
            // 
            // lblNewPrice
            // 
            this.lblNewPrice.AutoSize = true;
            this.lblNewPrice.Location = new System.Drawing.Point(66, 194);
            this.lblNewPrice.Name = "lblNewPrice";
            this.lblNewPrice.Size = new System.Drawing.Size(100, 25);
            this.lblNewPrice.TabIndex = 4;
            this.lblNewPrice.Text = "New Price";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(289, 72);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // lblProName
            // 
            this.lblProName.AutoSize = true;
            this.lblProName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProName.Location = new System.Drawing.Point(528, 72);
            this.lblProName.Name = "lblProName";
            this.lblProName.Size = new System.Drawing.Size(136, 25);
            this.lblProName.TabIndex = 15;
            this.lblProName.Text = "Product Name";
            // 
            // frmOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.grpbxOfferInfo);
            this.Controls.Add(this.lblOffer);
            this.Name = "frmOffer";
            this.Text = "frmOffer";
            this.grpbxOfferInfo.ResumeLayout(false);
            this.grpbxOfferInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOffer;
        private System.Windows.Forms.GroupBox grpbxOfferInfo;
        private System.Windows.Forms.Button btnNewPrice;
        private System.Windows.Forms.Label lblRs1;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblRs;
        private System.Windows.Forms.Label lblMRP;
        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnUpdatedPrice;
        private System.Windows.Forms.Label lblOriginalPrice;
        private System.Windows.Forms.Label lblDiscountPer;
        private System.Windows.Forms.Label lblNewPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProName;
    }
}