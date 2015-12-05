using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string TempStr1, TempStr2, TempStr3, TempStr4;
        string TempComm;
        int[] A0 = new int[11]; 
        int[] A = new int[11];
        int[] A2 = new int[11];
        int n, i;
        int addV = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TempStr1 = "Source Data :";
            Random r = new Random();
            for (i = 1; i <= 10; i++)
            {
                A[i] = r.Next(1, 10);
                if (i == 1) { TempComm = ""; }
                else { TempComm = " , "; }
                TempStr1 = TempStr1 + TempComm + string.Format("{0}", A[i])  ;
            }
            for (i = 1; i <= 10; i++)
            {
                A0[i] = A[i]; 
            }
            n = i - 1;
            label1.Text = TempStr1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int ss;
            ss = Sum (ref A,n);
            TempStr2 = TempStr2 + "after Sum data:";
            TempStr2 = TempStr2  + ss.ToString();
            label2.Text = TempStr2;
         }
        public int Sum(ref int[] A, int n )
        {
            int s=0 ;
            for (i = 1; i <= n ; i++)
            { s = s + A[i]; }
            return s;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            GetCustSum(ref A, n);
            TempStr3 = TempStr3 + "after CustSum data:";
            for (i = 1; i <= 10; i++)
            {
                if (i == 1) { TempComm = ""; }
                else { TempComm = " , "; }
                TempStr3 = TempStr3 + TempComm + string.Format("{0}", A2[i]);
            }
            label3.Text = TempStr3;
        }
        public void GetCustSum(ref int[] A,int n )
        {
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                s = s + A[i];
                A[i] = s;
            }
            for (int i = 0; i <= n; i++)
            {
                A2[i] = A[i];
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            for (i = 1; i <= 10; i++)
            {
                A[i] = A0[i];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addV = int.Parse(textBox1.Text);
            for (int i = 1; i <= n; i++)
            {
                 A[i] = A[i] + addV ;
            }
            TempStr4 = TempStr4 + "after addV  data:";
            for (i = 1; i <= 10; i++)
            {
                if (i == 1) { TempComm = ""; }
                else { TempComm = " , "; }
                TempStr4 = TempStr4 + TempComm + string.Format("{0}", A[i]);
            }
            label4.Text = TempStr4;

        }
    }
}
