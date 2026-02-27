namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reverseString(object sender, EventArgs e)
        {
            string sInputText = txtStringInput.Text;
            sInputText = ReverseStringDirect(sInputText);
            lblOutputLabel.Text = sInputText;
        }

        public static string ReverseStringDirect(string s)
        {
            char[] array = new char[s.Length];
            int forward = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                array[forward++] = s[i];
            }
            return new string(array);
        }

        private void btnFizzBuzz_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                } else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                } else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                } else
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
