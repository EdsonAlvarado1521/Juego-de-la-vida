using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form

    {
        int contador = 0;
        
        Tablero t;
        int tam = 0;
        public Form1()
        
        {
            InitializeComponent();
            t = new Tablero(10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
               
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
        
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            t.Dibuja(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.next();
            t.update();
            this.Invalidate();
            contador = contador+1;
            
            label2.Text = Convert.ToString(contador);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tam = int.Parse(comboBox1.Text);
           
            t = new Tablero(tam);
            this.Refresh();
            contador = 0;
            label2.Text = Convert.ToString(contador);

           
        }
    }
}
