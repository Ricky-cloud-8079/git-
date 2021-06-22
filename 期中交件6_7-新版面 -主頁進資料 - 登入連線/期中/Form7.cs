using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 
using Timer = System.Windows.Forms.Timer;


namespace 期中
{
    public partial class Form7 : Form
    {
        string myDBConnectionString = "";
        List<int> SearchIDs = new List<int>();
       
        public Form7()
        {
            InitializeComponent();
        }
        Timer timer = new Timer();


        private void Form7_Load(object sender, EventArgs e)
        {
           
          

            // TODO: 這行程式碼會將資料載入 'mydbDataSet2.學生' 資料表。您可以視需要進行移動或移除。
            this.學生TableAdapter1.Fill(this.mydbDataSet2.學生);
            cbox班級選擇.SelectedIndex = 0;
            cbox搜尋欄位.SelectedIndex = 0;
            listBox2學員.SelectedIndex = 0;
            listBox2學員.SelectedValue = 1;


            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;

            myDBConnectionString = scsb.ToString();
            this.Opacity = 0.8;
            timer.Tick += tick1;
            timer.Interval = 40;
            this.Opacity = 0.001;
            timer.Start();

        }


        private void tick1(object sender, EventArgs e)
        {
            this.Opacity += 0.06;
            if (this.Opacity == 1.0)
            {
                timer.Stop();
            }
        }
        private void 權限檢查(object a)
        {
            //  string aaa=a.ToString();
            //  if (aaa=="0") { 管理materialCheckbox1.Checked = true; }
            switch ((int)a) { case 0: 管理materialCheckbox1.Checked = true; break; case 2: 值日materialCheckbox2.Checked = true; break; case 1: break; default: break; }

        }

        private void btn新增_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txtEmail.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into 學生 values(@NewName,@NewAuthority,@NewPassword ,@NewPhone, @NewAddress, @NewEmail,@NewBirth,@NewClass);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewClass", cbox班級選擇.SelectedItem);
                int a;
                if (管理materialCheckbox1.Checked) { a = 0; } else if (值日materialCheckbox2.Checked) { a = 2; } else { a = 0; }


                cmd.Parameters.AddWithValue("@NewAuthority", a);
                cmd.Parameters.AddWithValue("@NewPassword", 0);



                int rows = cmd.ExecuteNonQuery();
                con.Close();//sop

