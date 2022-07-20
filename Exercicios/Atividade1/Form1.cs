namespace Atividade1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(txt1.Text);
            int num2 = Convert.ToInt16(txt2.Text);
            int num3 = Convert.ToInt16(txt3.Text);

            int maior = 0;
            int menor = 0;

            int[] list = new int[]
            {
                num1, num2, num3
            };

            for (int i = 0; i < list.Length; i++)
            {
                if (i == 0)
                {
                maior = list[i];
                menor = list[i];
                }
                else
                {
                    if (list[i] >= maior)
                    {
                        maior = list[i];
                    }
                    if (list[i] <= menor)
                    {
                        menor = list[i];
                    }
                }
            }

            lista.Items.Add("Maior: " + maior);
            lista.Items.Add("Menor: " + menor);
        }
    }
}