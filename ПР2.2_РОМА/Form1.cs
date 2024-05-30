using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ПР2._2_РОМА
{
    public partial class Form1 : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        public Form1()
        {
            InitializeComponent();
        }
        private bool WordHaveNumber(string input)// Метод для проверки наличия цифр в строке
        {
            foreach (char c in input) // Цикл по символам во входной строке
            {
                if (Char.IsDigit(c)) // Проверка, является ли символ цифрой
                {
                    return true; // Возвращаем true, если найдена цифра
                }
            }
            return false;  // Возвращаем false, если цифр не найдена
        }
        private async void calculation_button_1_Click(object sender, EventArgs e)
        {
            string inputString = InputTextBox.Text;
            if (String.IsNullOrWhiteSpace(inputString))
            {
                errorProvider.SetError(InputTextBox, "Ошибка: введите строку!");
                await Task.Delay(2000);
                errorProvider.SetError(InputTextBox, "");
            }
            else if (WordHaveNumber(inputString))
            {
                errorProvider.SetError(InputTextBox, "Ошибка: строка не должна содержать числа!");
                await Task.Delay(2000);
                errorProvider.SetError(InputTextBox, "");
            }
            else
            {
                inputString = InputTextBox.Text.Replace(" ", ""); // Удаляем пробелы
                Dictionary<char, int> charCountDictionary = new Dictionary<char, int>();
                foreach (char c in inputString)
                {
                    if (charCountDictionary.ContainsKey(c)) // Цикл по символам в очищенной строке
                    {
                        charCountDictionary[c]++; // Увеличиваем счетчик вхождений символа
                    }
                    else
                    {
                        charCountDictionary[c] = 1; // Добавляем символ в словарь
                    }
                }
                ResultTextBox.Text = "Словарь из строки: \r"; // Устанавливаем заголовок результата
                foreach (KeyValuePair<char, int> kvp in charCountDictionary) // Цикл по парам ключ-значение в словаре
                {
                    ResultTextBox.Text += $"{kvp.Key}: {kvp.Value}, "; // Добавляем информацию о символе и количестве в текстовое поле
                }
                ResultTextBox.Text = ResultTextBox.Text.TrimEnd(',', ' ') + "."; // Убираем лишние символы в конце текста результата
            }
        }
        private void close_1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void clear_Click(object sender, EventArgs e)
        {
            InputTextBox.Clear();
            ResultTextBox.Clear();
        }
        private void close_2_Click(object sender, EventArgs e)
        {
            close_1_Click(sender, e);
        }
        private void aboutTheProgram_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }
        private void calculation_button_2_Click(object sender, EventArgs e)
        {
            calculation_button_1_Click(sender,e);
        }
    }
}