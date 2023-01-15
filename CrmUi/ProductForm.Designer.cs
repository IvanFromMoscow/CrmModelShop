namespace CrmUi
{
    partial class ProductForm
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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnProductEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQuantityProduct = new System.Windows.Forms.NumericUpDown();
            this.nudPriceProduct = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите наименование:";
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductName.Location = new System.Drawing.Point(154, 12);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(212, 23);
            this.txtProductName.TabIndex = 1;
            // 
            // btnProductEdit
            // 
            this.btnProductEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnProductEdit.Location = new System.Drawing.Point(192, 194);
            this.btnProductEdit.Name = "btnProductEdit";
            this.btnProductEdit.Size = new System.Drawing.Size(174, 45);
            this.btnProductEdit.TabIndex = 4;
            this.btnProductEdit.Text = "Добавить или изменить продукт";
            this.btnProductEdit.UseVisualStyleBackColor = true;
            this.btnProductEdit.Click += new System.EventHandler(this.btnProductEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Стоимость продукта:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество продукта:";
            // 
            // nudQuantityProduct
            // 
            this.nudQuantityProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQuantityProduct.Location = new System.Drawing.Point(154, 74);
            this.nudQuantityProduct.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudQuantityProduct.Name = "nudQuantityProduct";
            this.nudQuantityProduct.Size = new System.Drawing.Size(212, 23);
            this.nudQuantityProduct.TabIndex = 3;
            // 
            // nudPriceProduct
            // 
            this.nudPriceProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPriceProduct.DecimalPlaces = 2;
            this.nudPriceProduct.Location = new System.Drawing.Point(154, 43);
            this.nudPriceProduct.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudPriceProduct.Name = "nudPriceProduct";
            this.nudPriceProduct.Size = new System.Drawing.Size(212, 23);
            this.nudPriceProduct.TabIndex = 2;
            // 
            // ProductForm
            // 
            this.AcceptButton = this.btnProductEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 251);
            this.Controls.Add(this.nudPriceProduct);
            this.Controls.Add(this.nudQuantityProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProductEdit);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnProductEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQuantityProduct;
        private System.Windows.Forms.NumericUpDown nudPriceProduct;
    }
}