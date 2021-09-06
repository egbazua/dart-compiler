using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dart_compilador
{
    public partial class dart_Form : Form
    {
        public dart_Form()
        {
            InitializeComponent();
        }

        private void EjecutarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lexico = new Lexico(txtCodigoFuente.Text);
            lexico.EjecutarLexico();

            var objSintactico = new Sintactico(lexico.listaToken);
            objSintactico.EjecutarSintactico(objSintactico.listaTokens);

            List<Error> listaErroresLexico = lexico.listaErrorLexico;
            List<Error> listaErroresSintactico = objSintactico.listaError;
            List<Error> listaErrores = listaErroresLexico.Union(listaErroresSintactico).ToList();

            var lista = new BindingList<Token>(lexico.listaToken);
            lexico_Dgv.DataSource = null;
            lexico_Dgv.DataSource = lista;

            errores_Dgv.DataSource = null;
            // errores_Dgv.DataSource = listaErroresLexico;
            errores_Dgv.DataSource = listaErrores;
        }

        private void AutómataFinitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutomataFinito myAutomataFinito = new AutomataFinito();
            myAutomataFinito.Show();
        }

        private void TablaDeTokensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablaTokens myTablaTokens = new TablaTokens();
            myTablaTokens.Show();
        }

        private void CerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creado por: Enrique Gómez Bazúa ♥.");
        }
    }
}
