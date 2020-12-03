using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            if (ToodeText.Text!="" && KogusText.Text!="" && HindText.Text!="")
            {
                command = new SqlCommand("INSERT INTO Tootetable (Toodenimetus,Kogus,Hind) VALUES (@toode,@kogus,@hind", connect);
                connect.Open();
                command.Parameters.AddWithValue("@toode", ToodeText.Text);
                command.Parameters.AddWithValue("@kogus", KogusText.Text);
                command.Parameters.AddWithValue("@hind", HindText.Text);
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
                ClearData();
                command = new SqlCommand("UPDATE Tootetable SET Toodenimetus=@toode,Kogus=@kogus,Hind=@hind WHERE Id=@id", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@toode", ToodeText.Text);
                command.Parameters.AddWithValue("@kogus", KogusText.Text);
                command.Parameters.AddWithValue("@hind", HindText.Text);
                command.ExecuteNonQuery();
                connect.Close();
                DisplayData();
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
        }
    }
}
