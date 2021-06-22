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
using System.Threading;
using Timer = System.Windows.Forms.Timer;

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
            
            

            訂購單ExpansionPanel1.Size = new Size(800, 787);
            訂購單ExpansionPanel1.Collapse = true;
            訂購單ExpansionPanel1.ExpandHeight = 787;
            materialCard收藏.Visible = false;
            materialCard收藏.Size = new Size(1397,901);
            materialCard收藏.Location = new Point(1726,196); materialCard篩選.Location = new Point(0, 196); materialCard主頁.Location = new Point(450, 196);


        }

        private void materialCard7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialExpansionPanel1_SaveClick(object sender, EventArgs e)
        {
            MessageBox.Show("btn2");
        }

        Timer timer = new Timer();

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Visible = true;
            this.Opacity =0.8;
            this.AutoScroll = false;
            Form6 form6 = new Form6();
            form6.ShowDialog();
            this.WindowState = FormWindowState.Maximized;
            materialCard收藏.Location = new Point(1726, 196); materialCard篩選.Location = new Point(0, 196); materialCard主頁.Location = new Point(450, 196);
            btn管理系統materialButton21.Visible = false;
            btn管理系統materialButton21.DrawShadows = false;
            值日生materialButton5.Visible = false;
            值日生materialButton5.DrawShadows = false;
            btn班級單materialButton5.Visible = false; btn班級單materialButton5.Visible = false;

            分權標籤materialLabel5.Text = form6.Authority;

            if (分權標籤materialLabel5.Text == "管理者")
            {
                btn管理系統materialButton21.Visible = true;
                btn管理系統materialButton21.DrawShadows = true;

            }
            else if (分權標籤materialLabel5.Text == "值日生") 
            {
                值日生materialButton5.DrawShadows = true;值日生materialButton5.Visible = true;
                btn班級單materialButton5.Visible = true;btn班級單materialButton5.Visible = true;
            }
            else {
                分權標籤materialLabel5.Location = new Point(17, 47);
            }

            訂購單ExpansionPanel1.BorderStyle = BorderStyle.FixedSingle;
            訂購單ExpansionPanel1.Size = new Size(800,787);
            訂購單ExpansionPanel1.Collapse = true;
            訂購單ExpansionPanel1.ExpandHeight = 787;
            richTextBox1備註.BorderStyle = BorderStyle.FixedSingle;

            timer.Tick += tick1;
            timer.Interval = 40; // 1 second
            this.Opacity = 0.001;
            timer.Start();

        }
            

         
      
        private void tick1(object sender, EventArgs e)
        {
             this.Opacity += 0.06;
            if (this.Opacity==1.0)
            {
                timer.Stop();
            }
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


        //收藏check
        private void materialSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch2.Checked)
            {
                materialCard收藏.Location = new Point(450, 183);

                materialCard收藏.Visible = true;
                panel1.Enabled = false;
            }
            else
            {
                materialCard收藏.Visible = false;
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

        private void btn班級單materialButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
