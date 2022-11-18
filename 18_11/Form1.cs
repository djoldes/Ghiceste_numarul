using System.ComponentModel;
using System.Net.Http.Headers;

namespace _18_11
{
    public partial class Form1 : Form
    {
        int[] numar = new int[4];
        int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            numar[0] = rnd.Next(1, 9);
            numar[1] = rnd.Next(0, 9);
            numar[2] = rnd.Next(0, 9);
            numar[3] = rnd.Next(0, 9);
            bool[] exista = new bool[10];
            for(int i=0; i<numar.Length; i++) {
                if (!exista[numar[i]])
                {
                    exista[numar[i]] = true;
                }
                else
                {
                    while (exista[numar[i]])
                    {
                        numar[i]=rnd.Next(0, 9);
                    }
                }
            }
            MessageBox.Show($"{numar[0]}{numar[1]}{numar[2]}{numar[3]}");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = 0;
            int c = 0;
            int numarint = int.Parse(textBox1.Text);
            int[] result = numarint.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            for(int i=0; i<numar.Length; i++)
            {
                for(int j = 0; j < result.Length; j++)
                {
                    if (numar[i] == result[j] && i==j)
                    {
                        c++;
                        break;
                    }
                    if(numar[i] == result[j] && i != j)
                    {
                        p++;
                        break;
                    }
                }
            }
            label1.Text = c.ToString();
            label2.Text = p.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}