namespace Макет
{
    partial class Employee
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.tbInn = new System.Windows.Forms.TextBox();
            this.tbPasp = new System.Windows.Forms.TextBox();
            this.tbSnils = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cbDep = new System.Windows.Forms.ComboBox();
            this.cbPost = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(9, 32);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(277, 20);
            this.tbName.TabIndex = 0;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(196, 110);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(128, 20);
            this.dtpBirth.TabIndex = 1;
            // 
            // tbInn
            // 
            this.tbInn.Location = new System.Drawing.Point(9, 71);
            this.tbInn.Name = "tbInn";
            this.tbInn.Size = new System.Drawing.Size(164, 20);
            this.tbInn.TabIndex = 2;
            // 
            // tbPasp
            // 
            this.tbPasp.Location = new System.Drawing.Point(9, 110);
            this.tbPasp.Name = "tbPasp";
            this.tbPasp.Size = new System.Drawing.Size(181, 20);
            this.tbPasp.TabIndex = 4;
            // 
            // tbSnils
            // 
            this.tbSnils.Location = new System.Drawing.Point(195, 71);
            this.tbSnils.Name = "tbSnils";
            this.tbSnils.Size = new System.Drawing.Size(129, 20);
            this.tbSnils.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата Рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ИНН";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Данные паспорта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "СНИЛС";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Подразделение";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Должность";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(352, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 22);
            this.button3.TabIndex = 22;
            this.button3.Text = "ОК";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbDep
            // 
            this.cbDep.FormattingEnabled = true;
            this.cbDep.Location = new System.Drawing.Point(9, 77);
            this.cbDep.Name = "cbDep";
            this.cbDep.Size = new System.Drawing.Size(309, 21);
            this.cbDep.TabIndex = 23;
            // 
            // cbPost
            // 
            this.cbPost.FormattingEnabled = true;
            this.cbPost.Location = new System.Drawing.Point(136, 36);
            this.cbPost.Name = "cbPost";
            this.cbPost.Size = new System.Drawing.Size(182, 21);
            this.cbPost.TabIndex = 24;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(403, 248);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(77, 22);
            this.button6.TabIndex = 27;
            this.button6.Text = "Отмена";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Табельный номер";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(96, 20);
            this.textBox3.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.btnFire);
            this.groupBox1.Controls.Add(this.btnTransfer);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(352, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 142);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Приказы";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(6, 77);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(116, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Прием на работу";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(6, 48);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(116, 23);
            this.btnFire.TabIndex = 1;
            this.btnFire.Text = "Увольнение";
            this.btnFire.UseVisualStyleBackColor = true;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(6, 19);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(116, 23);
            this.btnTransfer.TabIndex = 0;
            this.btnTransfer.Text = "Перевод";
            this.btnTransfer.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.cbDep);
            this.groupBox2.Controls.Add(this.cbPost);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 110);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Служебная информация";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbName);
            this.groupBox3.Controls.Add(this.dtpBirth);
            this.groupBox3.Controls.Add(this.tbInn);
            this.groupBox3.Controls.Add(this.tbPasp);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbSnils);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 142);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Общая информация";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 273);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Name = "Employee";
            this.Text = "Сотрудник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_FormClosing);
            this.Load += new System.EventHandler(this.Employee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.TextBox tbInn;
        private System.Windows.Forms.TextBox tbPasp;
        private System.Windows.Forms.TextBox tbSnils;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbDep;
        private System.Windows.Forms.ComboBox cbPost;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}