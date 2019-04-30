using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping_pong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Left)
            //    label_titulo.Location = new Point(label_titulo.Location.X - 10, label_titulo.Location.Y);

            //if (e.KeyCode == Keys.Right)
            //    label_titulo.Location = new Point(label_titulo.Location.X + 10, label_titulo.Location.Y);

            //if (e.KeyCode == Keys.Up)
            //    label_titulo.Location = new Point(label_titulo.Location.X, label_titulo.Location.Y - 10);

            //if (e.KeyCode == Keys.Down)
            //    label_titulo.Location = new Point(label_titulo.Location.X, label_titulo.Location.Y + 10);

            if (e.KeyCode == Keys.Down)
                barra_derecha.Location = new Point(barra_derecha.Location.X, barra_derecha.Location.Y + 20);

            if (barra_derecha.Bottom >= 575)
            {
                barra_derecha.Top = 425;
            }

            if (e.KeyCode == Keys.Up)
                barra_derecha.Location = new Point(barra_derecha.Location.X, barra_derecha.Location.Y - 20);

            if(barra_derecha.Top <= 0)
            
                barra_derecha.Top = 0;

            if (e.KeyCode == Keys.S)
                barra_izquierda.Location = new Point(barra_izquierda.Location.X, barra_izquierda.Location.Y + 20);

            if (barra_izquierda.Bottom >= 575)
            {
                barra_izquierda.Top = 425;
            }


            if (e.KeyCode == Keys.W)
                barra_izquierda.Location = new Point(barra_izquierda.Location.X, barra_izquierda.Location.Y - 20);

            if (barra_izquierda.Top <= 0)

                barra_izquierda.Top = 0;


        }

        
    }
}
