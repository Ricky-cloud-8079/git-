using System;
using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class Form5 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public Form5()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink400, Primary.Pink500, Primary.Pink100, Accent.Pink200, TextShade.WHITE);

            //主色,主元件色,主元件hover



        }

        private void materialCard7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialExpansionPanel1_SaveClick(object sender, EventArgs e)
        {
            MessageBox.Show("btn2");
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (分權標籤materialLabel5.Text == "管理者")
            {
                btn管理系統materialButton21.Visible = true;
            }
            else { btn管理系統materialButton21.Visible = false; }

            訂購單ExpansionPanel1.BorderStyle = BorderStyle.FixedSingle;
            訂購單ExpansionPanel1.Collapse = true;
            richTextBox1備註.BorderStyle = BorderStyle.FixedSingle;
        }

        private void materialFloatingActionButton2_Click(object sender, EventArgs e)
        {
            訂購單ExpansionPanel1.Collapse = false;
            訂購單ExpansionPanel1.Visible = true;

           // 訂購單ExpansionPanel1.BringToFront();
            //  Controls.SetChildIndex(訂購單ExpansionPanel1, 0);
            //Panel panelBack = new Panel();
            //panelBack.Visible = true;
            //panelBack.BackColor = Color.Black;
            //panelBack.Size=new  Size(206, 119);
            //panelBack.BringToFront();
            //panelBack.Visible = true;
            // panelBack.BackColor = Color.Gray;
            // panelBack.
            //panelBack.Size=new  Size(800, 200);
            //panelBack.BackColor = Color.Transparent;
            //panelBack.BringToFront(); 
            //訂購單ExpansionPanel1.BringToFront();

            訂購單ExpansionPanel1.BorderStyle = BorderStyle.FixedSingle;
            
        }

        private void materialSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch2.Checked)
            {
                materialCard16.Visible = true;
                panel1.Enabled = false;
            }
            else
            {
                materialCard16.Visible = false;
                panel1.Enabled = true;

            }
        }





        //區間條
        int progess;
        private void materialButton19_Click(object sender, EventArgs e)
        {
            if (progess != 500)
            {
                materialProgressBar1.Value = Math.Min(materialProgressBar1.Value + 5, 100);
                progess += 50;
                materialLabel55.Text = "NT$" + progess;
            }

        }
        private void materialButton17_Click(object sender, EventArgs e)
        {
            if (progess != 0)
            {
                materialProgressBar1.Value = Math.Max(materialProgressBar1.Value - 5, 0);
                progess -= 50;
                materialLabel55.Text = "NT$" + progess;
            }
            Console.WriteLine(materialProgressBar1.Value);
        }






        private void 上次訂購materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (上次訂購materialSwitch1.Checked)
            {

                panel1.Enabled = false;
            }
            else
            {

                panel1.Enabled = true;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        bool heartCheck = false;
        private void pictureBox5_Click(object sender, EventArgs e)
        {

            if (heartCheck==false)
            {
                pictureBox5.Image = Properties.Resources.icons8_heart_96; //路徑
                heartCheck = true;
              //  var mresult = MaterialMessageBox.Show("已加入收藏!!");
                MessageBox.Show("已加入收藏!!");
            }
            else
            {
                pictureBox5.Image = Properties.Resources.baseline_favorite_border_black_24dp;
                heartCheck = false;
            }
        }

        private void 訂購單ExpansionPanel1_Paint(object sender, PaintEventArgs e)
        {
            MessageBox.Show("123");
        }

        private void materialButton15送出訂購單_Click(object sender, EventArgs e)
        {
            MessageBox.Show("訂購成功!");
        }
    }
}
