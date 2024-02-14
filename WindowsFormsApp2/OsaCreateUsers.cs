using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BCrypt.Net;

namespace WindowsFormsApp2
{
    public partial class OsaCreateUsers : Form
    {
        private const string connectionString = "Data Source=DESKTOP-N0V2CA2\\OSAMASERVER;Initial Catalog=Users;Integrated Security=True";
        private SqlConnection connection;
        private SqlDataAdapter sqlDataAdapter;
        private DataTable dataTable;
        public OsaCreateUsers()
        {
            InitializeComponent();
        }

        private void btnnewuser_Click(object sender, EventArgs e)
        {
            string username = txtnewusername.Text;
            string password = txtnewpassword.Text;
           

            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                    // Insert the user into the database
                    SqlCommand command = new SqlCommand("INSERT INTO userstable (username, password) VALUES (@username, @password)", connection);
                    command.Parameters.AddWithValue("@username", username);

                    command.Parameters.AddWithValue("@password", hashedPassword);
                    command.ExecuteNonQuery();

                }
                MessageBox.Show("تم إنشاء مستخدم بنجاح!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل إنشاء مستخدم!!" + ex.Message);
            }
        }

        private void btnbacklogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

      
    }
}
