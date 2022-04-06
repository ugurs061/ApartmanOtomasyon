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
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }
        SqlHelper sqlHelper= new SqlHelper();
        private void button1_Click(object sender, EventArgs e)
        {
            int para = (int)numericUpDown1.Value;
            DateTime tarih =dateTimeGiderTarih.Value;

            string giderler = "";

            foreach (Control item in groupBox1.Controls) //groupbox ın içindeki controlleri geziyor
            {
                if (item is CheckBox && ((CheckBox)item).Checked) //item checkbox ve chaked edildiyse ismi string ifadeye atar.
                {
                    giderler = "," + item.Text; 
                }
            }

            giderler = giderler.Remove(0, 1);//en baştaki virgülü sildik

            SqlParameter p1 = new SqlParameter("Gider",giderler);
            SqlParameter p2 = new SqlParameter("Para", para);
            SqlParameter p3 = new SqlParameter("Tarih", tarih);

            

            sqlHelper.ExecuteProc("giderlerim",p1,p2,p3);
            
            GetGiderler();
            
            MessageBox.Show("Başarıyla Eklendi");

        }

        private void Giderler_Load(object sender, EventArgs e)
        {
            GetGiderler();
        }

        void GetGiderler() 
        {
            DataTable dt = sqlHelper.GetTable("select * from Gider_Tablosu");
            
            lBoxGider.Items.Clear();
            lBoxTutar.Items.Clear();
            lBoxTarih.Items.Clear();

            foreach (DataRow item in dt.Rows)
            {
                lBoxGider.Items.Add(item[3]).ToString();
                lBoxTutar.Items.Add(item[1]).ToString();
                lBoxTarih.Items.Add(item[2]).ToString();
            }
        }
    }
}
