using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mystring1 = textBoxInputStr.Text.Trim();
                char[] chararray = mystring1.ToCharArray();
                Increment(chararray);
            }
            catch (SyntaxErrorException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // check the last number
        private string CheckLastNumeric(char[] chararray)
        {
            string LastNum = "";
            try
            {
                for (int i = chararray.Length; i > 0; i--)
                {
                    char p = chararray[i - 1];
                    bool isInteger = char.IsDigit(p);
                    if (isInteger)
                    {
                        LastNum = p.ToString() + LastNum;
                    }
                    else break;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return LastNum;
        }

        private void Increment(char[] referenceNumber)
        {
            try
            {
                string myLastNo = CheckLastNumeric(referenceNumber);
                string OriginalString = new string(referenceNumber);
                if (myLastNo != "")
                {
     
                    string x = (int.Parse(myLastNo) + 1).ToString();
                    string y = (int.Parse(myLastNo)).ToString();


                    if (x.Length > y.Length)
                    {
                        x = x.Substring(x.Length - y.Length);
                    }
                    string newval = OriginalString.Replace(y, x);

                    setmessage(newval);
                }
                else setmessage(OriginalString);
            
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
        private void setmessage(string FinVal)
        {
            MessageBox.Show(FinVal);
        }

    }
}
