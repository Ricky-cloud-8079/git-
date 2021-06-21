using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace 期中
{
    class Global
    {//原始值
        //雙二維鋸齒
        public static int[][] 店家P = {
                           new int[] { 75, 80, 70, 65, 85, 75, 80 },
                             new int[]  { 75, 80, 70, 60, 95, 80},
                                new int[]   { 85, 90, 50, 78, 65, 50}};

        public static string[][] 店家N = {
                        new string[] { "滷雞腿便當", "炸雞腿便當", "烤雞翅便當", "鹹豬肉便當", "炸魚排便當", "紅\t茶", "麥\t茶  " },
                            new string[]  { "香雞排飯", "香酥排骨飯", "鹽酥雞丁飯", "鹹豬肉便當", "炸魚排便當", "宮保雞丁飯" },
                               new string[]  { "鹽酥大雞腿飯", "烤醬香雞排飯", "椒麻香雞排飯", "檸檬去骨雞腿", "和風排骨雞腿", "宮保雞丁飯" } };

        public static string[] 店家Name = { "品冠便當店", "正忠排骨飯", "太師傅便當" };
        public static string[] 班級 = { "JAVA班級", "全端班級", "全方位IT班" };

        //改丟SQL  ↑

        private static ArrayList list1 = new ArrayList(); ArrayList list2 = new ArrayList(); ArrayList list3 = new ArrayList();

        public static List<ArrayList> list店家統計 = new List<ArrayList>();
        public static List<List<string>> list各班 = new List<List<string>>(); public static List<List<string>> list各店 = new List<List<string>>();
        public static List<string> list班級集合 = new List<string>(); public static List<string> list班級集合2 = new List<string>(); public static List<string> list班級集合3 = new List<string>(); public static List<List<string>> list訂購人集合 = new List<List<string>>(); public static List<string> list訂購人每筆 = new List<string>(); public static List<string> list店家集合 = new List<string>(); public static List<string> list店家集合2 = new List<string>(); public static List<string> list店家集合3 = new List<string>();
        
        public List<int> SHOP = new List<int>(); public List<int> PRODUCT = new List<int>(); public List<int> COUNT = new List<int>(); public List<int> Class = new List<int>();
        public static List<String> Customer = new List<String>(); public List<int> Price = new List<int>();




        public void Load()
        { list店家統計.Add(list1); list店家統計.Add(list2); list店家統計.Add(list3);
            for (int k = 0; k < 店家P.Count(); k++)
            {
                for (int i = 0; i < 店家P[k].Count(); i++)
                {
                    list店家統計[k].Add(店家N[k][i] + "\t" + 店家P[k][i] + "元"); //  UI
                }
            }
        }
        public void Load2暫存(int s, int p, int c, string cus,int classCount)
        {
            SHOP.Add(s); PRODUCT.Add(p); COUNT.Add(c); Customer.Add(cus);Class.Add(classCount);//每筆存放
            for (int i = 0; i < SHOP.Count(); i++) {//幾筆跑幾次
                int price = COUNT[i] * (店家P[SHOP[i]][PRODUCT[i]]);
                Price.Add(price);
            }
        }
        public void Load2清除() {
            SHOP.Clear();
        }
        public void Load2暫存()//btn add 
        {
            for (int i = 0; i < SHOP.Count; i++)//3份 012
            {
                list訂購人每筆.Add(Customer[i]+list店家統計[SHOP[i]][PRODUCT[i]] + $"\t\t{COUNT[i]}份" + $"{Price[i]} 元");
                switch (Class[i])
                {
                    case 0:
                        list班級集合.Add(list店家統計[SHOP[i]][PRODUCT[i]] + $"\t\t{COUNT[i]}份" + $"{Price[i]} 元");
                        break;
                    case 1:
                        list班級集合2.Add(list店家統計[SHOP[i]][PRODUCT[i]] + $"\t\t{COUNT[i]}份" + $"{Price[i]} 元");
                        break;
                    case 2:
                        list班級集合3.Add(list店家統計[SHOP[i]][PRODUCT[i]] + $"\t\t{COUNT[i]}份" + $"{Price[i]} 元");
                        break;
                    default: break;
                }
                switch (SHOP[i])
                {
                    case 0:
                        list店家集合.Add(list店家統計[SHOP[i]][PRODUCT[i]] + $"\t\t{COUNT[i]}份" + $"{Price[i]} 元");
                        break;
                    case 1:
                        list店家集合2.Add(list店家統計[SHOP[i]][PRODUCT[i]] + $"\t\t{COUNT[i]}份" + $"{Price[i]} 元");
                        break;
                    case 2:
                        list店家集合3.Add(list店家統計[SHOP[i]][PRODUCT[i]] + $"\t\t{COUNT[i]}份" + $"{Price[i]} 元");
                        break;
                    default: break;
                }
            }
            list訂購人集合.Add(list訂購人每筆);
            list各班.Add(list班級集合); list各班.Add(list班級集合2); list各班.Add(list班級集合3);
            list各店.Add(list店家集合); list各店.Add(list店家集合2); list各店.Add(list店家集合3);
            //
            Console.WriteLine("測試集合----------------");

            foreach (var item in list各班[0])
            {
                Console.WriteLine(item);
               // Console.WriteLine(SHOP.Count().ToString());

            }
        }
        public void Load2暫存(int Class, int 人)
        {
           
            
        }
    public void Load2暫存(int index) {  
            switch (index) {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break; default:break;
            }
        }
      





    }
}
