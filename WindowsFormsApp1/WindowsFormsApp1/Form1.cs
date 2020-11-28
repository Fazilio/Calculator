using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text; // Кнопка, которая реагирует на события 
        }

        double a = 0, b = 0, c = 0; // Пременные

        private void button19_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            switch (znak) // Проверка znak
            {
                case '+': c = a + b;
                    break;
                case '-': c = a - b;
                    break;
                case '*': c = a * b;
                    break;
                case '/': c = a / b;
                    break;
            }
            textBox1.Text = c.ToString(); 
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="")
                if (textBox1.Text[0] == '-')
                    textBox1.Text = textBox1.Text.Remove(0, 1);   // Возвращает строку без определенного кол-ва символов
                else textBox1.Text = '-' + textBox1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1); // Удаляет последний символ
        }

       /* private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if ((Convert.ToDouble(textBox1.Text) == (int)((Convert.ToDouble(textBox1.Text))) &&
                    ((Convert.ToDouble(textBox1.Text) >= 0.0))
                {
                    a = Convert.ToDouble(textBox1.Text);

                    textBox1.Text = Factorial().ToString();

                    Clear_A();
                    FreeButtons();
                }
                else
                    MessageBox.Show ("Число должно быть >= 0 и целым ")
            }
        }
       */

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        char znak = '+';

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text); // Переводим в тип double
            znak = (sender as Button).Text[0];
            textBox1.Clear(); // Очистка 
        }
    }
}
