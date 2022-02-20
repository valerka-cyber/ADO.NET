
namespace Project3.Forms
{
    partial class EditManager
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSecName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Secnametxt = new System.Windows.Forms.TextBox();
            this.Surnametxt = new System.Windows.Forms.TextBox();
            this.labelMainDep = new System.Windows.Forms.Label();
            this.labelSecDep = new System.Windows.Forms.Label();
            this.labelCheifDep = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.CBMain = new System.Windows.Forms.ComboBox();
            this.CBSec = new System.Windows.Forms.ComboBox();
            this.CBCheif = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(320, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Изменения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(75, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Артикул";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(166, 84);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(35, 13);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "label3";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(75, 109);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 16);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Имя";
            // 
            // labelSecName
            // 
            this.labelSecName.AutoSize = true;
            this.labelSecName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecName.Location = new System.Drawing.Point(75, 133);
            this.labelSecName.Name = "labelSecName";
            this.labelSecName.Size = new System.Drawing.Size(79, 16);
            this.labelSecName.TabIndex = 4;
            this.labelSecName.Text = "Отчество";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(75, 158);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(74, 16);
            this.labelSurname.TabIndex = 5;
            this.labelSurname.Text = "Фамилия";
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(169, 105);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(209, 20);
            this.Nametxt.TabIndex = 6;
            // 
            // Secnametxt
            // 
            this.Secnametxt.Location = new System.Drawing.Point(169, 132);
            this.Secnametxt.Name = "Secnametxt";
            this.Secnametxt.Size = new System.Drawing.Size(209, 20);
            this.Secnametxt.TabIndex = 7;
            // 
            // Surnametxt
            // 
            this.Surnametxt.Location = new System.Drawing.Point(169, 158);
            this.Surnametxt.Name = "Surnametxt";
            this.Surnametxt.Size = new System.Drawing.Size(209, 20);
            this.Surnametxt.TabIndex = 8;
            this.Surnametxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelMainDep
            // 
            this.labelMainDep.AutoSize = true;
            this.labelMainDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainDep.Location = new System.Drawing.Point(75, 217);
            this.labelMainDep.Name = "labelMainDep";
            this.labelMainDep.Size = new System.Drawing.Size(81, 16);
            this.labelMainDep.TabIndex = 9;
            this.labelMainDep.Text = "Основной";
            this.labelMainDep.Click += new System.EventHandler(this.labelMainDep_Click);
            // 
            // labelSecDep
            // 
            this.labelSecDep.AutoSize = true;
            this.labelSecDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecDep.Location = new System.Drawing.Point(75, 243);
            this.labelSecDep.Name = "labelSecDep";
            this.labelSecDep.Size = new System.Drawing.Size(134, 16);
            this.labelSecDep.TabIndex = 10;
            this.labelSecDep.Text = "Дополнительный";
            this.labelSecDep.Click += new System.EventHandler(this.labelSecDep_Click);
            // 
            // labelCheifDep
            // 
            this.labelCheifDep.AutoSize = true;
            this.labelCheifDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCheifDep.Location = new System.Drawing.Point(75, 272);
            this.labelCheifDep.Name = "labelCheifDep";
            this.labelCheifDep.Size = new System.Drawing.Size(41, 16);
            this.labelCheifDep.TabIndex = 11;
            this.labelCheifDep.Text = "Шеф";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(78, 346);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(131, 23);
            this.Save.TabIndex = 15;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(431, 345);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(160, 23);
            this.Clear.TabIndex = 16;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // CBMain
            // 
            this.CBMain.FormattingEnabled = true;
            this.CBMain.Location = new System.Drawing.Point(243, 212);
            this.CBMain.Name = "CBMain";
            this.CBMain.Size = new System.Drawing.Size(329, 21);
            this.CBMain.TabIndex = 17;
            this.CBMain.SelectedIndexChanged += new System.EventHandler(this.CBMain_SelectedIndexChanged);
            // 
            // CBSec
            // 
            this.CBSec.FormattingEnabled = true;
            this.CBSec.Location = new System.Drawing.Point(243, 243);
            this.CBSec.Name = "CBSec";
            this.CBSec.Size = new System.Drawing.Size(329, 21);
            this.CBSec.TabIndex = 18;
            this.CBSec.SelectedIndexChanged += new System.EventHandler(this.CBSec_SelectedIndexChanged);
            // 
            // CBCheif
            // 
            this.CBCheif.FormattingEnabled = true;
            this.CBCheif.Location = new System.Drawing.Point(243, 271);
            this.CBCheif.Name = "CBCheif";
            this.CBCheif.Size = new System.Drawing.Size(329, 21);
            this.CBCheif.TabIndex = 19;
            this.CBCheif.SelectedIndexChanged += new System.EventHandler(this.CBCheif_SelectedIndexChanged);
            // 
            // EditManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CBCheif);
            this.Controls.Add(this.CBSec);
            this.Controls.Add(this.CBMain);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.labelCheifDep);
            this.Controls.Add(this.labelSecDep);
            this.Controls.Add(this.labelMainDep);
            this.Controls.Add(this.Surnametxt);
            this.Controls.Add(this.Secnametxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelSecName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditManager";
            this.Text = "EditManager";
            this.Load += new System.EventHandler(this.EditManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSecName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Secnametxt;
        private System.Windows.Forms.TextBox Surnametxt;
        private System.Windows.Forms.Label labelMainDep;
        private System.Windows.Forms.Label labelSecDep;
        private System.Windows.Forms.Label labelCheifDep;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ComboBox CBMain;
        private System.Windows.Forms.ComboBox CBSec;
        private System.Windows.Forms.ComboBox CBCheif;
    }
}