namespace Password_randomizer_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] letters = { "&", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "{", "}", "[", "]", "|", "\",", "; ", "<", ">", ",", ".", "/", "?", "~", "$", "€" };
            Random random = new Random();
            int index = random.Next(letters.Length);

            string password = letters[random.Next(index)];
            for (int i = 0; i < 12; i++)
            {
                Console.Write(password);
                password += letters[random.Next(index)];
            }


            textBox1.Text = password;


        }
    }
}
