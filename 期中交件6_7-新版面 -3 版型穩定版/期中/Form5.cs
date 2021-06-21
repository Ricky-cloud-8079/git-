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
            }
            else { 
                materialCard16.Visible = false;

            }
        }
    }
}
