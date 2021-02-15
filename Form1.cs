using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class Convertor : Form
    {
        public Convertor()
        {
            InitializeComponent();
        }

        private string ConvertToDec(string num, int based)
        {
            num = num.ToUpper();
            char[] val = num.ToCharArray();
            Array.Reverse(val);
            double res = 0;
            for (int i = 0; i < val.Length; i++)
            {
                int temp;
                switch (val[i])
                {
                    case 'A':
                        temp = 10;
                        break;
                    case 'B':
                        temp = 11;
                        break;
                    case 'C':
                        temp = 12;
                        break;
                    case 'D':
                        temp = 13;
                        break;
                    case 'E':
                        temp = 14;
                        break;
                    case 'F':
                        temp = 15;
                        break;
                    default:
                        temp = Convert.ToInt32(val[i].ToString());
                        break;
                }
                res += temp * Math.Pow(based, i);
               
            }
            return res.ToString();
        }

        private string ConvertDecToSmth(int num, int a)
        {
            string res = "";
            List<int> list = new List<int>();
            while (num >= a)
            {
                list.Add(num % a);
                num = Convert.ToInt32(Math.Floor((decimal)num / a));
            }
            list.Add(num);

            list.Reverse();
            foreach (int item in list)
            {
                switch (item)
                {
                    case 10:
                        res += "A";
                        break;
                    case 11:
                        res += "B";
                        break;
                    case 12:
                        res += "C";
                        break;
                    case 13:
                        res += "D";
                        break;
                    case 14:
                        res += "E";
                        break;
                    case 15:
                        res += "F";
                        break;
                    default:
                        res += item.ToString();
                        break;
                }
                

            }
            return res;
        }
       
        private void hexBox_TextChanged(object sender, EventArgs e)
        {
            hexBox.SelectionStart = hexBox.Text.Length;
            bool temp = false;
            string str = hexBox.Text.ToUpper();
            char[] helper = str.ToCharArray();
            for (int i = 0; i < helper.Length; i++)
            {

                if (!((helper[i]>=48 && helper[i]<=57) || (helper[i] >= 65 && helper[i] <= 70)))
                {
                    temp = true;
                    break;
                }
            }
            
            if (temp)
            {
                hexBox.Text = hexBox.Text.Substring(0, hexBox.Text.Length - 1);
            }
            else
            {
                if (str.Length != 0)
                {
                    try
                    {
                        string t = ConvertToDec(hexBox.Text, 16);
                        decBox.Text = t;
                        octBox.Text = ConvertDecToSmth(Convert.ToInt32(t), 8);
                        binBox.Text = ConvertDecToSmth(Convert.ToInt32(t), 2);
                    }
                    catch
                    {
                        MessageBox.Show("Значение вне диапазона!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        hexBox.Text = "";

                    }
                }
                else
                {
                    decBox.Text = "";
                    octBox.Text = "";
                    binBox.Text = "";
                }

            }

        }

        private void decBox_TextChanged(object sender, EventArgs e)
        {
            decBox.SelectionStart = decBox.Text.Length;
            bool temp = false;
            string str = decBox.Text.ToUpper();
            char[] helper = str.ToCharArray();
            for (int i = 0; i < helper.Length; i++)
            {
                if (!(helper[i] >= 48 && helper[i] <= 57))
                {
                    temp = true;
                    break;
                }
            }
            if (temp)
            {
                decBox.Text = decBox.Text.Substring(0, decBox.Text.Length - 1);
            }
            else
            {
                if (str.Length != 0)
                {
                    try
                    {
                        hexBox.Text = ConvertDecToSmth(Convert.ToInt32(str), 16);
                        octBox.Text = ConvertDecToSmth(Convert.ToInt32(str), 8);
                        binBox.Text = ConvertDecToSmth(Convert.ToInt32(str), 2);
                    }
                    catch
                    {
                        MessageBox.Show("Значение вне диапазона!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        decBox.Text = "";

                    }
                }
                else
                {
                    hexBox.Text = "";
                    octBox.Text = "";
                    binBox.Text = "";
                }
            }
        }

        private void octBox_TextChanged(object sender, EventArgs e)
        {
            octBox.SelectionStart = octBox.Text.Length;
            bool temp = false;
            string str = octBox.Text.ToUpper();
            char[] helper = str.ToCharArray();
            for (int i = 0; i < helper.Length; i++)
            {
                if (!(helper[i] >= 48 && helper[i] <= 55))
                {
                    temp = true;
                    break;
                }
            }
            if (temp)
            {
                octBox.Text = octBox.Text.Substring(0, octBox.Text.Length - 1);
            }
            else
            {
                if (str.Length != 0)
                {
                    try
                    {
                        string t = ConvertToDec(octBox.Text, 8);
                        decBox.Text = t;
                        hexBox.Text = ConvertDecToSmth(Convert.ToInt32(t), 16);
                        binBox.Text = ConvertDecToSmth(Convert.ToInt32(t), 2);
                    }
                    catch
                    {
                        MessageBox.Show("Значение вне диапазона!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        octBox.Text = "";

                    }
                }
                else
                {
                    decBox.Text = "";
                    hexBox.Text = "";
                    binBox.Text = "";
                }
            }
        }

        private void binBox_TextChanged(object sender, EventArgs e)
        {
            binBox.SelectionStart = binBox.Text.Length;
            bool temp = false;
            string str = binBox.Text.ToUpper();
            char[] helper = str.ToCharArray();
            for (int i = 0; i < helper.Length; i++)
            {
                if (!(helper[i] >= 48 && helper[i] <= 49))
                {
                    temp = true;
                    break;
                }
            }
            if (temp)
            {
                binBox.Text = binBox.Text.Substring(0, binBox.Text.Length - 1);
            }
            else
            {
                if (str.Length != 0)
                {
                    try
                    {
                        string t = ConvertToDec(binBox.Text, 2);
                        decBox.Text = t;
                        hexBox.Text = ConvertDecToSmth(Convert.ToInt32(t), 16);
                        octBox.Text = ConvertDecToSmth(Convert.ToInt32(t), 8);
                    }
                    catch
                    {
                        MessageBox.Show("Значение вне диапазона!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        binBox.Text = "";

                    }
                }
                else
                {
                    decBox.Text = "";
                    hexBox.Text = "";
                    octBox.Text = "";
                }
            }
        }
    }
}
