using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Booking_Xml : Form
    {
        private const string XmlFilePath = "Bookings.xml";
        private List<Booking> bookings;
        private int lastBookingID;
        //private bool userActivity = false;
       /* private const int InactivityTimeout = 10000;
        private Timer timer;*/
        public Booking_Xml()
        {
            InitializeComponent();
            bookings = new List<Booking>();
            lastBookingID = 0;
        }

        private void ClearFields()
        {
            Osa_CustNamexml.Text = string.Empty;
            Osa_CustEmailxml.Text = string.Empty;
            Osa_GuestsNoxml.Value = 1;
            Osa_InDatexml.Value = DateTime.Now;
            Osa_OutDatexml.Value = DateTime.Now.AddDays(1);
            Osa_RoomTypexml.SelectedIndex = -1;
        }
        private void LoadBookings()
        {
            bookings.Clear();

            XDocument doc = XDocument.Load(XmlFilePath);
            foreach (XElement element in doc.Root.Elements("Booking"))
            {
                Booking booking = new Booking
                {
                    BookingID = int.Parse(element.Element("BookingID").Value),
                    CustName = element.Element("CustName").Value,
                    CustEmail = element.Element("CustEmail").Value,
                    GuestNo = int.Parse(element.Element("GuestNo").Value),
                    InDate = DateTime.Parse(element.Element("InDate").Value),
                    OutDate = DateTime.Parse(element.Element("OutDate").Value),
                    RoomType = element.Element("RoomType").Value
                };

                bookings.Add(booking);
                lastBookingID = Math.Max(lastBookingID, booking.BookingID);
            }

            Osa_dataGridViewxml.DataSource = bookings;
        }
        private void Booking_Xml_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string custName = Osa_CustNamexml.Text.Trim();
            string custEmail = Osa_CustEmailxml.Text.Trim();
            int guestNo = (int)Osa_GuestsNoxml.Value;
            DateTime inDate = Osa_InDatexml.Value.Date;
            DateTime outDate = Osa_OutDatexml.Value.Date;
            string roomType = Osa_RoomTypexml.SelectedItem.ToString();

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

            int newBookingID = ++lastBookingID;

            Booking newBooking = new Booking
            {
                BookingID = newBookingID,
                CustName = custName,
                CustEmail = custEmail,
                GuestNo = guestNo,
                InDate = inDate,
                OutDate = outDate,
                RoomType = roomType
            };

            bookings.Add(newBooking);
            Osa_dataGridViewxml.DataSource = null;
            Osa_dataGridViewxml.DataSource = bookings;

            SaveBookings();

            ClearFields();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (Osa_dataGridViewxml.SelectedRows.Count > 0)
            {
                int selectedBookingID = (int)Osa_dataGridViewxml.SelectedRows[0].Cells["BookingID"].Value;

                Booking bookingToRemove = bookings.FirstOrDefault(booking => booking.BookingID == selectedBookingID);
                if (bookingToRemove != null)
                {
                    bookings.Remove(bookingToRemove);
                    Osa_dataGridViewxml.DataSource = null;
                    Osa_dataGridViewxml.DataSource = bookings;

                    SaveBookings();
                }
            }
        }
        private void SaveBookings()
        {
            XDocument doc = new XDocument(
                           new XElement("Bookings",
                               bookings.Select(booking =>
                                   new XElement("Booking",
                                       new XElement("BookingID", booking.BookingID),
                                       new XElement("CustName", booking.CustName),
                                       new XElement("CustEmail", booking.CustEmail),
                                       new XElement("GuestNo", booking.GuestNo),
                                       new XElement("InDate", booking.InDate.ToString("yyyy-MM-dd")),
                                       new XElement("OutDate", booking.OutDate.ToString("yyyy-MM-dd")),
                                       new XElement("RoomType", booking.RoomType)
                                   )
                               )
                           )
                       );

            doc.Save(XmlFilePath);
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (Osa_dataGridViewxml.SelectedRows.Count > 0)
            {
                int selectedRowIndex = Osa_dataGridViewxml.SelectedRows[0].Index;

                int bookingID = (int)Osa_dataGridViewxml.Rows[selectedRowIndex].Cells["BookingID"].Value;
                Booking selectedBooking = bookings.FirstOrDefault(booking => booking.BookingID == bookingID);

                if (selectedBooking != null)
                {
                    string custName = Osa_CustNamexml.Text.Trim();
                    string custEmail = Osa_CustEmailxml.Text.Trim();
                    int guestNo = (int)Osa_GuestsNoxml.Value;
                    DateTime inDate = Osa_InDatexml.Value.Date;
                    DateTime outDate = Osa_OutDatexml.Value.Date;
                    string roomType = Osa_RoomTypexml.SelectedItem.ToString();

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

                    selectedBooking.CustName = custName;
                    selectedBooking.CustEmail = custEmail;
                    selectedBooking.GuestNo = guestNo;
                    selectedBooking.InDate = inDate;
                    selectedBooking.OutDate = outDate;
                    selectedBooking.RoomType = roomType;

                    Osa_dataGridViewxml.Rows[selectedRowIndex].Cells["CustName"].Value = custName;
                    Osa_dataGridViewxml.Rows[selectedRowIndex].Cells["CustEmail"].Value = custEmail;
                    Osa_dataGridViewxml.Rows[selectedRowIndex].Cells["GuestNo"].Value = guestNo;
                    Osa_dataGridViewxml.Rows[selectedRowIndex].Cells["InDate"].Value = inDate.ToString("yyyy-MM-dd");
                    Osa_dataGridViewxml.Rows[selectedRowIndex].Cells["OutDate"].Value = outDate.ToString("yyyy-MM-dd");
                    Osa_dataGridViewxml.Rows[selectedRowIndex].Cells["RoomType"].Value = roomType;

                    SaveBookings();

                    ClearFields();
                }
            }
        }

        private void Osa_dataGridViewxml_SelectionChanged(object sender, EventArgs e)
        {
            if (Osa_dataGridViewxml.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Osa_dataGridViewxml.SelectedRows[0];

                string custName = selectedRow.Cells["CustName"].Value.ToString();
                string custEmail = selectedRow.Cells["CustEmail"].Value.ToString();
                int guestNo = Convert.ToInt32(selectedRow.Cells["GuestNo"].Value);
                DateTime inDate = Convert.ToDateTime(selectedRow.Cells["InDate"].Value);
                DateTime outDate = Convert.ToDateTime(selectedRow.Cells["OutDate"].Value);
                string roomType = selectedRow.Cells["RoomType"].Value.ToString();

                Osa_CustNamexml.Text = custName;
                Osa_CustEmailxml.Text = custEmail;
                Osa_GuestsNoxml.Value = guestNo;
                Osa_InDatexml.Value = inDate;
                Osa_OutDatexml.Value = outDate;
                Osa_RoomTypexml.SelectedItem = roomType;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}


