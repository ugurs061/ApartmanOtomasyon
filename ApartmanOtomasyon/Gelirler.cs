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
        SqlHelper sqlHelper=new SqlHelper();//sqlHelper içindeki metodları kullanmak için newliyoruz.
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //değişkenler tanımlama 
            int daireno= Convert.ToInt32(comboBoxDaireNo.Text);
            int para = (int) numericUDTutar.Value;
            DateTime tarih = dateTimeGelirlerTarih.Value;

            //sqle gidecek parametreler oluşturuldu.

            SqlParameter p1 = new SqlParameter("Daireno",daireno);
            SqlParameter p2 = new SqlParameter("Para", para);
            SqlParameter p3 = new SqlParameter("Tarih",tarih);

            sqlHelper.ExecuteProc("aidat", p1, p2, p3);//parametreleri prosüdurlara gönderdik
            
            GetGelirler(); //her eklediğimizde verilerin gözükmesi için
            
            MessageBox.Show("Başarıyla Eklendi");


        }

        private void Gelirler_Load(object sender, EventArgs e)
        {
            GetGelirler();

        }

        void GetGelirler() 
        {

            DataTable dataTable = sqlHelper.GetTable("select * from AidatOdemesi");//sqlHelperdaki hazırladığımız GetTable metoduna sorgu gönderdik.

            //listbox her eklendiğinde temizleniyor.
            lBoxDaireNo.Items.Clear();
            lBoxTutar.Items.Clear();
            lBoxTarih.Items.Clear();
            
            foreach (DataRow item in dataTable.Rows) //tablomdaki her satırı gezecek ve listboxa ekleyecek.
            {
                
                lBoxDaireNo.Items.Add(item["DaireNo"]).ToString();
                lBoxTutar.Items.Add(item["Para"]).ToString();
                lBoxTarih.Items.Add(item["Tarih"]).ToString();
            }
        }

    }
}
