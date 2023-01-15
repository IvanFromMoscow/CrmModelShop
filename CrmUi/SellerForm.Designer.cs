namespace CrmUi
{
    partial class SellerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSellerName = new System.Windows.Forms.TextBox();
            this.btnSellerEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя:";
            // 
            // txtSellerName
            // 
            this.txtSellerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSellerName.Location = new System.Drawing.Point(105, 12);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.Size = new System.Drawing.Size(212, 23);
            this.txtSellerName.TabIndex = 1;
            // 
            // btnSellerEdit
            // 
            this.btnSellerEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSellerEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSellerEdit.Location = new System.Drawing.Point(143, 74);
            this.btnSellerEdit.Name = "btnSellerEdit";
            this.btnSellerEdit.Size = new System.Drawing.Size(174, 41);
            this.btnSellerEdit.TabIndex = 2;
            this.btnSellerEdit.Text = "Добавить или изменить продавца";
            this.btnSellerEdit.UseVisualStyleBackColor = true;
            this.btnSellerEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellerForm
            // 
            this.AcceptButton = this.btnSellerEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 127);
            this.Controls.Add(this.btnSellerEdit);
            this.Controls.Add(this.txtSellerName);
            this.Controls.Add(this.label1);
            this.Name = "SellerForm";
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSellerName;
        private System.Windows.Forms.Button btnSellerEdit;
    }
}