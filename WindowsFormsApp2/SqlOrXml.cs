using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class SqlOrXml : Form
    {
        public SqlOrXml()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Booking_Sql booking_Sql = new Booking_Sql();
            booking_Sql.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Booking_Xml booking_Xml = new Booking_Xml();
            booking_Xml.Show();
            this.Hide();
        }
    }
}
