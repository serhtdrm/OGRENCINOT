﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ogrenci_not_kayit
{
    public partial class Frmgiris : Form
    {
        public Frmgiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmogrencidetay frm = new Frmogrencidetay();
            frm.numara = maskedTextBox1.Text;
            frm.Show();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Frmgiris_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbNotKayıtDataSet1.TBLDERS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet1.TBLDERS);

        }

        private void label2_Click(object sender, EventArgs e)
        {
                Frmogrtmgirs fr1 = new Frmogrtmgirs();
                fr1.Show();
            
        }
    }
}
