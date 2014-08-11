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
        public Form1()
        {
            InitializeComponent();
        }
        List<igrac> lista = new List<igrac>();

        private void button2_Click(object sender, EventArgs e)
        {
            string cur = listBox1.SelectedItem.ToString();
            int index = listBox1.FindString(cur);
            label2.Text = lista[index].DajRezultat().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            igrac i = new igrac(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            lista.Add(i);
            listBox1.Items.Add(i.DajIme());
        }
    }
}
