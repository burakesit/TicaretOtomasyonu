
namespace TicaretOtomasyonOrnegi
{
    partial class frmCategories
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblParentId = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtParentId = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkIsSale = new System.Windows.Forms.CheckBox();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblParent = new System.Windows.Forms.Label();
            this.txtParent = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbCategories = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(51, 101);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(51, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "İsim";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(225, 335);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(274, 40);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Kategori Oluştur";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblParentId
            // 
            this.lblParentId.AutoSize = true;
            this.lblParentId.Location = new System.Drawing.Point(51, 137);
            this.lblParentId.Name = "lblParentId";
            this.lblParentId.Size = new System.Drawing.Size(54, 15);
            this.lblParentId.TabIndex = 6;
            this.lblParentId.Text = "Parent Id";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(51, 185);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(56, 15);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Açıklama";
            // 
            // txtParentId
            // 
            this.txtParentId.Location = new System.Drawing.Point(51, 159);
            this.txtParentId.Name = "txtParentId";
            this.txtParentId.Size = new System.Drawing.Size(100, 23);
            this.txtParentId.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(51, 218);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 68);
            this.txtDescription.TabIndex = 9;
            // 
            // chkIsSale
            // 
            this.chkIsSale.AutoSize = true;
            this.chkIsSale.Location = new System.Drawing.Point(51, 307);
            this.chkIsSale.Name = "chkIsSale";
            this.chkIsSale.Size = new System.Drawing.Size(60, 19);
            this.chkIsSale.TabIndex = 10;
            this.chkIsSale.Text = "Satışta";
            this.chkIsSale.UseVisualStyleBackColor = true;
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(51, 359);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(100, 23);
            this.txtTaxRate.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Vergi Oranı";
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.Location = new System.Drawing.Point(51, 21);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(41, 15);
            this.lblParent.TabIndex = 14;
            this.lblParent.Text = "Parent";
            // 
            // txtParent
            // 
            this.txtParent.Location = new System.Drawing.Point(51, 39);
            this.txtParent.Name = "txtParent";
            this.txtParent.Size = new System.Drawing.Size(100, 23);
            this.txtParent.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Alt Kategori Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbCategories
            // 
            this.lbCategories.FormattingEnabled = true;
            this.lbCategories.ItemHeight = 15;
            this.lbCategories.Location = new System.Drawing.Point(225, 21);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(274, 304);
            this.lbCategories.TabIndex = 16;
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 431);
            this.Controls.Add(this.lbCategories);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblParent);
            this.Controls.Add(this.txtParent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.chkIsSale);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtParentId);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblParentId);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.MinimumSize = new System.Drawing.Size(549, 470);
            this.Name = "frmCategories";
            this.Text = "frmCategories";
            this.Load += new System.EventHandler(this.frmCategories_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblParentId;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtParentId;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckBox chkIsSale;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.TextBox txtParent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbCategories;
    }
}