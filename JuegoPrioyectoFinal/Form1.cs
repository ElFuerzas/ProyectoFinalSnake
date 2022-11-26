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

namespace JuegoPrioyectoFinal
{
    public partial class JuegoSerpiente : Form
    {


        int seconds = 3;
        String Perdida ;
        public JuegoSerpiente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botonStart_Click(object sender, EventArgs e)
        {
            seconds = 3;
            
            timer1.Start();
        }

        private void JuegoSerpiente_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.DoEvents();
        }

        private void JuegoSerpiente_Load(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tiempo.Text = seconds--.ToString();
            if(seconds < 0)
            {
                mensajePerdida1.Text = "Perdiste, Sorry";
                timer1.Stop();

                
            }
            
        }


    }
}
