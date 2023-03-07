namespace modul3_1302213117
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int angka = 0;
        int i = -1;
        int[] bilangan = new int[50];

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
            angka = angka * 10 + 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
            angka = angka * 10;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
            angka = angka * 10 + 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
            angka = angka * 10 + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
            angka = angka * 10 + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
            angka = angka * 10 + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
            angka = angka * 10 + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
            angka = angka * 10 + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
            angka = angka * 10 + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
            angka = angka * 10 + 9;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + " + ";
            i++;
            bilangan[i] = angka;
            angka = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            i++;
            bilangan[i] = angka;
            angka = 0;
            int n = 0;
            int hasil = 0;
            while (n <= i)
            {
                hasil = hasil + bilangan[n];
                n++;
            }
            label1.Text = "" + hasil;
        }
    }
}