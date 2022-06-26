using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    public partial class ProximaCripto : Form
    {

        System.Timers.Timer t;
        int s, h, m;
        public ProximaCripto()
        {
            InitializeComponent();
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProximaCripto_Load(object sender, EventArgs e)
        {

            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            
     
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(()=>{
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
            
            }));


        }

        private void button7_Click(object sender, EventArgs e)
        {
            t.Start();
            Application.DoEvents();
        }
    }
}
    
