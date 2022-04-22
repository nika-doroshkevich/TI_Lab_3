using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_3_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public static int g = 0, p = 0;
        public static string fileName = "";

        private void encryptButton_Click(object sender, EventArgs e)
        {
            currDataTextBox.Text = "";
            resultTextBox.Text = "";

            string xStr = (xTextBox.Text).ToString();
            string kStr = (kTextBox.Text).ToString();

            if (xStr == "" || kStr == "")
            {
                MessageBox.Show("Please, enter data!");
                return;
            }

            xStr = ToCorrectData(xStr);
            kStr = ToCorrectData(kStr);

            if (xStr == "" || kStr == "")
            {
                MessageBox.Show("Please, enter data consisting of digits!");
                return;
            }

            int x = int.Parse(xStr);
            int k = int.Parse(kStr);

            if (!check(x, k))
                return;

            int y = powByMod(g, x, p);

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(fs);
            fileName = fileName.Insert(fileName.LastIndexOf('.'), "New");
            BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.OpenOrCreate));

            byte b = 0;
            byte a = (byte)(powByMod(g, k, p));
            short b2 = 0;
            short a2 = (short)(powByMod(g, k, p));
            int input = 0;

            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                byte byteMessage = reader.ReadByte();
                if (input++ < 200)
                    currDataTextBox.Text += byteMessage.ToString() + " ";
                if (p < 256)
                {
                    b = (byte)(powByMod(y, k, p) * byteMessage % p);
                    if (input++ < 200)
                        resultTextBox.Text += a.ToString() + "," + b.ToString() + "  ";
                    writer.Write(a);
                    writer.Write(b);
                }
                else if (p < 65536)
                {
                    b2 = (short)(powByMod(y, k, p) * byteMessage % p);
                    if (input++ < 200)
                        resultTextBox.Text += a2.ToString() + "," + b2.ToString() + "  ";
                    writer.Write(a2);
                    writer.Write(b2);
                }
            }
            reader.Close();
            writer.Close();
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            currDataTextBox.Text = "";
            resultTextBox.Text = "";

            string xStr = (xTextBox.Text).ToString();
            string kStr = (kTextBox.Text).ToString();

            if (xStr == "" || kStr == "")
            {
                MessageBox.Show("Please, enter data!");
                return;
            }

            xStr = ToCorrectData(xStr);
            kStr = ToCorrectData(kStr);

            if (xStr == "" || kStr == "")
            {
                MessageBox.Show("Please, enter data consisting of digits!");
                return;
            }

            int x = int.Parse(xStr);
            int k = int.Parse(kStr);

            if (!check(x, k))
                return;

            int y = powByMod(g, x, p);

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(fs);
            fileName = fileName.Insert(fileName.LastIndexOf('.'), "New");
            BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.OpenOrCreate));

            byte b = 0;
            byte a = (byte)(powByMod(g, k, p));
            short b2 = 0;
            short a2 = (short)(powByMod(g, k, p));
            int input = 0;
            
            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                if (p < 256)
                {
                    a = reader.ReadByte();
                    b = reader.ReadByte();

                    byte t = decrypt(a, b, p, x);
                    if (input++ < 200)
                        resultTextBox.Text += t.ToString() + " ";
                    writer.Write(t);
                }
                else if (p < 65536)
                {
                    a2 = reader.ReadInt16();
                    b2 = reader.ReadInt16();

                    byte t = decrypt(a2, b2, p, x);
                    if (input++ < 200)
                        resultTextBox.Text += t.ToString() + " ";
                    writer.Write(t);
                } 
            }
            reader.Close();
            writer.Close();
        }

        public static bool check(int x, int k)
        {
            if (p == 0)
            {
                MessageBox.Show("Please, enter p!");
                return false;
            }

            if (!checkPrime(p))
            {
                MessageBox.Show("p is not prime!");
                return false;
            }

            if (p <= 255)
            {
                MessageBox.Show("p <= 255!");
                return false;
            }

            if (g == 0)
            {
                MessageBox.Show("Please, choose g!");
                return false;
            }

            if (!((GCD(k, p - 1) == 1) && k > 1 && k < (p - 1)))
            {
                MessageBox.Show("k is not coprime with p or not 1<k<p-1!");
                return false;
            }

            if(!(x > 1 && x < (p - 1)))
            {
                MessageBox.Show("x not 1<x<p-1!");
                return false;
            }

            if (fileName == "")
            {
                MessageBox.Show("Please, choose file!");
                return false;
            }

            return true;
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            if (Dialog.ShowDialog() == DialogResult.OK)
                fileName = Dialog.FileName;
        }

        private static string ToCorrectData(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
                if (str[i] >= '0' && str[i] <= '9')
                    result += str[i];

            return result;
        }

        private void pTextBox_Leave(object sender, EventArgs e)
        {
            string pStr = (pTextBox.Text).ToString();
            if (pStr == "")
            {
                MessageBox.Show("Please, enter p!");
                chooseGListBox.Items.Clear();
                countOfGTextBox.Text = "";
                return;
            }

            pStr = ToCorrectData(pStr);
            if (pStr == "")
            {
                MessageBox.Show("Please, enter p consisting of digits!");
                return;
            }

            p = int.Parse(pStr);

            if (!checkPrime(p))
            {
                MessageBox.Show("p is not prime!");
                return;
            }

            if (chooseGListBox.Items.Count != 0)
                chooseGListBox.Items.Clear();

            int count = 0;
            foreach (int i in findAntid(p))
            {
                chooseGListBox.Items.Add(i.ToString());
                count++;
            }

            countOfGTextBox.Text = count.ToString();
        }

        private void chooseGListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            g = int.Parse(chooseGListBox.SelectedItem.ToString());
        }

        public static List<int> findAntid(int p)
        {
            HashSet<int> prime = findPrimeDiv(p - 1);
            List<int> antid = new List<int>();
            for (int x = 2; x < p; x++)
            {
                bool f = true;
                foreach (int s in prime)
                    f = f && powByMod(x, (p - 1) / s, p) != 1;
                if (f)
                    antid.Add(x);
            }

            return antid;
        }

        public static HashSet<int> findPrimeDiv(int num)
        {
            if (num == 1)
                return new HashSet<int>(1);
            int i;
            for (i = 2; num % i != 0; i++) ;
            HashSet<int> hs = new HashSet<int>();
            hs.Add(i);
            foreach (int x in findPrimeDiv(num / i))
                hs.Add(x);

            return hs;
        }

        public static bool checkPrime(int number)
        {
            if (number == 2)
                return true;
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                int randomNumber = r.Next(2, number);
                if (GCD(randomNumber, number) != 1)
                    return false;
                if (powByMod(randomNumber, number - 1, number) != 1)
                    return false;
            }
            return true;
        }

        public static int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }

        public static int powByMod(int a, int b, int m)
        {
            if (b == 0)
                return 1;
            if (b % 2 == 0)
            {
                int t = powByMod(a, b / 2, m);
                return t * t % m;
            }

            return a * powByMod(a, b - 1, m) % m;
        }

        public static byte decrypt(int a, int b, int p, int x)
        {
            int inversA = powByMod(a, p - 2, p);
            int temp = powByMod(inversA, x, p);
            byte m = (byte)(b * temp % p);
            return m;
        }
        
    }
}
