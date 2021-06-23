using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
using System.Collections;

namespace 期中
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Global Global = new Global();//non static
        List<ArrayList> list店家選擇 = new List<ArrayList>();
        List<string> list班級 = new List<string>();
        List<string> list店家 = new List<string>();
        bool load店家;
        


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'mydbDataSet1.products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter.Fill(this.mydbDataSet1.products);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";

            foreach (var item in Global.班級) {list班級.Add(item);}
            foreach (var item in Global.店家Name){list店家.Add(item);}        
            Global.Load();
            list店家選擇 = Global.list店家統計;
            foreach (string item in list班級) {comboBox班級.Items.Add(item);}
            comboBox班級.SelectedIndex = 0;
            foreach (string item in list店家){comboBox店家.Items.Add(item);load店家 = false;}
            load店家 = true;
            comboBox店家.SelectedIndex = 0;



            WriteLine("測試-----------------------------------");

        }



        


        private void button4_Click(object sender, EventArgs e)
        {
            Form2 Form2訂購 = new Form2();

            if (Global.SHOP.Count().ToString() == "0") { MessageBox.Show("請先加入訂單!"); }
            else
            { Form2訂購.ShowDialog(); }
       
        }


        private void button加入預覽_Click(object sender, EventArgs e)
        {
            foreach (int index in checklist餐點.CheckedIndices) { //有check才加
                int shop = comboBox店家.SelectedIndex, product = index, count = (int)加入數量.Value;int Class=comboBox班級.SelectedIndex;
                int price = count * (Global.店家P[shop][product]); String C = textBox4.Text;
                Global.Load2暫存(shop, product, count, C, Class);
                checkedListBox預覽.Items.Add(list店家選擇[shop][product] + $"\t{count}份" + $"\t{price} 元");
            }

        }

        private void checkedListBox預覽_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button移除所選_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void checklist餐點_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        void 店家選擇(int index)
        {
            checklist餐點.Items.Clear();
            for (int a = 0; a < list店家選擇[index].Count; a++)
            {
                checklist餐點.Items.Add(list店家選擇[index][a]);
            }
            checklist餐點.SetItemChecked(0,true) ;
        }

            private void comboBox店家_SelectedIndexChanged(object sender, EventArgs e)//觸發店家選擇
        {
            int slindex = comboBox店家.SelectedIndex;
            while (load店家){ 店家選擇(slindex); break;}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Global.Load2清除();
            checkedListBox預覽.Items.Clear();
        }

        private void button加入訂單_Click(object sender, EventArgs e)

        {
            //  Console.WriteLine(checklist餐點.CheckedIndices.ToString());
            if (Global.SHOP.Count().ToString() == "0") 
            { MessageBox.Show("請先加入預覽!"); }
            else
            { Global.Load2暫存(); MessageBox.Show("加入成功!"); }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4();

            form4.ShowDialog(); 

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checklist餐點_DoubleClick(object sender, EventArgs e)
        {

        }

        private void 加入數量_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
