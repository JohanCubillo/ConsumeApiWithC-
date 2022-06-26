using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Http;


namespace GUI_MODERNISTA
{
    public partial class Mercados : Form 
    {
      

        public Mercados()
        {
            InitializeComponent();
        }

        private void Mercados_Load(object sender, EventArgs e)
        {
            
        }

        private void btnrptpagos_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Billetera bil = new Billetera();
            bil.Show();

        }


  

        


        private void label5_Click(object sender, EventArgs e)
        {
          
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProximaCripto furby = new ProximaCripto();
            furby.Show();
            
    }
    }
}
