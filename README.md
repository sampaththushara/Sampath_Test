# Sampath_Test - Here is the main code ...

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

        // Check the last number
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
                    else
                    {
                        break;
                    }
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return LastNum;
        }
		//increase the last digit part by 1
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
                    SetMessage(newval);
                }
                else
                {
                    SetMessage(OriginalString);
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetMessage(string FinVal)
        {
            MessageBox.Show(FinVal);
        }
    }
