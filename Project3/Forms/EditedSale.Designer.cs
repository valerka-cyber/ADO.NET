
namespace Project3.Forms
{
    partial class EditedSale
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelManagers = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBProduct = new System.Windows.Forms.ComboBox();
            this.TBCnt = new System.Windows.Forms.TextBox();
            this.DTPicker = new System.Windows.Forms.DateTimePicker();
            this.Cancel = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.CBManagers = new System.Windows.Forms.ComboBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(303, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Изменения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Артикул";
            // 
            // labelManagers
            // 
            this.labelManagers.AutoSize = true;
            this.labelManagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManagers.Location = new System.Drawing.Point(81, 108);
            this.labelManagers.Name = "labelManagers";
            this.labelManagers.Size = new System.Drawing.Size(84, 16);
            this.labelManagers.TabIndex = 2;
            this.labelManagers.Text = "Менеджер";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProduct.Location = new System.Drawing.Point(81, 136);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(54, 16);
            this.labelProduct.TabIndex = 3;
            this.labelProduct.Text = "Товар";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(81, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Кол-во";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(82, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Дата";
            // 
            // CBProduct
            // 
            this.CBProduct.FormattingEnabled = true;
            this.CBProduct.Location = new System.Drawing.Point(176, 136);
            this.CBProduct.Name = "CBProduct";
            this.CBProduct.Size = new System.Drawing.Size(200, 21);
            this.CBProduct.TabIndex = 7;
            this.CBProduct.SelectedIndexChanged += new System.EventHandler(this.CBProduct_SelectedIndexChanged);
            // 
            // TBCnt
            // 
            this.TBCnt.Location = new System.Drawing.Point(176, 164);
            this.TBCnt.Name = "TBCnt";
            this.TBCnt.Size = new System.Drawing.Size(200, 20);
            this.TBCnt.TabIndex = 8;
            // 
            // DTPicker
            // 
            this.DTPicker.Location = new System.Drawing.Point(176, 190);
            this.DTPicker.Name = "DTPicker";
            this.DTPicker.Size = new System.Drawing.Size(200, 20);
            this.DTPicker.TabIndex = 9;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(212, 302);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(176, 82);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(35, 13);
            this.labelID.TabIndex = 12;
            this.labelID.Text = "label7";
            // 
            // CBManagers
            // 
            this.CBManagers.FormattingEnabled = true;
            this.CBManagers.Location = new System.Drawing.Point(176, 109);
            this.CBManagers.Name = "CBManagers";
            this.CBManagers.Size = new System.Drawing.Size(200, 21);
            this.CBManagers.TabIndex = 13;
            this.CBManagers.SelectedIndexChanged += new System.EventHandler(this.CBManagers_SelectedIndexChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(74, 301);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 14;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // EditedSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.CBManagers);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.DTPicker);
            this.Controls.Add(this.TBCnt);
            this.Controls.Add(this.CBProduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.labelManagers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditedSale";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.EditedSale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelManagers;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBProduct;
        private System.Windows.Forms.TextBox TBCnt;
        private System.Windows.Forms.DateTimePicker DTPicker;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ComboBox CBManagers;
        private System.Windows.Forms.Button Save;
    }
}