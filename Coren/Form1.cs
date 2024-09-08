using System.Windows.Forms;
namespace Coren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Math.Sqrt(double.Parse(textBox1.Text)));
        }
    }
}