using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace _3_layer_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BL.BL b = new BL.BL();
            b.Project_Num = textBox1.Text;
            b.Auto_ID = textBox2.Text;
            b.Auto_Date = textBox3.Text;
            b.Addr = textBox4.Text;
            b.ADD();
            Form1_Load(null, null);
            MessageBox.Show("Saved");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BL.BL bl = new BL.BL();
            DataTable dt = bl.SHOWDATA();
            dataGridView1.DataSource = dt;
            //Form1_Load(null, null);

        }
    }
}
