using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaLoTo
{
    public partial class Form1 : Form
    {
        private const int arraySize = 6;
        private const int maxNum = 50;
        public static Random randomNum = new Random();
        private int[] numbers = new int[arraySize];
        private TextBox[] txtLucky;


        public static void DataGen1(int[] numbers)//產生亂數
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randomNum.Next(1, maxNum);
                for (int j = i - 1; j >= 0; j--)//避免產生重複的數字
                {
                    if (numbers[i] == numbers[j])
                    {
                        i--;
                        break;
                    }
                }
            }
        }


        public Form1()//表格產生
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//表格載入
        {
            TextBox[] temp = { txtNum1, txtNum2, txtNum3, txtNum4, txtNum5, txtNum6 };
            txtLucky = temp;
        }

        private void btnGen_Click(object sender, EventArgs e)
        {

            DataGen1(numbers);//產生亂數
            for(int i=0; i< numbers.Length; i++)//把產生的亂數放到textBox中
            {
                txtLucky[i].Text = numbers[i].ToString();
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        { 
            Array.Sort(numbers);//給亂數排序
            for (int i=0; i<numbers.Length; i++)//把排序好的亂數放到textBox中
            {
                txtLucky[i].Text = numbers[i].ToString();
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                txtLucky[i].Clear();//文字框可用Clear()來清除，label則="";
            }
        }
    }
}
