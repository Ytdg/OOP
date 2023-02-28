using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
       int x, y;
       


        public Form1()
        {
            InitializeComponent();
        }
        
        private void vh_button_Click(object sender, EventArgs e)
        {
            try
            {
                DrawVag[] count_vg = new DrawVag[Convert.ToInt32(Count_Vg.Text)];
                x = 100;
                y = 100;
                for (int i = 0; i <count_vg.Length; i++)
                {
                    count_vg[i] = new DrawVag(x, y);
                    count_vg[i].Draw(this.CreateGraphics());
                    x = x + 500;


                }


            }
            catch { Count_Vg.Text = "Error"; }
        }
    }
}
