using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenci_not_kayit
{
    public partial class Frmogrtmgirs : Form
    {
        public Frmogrtmgirs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (maskedTextBox1.Text == "1111")
            {
                Frmogretmendetay f1 = new Frmogretmendetay();
                f1.Show();

            }
            }
    }
}
