namespace Calculadora
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        Clases.ClaseSuma obj = new Clases.ClaseSuma();
        Clases.ClaseRestar obj2 = new Clases.ClaseRestar();
        Clases.ClaseMultiplicar obj3 = new Clases.ClaseMultiplicar();
        Clases.ClaseDividir obj4 = new Clases.ClaseDividir();
        private void btn0_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxScreen.Text);
            double suma, resta, multi, divi;
            switch (operador)
            {
                case "+":
                    suma = obj.Sumar((primero), (segundo));
                    tbxScreen.Text = suma.ToString();
                    break;

                case "-":
                    resta = obj2.Restar((primero), (segundo));
                    tbxScreen.Text = resta.ToString();
                    break;

                case "*":
                    multi = obj3.Multiplicar((primero), (segundo));
                    tbxScreen.Text = multi.ToString();
                    break;

                case "/":
                    divi = obj4.Dividir((primero), (segundo));
                    tbxScreen.Text = divi.ToString();
                    break;
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Length == 1)
                tbxScreen.Text = "";
            else
                tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
        }
    }
}