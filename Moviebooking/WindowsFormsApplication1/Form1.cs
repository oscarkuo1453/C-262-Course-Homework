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
        public string choisS = "";
        public int[] aAry = new int[20];
        public int[] bAry = new int[20];
        public int[] cAry = new int[20];
        public int[] dAry = new int[20];
        public int[] afindS = new int[5];
        private TextBox[] aBoxText = new TextBox[20];
        private TextBox[] bBoxText = new TextBox[20];
        private TextBox[] cBoxText = new TextBox[20];
        private TextBox[] dBoxText = new TextBox[20];
        public int countSeat = 0;
        private int swSeat = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random ran = new Random();
            for (int i = 0; i < aAry.Length; i++)
            {
                int r = ran.Next(0, 2);
                aAry[i] = r;
            }
            for (int i = 0; i < bAry.Length; i++)
            {
                int r = ran.Next(0, 2);
                bAry[i] = r;
            }
            for (int i = 0; i < cAry.Length; i++)
            {
                int r = ran.Next(0, 2);
                cAry[i] = r;
            }
            for (int i = 0; i < dAry.Length; i++)
            {
                int r = ran.Next(0, 2);
                dAry[i] = r;
            }

            TextBox[] aBoxText =
              {textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9,textBox10,
               textBox11,textBox12,textBox13,textBox14,textBox15,textBox16,textBox17,textBox18,textBox19,textBox20};

            //  TextBox[] aBoxText = new TextBox[20];
            //  for (int i = 0; i < 20; i++)
            //  {
            //      int j = i + 1;
            //        aBoxText[i] = new TextBox();
            //      this.Controls.Add(textBox[j]);
            //  }

            for (int i = 0; i < aBoxText.Length; i++)
            {
                if (aAry[i] == 1)
                    aBoxText[i].BackColor = Color.Red;
                else if
                (aAry[i] == 0)
                    aBoxText[i].BackColor = Color.Silver;
            }

            TextBox[] bBoxText =
            { textBox21,textBox22,textBox23,textBox24,textBox25,textBox26,textBox27,textBox28,textBox29,textBox30,
              textBox31,textBox32,textBox33,textBox34,textBox35,textBox36,textBox37,textBox38,textBox39,textBox40 };
            for (int i = 0; i != aBoxText.Length; i++)
            {
                if (bAry[i] == 1)
                    bBoxText[i].BackColor = Color.Red;
                else if
                    (bAry[i] == 0)
                    bBoxText[i].BackColor = Color.Silver;
            }

            TextBox[] cBoxText =
            { textBox41,textBox42,textBox43,textBox44,textBox45,textBox46,textBox47,textBox48,textBox49,textBox50,
              textBox51,textBox52,textBox53,textBox54,textBox55,textBox56,textBox57,textBox58,textBox59,textBox60};
            for (int i = 0; i != cBoxText.Length; i++)
            {
                if (cAry[i] == 1)
                    cBoxText[i].BackColor = Color.Red;
                else if
                    (cAry[i] == 0)
                    cBoxText[i].BackColor = Color.Silver;
            }
            TextBox[] dBoxText =
            { textBox61,textBox62,textBox63,textBox64,textBox65,textBox66,textBox67,textBox68,textBox69,textBox70,
              textBox71,textBox72,textBox73,textBox74,textBox75,textBox76,textBox77,textBox78,textBox79,textBox80 };
            for (int i = 0; i != dBoxText.Length; i++)
            {
                if (dAry[i] == 1)
                    dBoxText[i].BackColor = Color.Red;
                else if
                    (dAry[i] == 0)
                    dBoxText[i].BackColor = Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void textBox81_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox95_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox99_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox94_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkinBtn_Click(object sender, EventArgs e)
        {
            countSeat = int.Parse(textBox99.Text);
            int findS = 0;
            swSeat = 0;
            bool Isfind = false;
            for (int i = 1; i < 5; i++)
            {
                if (i == 1) { findS = searchSeat(ref aAry, bAry, cAry, dAry, 1, countSeat); }
                else if ((i == 2) && (findS == 999)) findS = searchSeat(ref aAry, bAry, cAry, dAry, 2, countSeat);
                else if (i == 3) findS = searchSeat(ref aAry, bAry, cAry, dAry, 3, countSeat);
                else findS = searchSeat(ref aAry, bAry, cAry, dAry, 4, countSeat);
                if (findS != 999) { Isfind = true; swSeat = i; break; }
            }

            if (Isfind == true)
            {
                if (swSeat == 1) textBox81.Text = "A".ToString();
                else if (swSeat == 2) textBox81.Text = "B".ToString();
                else if (swSeat == 3) textBox81.Text = "C".ToString();
                else if (swSeat == 4) textBox81.Text = "D".ToString();

                TextBox[] t9BoxAry = new TextBox[] { textBox91, textBox92, textBox93, textBox94, textBox95 };
                for (int i = 0; i < 5; i++)
                {
                    t9BoxAry[i].Text = "";
                }

                for (int i = 0; i < countSeat; i++)
                {
                    t9BoxAry[i].Text = (findS + i).ToString();
                }
                if (swSeat == 1) choisS = "A";
                else if (swSeat == 2) choisS = "B";
                else if (swSeat == 3) choisS = "C";
                else if (swSeat == 4) choisS = "D";

                for (int i = 0; i < afindS.Length; i++)
                {
                    afindS[i] = 999;
                }
                for (int i = 0; i < countSeat; i++)
                {
                    afindS[i] = findS + i;
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            TextBox[] aBoxText =
               { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9,textBox10,
                 textBox11,textBox12,textBox13,textBox14,textBox15,textBox16,textBox17,textBox18,textBox19,textBox20};

            TextBox[] bBoxText =
            { textBox21, textBox22, textBox23, textBox24, textBox25, textBox26, textBox27, textBox28, textBox29,textBox30,
              textBox31, textBox32, textBox33, textBox34, textBox35, textBox36, textBox37, textBox38, textBox39,textBox40 };

            TextBox[] cBoxText =
            { textBox41, textBox42, textBox43, textBox44, textBox45, textBox46, textBox47, textBox48, textBox49,textBox50,
              textBox51, textBox52, textBox53, textBox54, textBox55, textBox56, textBox57, textBox58, textBox59,textBox60};

            TextBox[] dBoxText =
            { textBox61, textBox62, textBox63, textBox64, textBox65, textBox66, textBox67, textBox68, textBox69,textBox70,
              textBox71, textBox72, textBox73, textBox74, textBox75, textBox76, textBox77, textBox78, textBox79,textBox80 };

            refreshBox(ref  aAry, bAry, cAry, dAry, afindS, aBoxText, bBoxText, cBoxText, dBoxText, swSeat, countSeat);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private static int searchSeat(ref int[] aAry, int[] bAry, int[] cAry, int[] dAry, int n, int s)
        {
            int[] aTemp = new int[20];
            if (n == 1) { aTemp = aAry; }
            else if (n == 2) { aTemp = bAry; }
            else if (n == 3) { aTemp = cAry; }
            else { aTemp = dAry; }
            bool Ishave = false;
            int sSeat = 999;
            for (int i = 0; i < aTemp.Length; i++)
            {
                for (int j = i; (j <= i + s - 1) && (j <= 19); j++)
                {
                    if (aTemp[j] == 1) { break; }
                    else if ((aTemp[j] == 1) && (j == 19))
                    { break; }
                    if ((j == i + s - 1) && (aTemp[j] == 0))
                    {
                        Ishave = true;
                        sSeat = i + 1;
                    }
                }
                if (Ishave == true)
                    break;
            }
            return sSeat;
        }

        private static void refreshBox(ref int[] aAry, int[] bAry, int[] cAry, int[] dAry, int[] afindS, TextBox[] aBoxText, TextBox[] bBoxText, TextBox[] cBoxText, TextBox[] dBoxText, int n, int cs)
        {
            int[] aTemp = new int[20];
            TextBox[] tBoxText = new TextBox[20];
            if (n == 1) { aTemp = aAry; tBoxText = aBoxText; }
            else if (n == 2) { aTemp = bAry; tBoxText = bBoxText; }
            else if (n == 3) { aTemp = cAry; tBoxText = cBoxText; }
            else { aTemp = dAry; tBoxText = dBoxText; }
            int[] tfindS = afindS;

            for (int i = 0; i < cs; i++)
            {
                int t;
                t = tfindS[i] - 1;
                aTemp[t] = 1;
            }

            for (int i = 0; i != tBoxText.Length; i++)
            {
                if (aTemp[i] == 1)
                    tBoxText[i].BackColor = Color.Red;
                else if
                (aTemp[i] == 0)
                    tBoxText[i].BackColor = Color.Silver;
            }
        }

        private void textBox74_TextChanged(object sender, EventArgs e)
        {
        }
    }
}