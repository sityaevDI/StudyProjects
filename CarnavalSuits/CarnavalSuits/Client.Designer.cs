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
            this.gbLeftButtons = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.dtPassportDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbPassport = new System.Windows.Forms.TextBox();
            this.tbPassportGiven = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbLeftButtons.SuspendLayout();
            this.gbClient.SuspendLayout();
            this.gbEdit.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.gbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
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
            // gbLeftButtons
            // 
            this.gbLeftButtons.Controls.Add(this.btnDelete);
            this.gbLeftButtons.Controls.Add(this.btnEdit);
            this.gbLeftButtons.Controls.Add(this.btnAdd);
            this.gbLeftButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLeftButtons.Location = new System.Drawing.Point(493, 3);
            this.gbLeftButtons.Name = "gbLeftButtons";
            this.gbLeftButtons.Size = new System.Drawing.Size(103, 354);
            this.gbLeftButtons.TabIndex = 2;
            this.gbLeftButtons.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(20, 186);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(20, 128);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.gbSearch);
            this.gbClient.Controls.Add(this.gbList);
            this.gbClient.Controls.Add(this.gbEdit);
            this.gbClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbClient.Location = new System.Drawing.Point(3, 3);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(484, 354);
            this.gbClient.TabIndex = 0;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Клиенты";
            // 
            // gbEdit
            // 
            this.gbEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEdit.Controls.Add(this.dtPassportDate);
            this.gbEdit.Controls.Add(this.btnCancel);
            this.gbEdit.Controls.Add(this.label5);
            this.gbEdit.Controls.Add(this.btnOk);
            this.gbEdit.Controls.Add(this.tbPassport);
            this.gbEdit.Controls.Add(this.tbPassportGiven);
            this.gbEdit.Controls.Add(this.label6);
            this.gbEdit.Controls.Add(this.label4);
            this.gbEdit.Controls.Add(this.tbAdress);
            this.gbEdit.Controls.Add(this.label3);
            this.gbEdit.Controls.Add(this.tbPhone);
            this.gbEdit.Controls.Add(this.label2);
            this.gbEdit.Controls.Add(this.tbName);
            this.gbEdit.Controls.Add(this.label1);
            this.gbEdit.Location = new System.Drawing.Point(7, 82);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(471, 265);
            this.gbEdit.TabIndex = 5;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Изменение";
            this.gbEdit.Visible = false;
            // 
            // dtPassportDate
            // 
            this.dtPassportDate.Location = new System.Drawing.Point(183, 139);
            this.dtPassportDate.Name = "dtPassportDate";
            this.dtPassportDate.Size = new System.Drawing.Size(140, 20);
            this.dtPassportDate.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(390, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(346, 236);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(38, 23);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbPassport
            // 
            this.tbPassport.Location = new System.Drawing.Point(9, 139);
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.Size = new System.Drawing.Size(129, 20);
            this.tbPassport.TabIndex = 8;
            // 
            // tbPassportGiven
            // 
            this.tbPassportGiven.Location = new System.Drawing.Point(9, 189);
            this.tbPassportGiven.Name = "tbPassportGiven";
            this.tbPassportGiven.Size = new System.Drawing.Size(375, 20);
            this.tbPassportGiven.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Кем выдан";
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
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(232, 87);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(233, 20);
            this.tbAdress.TabIndex = 6;
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
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(9, 87);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(179, 20);
            this.tbPhone.TabIndex = 3;
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
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(9, 35);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(456, 20);
            this.tbName.TabIndex = 1;
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
            this.gbList.Controls.Add(this.dgvMain);
            this.gbList.Location = new System.Drawing.Point(6, 80);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(471, 265);
            this.gbList.TabIndex = 2;
            this.gbList.TabStop = false;
            this.gbList.Text = "Список клиентов";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(6, 19);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(459, 246);
            this.dgvMain.TabIndex = 0;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 360);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Client";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Client_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbLeftButtons.ResumeLayout(false);
            this.gbClient.ResumeLayout(false);
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
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
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.DateTimePicker dtPassportDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbPassport;
        private System.Windows.Forms.TextBox tbPassportGiven;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
    }
}