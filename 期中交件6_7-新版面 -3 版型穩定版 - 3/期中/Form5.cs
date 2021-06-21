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
            
        }

        private void materialFloatingActionButton2_Click(object sender, EventArgs e)
        {
            訂購單ExpansionPanel1.Collapse = false;
        }

        private void materialSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch2.Checked)
            {
                materialCard16.Visible = true;
                panel1.Enabled = false;
            }
            else { 
                materialCard16.Visible = false;
                panel1.Enabled = true;

            }
        }
        int progess;
        private void materialButton19_Click(object sender, EventArgs e)
        {
            if (progess != 500)
            {
                materialProgressBar1.Value = Math.Min(materialProgressBar1.Value + 5, 100);
                progess += 50;
                materialLabel55.Text = "NT$"+progess;
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
    }
}
