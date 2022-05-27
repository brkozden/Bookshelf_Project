namespace Bookshelf_Proje
{
    partial class BookshelftForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookshelftForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.rbtnbUsed = new System.Windows.Forms.RadioButton();
            this.rbtnZero = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1175, 304);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBookName.Location = new System.Drawing.Point(44, 78);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(104, 28);
            this.lblBookName.TabIndex = 1;
            this.lblBookName.Text = "Kitap Adı:";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(188, 75);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(212, 36);
            this.txtBookName.TabIndex = 2;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(188, 120);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(212, 36);
            this.txtAuthor.TabIndex = 4;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAuthor.Location = new System.Drawing.Point(78, 120);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(70, 28);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Yazar:";
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(188, 164);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(212, 36);
            this.txtPage.TabIndex = 6;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPage.Location = new System.Drawing.Point(77, 164);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(71, 28);
            this.lblPage.TabIndex = 5;
            this.lblPage.Text = "Sayfa:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblType.Location = new System.Drawing.Point(98, 211);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(50, 28);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Tür:";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Şiir ",
            "Tiyatro"});
            this.cbxType.Location = new System.Drawing.Point(188, 211);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(212, 36);
            this.cbxType.TabIndex = 8;
            // 
            // rbtnbUsed
            // 
            this.rbtnbUsed.AutoSize = true;
            this.rbtnbUsed.Checked = true;
            this.rbtnbUsed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnbUsed.Location = new System.Drawing.Point(188, 254);
            this.rbtnbUsed.Name = "rbtnbUsed";
            this.rbtnbUsed.Size = new System.Drawing.Size(105, 32);
            this.rbtnbUsed.TabIndex = 9;
            this.rbtnbUsed.TabStop = true;
            this.rbtnbUsed.Text = "İkinci El";
            this.rbtnbUsed.UseVisualStyleBackColor = true;
            this.rbtnbUsed.CheckedChanged += new System.EventHandler(this.rbtnbUsed_CheckedChanged);
            // 
            // rbtnZero
            // 
            this.rbtnZero.AutoSize = true;
            this.rbtnZero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnZero.Location = new System.Drawing.Point(329, 254);
            this.rbtnZero.Name = "rbtnZero";
            this.rbtnZero.Size = new System.Drawing.Size(71, 32);
            this.rbtnZero.TabIndex = 10;
            this.rbtnZero.Text = "Sıfır";
            this.rbtnZero.UseVisualStyleBackColor = true;
            this.rbtnZero.CheckedChanged += new System.EventHandler(this.rbtnZero_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStatus.Location = new System.Drawing.Point(64, 253);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 28);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Durum:";
            // 
            // txtBookID
            // 
            this.txtBookID.Enabled = false;
            this.txtBookID.Location = new System.Drawing.Point(188, 30);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(212, 36);
            this.txtBookID.TabIndex = 13;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBookID.Location = new System.Drawing.Point(54, 33);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(94, 28);
            this.lblBookID.TabIndex = 12;
            this.lblBookID.Text = "Kitap ID:";
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.DarkOrange;
            this.btnList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnList.Location = new System.Drawing.Point(451, 30);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(204, 99);
            this.btnList.TabIndex = 14;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(451, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(204, 87);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(672, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(204, 96);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Turquoise;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(672, 132);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(204, 91);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(901, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(624, 255);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(212, 36);
            this.txtFind.TabIndex = 20;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(480, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kitap Bul:";
            // 
            // BookshelftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1199, 630);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.rbtnZero);
            this.Controls.Add(this.rbtnbUsed);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookshelftForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.RadioButton rbtnbUsed;
        private System.Windows.Forms.RadioButton rbtnZero;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label1;
    }
}
