using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BCrypt.Net;


namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        private const string connectionString = "Data Source=DESKTOP-N0V2CA2\\OSAMASERVER;Initial Catalog=Users;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtusername.Text;
            string password = txtpassword.Text;
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return; 
            }
            if (IsValidUser(username, password))
            {
                MessageBox.Show("تم تسجيل الدخول بنجاح!");
                // تنفيذ الإجراءات بعد تسجيل الدخول الناجح
                SqlOrXml sqlOrXml = new SqlOrXml();
                sqlOrXml.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("فشل تسجيل الدخول. يرجى التحقق من اسم المستخدم وكلمة المرور.");
                txtpassword.Clear();
                txtusername.Clear();
                txtusername.Focus();
            }
        }
        private bool IsValidUser(string username, string password)
        {
            string query = "SELECT password FROM userstable WHERE username=@username";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string hashedPassword = reader["password"].ToString();
                    if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        private void btnnewuser_Click(object sender, EventArgs e)
        {
            OsaCreateUsers createUsers = new OsaCreateUsers();
            createUsers.Show();
            this.Hide();
        }
    }
}
