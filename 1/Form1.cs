using System;
using System.Windows.Forms;

namespace _1
{
    public partial class OctopusColculator : Form
    {
        private static Fraction a, b, c;
        private static string charr = "+-*÷";

        private void num2_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (!int.TryParse(num2.Text, out x))
            {
                num2.Text = b.Num + "";
                MessageBox.Show("Введено некорректное значение, поэтому замена значений не была произведена.",
                    "Предупреждение ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                b.Num = x;
            }
            label1.Text = charr[0]+"";
            c = a + b;
            num3.Text = c.Num + "";
            den3.Text = c.Den + "";
        }

        private void den1_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (!int.TryParse(den1.Text, out x) || x == 0)
            {
                den1.Text = a.Den + "";
                MessageBox.Show("Введено некорректное значение, поэтому замена значений не была произведена.",
                    "Предупреждение ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                a.Den = x;
            }
            num1.Text = a.Num + "";
            den1.Text = a.Den + "";
            label1.Text = charr[0] + "";
            c = a + b;
            num3.Text = c.Num + "";
            den3.Text = c.Den + "";
        }

        private void den2_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (!int.TryParse(den2.Text, out x) || x == 0)
            {
                den2.Text = b.Den + "";
                MessageBox.Show("Введено некорректное значение, поэтому замена значений не была произведена.",
                    "Предупреждение ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                b.Den = x;
            }
            num2.Text = b.Num + "";
            den2.Text = b.Den + "";
            label1.Text = charr[0] + "";
            c = a + b;
            num3.Text = c.Num + "";
            den3.Text = c.Den + "";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            label1.Text = charr[0] + "";
            c = a + b;
            num3.Text = c.Num + "";
            den3.Text = c.Den + "";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            label1.Text = charr[1] + "";
            c = a - b;
            num3.Text = c.Num + "";
            den3.Text = c.Den + "";
        }

        private void Multiplications_Click(object sender, EventArgs e)
        {
            label1.Text = charr[2] + "";
            c = a * b;
            num3.Text = c.Num + "";
            den3.Text = c.Den + "";
        }

        private void Plus1_Click(object sender, EventArgs e)
        {
            ++a;
            num1.Text = a.Num + "";
            den1.Text = a.Den + "";
            label1.Text = charr[0] + "";
            c = a + b;
            num3.Text = c.Num + "";
            den3.Text = c.Den + "";
        }

        private void Minus1_Click(object sender, EventArgs e)
        {
            --a;
            num1.Text = a.Num + "";
            den1.Text = a.Den + "";
            label1.Text = charr[0] + "";
            c = a + b;
            num3.Text = c.Num + "";
            den3.Text = c.Den + "";
        }

        private void Div_Click(object sender, EventArgs e)
        {
            try
            {
                c = a / b;
                label1.Text = charr[3] + "";
                num3.Text = c.Num + "";
                den3.Text = c.Den + "";
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show("Деление на вторую дробь невозможно, поэтому операция не будет выполнена.",
                    "Предупреждение ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Десятичная форма ответа равна\n{c.Convert()}",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {
            int x;
            if(!int.TryParse(num1.Text, out x))
            {
                num1.Text = a.Num + "";
                MessageBox.Show("Введено некорректное значение, поэтому замена значений не была произведена.",
                    "Предупреждение ", MessageBoxButtons.OK,MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                a.Num = x;
            }
            label1.Text = charr[0] + "";
            c = a + b;
            num3.Text = c.Num + "";
            den3.Text = c.Den + "";
        }

        public OctopusColculator()
        {
            a = new Fraction(0, 1);
            b = new Fraction(0, 1);
            c = new Fraction(0, 1);
            InitializeComponent();
        }
    }
}
