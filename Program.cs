using System;

namespace ConsoleApp1
{
    public partial class Form1 : Form
    {
        Empleado myEmpleado = new Empleado();
        Nomina myNomina = new Nomina();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnAlmacenarRegistro_Click(Object sender, EventArgs e)
        {
            myEmpleado.Nombre = txtNombre.Text;
            myEmpleado.Identificacion = txtIdentificacion.Text;
            myEmpleado.AsignacionDia = Convert.ToDecimal(txtAsignacionDia.Text);
            myNomina.DiasLaborados = Convert.ToInt32(txtDiasLaborados.Text);
            MessageBox.Show("El registro se guardo correctamente ");
        }
        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            txtTotalDevengado.Text = myNomina.CalcularNomina(Convert.ToInt32(myNomina.DiasLaborados),Convert.ToDecimal(tomyEmpleado.AsignacionDia)).ToString();
        }
    }

}
