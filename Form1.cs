namespace SobrecargaMetodos_2026_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            float sumando1 = float.Parse(txtbSumando1.Text);
            float sumando2 = float.Parse(txtbSuumando2.Text);
            float resultado = sumar(sumando1, sumando2);
            lbSuma.Text = resultado.ToString();

        }
       

        private void btnSumar1_Click(object sender, EventArgs e)
        {
            float sumando1 = float.Parse(txtbSumando11.Text);
            float sumando2 = float.Parse(txtbSumando12.Text);
            float sumando3 = float.Parse(txtbSumando13.Text);
            float resultado = sumar(sumando1, sumando2, sumando3);

            lbSuma1.Text = resultado.ToString();
        }

        private float sumar(float sumando1, float sumando2)
        {
            return sumando1 + sumando2;
        }

        private float sumar(float sumando1,float sumando2, float sumando3)
        {
            return sumando1 + sumando2 + sumando3;
        }
    }
}
