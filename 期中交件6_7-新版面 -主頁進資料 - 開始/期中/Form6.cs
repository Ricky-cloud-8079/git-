using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中
{
    public partial class Form6 : Form
    {

        int account = 0, pwd=0 , 權限=0;//0管1學2值
        string name="王大錘";
        public Form6()
        {
            InitializeComponent();
           
        }
        private void Form6_Load(object sender, EventArgs e)
        {

           
        }

        private void btn登入materialButton1_Click(object sender, EventArgs e)
        {


        }
        int ii = 0;
        private void btn登入_Click(object sender, EventArgs e)
        {

            if (materialSingleLineTextField2.Text == account.ToString() && materialTextBox2.Text==pwd.ToString())
            {
                ii = 1;
                string Authority="";
                switch (權限) { case 0: Authority = "管理者"; break; case 1: Authority = "學員"; break; case 2: Authority = "值日生"; break; }
                MessageBox.Show($"{Authority}:{name} 歡迎登入!");
                this.Close();
            }
            else
            {
                MessageBox.Show("編號或密碼錯誤!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ii==0) { 
            e.Cancel = true;
            MessageBox.Show("請登入系統");
            }
            else{ e.Cancel = false; }
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void materialSingleLineTextField2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
