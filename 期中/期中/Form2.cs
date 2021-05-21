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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Global Global = new Global();
        bool load店家;

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (string item in Global.班級) { comboBox班級.Items.Add(item); }
            comboBox班級.SelectedIndex = 0;
            foreach (string item in Global.店家Name) { comboBox店家.Items.Add(item); load店家 = false; }
            load店家 = true;
            comboBox店家.SelectedIndex = 0;
            //foreach (string item in Global.Customer) { comboBox人.Items.Add(item); }
            //comboBox人.SelectedIndex = 0;

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        void 店家選擇(int index)
        {
            checkedListBox2.Items.Clear();
            
            foreach (var item in Global.list各店[comboBox店家.SelectedIndex])
            {
                checkedListBox2.Items.Add(item);
            }
        }
        private void comboBox班級_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            foreach (var item in Global.list各班[comboBox班級.SelectedIndex])
            {
                checkedListBox1.Items.Add(item);
            }
         
        }

        private void button4_Click(object sender, EventArgs e)
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
          //  lines訂購資訊.Add(DateTime.Now.ToString() + "  訂購人" + GlobalVar.訂購人);
            lines訂購資訊.Add("----------------------------");
            lines訂購資訊.Add("<<訂購品項>>");

            //if (GlobalVar.list訂購品項列表.Count > 0)
            //{
            //    foreach (ArrayList 訂購item in GlobalVar.list訂購品項列表)
            //    {
            //        
            //        string str品項資訊 = string.Format("{0}{1}杯 單價{2} {3} {4}", 品項, 數量, 單價, 甜度, 冰塊);/
            //        lines訂購資訊.Add(str品項資訊);
            //    }

            //}

            lines訂購資訊.Add("--------------------------------------");
           // lines訂購資訊.Add("總價:" + 計算訂單總價().ToString());
            lines訂購資訊.Add("===========================");

            System.IO.File.WriteAllLines(完整路徑檔, lines訂購資訊, Encoding.UTF8);
            MessageBox.Show("存檔成功");
        }

        private void comboBox店家_SelectedIndexChanged(object sender, EventArgs e)
        {
            int slindex = comboBox店家.SelectedIndex;
            while (load店家) { 店家選擇(slindex); break; }
        }

        private void comboBox人_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foreach (var item in Global.list訂購人集合[comboBox人.SelectedIndex]) {
            //    comboBox人.Items.Add(item);

            //}

            //foreach (var item in Global.Customer) //
            //{

            //    foreach (var itttttt in comboBox人.Items) { 
            //        // Console.WriteLine(comboBox人.Items[i]);
            //        if (item != itttttt)
            //        {
            //            comboBox人.Items.Add(item);
            //        }
            //    }
            //}
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkedListBox2.Items.Clear();

        }
    }
    
}
