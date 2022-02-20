
namespace Project3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Departmen = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.genCnt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_sale = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grou_sale = new System.Windows.Forms.Label();
            this.grou_prod = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grou_man = new System.Windows.Forms.Label();
            this.grou_dep = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.NewQuery = new System.Windows.Forms.Button();
            this.Form2 = new System.Windows.Forms.Button();
            this.Filter = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.add_managers = new System.Windows.Forms.Button();
            this.add_dep = new System.Windows.Forms.Button();
            this.add_product = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Departmen
            // 
            this.Departmen.Location = new System.Drawing.Point(28, 146);
            this.Departmen.Name = "Departmen";
            this.Departmen.Size = new System.Drawing.Size(112, 34);
            this.Departmen.TabIndex = 0;
            this.Departmen.Text = "Department";
            this.Departmen.UseVisualStyleBackColor = true;
            this.Departmen.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(177, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(329, 251);
            this.listBox1.TabIndex = 1;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Managers";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Products";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "Generate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // genCnt
            // 
            this.genCnt.Location = new System.Drawing.Point(6, 32);
            this.genCnt.Name = "genCnt";
            this.genCnt.Size = new System.Drawing.Size(112, 20);
            this.genCnt.TabIndex = 5;
            this.genCnt.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Сгенерировать запись";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button_sale);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.genCnt);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 128);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button_sale
            // 
            this.button_sale.Location = new System.Drawing.Point(0, 57);
            this.button_sale.Name = "button_sale";
            this.button_sale.Size = new System.Drawing.Size(112, 31);
            this.button_sale.TabIndex = 16;
            this.button_sale.Text = "Оформить";
            this.button_sale.UseVisualStyleBackColor = true;
            this.button_sale.Click += new System.EventHandler(this.button_sale_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 270);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 34);
            this.button5.TabIndex = 8;
            this.button5.Text = "Sales";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grou_sale);
            this.groupBox2.Controls.Add(this.grou_prod);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.grou_man);
            this.groupBox2.Controls.Add(this.grou_dep);
            this.groupBox2.Location = new System.Drawing.Point(529, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 109);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // grou_sale
            // 
            this.grou_sale.AutoSize = true;
            this.grou_sale.Location = new System.Drawing.Point(176, 88);
            this.grou_sale.Name = "grou_sale";
            this.grou_sale.Size = new System.Drawing.Size(13, 13);
            this.grou_sale.TabIndex = 10;
            this.grou_sale.Text = "0";
            // 
            // grou_prod
            // 
            this.grou_prod.AutoSize = true;
            this.grou_prod.Location = new System.Drawing.Point(176, 67);
            this.grou_prod.Name = "grou_prod";
            this.grou_prod.Size = new System.Drawing.Size(13, 13);
            this.grou_prod.TabIndex = 11;
            this.grou_prod.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Продаж";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Сотрудники";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Товаров";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Отдел";
            // 
            // grou_man
            // 
            this.grou_man.AutoSize = true;
            this.grou_man.Location = new System.Drawing.Point(176, 50);
            this.grou_man.Name = "grou_man";
            this.grou_man.Size = new System.Drawing.Size(13, 13);
            this.grou_man.TabIndex = 1;
            this.grou_man.Text = "0";
            // 
            // grou_dep
            // 
            this.grou_dep.AutoSize = true;
            this.grou_dep.Location = new System.Drawing.Point(176, 28);
            this.grou_dep.Name = "grou_dep";
            this.grou_dep.Size = new System.Drawing.Size(13, 13);
            this.grou_dep.TabIndex = 0;
            this.grou_dep.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Location = new System.Drawing.Point(28, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 111);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Продажи";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "Все";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // NewQuery
            // 
            this.NewQuery.Location = new System.Drawing.Point(683, 175);
            this.NewQuery.Name = "NewQuery";
            this.NewQuery.Size = new System.Drawing.Size(91, 23);
            this.NewQuery.TabIndex = 12;
            this.NewQuery.Text = "Query";
            this.NewQuery.UseVisualStyleBackColor = true;
            this.NewQuery.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.Form2.Location = new System.Drawing.Point(683, 204);
            this.Form2.Name = "Form2";
            this.Form2.Size = new System.Drawing.Size(91, 23);
            this.Form2.TabIndex = 13;
            this.Form2.Text = "Form2";
            this.Form2.UseVisualStyleBackColor = true;
            this.Form2.Click += new System.EventHandler(this.Form2_Click);
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(683, 146);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(91, 23);
            this.Filter.TabIndex = 14;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.add_managers);
            this.groupBox4.Controls.Add(this.add_dep);
            this.groupBox4.Controls.Add(this.add_product);
            this.groupBox4.Location = new System.Drawing.Point(529, 127);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(129, 119);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Added";
            // 
            // add_managers
            // 
            this.add_managers.Location = new System.Drawing.Point(20, 77);
            this.add_managers.Name = "add_managers";
            this.add_managers.Size = new System.Drawing.Size(75, 23);
            this.add_managers.TabIndex = 2;
            this.add_managers.Text = "сотрудники";
            this.add_managers.UseVisualStyleBackColor = true;
            this.add_managers.Click += new System.EventHandler(this.add_managers_Click);
            // 
            // add_dep
            // 
            this.add_dep.Location = new System.Drawing.Point(20, 48);
            this.add_dep.Name = "add_dep";
            this.add_dep.Size = new System.Drawing.Size(75, 23);
            this.add_dep.TabIndex = 1;
            this.add_dep.Text = "отдел";
            this.add_dep.UseVisualStyleBackColor = true;
            this.add_dep.Click += new System.EventHandler(this.add_dep_Click);
            // 
            // add_product
            // 
            this.add_product.Location = new System.Drawing.Point(20, 19);
            this.add_product.Name = "add_product";
            this.add_product.Size = new System.Drawing.Size(75, 23);
            this.add_product.TabIndex = 0;
            this.add_product.Text = "товар";
            this.add_product.UseVisualStyleBackColor = true;
            this.add_product.Click += new System.EventHandler(this.add_product_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "Менеджер Оф";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.Form2);
            this.Controls.Add(this.NewQuery);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Departmen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Departmen;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox genCnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label grou_sale;
        private System.Windows.Forms.Label grou_prod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label grou_man;
        private System.Windows.Forms.Label grou_dep;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button NewQuery;
        private System.Windows.Forms.Button Form2;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button add_managers;
        private System.Windows.Forms.Button add_dep;
        private System.Windows.Forms.Button add_product;
        private System.Windows.Forms.Button button_sale;
        private System.Windows.Forms.Button button1;
    }
}

