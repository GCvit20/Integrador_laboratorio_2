using Entidades;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Trabajo_integrador_laboratorio_2
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();

            rdbDecimal.TabIndex = 0;
            rdbBinario.TabIndex = 1;
            txtPrimerOperador.TabIndex = 2;
            txtSegundoOperador.TabIndex = 3;
            cmbOperacion.TabIndex = 4;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblSegundoOperador_Click(object sender, EventArgs e)
        {

        }

        private void LblOperacion_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] options = new string[] { "+", "-", "/", "*" };


            foreach (string option in options)
            {
                this.cmbOperacion.Items.Add(option);
            }
        }

        private void LblPrimerOperador_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea salir?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {

            // Obtener valores de las cajas de texto y el ComboBox
            string valorPrimerOperador = txtPrimerOperador.Text;
            string valorSegundoOperador = txtSegundoOperador.Text;
            string operador = cmbOperacion.SelectedItem.ToString();

            // Crear instancias de Numeracion
            Numeracion primerNumero = new Numeracion(valorPrimerOperador, Numeracion.ESistema.Decimal); // Supongamos que los valores ingresados son decimales
            Numeracion segundoNumero = new Numeracion(valorSegundoOperador, Numeracion.ESistema.Decimal); // Supongamos que los valores ingresados son decimales

            // Crear una instancia de Operacion
            Operacion operacion = new Operacion(primerNumero, segundoNumero);

            // Realizar la operación
            Numeracion resultado = operacion.Operar(operador[0]); // Convertimos el operador a char

            // Mostrar el resultado en el Label
            //label1.Text = resultado.Valor;

            if (this.rdbDecimal.Checked) 
            {
                label1.Text = resultado.Valor;
            }
            else if (this.rdbBinario.Checked) 
            {
                resultado = new Numeracion(resultado.Valor, Numeracion.ESistema.Binario);
                label1.Text = resultado.Valor;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtPrimerOperador.Clear();
            this.txtSegundoOperador.Clear();
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void grpSistema_Enter(object sender, EventArgs e)
        {

        }
    }
}