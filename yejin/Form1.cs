using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yejin
{
    public partial class Form1 : Form
    {
        static private List<idle> idles = new List<idle>()
        {
            new idle(){ Name = "미연", Age = 27, position = "보컬"},
            new idle(){ Name = "민니", Age = 27, position = "보컬"},
            new idle(){ Name = "소연", Age = 26, position = "랩"},
            new idle(){ Name = "우기", Age = 25, position = "댄스"},
            new idle(){ Name = "슈화", Age = 24, position = "댄스"}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           idleBindingSource.DataSource = idles;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idleBindingSource.DataSource = from item in idles
                                           orderby item.Age ascending
                                           select item;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            idleBindingSource.DataSource = from item in idles
                                           where item.position == "보컬"
                                           select item;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            idleBindingSource.DataSource = from item in idles
                                           where item.position == "랩"
                                           select item;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            idleBindingSource.DataSource = from item in idles
                                           where item.position == "댄스"
                                           select item;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
