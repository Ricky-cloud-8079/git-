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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str路徑 = @"C:\Users\iii\Desktop\RickyClass後端\C#\";
            Random myRnd = new Random();
            int myNum = myRnd.Next(1000, 9999);
            string str檔名 = DateTime.Now.ToString("yyMMddHHmmss") + myNum.ToString() + @"訂購檔.txt";
            string 完整路徑檔 = str路徑 + str檔名;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = str路徑;
            sfd.InitialDirectory = str路徑;
            sfd.FileName = str檔名;
            sfd.Filter = "Txt File|*.txt";
            DialogResult R = sfd.ShowDialog();
            if (R == DialogResult.OK)
            {
                完整路徑檔 = sfd.FileName;
            }
            else
            {
                return;
            }
            List<string> lines訂購資訊 = new List<string>();

            lines訂購資訊.Add("******資策會點餐訂購單******");
            lines訂購資訊.Add("===========================");

            lines訂購資訊.Add("----------------------------");
            lines訂購資訊.Add("<<訂購品項>>");


            lines訂購資訊.Add("--------------------------------------");

            lines訂購資訊.Add("===========================");

            System.IO.File.WriteAllLines(完整路徑檔, lines訂購資訊, Encoding.UTF8);
            MessageBox.Show("存檔成功");
        }
    }
}
