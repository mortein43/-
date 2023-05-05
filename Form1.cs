namespace Пятнашки
{
    using System.Collections;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {

        int score = 0;

        public bool checkWin()
        {
            bool res = false;
            if
            (
                button1.Text == "1" &&
                button2.Text == "2" &&
                button3.Text == "3" &&
                button4.Text == "4" &&
                button5.Text == "5" &&
                button6.Text == "6" &&
                button7.Text == "7" &&
                button8.Text == "8" &&
                button9.Text == "9" &&
                button10.Text == "10" &&
                button11.Text == "11" &&
                button12.Text == "12" &&
                button13.Text == "13" &&
                button14.Text == "14" &&
                button15.Text == "15" &&
                button16.Text == " "
            )
            {
                res = true;
            }
            else res = false;
            return res;
        }
        public void show()
        {
            if (checkWin())
            {
                label2.Text = score.ToString();
                MessageBox.Show(this, $"Вітаю, Тобі знадобилося {label2.Text} ходів!!!", "Молодець!", MessageBoxButtons.OK);
                button16.Text = "";
            }

        }
        public void start()
        {
            Button[] buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16 };

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = " ";
            }
            ArrayList numbers = new ArrayList() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", " " };
            while (numbers.Count > 0)
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    Random random = new Random();
                    int randomNum = random.Next(0, numbers.Count);

                    buttons[i].Text = numbers[randomNum].ToString();
                    numbers.RemoveAt(randomNum);
                }
            }
        }
        public bool check()
        {
            bool res = true;
            ArrayList listForCheck = new ArrayList()
            {
                button1.Text,
                button2.Text,
                button3.Text,
                button4.Text,
                button8.Text,
                button7.Text,
                button6.Text,
                button5.Text,
                button9.Text,
                button10.Text,
                button11.Text,
                button12.Text,
                button16.Text,
                button15.Text,
                button14.Text,
                button13.Text
            };

            int indexForClear = listForCheck.IndexOf(" ", 0);
            listForCheck.RemoveAt(indexForClear);



            int sum = 0;

            for (int i = 0; i < listForCheck.Count - 1; i++)
            {
                for (int j = i + 1; j < listForCheck.Count; j++)
                {
                    int i1 = int.Parse((string)listForCheck[i]);
                    int j1 = int.Parse((string)listForCheck[j]);


                    if (i1 > j1)
                    {
                        sum = sum + 1;
                    }
                }
            }
            
            int intres = sum % 2;

            if (intres == 0)
            {
                res = false;
            }
            else if (intres == 1)
            {
                res = true;
            }

            return res;
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label2.Text = score.ToString();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Text == " ")
            {
                string temp = button1.Text;
                button1.Text = button2.Text;
                button2.Text = temp;
                score++;
                show();
            }
            else if (button5.Text == " ")
            {
                string temp = button1.Text;
                button1.Text = button5.Text;
                button5.Text = temp;
                score++;
                show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text == " ")
            {
                string temp = button2.Text;
                button2.Text = button1.Text;
                button1.Text = temp;
                score++;
                show();
            }
            else if (button3.Text == " ")
            {
                string temp = button2.Text;
                button2.Text = button3.Text;
                button3.Text = temp;
                score++;
                show();
            }
            else if (button6.Text == " ")
            {
                string temp = button2.Text;
                button2.Text = button6.Text;
                button6.Text = temp;
                score++;
                show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button2.Text == " ")
            {
                string temp = button3.Text;
                button3.Text = button2.Text;
                button2.Text = temp;
                score++;
                show();
            }
            else if (button4.Text == " ")
            {
                string temp = button3.Text;
                button3.Text = button4.Text;
                button4.Text = temp;
                score++;
                show();
            }
            else if (button7.Text == " ")
            {
                string temp = button3.Text;
                button3.Text = button7.Text;
                button7.Text = temp;
                score++;
                show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button3.Text == " ")
            {
                string temp = button4.Text;
                button4.Text = button3.Text;
                button3.Text = temp;
                score++;
                show();
            }
            else if (button8.Text == " ")
            {
                string temp = button4.Text;
                button4.Text = button8.Text;
                button8.Text = temp;
                score++;
                show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button1.Text == " ")
            {
                string temp = button5.Text;
                button5.Text = button1.Text;
                button1.Text = temp;
                score++;
                show();
            }
            else if (button6.Text == " ")
            {
                string temp = button5.Text;
                button5.Text = button6.Text;
                button6.Text = temp;
                score++;
                show();
            }
            else if (button9.Text == " ")
            {
                string temp = button5.Text;
                button5.Text = button9.Text;
                button9.Text = temp;
                score++;
                show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button2.Text == " ")
            {
                string temp = button6.Text;
                button6.Text = button2.Text;
                button2.Text = temp;
                score++;
                show();
            }
            else if (button5.Text == " ")
            {
                string temp = button6.Text;
                button6.Text = button5.Text;
                button5.Text = temp;
                score++;
                show();
            }
            else if (button7.Text == " ")
            {
                string temp = button6.Text;
                button6.Text = button7.Text;
                button7.Text = temp;
                score++;
                show();
            }
            else if (button10.Text == " ")
            {
                string temp = button6.Text;
                button6.Text = button10.Text;
                button10.Text = temp;
                score++;
                show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button3.Text == " ")
            {
                string temp = button7.Text;
                button7.Text = button3.Text;
                button3.Text = temp;
                score++;
                show();
            }
            else if (button6.Text == " ")
            {
                string temp = button7.Text;
                button7.Text = button6.Text;
                button6.Text = temp;
                score++;
                show();
            }
            else if (button8.Text == " ")
            {
                string temp = button7.Text;
                button7.Text = button8.Text;
                button8.Text = temp;
                score++;
                show();
            }
            else if (button11.Text == " ")
            {
                string temp = button7.Text;
                button7.Text = button11.Text;
                button11.Text = temp;
                score++;
                show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button4.Text == " ")
            {
                string temp = button8.Text;
                button8.Text = button4.Text;
                button4.Text = temp;
                score++;
                show();
            }
            else if (button7.Text == " ")
            {
                string temp = button8.Text;
                button8.Text = button7.Text;
                button7.Text = temp;
                score++;
                show();
            }
            else if (button12.Text == " ")
            {
                string temp = button8.Text;
                button8.Text = button12.Text;
                button12.Text = temp;
                score++;
                show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button5.Text == " ")
            {
                string temp = button9.Text;
                button9.Text = button5.Text;
                button5.Text = temp;
                score++;
                show();
            }
            else if (button10.Text == " ")
            {
                string temp = button9.Text;
                button9.Text = button10.Text;
                button10.Text = temp;
                score++;
                show();
            }
            else if (button13.Text == " ")
            {
                string temp = button9.Text;
                button9.Text = button13.Text;
                button13.Text = temp;
                score++;
                show();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button6.Text == " ")
            {
                string temp = button10.Text;
                button10.Text = button6.Text;
                button6.Text = temp;
                score++;
                show();
            }
            else if (button9.Text == " ")
            {
                string temp = button10.Text;
                button10.Text = button9.Text;
                button9.Text = temp;
                score++;
                show();
            }
            else if (button11.Text == " ")
            {
                string temp = button10.Text;
                button10.Text = button11.Text;
                button11.Text = temp;
                score++;
                show();
            }
            else if (button14.Text == " ")
            {
                string temp = button10.Text;
                button10.Text = button14.Text;
                button14.Text = temp;
                score++;
                show();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button7.Text == " ")
            {
                string temp = button11.Text;
                button11.Text = button7.Text;
                button7.Text = temp;
                score++;
                show();
            }
            else if (button10.Text == " ")
            {
                string temp = button11.Text;
                button11.Text = button10.Text;
                button10.Text = temp;
                score++;
                show();
            }
            else if (button12.Text == " ")
            {
                string temp = button11.Text;
                button11.Text = button12.Text;
                button12.Text = temp;
                score++;
                show();
            }
            else if (button15.Text == " ")
            {
                string temp = button11.Text;
                button11.Text = button15.Text;
                button15.Text = temp;
                score++;
                show();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button8.Text == " ")
            {
                string temp = button12.Text;
                button12.Text = button8.Text;
                button8.Text = temp;
                score++;
                show();
            }
            else if (button11.Text == " ")
            {
                string temp = button12.Text;
                button12.Text = button11.Text;
                button11.Text = temp;
                score++;
                show();
            }
            else if (button16.Text == " ")
            {
                string temp = button12.Text;
                button12.Text = button16.Text;
                button16.Text = temp;
                score++;
                show();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button9.Text == " ")
            {
                string temp = button13.Text;
                button13.Text = button9.Text;
                button9.Text = temp;
                score++;
                show();
            }
            else if (button14.Text == " ")
            {
                string temp = button13.Text;
                button13.Text = button14.Text;
                button14.Text = temp;
                score++;
                show();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button10.Text == " ")
            {
                string temp = button14.Text;
                button14.Text = button10.Text;
                button10.Text = temp;
                score++;
                show();
            }
            else if (button13.Text == " ")
            {
                string temp = button14.Text;
                button14.Text = button13.Text;
                button13.Text = temp;
                score++;
                show();
            }
            else if (button15.Text == " ")
            {
                string temp = button14.Text;
                button14.Text = button15.Text;
                button15.Text = temp;
                score++;
                show();
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (button11.Text == " ")
            {
                string temp = button15.Text;
                button15.Text = button11.Text;
                button11.Text = temp;
                score++;
                show();
            }
            else if (button14.Text == " ")
            {
                string temp = button15.Text;
                button15.Text = button14.Text;
                button14.Text = temp;
                score++;
                show();
            }
            else if (button16.Text == " ")
            {
                string temp = button15.Text;
                button15.Text = button16.Text;
                button16.Text = temp;
                score++;
                show();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button12.Text == " ")
            {
                string temp = button16.Text;
                button16.Text = button12.Text;
                button12.Text = temp;
                score++;
                show();
            }
            else if (button15.Text == " ")
            {
                string temp = button16.Text;
                button16.Text = button15.Text;
                button15.Text = temp;
                score++;
                show();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            score = 0;

            start();
            while (!check())
            {
                start();
            }
        }


    }
}