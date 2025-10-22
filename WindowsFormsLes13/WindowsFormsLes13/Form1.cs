using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLes13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked)
                MessageBox.Show("Установлен первый флажок");
            else if (checkBox2.Checked && !checkBox1.Checked)
                MessageBox.Show("Установлен второй флажок");
            else if(checkBox1.Checked && checkBox2.Checked)
                MessageBox.Show("Установлено два флажка");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("Установлена первая радио кнопка");
            else if (radioButton2.Checked)
                MessageBox.Show("Установлена вторая радио кнопка");
            else if (radioButton1.Checked)
                MessageBox.Show("Установлена третья радио кнопка");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioButton4.Checked)
                gender = "Мужской";
            else if (radioButton5.Checked)
                gender = "Женский";

            List<string> hobbies = new List<string>();
            if (checkBox3.Checked) hobbies.Add("Чтение");
            if (checkBox4.Checked) hobbies.Add("Музыка");
            if (checkBox5.Checked) hobbies.Add("Спорт");
            if (checkBox6.Checked) hobbies.Add("Путешествия");

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    if (radioButton4.Checked || radioButton5.Checked)
                    {
                        if (checkBox3.Checked || checkBox4.Checked || checkBox5.Checked || checkBox6.Checked)
                        {
                            string result = "Имя: " + textBox1.Text + "\n" + "Возраст: " + textBox2.Text + "\n" + "Пол: " + gender + "\n" + "Хобби: " + string.Join(",", hobbies);
                            MessageBox.Show(result);
                        }
                        else
                            MessageBox.Show("Укажите хотя бы одно хобби");
                    }
                    else
                        MessageBox.Show("Укажите пол");
                }
                else
                    MessageBox.Show("Введите возраст");
            }
            else
                MessageBox.Show("Введите имя");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (checkBox7.Checked)
            {
                sum += 1000;
                if(checkBox8.Checked)
                {
                    sum += 500;
                    if(checkBox9.Checked)
                    {
                        sum += 1500;
                    }
                }
            }
            label4.Text = "Итоговая сумма" + sum;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                MessageBox.Show("Твой любимый цвет - Красный");
                this.BackColor = Color.Red;
            }
            else if (radioButton7.Checked)
            { 
                MessageBox.Show("Твой любимый цвет - Синий");
                this.BackColor = Color.Blue;
            }
            else if (radioButton8.Checked)
            {
                MessageBox.Show("Твой любимый цвет - Зеленый");
                this.BackColor = Color.Green;
            }
            else if (radioButton9.Checked)
            {
                MessageBox.Show("Твой любимый цвет - Желтый");
                this.BackColor = Color.Yellow;
            }
        }
    }
}
