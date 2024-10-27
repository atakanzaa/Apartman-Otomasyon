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

namespace ApartmanOtomasyon
{
    public partial class Gelirler : Form
    {
        public Gelirler()
        {
            InitializeComponent();
        }
        SqlHelper helper = new SqlHelper();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int daireNo = Convert.ToInt32(comboBox1.Text);
            int para = (int)(numericUpDown1.Value);
            DateTime tarih = dateTimePicker1.Value;

            SqlParameter p1 = new SqlParameter("Daireno",daireNo);
            SqlParameter p2 = new SqlParameter("Para", para);
            SqlParameter p3 = new SqlParameter("Tarih", tarih);

            helper.ExecuteProc("odeme_al", p1, p2, p3);

        }

        private void Gelirler_Load(object sender, EventArgs e)
        {
            DataTable dt = helper.GetTable("Select * from AidatOdemesi");
            foreach(DataRow x in dt.Rows)
            {
                listBox1.Items.Add(x["DaireNo"]).ToString();
                listBox2.Items.Add(x["Para"]).ToString();
                listBox3.Items.Add(x["Tarih"]).ToString();
            }
        }
    }
}
