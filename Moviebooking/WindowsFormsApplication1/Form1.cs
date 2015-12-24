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
        public int[] aAry = new int[20];
        public int[] bAry = new int[20];
        public int[] cAry = new int[20];
        public int[] dAry = new int[20];
        public int[] afindS = new int[5];
        public TextBox[] aBoxText = new TextBox[20];
        private TextBox[] bBoxText = new TextBox[20];
        private TextBox[] cBoxText = new TextBox[20];
        private TextBox[] dBoxText = new TextBox[20];
        public int countSeat;

        private int swSeat = 0;
        public string fresh_sw = "first";
        public string error_seat = "none";

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
            cancelBtn.Enabled = false;
            refreshBtn.Enabled = false;
            checkinBtn.Enabled = true;
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
            ////
            //  TextBox[] aBoxText =
            //    {textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9,textBox10,
            //     textBox11,textBox12,textBox13,textBox14,textBox15,textBox16,textBox17,textBox18,textBox19,textBox20};
            ////

            GenerateTextBox(ref aBoxText, bBoxText, cBoxText, dBoxText);
            for (int i = 0; i < 20; i++)
            {
                if (aAry[i] == 1)
                { aBoxText[i].BackColor = Color.Red; }
                else
                { aBoxText[i].BackColor = Color.Silver; }

                if (bAry[i] == 1)
                { bBoxText[i].BackColor = Color.Red; }
                else
                { bBoxText[i].BackColor = Color.Silver; }

                if (cAry[i] == 1)
                { cBoxText[i].BackColor = Color.Red; }
                else
                { cBoxText[i].BackColor = Color.Silver; }

                if (dAry[i] == 1)
                { dBoxText[i].BackColor = Color.Red; }
                else
                { dBoxText[i].BackColor = Color.Silver; }
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
            checkinBtn.Enabled = true;
            error_seat = "none";
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
            checkinBtn.Enabled = true;
            if (textBox99.Text == "" || textBox99.Text == null)
                countSeat = 0;
            else
                countSeat = Convert.ToInt32(textBox99.Text);

            if (countSeat < 1 || countSeat > 5)
            {
                MessageBox.Show("數量錯誤", "moveBooking");
                error_seat = "have";
                checkinBtn.Enabled = false;
            }

            int findS = 0;
            swSeat = 0;
            bool Isfind = false;
            textBox81.Text = "";

            //
            //  TextBox[] t9BoxAry = new TextBox[] { textBox91, textBox92, textBox93, textBox94, textBox95 };
            //
            TextBox[] t9BoxAry = new TextBox[5];
            for (int i = 0; i < 5; i++)
            {
                TextBox tB = (TextBox)Controls["textBox" + (i + 91)];
                t9BoxAry[i] = tB;
                t9BoxAry[i].Text = "";
            }

            for (int i = 1; i < 5; i++)
            {
                if (i == 1) findS = searchSeat(ref aAry, bAry, cAry, dAry, 1, countSeat);
                else if (i == 2) findS = searchSeat(ref aAry, bAry, cAry, dAry, 2, countSeat);
                else if (i == 3) findS = searchSeat(ref aAry, bAry, cAry, dAry, 3, countSeat);
                else findS = searchSeat(ref aAry, bAry, cAry, dAry, 4, countSeat);
                if (findS != 999) { Isfind = true; swSeat = i; break; }
            }

            if ((Isfind == true) && (error_seat != "have"))
            {
                if (swSeat == 1) textBox81.Text = "A".ToString();
                else if (swSeat == 2) textBox81.Text = "B".ToString();
                else if (swSeat == 3) textBox81.Text = "C".ToString();
                else if (swSeat == 4) textBox81.Text = "D".ToString();

                for (int i = 0; i < countSeat; i++)
                {
                    t9BoxAry[i].Text = (findS + i).ToString();
                }

                for (int i = 0; i < countSeat; i++)
                {
                    afindS[i] = findS + i;
                }
                GenerateTextBox(ref aBoxText, bBoxText, cBoxText, dBoxText);
                fresh_sw = "first";
                refreshBox(ref  aAry, bAry, cAry, dAry, afindS, aBoxText, bBoxText, cBoxText, dBoxText, swSeat, countSeat, fresh_sw);
                cancelBtn.Enabled = true;
                refreshBtn.Enabled = true;
                checkinBtn.Enabled = false;
            }
            if ((Isfind == false) && (error_seat != "have"))
            {
                MessageBox.Show("無符合的座位", "moveBooking");
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            GenerateTextBox(ref aBoxText, bBoxText, cBoxText, dBoxText);
            fresh_sw = "second";
            refreshBox(ref  aAry, bAry, cAry, dAry, afindS, aBoxText, bBoxText, cBoxText, dBoxText, swSeat, countSeat, fresh_sw);
            textBox81.Text = "";
            textBox99.Text = "";
            TextBox[] t9BoxAry = new TextBox[5];
            for (int i = 0; i < 5; i++)
            {
                TextBox tB = (TextBox)Controls["textBox" + (i + 91)];
                t9BoxAry[i] = tB;
                t9BoxAry[i].Text = "";
            }
            refreshBtn.Enabled = false;
            cancelBtn.Enabled = false;
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
                if (aTemp[i] == 3)
                    aTemp[i] = 0;
            }

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

        private static void refreshBox(ref int[] aAry, int[] bAry, int[] cAry, int[] dAry, int[] afindS, TextBox[] aBoxText, TextBox[] bBoxText, TextBox[] cBoxText, TextBox[] dBoxText, int n, int cs, string fresh_sw)
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
                if (fresh_sw == "first")
                    aTemp[tfindS[i] - 1] = 3;
                else if (fresh_sw == "second")
                    aTemp[tfindS[i] - 1] = 1;
                else
                    aTemp[tfindS[i] - 1] = 0;
            }

            for (int i = 0; i != tBoxText.Length; i++)
            {
                if (aTemp[i] == 1)
                    tBoxText[i].BackColor = Color.Red;
                else if
                (aTemp[i] == 3)
                    tBoxText[i].BackColor = Color.Yellow;
                else if
                  (aTemp[i] == 0)
                    tBoxText[i].BackColor = Color.Silver;
            }
        }

        private void textBox74_TextChanged(object sender, EventArgs e)
        {
        }

        private void GenerateTextBox(ref TextBox[] aBoxText, TextBox[] bBoxText, TextBox[] cBoxText, TextBox[] dBoxText)
        {
            for (int i = 0; i < 20; i++)
            {
                TextBox tB1 = (TextBox)Controls["textBox" + (i + 1)];
                TextBox tB2 = (TextBox)Controls["textBox" + (i + 21)];
                TextBox tB3 = (TextBox)Controls["textBox" + (i + 41)];
                TextBox tB4 = (TextBox)Controls["textBox" + (i + 61)];
                aBoxText[i] = tB1;
                bBoxText[i] = tB2;
                cBoxText[i] = tB3;
                dBoxText[i] = tB4;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            countSeat = int.Parse(textBox99.Text);
            GenerateTextBox(ref aBoxText, bBoxText, cBoxText, dBoxText);
            fresh_sw = "cancel";
            int[] tfindS = afindS;
            refreshBox(ref  aAry, bAry, cAry, dAry, afindS, aBoxText, bBoxText, cBoxText, dBoxText, swSeat, countSeat, fresh_sw);

            textBox81.Text = "";
            textBox99.Text = "";
            TextBox[] t9BoxAry = new TextBox[5];
            for (int i = 0; i < 5; i++)
            {
                TextBox tB = (TextBox)Controls["textBox" + (i + 91)];
                t9BoxAry[i] = tB;
                t9BoxAry[i].Text = "";
            }
            refreshBtn.Enabled = false;
            cancelBtn.Enabled = false;
        }
    }
}