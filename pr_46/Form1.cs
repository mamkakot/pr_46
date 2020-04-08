using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr_46
{
    public partial class Form1 : Form
    {
        // для того, чтобы зашифровать сообщение, нужно ввести его в текстовое поле,
        // а также ввести ключ шифрования
        // для расшифровки ввести тот же ключ и нажать на кнопку "расшифровать"
        public Form1()
        {
            InitializeComponent();
        }

        // открытие зашифрованного файла
        private void Btn_OpenFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Title = "Открыть зашифрованный файл",
                InitialDirectory = @"C:\",
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // просто вывод в текстовое поле
                Rtb_Main.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
            }
        }

        // сохранение текста в зашифрованном виде
        private void Btn_SaveFile_Click(object sender, EventArgs e)
        {
            var keyword = Tb_Keyword.Text;
            // удаление пробелов в начале и в конце
            var text = Rtb_Main.Text.Trim();
            // кол-во строк в таблице шифровки
            var height = (int)Math.Ceiling(text.Length / (double)keyword.Length);
            var cripter = new Crypter(height, keyword);
            // вызов метода из объекта cripter для зашифровки
            var criptedText = cripter.Encode(text);
            var saveFileDialog = new SaveFileDialog
            {
                Title = "Сохранить зашифрованный файл",
                InitialDirectory = @"C:\",
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                var path = saveFileDialog.FileName;
                System.IO.File.WriteAllText(path, criptedText);
            }
        }

        // расшифровка сообщения
        private void Btn_Decode_Click(object sender, EventArgs e)
        {
            var keyword = Tb_Keyword.Text;
            var text = Rtb_Main.Text;
            var height = (int)Math.Ceiling(text.Length / (double)keyword.Length);
            var cripter = new Crypter(height, keyword);
            // вызов метода из объекта cripter для расшифровки
            var decriptedText = cripter.Decode(text);
            Rtb_Main.Text = decriptedText;
        }
    }


    // этот класс я скопировал с киберфорума, но он хорошо работает
    class Crypter
    {
        int width;
        int height;
        int[] permutation;

        // конструктор, в который передаётся количество строк таблицы с текстом
        public Crypter(int height, string keyword)
        {
            width = keyword.Length;
            this.height = height;
            // массив целых чисел для перестановки
            permutation = new int[keyword.Length];
            // сначала заполняется целыми числами
            for (int i = 0; i < permutation.Length; i++)
            {
                permutation[i] = i;
            }
            // потом сортируется в зависимости от мест букв ключа в алфавите
            Array.Sort(keyword.ToCharArray(), permutation);
        }

        public string Encode(string src)
        {
            char[] res = new char[height * width];
            // здесь заполнение пробелами, если длина строки меньше длины таблицы
            // чтобы ошибку не выдавало
            if (src.Length < res.Length)
            {
                for (int i = 0; i <= res.Length - src.Length; i++)
                {
                    src += " ";
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    var t = src[permutation[j] * height + i];
                    res[i * width + j] = t;
                }
            }
            return new string(res);
        }

        public string Decode(string src)
        {
            char[] res = new char[width * height];
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    res[permutation[i] * height + j] = src[j * width + i];
            return new string(res);
        }
    }
}
