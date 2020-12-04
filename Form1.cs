using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TondoDB
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\TondoDB\AppData\Tooded.mdf;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter;
        int Id = 0;

        public Form1()
        {
            InitializeComponent();
            DisplayData();
        }
        private void DisplayData()
        {
            connect.Open();
            DataTable tabel = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM Tootetable", connect);
            adapter.Fill(tabel);
            dataGridView1.DataSource = tabel;
            connect.Close();
        }
        private void ClearData()
        {
            Id = 0;
            ToodeText.Text = "";
            HindText.Text = "";
            KogusText.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /* private void Form1_Load(object sender, EventArgs e)
         {
              //TODO: This line of code loads data into the 'toodedDataSet.Tootetable' table. You can move, or remove it, as needed.
             this.tootetableTableAdapter.Fill(this.toodedDataSet.Tootetable);

         }*/

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (ToodeText.Text != "" && KogusText.Text != "" && HindText.Text != "")
            {
                command = new SqlCommand("INSERT INTO Tootetable (Toodenimetus,Kogus,Hind,Pilt) VALUES (@toode,@kogus,@hind,@pilt)", connect);
                connect.Open();
                command.Parameters.AddWithValue("@toode", ToodeText.Text);
                command.Parameters.AddWithValue("@kogus", KogusText.Text);
                command.Parameters.AddWithValue("@hind", HindText.Text);
                command.Parameters.AddWithValue("@pilt", save.FileName + save.Filter);
                command.ExecuteNonQuery();
                connect.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed uuendatud");

            }
            else
            {
                MessageBox.Show("Viga");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO: This line of code loads data into the 'toodedDataSet.Tootetable' table. You can move, or remove it, as needed.
            this.tootetableTableAdapter.Fill(this.toodedDataSet.Tootetable);

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (ToodeText.Text != "" && KogusText.Text != "" && HindText.Text != "")
            {
                command = new SqlCommand("UPDATE Tootetable SET Toodenimetus=@toode,Kogus=@kogus,Hind=@hind, Pilt=@pilt WHERE Id=@id", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@toode", ToodeText.Text);
                command.Parameters.AddWithValue("@kogus", KogusText.Text);
                command.Parameters.AddWithValue("@hind", HindText.Text.Replace(",", "."));
                command.Parameters.AddWithValue("@pilt", save.FileName + save.Filter);
                command.ExecuteNonQuery();
                connect.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed on uuendatud");

            }
            else
            {
                MessageBox.Show("Viga");
            }
        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            ToodeText.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            KogusText.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            HindText.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            pictureBox1.Image = Image.FromFile(@"C:\Users\opilane\source\repos\TondoDB\Images\" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                command = new SqlCommand("DELETE Tootetable WHERE Id=@id", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.ExecuteNonQuery();
                connect.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed on kustuta");

            }
            else
            {
                MessageBox.Show("Viga");
            }
        }
        SaveFileDialog save;

        private void btn_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg; *.bmp; *.png *.jpg)|*.jpeg;*.bmp;*.png;*.jpg;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                save = new SaveFileDialog();
                save.FileName = ToodeText.Text +"_"+Id;
                save.Filter = "Image Files(*.jpeg; *.bmp; *.png *.jpg)|*.jpeg;*.bmp;*.png;*.jpg;";
                save.InitialDirectory = Path.GetFullPath(@"C:\Users\opilane\source\repos\TondoDB\Images\");
                save.ShowDialog();
                save.RestoreDirectory = true;
                
                
            }

        }
        void Imagec()
        {
           if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();

                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                ms.Position = 0;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toodedDataSet1.Tootetable' table. You can move, or remove it, as needed.
            this.tootetableTableAdapter1.Fill(this.toodedDataSet1.Tootetable);

        }

        
    }
}

