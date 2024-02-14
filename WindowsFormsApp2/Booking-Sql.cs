using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Booking_Sql : Form
    {
        private string connectionString = "Data Source=DESKTOP-N0V2CA2\\OSAMASERVER;Initial Catalog=MyDb;Integrated Security=True";
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        
        public Booking_Sql()
        {
            InitializeComponent();           
        }
        private void LoadBookings()
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {

                    dataAdapter = new SqlDataAdapter("SELECT * FROM Bookings", connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string custName = CustName.Text;
                string custEmail = CustEmail.Text;
                int guestNo = int.Parse(GuestNo.Text);
                DateTime inDate = InDate.Value;
                DateTime outDate = OutDate.Value;
                string roomType = RoomType.SelectedItem.ToString();
                if (string.IsNullOrEmpty(custName) || string.IsNullOrEmpty(custEmail))
                {
                    MessageBox.Show("يرجى إدخال اسم العميل والبريد الإلكتروني.");
                    return;
                }

                if (!IsValidEmail(custEmail))
                {
                    MessageBox.Show("يرجى إدخال بريد إلكتروني صالح.");
                    return;
                }

                using (connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Bookings ( CustName, CustEmail, GuestNo, InDate, OutDate, RoomType) VALUES ( @CustName, @CustEmail, @GuestNo, @InDate, @OutDate, @RoomType); SELECT SCOPE_IDENTITY()", connection);
                    command.Parameters.AddWithValue("@CustName", custName);
                    command.Parameters.AddWithValue("@CustEmail", custEmail);
                    command.Parameters.AddWithValue("@GuestNo", guestNo);
                    command.Parameters.AddWithValue("@InDate", inDate);
                    command.Parameters.AddWithValue("@OutDate", outDate);
                    command.Parameters.AddWithValue("@RoomType", roomType);
                    connection.Open();
                    int bookingID = Convert.ToInt32(command.ExecuteScalar());
                    BookingID.Text = BookingID.ToString();
                    command.ExecuteNonQuery();

                }
                LoadBookings();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occurred " + ex.Message, "Error");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int bookingID = int.Parse(dataGridView1.SelectedRows[0].Cells["BookingID"].Value.ToString());
                    string custName = CustName.Text;
                    string custEmail = CustEmail.Text;
                    int guestNo = int.Parse(GuestNo.Text);
                    DateTime inDate = InDate.Value;
                    DateTime outDate = OutDate.Value;
                    string roomType = RoomType.SelectedItem.ToString();
                    using (connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("UPDATE Bookings SET CustName = @CustName, CustEmail = @CustEmail, GuestNo = @GuestNo, InDate = @InDate, OutDate = @OutDate, RoomType = @RoomType WHERE BookingID = @BookingID", connection);
                        command.Parameters.AddWithValue("@CustName", CustName);
                        command.Parameters.AddWithValue("@CustEmail", CustEmail);
                        command.Parameters.AddWithValue("@GuestNo", GuestNo);
                        command.Parameters.AddWithValue("@InDate", InDate);
                        command.Parameters.AddWithValue("@OutDate", OutDate);
                        command.Parameters.AddWithValue("@RoomType", RoomType);
                        command.Parameters.AddWithValue("@BookingID", bookingID);
                        connection.Open();
                        command.ExecuteNonQuery();
                        LoadBookings();
                    }
                   
                    ClearInputFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occurred " + ex.Message, "Error");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int BookingID = int.Parse(dataGridView1.SelectedRows[0].Cells["BookingID"].Value.ToString());
                    using (connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("DELETE FROM Bookings WHERE BookingID = @BookingID", connection);
                        command.Parameters.AddWithValue("@BookingID", BookingID);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    LoadBookings();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occurred " + ex.Message, "Error");
            }
        }
        private void ClearInputFields()
        {
            BookingID.Text = string.Empty;
            CustName.Text = string.Empty;
            CustEmail.Text = string.Empty;
           GuestNo.Value = 1;
            InDate.Value = DateTime.Today;
            OutDate.Value = DateTime.Now.AddDays(1);
            RoomType.SelectedIndex = -1;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void Booking_Sql_Load(object sender, EventArgs e)
        {
            LoadBookings();
            osatimersql.Enabled = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string custName = selectedRow.Cells["CustName"].Value.ToString();
                string custEmail = selectedRow.Cells["CustEmail"].Value.ToString();
                int guestNo = Convert.ToInt32(selectedRow.Cells["GuestNo"].Value);
                DateTime inDate = Convert.ToDateTime(selectedRow.Cells["InDate"].Value);
                DateTime outDate = Convert.ToDateTime(selectedRow.Cells["OutDate"].Value);
                string roomType = selectedRow.Cells["RoomType"].Value.ToString();

                CustName.Text = custName;
                CustEmail.Text = custEmail;
                GuestNo.Value = guestNo;
                InDate.Value = inDate;
                OutDate.Value = outDate;
                RoomType.SelectedItem = roomType;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void Booking_Sql_MouseMove(object sender, MouseEventArgs e)
        {
            osatimersql.Stop();
            osatimersql.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            osatimersql.Stop();
            Login login = new Login();
            login.Show();
            this.Close();

        }
        

        private void Booking_Sql_KeyDown(object sender, KeyEventArgs e)
        {
            osatimersql.Stop();
            osatimersql.Start();
        }

        private void Booking_Sql_Enter(object sender, EventArgs e)
        {
            osatimersql.Stop();
            osatimersql.Start();
        }

        private void Booking_Sql_KeyPress(object sender, KeyPressEventArgs e)
        {
            osatimersql.Stop();
            osatimersql.Start();
        }

        private void Booking_Sql_Move(object sender, EventArgs e)
        {
            osatimersql.Stop();
            osatimersql.Start();
        }

        private void CustEmail_TextChanged(object sender, EventArgs e)
        {
            osatimersql.Stop();
            osatimersql.Start();
        }

        private void BookingID_TextChanged(object sender, EventArgs e)
        {
            osatimersql.Stop();
            osatimersql.Start();
        }

        private void CustName_TextChanged(object sender, EventArgs e)
        {
            osatimersql.Stop();
            osatimersql.Start();
        }

        private void GuestNo_ValueChanged(object sender, EventArgs e)
        {
            osatimersql.Stop();
            osatimersql.Start();
        }

        private void GuestNo_MouseClick(object sender, MouseEventArgs e)
        {
            osatimersql.Stop();
            osatimersql.Start();
        }

        private void GuestNo_KeyDown(object sender, KeyEventArgs e)
        {
            osatimersql.Stop();
            osatimersql.Start();
        }

        private void GuestNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            osatimersql.Stop();
            osatimersql.Start();
        }

        private void groupBox1_Move(object sender, EventArgs e)
        {
            osatimersql.Stop();
            osatimersql.Start();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            osatimersql.Stop();
            osatimersql.Start();
        }

        private void InDate_ValueChanged(object sender, EventArgs e)
        {
            osatimersql.Stop();
            osatimersql.Start();
        }

        private void OutDate_ValueChanged(object sender, EventArgs e)
        {
            osatimersql.Stop();
            osatimersql.Start();
        }

        private void RoomType_Click(object sender, EventArgs e)
        {
            osatimersql.Stop();
            osatimersql.Start();
        }

        private void RoomType_MouseClick(object sender, MouseEventArgs e)
        {
            osatimersql.Stop();
            osatimersql.Start();
        }

        private void RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            osatimersql.Stop();
            osatimersql.Start();
        }

        private void RoomType_KeyPress(object sender, KeyPressEventArgs e)
        {
            osatimersql.Stop();
            osatimersql.Start();
        }
    }
}
