using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yas = Convert.ToInt32(textBox1.Text);
            if(radioButton1.Checked==true)
            {
                if(yas>=18)
                {
                    label3.Text="Merhaba Beyefendi,hoş geldiniz! ";
                }
                else
                {
                    label3.Text = "Yaşınız Küçük,Erişim İzniniz Yok.";
                }
            }
           

            if (radioButton2.Checked==true)
            {
                if(yas>=18)
                {
                    label3.Text = "Merhaba Hanımefendi,hoş geldiniz!";
                }
                else
                {
                    label3.Text = "Yaşınız Küçük,Erişim İzniniz Yok.";
                }
            }
          
         

        }
    }
}
