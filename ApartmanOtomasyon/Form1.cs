using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanOtomasyon
{
    public partial class formAnasayfa : Form
    {
        public formAnasayfa()
        {
            InitializeComponent();
        }

        private void btnGelirler_Click(object sender, EventArgs e)
        {
            new Gelirler().Show();
        }

        private void btnGiderler_Click(object sender, EventArgs e)
        {
            new Giderler().Show();
        }
    }
}
