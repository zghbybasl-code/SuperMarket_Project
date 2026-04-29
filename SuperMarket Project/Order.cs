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
            if (string.IsNullOrWhiteSpace(CmbMeal.Text) || string.IsNullOrWhiteSpace(TxtCount.Text) || string.IsNullOrWhiteSpace(TxtID.Text) || string.IsNullOrWhiteSpace(TxtPrice.Text))
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
            neworder.ID = TxtID.Text;
            neworder.CmbMeal = CmbMeal.Text;
            neworder.Count = TxtCount.Text;
            neworder.Price = TxtPrice.Text;
            neworder.cmbSite = CmbSite.Text;
            neworder.CmbDrink = CmbDrink.Text;
            neworder.TxtCount2 = TxtCount2.Text;
            neworder.IDDrink=IdDrink.Text;
            neworder.savefile();

            //Data Grade View 
            string Name = TxtName.Text;
            string Site = CmbSite.Text.ToString();
            string Meals = CmbMeal.Text.ToString();
            string ID = TxtID.Text;
            string CountMeals = TxtCount.Text;
            string Price = TxtPrice.Text;
            string Count2 = TxtCount2.Text;
            string Drink = CmbDrink.Text;
            string IDDrink = IdDrink.Text;
            DgvOrders.Rows.Add(Name, Site, Meals, CountMeals, Drink, Count2, ID,IDDrink, Price);
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
            File.WriteAllText("orders.txt",string.Empty);
            DgvOrders.Rows.Clear();
          
        }

        private void CmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {//ده كنت بفكر في حته الهوا يظهر اول انديكس بس مظبتش
            if (CmbMeal.SelectedItem != null)
            {     // Add Enum

                MealsTybe Selected = (MealsTybe)CmbMeal.SelectedItem;
                int ID = 0;
                double Price = 0;
                switch (Selected)
                {
                    case
                        MealsTybe.Chicken_Crepe:
                        Price = 120.50; ID = 13432144;
                        break;
                    case
                        MealsTybe.Beef_Steak_With_Muchroom:
                        Price = 200; ID = 876575756;
                        break;
                    case
                        MealsTybe.Chicken_Pane_With_Pasta:
                        Price = 150; ID = 543243543;
                        break;
                    case
                        MealsTybe.Zinger_Burger:
                        Price = 300; ID = 345235253;
                        break;
                    case
                        MealsTybe.Pizza:
                        Price = 100; ID = 23432453;
                        break;
                    case
                        MealsTybe.Double_Beef_Burger:
                        Price = 200; ID = 53424325;
                        break;

                    case
                        MealsTybe.Crispy_Chicken_Sandwich:
                        Price = 250; ID = 23576876;
                        break;
                    case
                        MealsTybe.Burger:
                        Price = 150; ID = 25342354;
                        break;


                }
                TxtID.Text = ID.ToString();
                TxtPrice.Text = Price.ToString();



            }


        }




        private void CmbSite_SelectedIndexChanged(object sender, EventArgs e)
        {// حاولت هنا برضوا

   
        }

        private void Order_Load(object sender, EventArgs e)
        {//  هو طبعا هتلاقيه تحت خالصOrderLogic  ده تبع شفل الفايل هندل اسم الكلاس  
            OrderLogic.LoadInfoGrade(DgvOrders);
            //ده شفل Enum
            CmbMeal.DataSource = Enum.GetValues(typeof(MealsTybe));
            CmbDrink.DataSource = Enum.GetValues(typeof(DrinksTybe));
            
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
            this.WindowState = FormWindowState.Minimized;
        }

        private void CmbDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrinksTybe Selected=(DrinksTybe)CmbDrink.SelectedItem;
            int ID = 0;
            double Price = 0;
            switch (Selected)
            {

                case
                    DrinksTybe.Black_tea:
                    Price = 20; ID = 457666666;
                    break;

                case
                    DrinksTybe.orange_juice:
                    Price = 15; ID = 23452345;
                    break;
                case
                    DrinksTybe.Green_tea:
                    Price = 20;  ID = 214543555;
                    break;
                case
                    DrinksTybe.Mango_juice:
                    Price = 15;  ID = 55433254;
                    break;

                case
                    DrinksTybe.Apple_juice:
                    Price = 15; ID = 43252132;
                    break;
                case
                    DrinksTybe.Latte_Cappuccino:
                    Price = 25; ID = 6574545;
                    break;
                case
                    DrinksTybe.Espresso:
                    Price = 30; ID = 45765656;
                    break;
                case
                    DrinksTybe.Hot_Chocolate:
                    Price = 50;   ID = 53534324;
                    break;
             
                    
                case
                    DrinksTybe.Water:
                    Price = 10;  ID = 453565254;
                    break;



            }
            IdDrink.Text =ID.ToString(); 
            PriDrink.Text = Price.ToString();


        }

        private void DgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
        public string CmbDrink { get; set; }
        public string TxtCount2 { get; set; }
        public string IDDrink {  get; set; }

        public void savefile()//دي الداله احنا هننشيء فيها فايل الهنخزن فيه كل حاجه  تبع الجدول
        {

            using (StreamWriter Writer = new StreamWriter("orders.txt", true))

                Writer.WriteLine($"{Name}|{cmbSite}|{CmbMeal}|{Count}|{CmbDrink}|{ID}|{ID}|{Price}");//هنا لازم نرسس كل حاجه بنفس ترتيب الجدول
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
        Chicken_Crepe,
        Macaroni_Bechamel,
        Potato_and_Cheese_Sandwich,
        Shawarma,
        Pizza,
        Burger,
        Zinger_Burger,
        Double_Beef_Burger,
        Crispy_Chicken_Sandwich,
        Philly_Cheesesteak,
        Chicken_Pane_With_Pasta,
        Beef_Steak_With_Muchroom,


    }
    public enum DrinksTybe
    {
        Black_tea,
        Green_tea,
        orange_juice,
        Apple_juice,
        Mango_juice,
        Espresso,
        Latte_Cappuccino,
        Hot_Chocolate,
        Water,





    }
    
   




    }



