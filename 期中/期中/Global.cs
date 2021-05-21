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
            SHOP.Add(s); PRODUCT.Add(p); COUNT.Add(c); Customer.Add(cus);Class.Add(classCount);
            for (int i = 0; i < SHOP.Count(); i++) {
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
            foreach (var item in list各店[0])
            {
                Console.WriteLine(item);
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
      


        //for (int i = 0; i < 品冠N.Count(); i++)
        //{
        //    list1.Add(品冠N[i] + $"\t${P1[i]}");
        //    品冠數量[i]=0;
        //    //傳入索引+數量

        //}
        //for (int i = 0; i < 正忠N.Count(); i++)
        //{
        //    list2.Add(正忠N[i] + $"\t${P2[i]}");
        //    正忠數量[i] = 0;

        //}
        //for (int i = 0; i < 太師傅N.Count(); i++)
        //{
        //    list3.Add(太師傅N[i] + $"\t${P3[i]}");
        //    太師傅數量[i] = 0;
        //};


        //價格必須另外算 不抓字串 就用變數
        //按下預覽 量累加
        //
        //按下訂單 抓 個別餐量累加 不抓UI 傳日期

        //班統計=個人+餐+量+價綁訂餐索引*量
        //


        //方法 遍歷店餐點 量>0 抓出來顯示店統計
        //indexof>0



        //foreach (var item in 品冠數量)
        //{
        //    Console.WriteLine(item);

        //}

        //Console.WriteLine(店家P[0][0]);

        //list陣列.Add(店家P);//0
        //list陣列.Add(店家N);//1

        //Console.WriteLine(list陣列[0]);
        //複製到空list取索引

        // list整合.Add(list陣列);
        // Console.WriteLine(list整合[0][0]);
        //最終目的是一行取所有值 p+n
















        //三維List

        // List<List<List<string>>> 店家 = new List<List<List<string>>>();

        //一維list+二維店家+三維值



        //三維Array //每列不固定,不能work
        //[][,]



        //店家Name[0] 店家N[0][i] 店家P[0][i]

        //public void Load2()
        //{
        //    //foreach (string s in 店家 ) 
        //    //{
        //    //ArrayList s = new ArrayList();
        //    //};
        //    //for (int i = 0; i < 店家.Length; i++)
        //    //{
        //    //    string shop = 店家[i];
        //    //    ArrayList shop = new ArrayList();
        //    //}
        //    //ArrayList 店家資料 = new ArrayList();

        //    //店家資料.Add(品冠N);//0
        //    //店家資料.Add(P1);//1


        //    //店家資料[0][1];
        //}


        // 三一維Array

        //public static int[] P1 = { 75, 80, 70, 65, 85, 75, 80 },
        //                     P2 = { 75, 80, 70, 60, 95, 80,100 },
        //                     P3 = { 85, 90, 50, 78, 65, 50 };


        //public static string[]品冠N = { "滷雞腿便當", "炸雞腿便當", "烤雞翅便當", "鹹豬肉便當", "炸魚排便當", "紅茶\t", "麥茶\t" },
        //                       正忠N = { "香雞排飯", "香酥排骨飯", "鹽酥雞丁飯", "宮保雞丁飯","鹹豬肉便當", "炸魚排便當", "G腿飯\t" },
        //                       太師傅N = { "鹽酥大雞腿飯", "烤醬香雞排飯", "椒麻香雞排飯", "檸檬去骨雞腿", "和風排骨雞腿", "宮保雞丁飯" };


        //public static string[] 店家 = {"品冠便當店","正忠排骨飯","太師傅便當" };

        //public static int[] 品冠數量 = new int[品冠N.Length];
        //public static int[] 正忠數量 = new int[正忠N.Length];
        //public static int[] 太師傅數量 = new int[太師傅N.Length];



        //public static List<Array> list店家 = new List<Array>();
        //public static List<List<Array>> list整合 = new List<List<Array>>();


        //public static List<string> list店家統計2 = new List<string>();
        //public static List<ArrayList> list班級集合 = new List<ArrayList>();










        //統計


        // int count =0;



    }
}