                MessageBox.Show(rows.ToString() + "筆資料新增成功");
            }
            else
            {
                MessageBox.Show("姓名, Email 必填!");
            }
            this.學生TableAdapter1.Fill(this.mydbDataSet2.學生);
            學員listbox載入();
        }

        private void btn更新_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txtID.Text, out intID);
            this.學生TableAdapter1.Fill(this.mydbDataSet2.學生);
            學員listbox載入();


            if (intID > 0)
            {
                if ((txt姓名.Text != "") && (txtEmail.Text != ""))
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    //sql 更新語法 下指令
                    string strSQL = "update 學生 setstName=@NewName, 電話=@NewPhone, 地址=@NewAddress, email=@NewEmail, 生日=@NewBirth, stAuthority=@NewAuthority,班級=@NewClass, stPassword=@NewPassword where id=@SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    //補參數
                    cmd.Parameters.AddWithValue("@SearchID", intID);
                    cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                    cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                    cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                    cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@NewClass", cbox班級選擇.SelectedItem);
                    cmd.Parameters.AddWithValue("@NewBirth", dtp生日.Value);
                    int a;
                    if (管理materialCheckbox1.Checked) { a = 0; } else if (值日materialCheckbox2.Checked) { a = 2; } else { a = 0; }
                    cmd.Parameters.AddWithValue("@NewAuthority", a);



                    //筆數
                    int rows = cmd.ExecuteNonQuery(); //ExecuteNonQuery執行異動並傳回異動數量
                    con.Close();

                    MessageBox.Show(rows.ToString() + "筆資料修改成功");
                }
                else
                {
                    MessageBox.Show("姓名, Email 必填!");
                }
            }
        }

        private void btn筆數_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from 學生";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string strMsg = "";
            int i = 0;

            while (reader.Read())
            {
                strMsg += string.Format("{0} {1} {2}\t\t\t\n", reader["id"], reader["stName"], reader["班級"]);
                i += 1;

            }


            strMsg += "資料筆數:" + i.ToString();

            reader.Close();
            con.Close();

            MessageBox.Show(strMsg);
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            if (txt姓名.Text != "")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from 學生 where stName like @SearchName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", "%" + txt姓名.Text + "%");   //(參數名稱, 參數內容= %User輸入值% ) 加指令
                SqlDataReader reader = cmd.ExecuteReader();// 執行讀取器

                if (reader.Read())
                {
                    txtID.Text = string.Format("{0}", reader["id"]);
                    txt姓名.Text = string.Format("{0}", reader["stName"]);
                    txt電話.Text = string.Format("{0}", reader["電話"]);
                    txt地址.Text = string.Format("{0}", reader["地址"]);
                    txtEmail.Text = string.Format("{0}", reader["email"]);
                    string cb = string.Format("{0}", reader["班級"]);
                    if (cb == "java") { cbox班級選擇.SelectedIndex = 0; } else if (cb == "全端工程") { cbox班級選擇.SelectedIndex = 1; } else { cbox班級選擇.SelectedIndex = 2; }

                    權限檢查(reader["stAuthority"]);
                    dtp生日.Value = (DateTime)reader["生日"];

                    //.Checked = (bool)reader["stAuthority"];  



                }
                else    //reader.Read() 讀取false 表 找不到
                {
                    MessageBox.Show("查無此人");
                    txtID.Text = "";
                    txt姓名.Text = "";
                    txt電話.Text = "";
                    txt地址.Text = "";
                    txtEmail.Text = "";
                    dtp生日.Value = Convert.ToDateTime("1970-01-01");
                    值日materialCheckbox2.Checked = false;
                    管理materialCheckbox1.Checked = false;



                }
                reader.Close();
                con.Close();     //sop
            }
            else
            {
                MessageBox.Show("請輸入姓名搜尋");
            }
        }




        private void btn刪除_Click(object sender, EventArgs e)
        {
            int intID = 0;   //準備放ID
            Int32.TryParse(txtID.Text, out intID);   //ID 試轉整數
            


            if (intID > 0)  // 有ID 有資料存在再刪除 沒有會試轉失敗↑
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();                                 //SOP
                string strSQL = "delete from 學生 where id = @SearchID"; //查詢語法字串 user輸入參數化
                SqlCommand cmd = new SqlCommand(strSQL, con);  //指令SOP
                cmd.Parameters.AddWithValue("@SearchID", intID);   //增加指令SOP   字串strSQL補進參數

                int rows = cmd.ExecuteNonQuery();  //回傳受影響資料 "數目" 傳整數回來
                con.Close();   //SOP


                //刪除後清空
                txtID.Text = "";
                txt姓名.Text = "";
                txt電話.Text = "";
                txt地址.Text = "";
                txtEmail.Text = "";
                dtp生日.Value = Convert.ToDateTime("1970-01-01");
                值日materialCheckbox2.Checked = false;
                管理materialCheckbox1.Checked = false;

                MessageBox.Show(rows.ToString() + "筆資料刪除成功");
            }
            this.學生TableAdapter1.Fill(this.mydbDataSet2.學生);
            學員listbox載入();
        }

        private void 管理materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (管理materialCheckbox1.Checked) { 值日materialCheckbox2.CheckState = 0; }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void 值日materialCheckbox2_CheckedChanged(object sender, EventArgs e)
        {
            if (值日materialCheckbox2.Checked) { 管理materialCheckbox1.CheckState = 0; }
        }

        private void btn重載_Click(object sender, EventArgs e)
        {
            this.學生TableAdapter1.Fill(this.mydbDataSet2.學生);
            listBox2學員.SelectedIndex = 0;
            學員listbox載入();
        }

        



        private void btn進階_Click(object sender, EventArgs e)
        {
            lbox搜尋結果.Items.Clear(); 
            SearchIDs.Clear();              
            string strFieldName = cbox搜尋欄位.SelectedItem.ToString(); 

            if (txt搜尋字串.Text != "")
            {
                string strSQL = "select * from persons where (" + strFieldName + " like @SearchString) and (生日 >= @StartDate and 生日 <= @EndDate)"; // 所選欄位+ 搜尋條件
                //sop
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                //補參數
                cmd.Parameters.AddWithValue("@SearchString", "%" + txt搜尋字串.Text + "%");//搜尋內容
                cmd.Parameters.AddWithValue("@StartDate", dtp開始時間.Value);   
                cmd.Parameters.AddWithValue("@EndDate", dtp結束時間.Value);     

                SqlDataReader reader = cmd.ExecuteReader();    
                int i = 0; //筆數
                while (reader.Read())           //Read遍歷有讀到true =>  有找到的每筆 ID存進串列
                {
                    lbox搜尋結果.Items.Add(reader["姓名"] + "  " + reader["email"] + "  " + reader["電話"]);  //結果 讀入欄位 add Items             對應↓
                    
                    SearchIDs.Add((int)reader["id"]);       //結果ID 讀入欄位  add id串列                                                        key對應↑
                   
                    i += 1;
                }

                if (i <= 0) //沒讀到筆數 i<0    Read()=false
                {
                    MessageBox.Show("查無此人");
                }
                //sop
                reader.Close();
                con.Close();
            }
            else
            
            {
                MessageBox.Show("請輸入搜尋關鍵字");
            }
        }

        private void cbox搜尋欄位_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2學員_Click(object sender, EventArgs e)  
        {
            學員listbox載入();
        }



        void 學員listbox載入() {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from 學生 where id like @SearchName";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            int ID = 1;
            ID = (int)listBox2學員.SelectedValue;


            cmd.Parameters.AddWithValue("@SearchName", ID);   //參數.SqlCommand加入值(參數名稱, 參數內容= %User輸入值% )  增加指令
            SqlDataReader reader = cmd.ExecuteReader();// 執行讀取器

            if (reader.Read())
            {
                txtID.Text = string.Format("{0}", reader["id"]);
                txt姓名.Text = string.Format("{0}", reader["stName"]);
                txt電話.Text = string.Format("{0}", reader["電話"]);
                txt地址.Text = string.Format("{0}", reader["地址"]);
                txtEmail.Text = string.Format("{0}", reader["email"]);
                權限檢查(reader["stAuthority"]);
                dtp生日.Value = (DateTime)reader["生日"];
            }
            reader.Close();
            con.Close();     
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            Form5 form5 = new Form5();
        }
    }
}
