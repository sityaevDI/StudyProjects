namespace CarnavalSuits
{
    partial class CostumeSize
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
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbLeftButtons = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbPassport = new System.Windows.Forms.TextBox();
            this.tbPassportGiven = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbSearch.SuspendLayout();
            this.gbLeftButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.gbList.SuspendLayout();
            this.gbEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.tbSearch);
            this.gbSearch.Location = new System.Drawing.Point(6, 19);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(267, 55);
            this.gbSearch.TabIndex = 1;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Поиск";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(9, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(252, 20);
            this.tbSearch.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 186);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(6, 128);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // gbLeftButtons
            // 
            this.gbLeftButtons.Controls.Add(this.btnDelete);
            this.gbLeftButtons.Controls.Add(this.btnEdit);
            this.gbLeftButtons.Controls.Add(this.btnAdd);
            this.gbLeftButtons.Location = new System.Drawing.Point(282, 3);
            this.gbLeftButtons.Name = "gbLeftButtons";
            this.gbLeftButtons.Size = new System.Drawing.Size(97, 254);
            this.gbLeftButtons.TabIndex = 2;
            this.gbLeftButtons.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.03665F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.96335F));
            this.tableLayoutPanel1.Controls.Add(this.gbLeftButtons, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbClient, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 259);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.gbSearch);
            this.gbClient.Controls.Add(this.gbList);
            this.gbClient.Controls.Add(this.gbEdit);
            this.gbClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbClient.Location = new System.Drawing.Point(3, 3);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(273, 354);
            this.gbClient.TabIndex = 0;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Размеры";
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
            this.dgvMain.Size = new System.Drawing.Size(255, 148);
            this.dgvMain.TabIndex = 0;
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.dgvMain);
            this.gbList.Location = new System.Drawing.Point(6, 80);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(267, 174);
            this.gbList.TabIndex = 2;
            this.gbList.TabStop = false;
            this.gbList.Text = "Список размеров";
            // 
            // gbEdit
            // 
            this.gbEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEdit.Controls.Add(this.label1);
            this.gbEdit.Controls.Add(this.comboBox1);
            this.gbEdit.Controls.Add(this.btnCancel);
            this.gbEdit.Controls.Add(this.btnOk);
            this.gbEdit.Controls.Add(this.tbPassport);
            this.gbEdit.Controls.Add(this.tbPassportGiven);
            this.gbEdit.Controls.Add(this.label6);
            this.gbEdit.Controls.Add(this.label4);
            this.gbEdit.Controls.Add(this.tbAdress);
            this.gbEdit.Controls.Add(this.label3);
            this.gbEdit.Location = new System.Drawing.Point(6, 81);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(267, 173);
            this.gbEdit.TabIndex = 7;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Изменение";
            this.gbEdit.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Тип размера";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(183, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 21);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(139, 137);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(38, 21);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // tbPassport
            // 
            this.tbPassport.Location = new System.Drawing.Point(9, 111);
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.Size = new System.Drawing.Size(108, 20);
            this.tbPassport.TabIndex = 8;
            // 
            // tbPassportGiven
            // 
            this.tbPassportGiven.Location = new System.Drawing.Point(136, 111);
            this.tbPassportGiven.Name = "tbPassportGiven";
            this.tbPassportGiven.Size = new System.Drawing.Size(122, 20);
            this.tbPassportGiven.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Международный";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Американский";
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(9, 72);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(249, 20);
            this.tbAdress.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Российский";
            // 
            // CostumeSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 259);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CostumeSize";
            this.Text = "Размеры костюмов";
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbLeftButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.gbList.ResumeLayout(false);
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox gbLeftButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbPassport;
        private System.Windows.Forms.TextBox tbPassportGiven;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label label3;
    }
}