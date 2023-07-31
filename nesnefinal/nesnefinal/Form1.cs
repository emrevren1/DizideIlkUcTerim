using System.Runtime.ConstrainedExecution;

namespace nesnefinal
{
    public partial class Form1 : Form
    {

        int m;
        int m4;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i <= 3; i++)
            {
                listBox1.Items.Add(m + i);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}