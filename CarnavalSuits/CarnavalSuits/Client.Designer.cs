namespace CarnavalSuits
{
    partial class Client
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.gbLeftButtons = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbClient.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.gbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.gbLeftButtons.SuspendLayout();
            this.gbEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.803F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.19699F));
            this.tableLayoutPanel1.Controls.Add(this.gbLeftButtons, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbClient, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(599, 360);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.textBox6);
            this.gbClient.Controls.Add(this.label6);
            this.gbClient.Controls.Add(this.gbSearch);
            this.gbClient.Controls.Add(this.gbList);
            this.gbClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbClient.Location = new System.Drawing.Point(3, 3);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(483, 354);
            this.gbClient.TabIndex = 0;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Клиенты";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.tbSearch);
            this.gbSearch.Location = new System.Drawing.Point(6, 19);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(471, 55);
            this.gbSearch.TabIndex = 1;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Поиск";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(9, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(456, 20);
            this.tbSearch.TabIndex = 0;
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.gbEdit);
            this.gbList.Controls.Add(this.dgvMain);
            this.gbList.Location = new System.Drawing.Point(6, 80);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(471, 189);
            this.gbList.TabIndex = 2;
            this.gbList.TabStop = false;
            this.gbList.Text = "Список клиентов";
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(6, 19);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(459, 157);
            this.dgvMain.TabIndex = 0;
            // 
            // gbLeftButtons
            // 
            this.gbLeftButtons.Controls.Add(this.btnDelete);
            this.gbLeftButtons.Controls.Add(this.btnEdit);
            this.gbLeftButtons.Controls.Add(this.btnAdd);
            this.gbLeftButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLeftButtons.Location = new System.Drawing.Point(492, 3);
            this.gbLeftButtons.Name = "gbLeftButtons";
            this.gbLeftButtons.Size = new System.Drawing.Size(104, 354);
            this.gbLeftButtons.TabIndex = 2;
            this.gbLeftButtons.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(20, 128);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(20, 186);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // gbEdit
            // 
            this.gbEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEdit.Controls.Add(this.dateTimePicker1);
            this.gbEdit.Controls.Add(this.label5);
            this.gbEdit.Controls.Add(this.textBox5);
            this.gbEdit.Controls.Add(this.label4);
            this.gbEdit.Controls.Add(this.textBox4);
            this.gbEdit.Controls.Add(this.label3);
            this.gbEdit.Controls.Add(this.textBox2);
            this.gbEdit.Controls.Add(this.label2);
            this.gbEdit.Controls.Add(this.textBox1);
            this.gbEdit.Controls.Add(this.label1);
            this.gbEdit.Location = new System.Drawing.Point(0, 0);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(471, 265);
            this.gbEdit.TabIndex = 3;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Изменение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия Имя Отчество";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(456, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Телефон";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(232, 87);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(233, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Адрес";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(9, 139);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(129, 20);
            this.textBox5.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Серия и номер паспорта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата выдачи";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(183, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(15, 271);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(314, 20);
            this.textBox6.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Кем выдан";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 360);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Client";
            this.Text = "Client";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.gbLeftButtons.ResumeLayout(false);
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.GroupBox gbLeftButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}