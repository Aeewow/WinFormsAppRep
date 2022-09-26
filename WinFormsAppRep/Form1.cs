namespace WinFormsAppRep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lineReplace.Text = Properties.Settings.Default.text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = this.lineReplace.Text;

            Properties.Settings.Default.text = text;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.Swap(text));
        }

        private void lineReplace_TextChanged(object sender, EventArgs e)
        {
            
        }
        public class Logic
        {
            public static string Swap(string text)
            {
                string textReplace = text;
                textReplace = textReplace.Replace('ì', 'ñ').Replace('ó', 'ë').Replace('õ', 'î').Replace('à', 'í');
                return textReplace;
            }
        }
    }
}