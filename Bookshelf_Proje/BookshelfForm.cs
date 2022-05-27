using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bookshelf_Proje
{
    public partial class BookshelftForm : Form
    {
        public BookshelftForm()
        {
            InitializeComponent();
        }
        OleDbConnection bgl = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\berko\OneDrive\Belgeler\Bookshelf.mdb");
       
        void Liste()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From Books",bgl);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            Liste();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Liste();
        }
        string Status = "";
        private void btnSave_Click(object sender, EventArgs e)
        {
            bgl.Open();
            OleDbCommand cmd = new OleDbCommand("insert into Books (BookName,type,author,page,status) values (@p1,@p2,@p3,@p4,@p5)", bgl);
            cmd.Parameters.AddWithValue("@p1",txtBookName.Text);
            cmd.Parameters.AddWithValue("@p2", cbxType.Text);
            cmd.Parameters.AddWithValue("@p3", txtAuthor.Text);
            cmd.Parameters.AddWithValue("@p4", txtPage.Text);
            cmd.Parameters.AddWithValue("@p5", Status);
            cmd.ExecuteNonQuery();
            bgl.Close();

            MessageBox.Show("Kitap Sisteme Kaydedildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Liste();
            temizle();

        }

        private void rbtnbUsed_CheckedChanged(object sender, EventArgs e)
        {
            Status = "1";
        }

        private void rbtnZero_CheckedChanged(object sender, EventArgs e)
        {
            Status = "0";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            txtBookID.Text = dataGridView1.Rows[select].Cells[0].Value.ToString();
            txtBookName.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            txtAuthor.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            txtPage.Text = dataGridView1.Rows[select].Cells[4].Value.ToString();
            cbxType.Text = dataGridView1.Rows[select].Cells[3].Value.ToString();
            if (dataGridView1.Rows[select].Cells[5].Value.ToString() == "True")
            {
                rbtnbUsed.Checked = true;
            }
            if (dataGridView1.Rows[select].Cells[5].Value.ToString() == "False")
            {
                rbtnZero.Checked = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bgl.Open();
            OleDbCommand cmd2 = new OleDbCommand("Delete From Books Where Bookid=@p1",bgl);
            cmd2.Parameters.AddWithValue("@p1",txtBookID.Text);
            cmd2.ExecuteNonQuery();

            bgl.Close();
            MessageBox.Show("Kitap Listeden Silindi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            Liste();
            temizle();
        }
        void temizle()
        {
            txtAuthor.Text = txtBookID.Text = txtBookName.Text = txtPage.Text = cbxType.Text = "";
            rbtnbUsed.Checked= true;
            txtBookName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bgl.Open();
            OleDbCommand cmd3 = new OleDbCommand("update Books set BookName=@p1,author=@p2,type=@p3,page=@p4,status=@p5 Where Bookid=@p6", bgl);
            cmd3.Parameters.AddWithValue("@p1",txtBookName.Text);
            cmd3.Parameters.AddWithValue("@p2", txtAuthor.Text);
            cmd3.Parameters.AddWithValue("@p3", cbxType.Text);
            cmd3.Parameters.AddWithValue("@p4",Convert.ToInt32(txtPage.Text));
            cmd3.Parameters.AddWithValue("@p6",Convert.ToInt32(txtBookID.Text));
            if (rbtnbUsed.Checked == true)
            {
                cmd3.Parameters.AddWithValue("@p5", Status);
            }
            if (rbtnZero.Checked == true)
            {
                cmd3.Parameters.AddWithValue("@p5", Status);
            }
            cmd3.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Güncelleme İşlemi Yapıldı.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Liste();
            temizle();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            
            OleDbCommand command = new OleDbCommand("Select * From Books Where BookName Like '%" +txtFind.Text+ "%'", bgl);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
