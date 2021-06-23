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

        public int account = 0, pwd = 0, 權限 = 0, id = 0;
        //0管1學2值
        //test
        public string name = "XXX";
        public string Authority = "";
        Form5 form5 = new Form5();

        public Form6()
        {
            InitializeComponent();

        }
        private void Form6_Load(object sender, EventArgs e)
        {
            form5.Visible = true;
            // form5.opStart = false;

           
        }



        public  string 接值 { get { return ""; }set { materialSingleLineTextField2.Text = value; } }

        private void btn登入materialButton1_Click(object sender, EventArgs e)
        {


        }
        int ii = 0;
        private void btn登入_Click(object sender, EventArgs e)
        {


            account = Convert.ToInt32(materialSingleLineTextField2.Text); 

            switch (account) { case 1: account = 1; 權限=1; pwd = 0; name="王小明"; break; case 6: account = 6; 權限 = 0; pwd = 1111; name = "阿明"; break; case 2: account=2; pwd = 123; 權限 = 2; name = "黃小貓"; break; }


            if (materialSingleLineTextField2.Text == account.ToString() && materialTextBox2.Text == pwd.ToString())
            {
                ii = 1;
                switch (權限) { case 0: Authority = "管理者"; break; case 1: Authority = "學員"; break; case 2: Authority = "值日生"; break; }
                MessageBox.Show($"{Authority}:{name} 歡迎登入!");
                form5.Status = true;
                form5.Visible = false;

                form5.opStart = true;

                if (chk記憶materialCheckbox16.Checked==false)
                {
                    materialSingleLineTextField2.Text = "";
                    
                }
                

                materialTextBox2.Text = "";
                this.Visible = false;
                form5.接值2(materialSingleLineTextField2.Text);
                form5.接值(Authority);
                form5.ShowDialog();
                Close();

            }
            else
            {
                MessageBox.Show("編號或密碼錯誤!");
            }





        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chk記憶materialCheckbox16_CheckedChanged(object sender, EventArgs e)
        {
            if (chk記憶materialCheckbox16.Checked)
            {
                form5.Status = true;
            }
            
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ii == 0)
            {
                
                DialogResult R=MessageBox.Show("確認離開?", "登出",MessageBoxButtons.YesNo);
                if (R == DialogResult.No) { e.Cancel = true; } else { e.Cancel = false; }
            }
            else if (ii==1)
            {
                
                e.Cancel = false;
            }
            else { e.Cancel = false; }
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void materialSingleLineTextField2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
