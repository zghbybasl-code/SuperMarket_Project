using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_Project
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

   

     

        
       
        private void button2_Click_1(object sender, EventArgs e)
        {    //if  الكومبوا بوكس او تيكست بوكس فاضي
            if (string.IsNullOrWhiteSpace(CmbMeal.Text)|| string.IsNullOrWhiteSpace(TxtCount.Text)|| string.IsNullOrWhiteSpace(TxtID.Text) || string.IsNullOrWhiteSpace(TxtPrice.Text))
            {

                MessageBox.Show("Error Pls Enter ID Product or Count Product Or Choose The Prouduct ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(TxtName.Text) || string.IsNullOrWhiteSpace(CmbSite.Text))
            {

                MessageBox.Show("Error Pls Enter a Name or this Site", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            //File Handling
            OrderLogic neworder = new OrderLogic();
            neworder.Name = TxtName.Text;
            neworder.ID=TxtID.Text;
            neworder.CmbMeal = CmbMeal.Text;
            neworder.Count = TxtCount.Text;
            neworder.Price = TxtPrice.Text;
            neworder.cmbSite = CmbSite.Text;
            neworder.CmbDrink=CmbDrink.Text;
            neworder.TxtCount2 = TxtCount2.Text;
            neworder.savefile();

            //Data Grade View 
            string Name = TxtName.Text;
            string Site=CmbSite.Text.ToString();
            string Meals=CmbMeal.Text.ToString();
            string ID = TxtID.Text;
            string CountMeals=TxtCount.Text;
            string Price=TxtPrice.Text;
            string Count2=TxtCount2.Text;
            string Drink=CmbDrink.Text;
            DgvOrders.Rows.Add(Name,Site, Meals, CountMeals, Drink,Count2, ID, Price);
            MessageBox.Show("The Order Added Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtName.Clear();
            TxtCount.Clear();
            TxtPrice.Clear();
            TxtID.Clear();
            TxtName.Focus();
          
            
          



        }  

      


        private void button3_Click(object sender, EventArgs e)
        {//ده زرار قفل للفورم
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {   //ده بيمسح بينات الجدول انا مسميه DgvOrders
            DgvOrders.Rows.Clear();
        }

        private void CmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {//ده كنت بفكر في حته الهوا يظهر اول انديكس بس مظبتش
            CmbMeal.SelectedIndex = 0;


        }
 



        private void CmbSite_SelectedIndexChanged(object sender, EventArgs e)
        {// حاولت هنا برضوا
           
            CmbSite.SelectedIndex= 0;
        }

        private void Order_Load(object sender, EventArgs e)
        {//  هو طبعا هتلاقيه تحت خالصOrderLogic  ده تبع شفل الفايل هندل اسم الكلاس  
            OrderLogic.LoadInfoGrade(DgvOrders);
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {//محاوله فاشله لتوجيه الكتابه لتيكست الاسم
            TxtName.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }
    }
    public class OrderLogic// ده كلاس بتاع الفايل هندل
    {//كل البروبيرتي دي بنساويها فوق باسم التيكست بوكس او الكومبوا بوكس التبعه
        public string Name { get; set; }
        public string ID { get; set; }
        public string Count { get; set; }
        public string Price { get; set; }
        public string cmbSite { get; set; }
        public string CmbMeal { get; set; }
        public string CmbDrink {  get; set; }
        public string TxtCount2 {  get; set; }

        public void savefile()//دي الداله احنا هننشيء فيها فايل الهنخزن فيه كل حاجه  تبع الجدول
        {

            using (StreamWriter Writer = new StreamWriter("orders.txt", true)) 

            Writer.WriteLine($"{Name}|{cmbSite}|{CmbMeal}|{TxtCount2}|{CmbDrink}|{ID}|{Count}|{Price}");//هنا لازم نرسس كل حاجه بنفس ترتيب الجدول
        }
        public static void LoadInfoGrade(DataGridView DgvOrders)
        {

            if (File.Exists("orders.txt"))
                {

                string[] Rows = File.ReadAllLines("orders.txt");
                foreach (string s in Rows)
                {
                    string[] data = s.Split('|');//هنا بنستثني دي من الكتابه الفوق |

                    DgvOrders.Rows.Add(data);//دي لازم تتعمب علشان الفايل يحط بيناته في الجدول


                }


            }


        }
        
      




    }//هنا للاسف الدكاتره طالبين لازم اعمله enum
    public enum MealsTybe
    {
        Burger,
        Pizza,
        Pasta,
        Chicken,


    }
    public enum DrinksTybe
    {
        water,
        Cola,
        pepsi,
        juice





    }
    public class MealsItem
    {
        public MealsTybe MealTybe {get; set;}
    public  DrinksTybe DrinkTybe { get; set; }
    public double Price {  get; set; }
public string ID {  get; set; }
        public override string ToString()
        {
            return MealTybe.ToString();


        }




    }
    


}