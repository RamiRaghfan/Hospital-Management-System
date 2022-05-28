using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace E_Hospital
{
    public partial class Dashboard : Form
    {
        private static MySqlConnection connection;

        public Dashboard()
        {
            InitializeComponent();
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "127.0.0.1";
            builder.UserID = "root";
            builder.Password = "root";
            builder.Database = "ehospital";
            builder.SslMode = MySqlSslMode.Disabled;

            try
            {
              connection = new MySqlConnection(builder.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void btnCreateP_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
       

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShowPatients_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;

        }

        private void btnAddDiag_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e) {}

        private void btnSave_Click(object sender, EventArgs e)
        {


            try
            {

                String name = txtName.Text;
                String address = txtAddress.Text;
                String contact = txtContactNr.Text;
                int age = Convert.ToInt32(txtAge.Text);
                String gender = comboSex.Text;
                String desc = txtDescr.Text;
                String blood = txtBldType.Text;
                String weight = txtWeight.Text;

                string query = "INSERT INTO patient(p_name, p_address, p_contact, p_age, p_sex, p_bloodtype, p_weight, p_description) values (@p_name, @p_address, @p_contact, @p_age, @p_sex, @p_bloodtype, @p_weight, @p_description);";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@p_name", name);
                    cmd.Parameters.AddWithValue("@p_address", address);
                    cmd.Parameters.AddWithValue("@p_contact", contact);
                    cmd.Parameters.AddWithValue("@p_age", age);
                    cmd.Parameters.AddWithValue("@p_sex", gender);
                    cmd.Parameters.AddWithValue("@p_bloodtype", blood);
                    cmd.Parameters.AddWithValue("@p_weight", weight);
                    cmd.Parameters.AddWithValue("@p_description",desc);

                    MessageBox.Show("New patient has been added");
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtName.Clear();
            txtAddress.Clear();
            txtContactNr.Clear();
            txtAge.Clear();
            txtDescr.Clear();
            txtBldType.Clear();
            txtWeight.Clear();
            comboSex.ResetText();



        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
