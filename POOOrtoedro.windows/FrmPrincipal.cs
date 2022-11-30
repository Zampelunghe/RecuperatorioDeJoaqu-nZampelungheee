using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POOOrtaedro.entidades;
using POOOrtoedro.datos;

namespace POOOrtoedro.windows
{
    public partial class Frm_Principal : Form
    {
        private RepositorioDeOrtoedro repo = new RepositorioDeOrtoedro();
        private List<Ortoedro> listaOrtoedro;
        private int cantidad;
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            cargarComboFiltro();
            repo = new RepositorioDeOrtoedro();
            listaOrtoedro = repo.GetLista();
            cantidad = repo.GetCantidad();
            if (cantidad>0)
            {
                mostrarLista();
            }
            else
            {
                MessageBox.Show("repo vacio ","mensaje ",MessageBoxButtons.OK);
            }
            mostrarTotal();
        }

        private void cargarComboFiltro()
        {
            var listaortoedro = Enum.GetValues(typeof(ColorRelleno)).Cast<ColorRelleno>().ToList();
            foreach (var filtro in listaortoedro)
            {
                TrazosToolStripComboBox.Items.Add(filtro);
            }
        }

        private void mostrarLista()
        {
            OrtoedroGridView.Rows.Clear();
            foreach (var ortoedro in listaOrtoedro)
            {
                var r = ConstruirFila();
                setearFila(r, ortoedro);
                AgregarFila(r);
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            Frm_Nuevo frm = new Frm_Nuevo();
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            Ortoedro Nuevoortoedro = frm.GetOrtoedro();
            repo.Agregar(Nuevoortoedro);
            DataGridViewRow r = ConstruirFila();
            setearFila(r, Nuevoortoedro);
            AgregarFila(r);
            cantidad = repo.GetCantidad();
            mostrarTotal();
            repo.Guardar();

            


        }

        private void mostrarTotal()
        {
            CantidadTextBox.Text = cantidad.ToString();
        }

        private void AgregarFila(DataGridViewRow r)
        {
            OrtoedroGridView.Rows.Add(r);
        }

        private void setearFila(DataGridViewRow r, Ortoedro nuevoortoedro)
        {
            r.Cells[colAristaA.Index].Value = nuevoortoedro.AristaA.ToString();
            r.Cells[colAristaB.Index].Value = nuevoortoedro.AristaB.ToString();
            r.Cells[colAristaC.Index].Value = nuevoortoedro.AristaC.ToString();
            r.Cells[colArea.Index].Value = nuevoortoedro.GetArea().ToString();
            r.Cells[colVolumen.Index].Value = nuevoortoedro.GetVolumen().ToString();
            r.Cells[ColRelleno.Index].Value = nuevoortoedro.Relleno;

        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(OrtoedroGridView);
            return r;
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            repo.Guardar();
            DialogResult dr = MessageBox.Show("¿Desea salir del Programa?", "confirmar salida ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.No)
            {
                return;
            }
            Application.Exit();

        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (OrtoedroGridView.Rows.Count==0)
            {
                return;
            }
            var r = OrtoedroGridView.SelectedRows[0];
            Ortoedro Nuevoortoedro = (Ortoedro)r.Tag ;

            DialogResult dr =MessageBox.Show($"¿Desea borrar las Arista Del Ortoedro",
                "Confirmar Operación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (dr==DialogResult.No)
            {
                MessageBox.Show("el usuario no quiere borrar ");
                return;
            }
           
                repo.Borrar(Nuevoortoedro);
                listaOrtoedro.Remove(Nuevoortoedro);
                OrtoedroGridView.Rows.Remove(r);
                cantidad = repo.GetCantidad();
                mostrarTotal();
                repo.Guardar();
                MessageBox.Show("fila eliminada ", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

          




        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (OrtoedroGridView.Rows.Count==0)
            {
                return;
            }
            var r = OrtoedroGridView.SelectedRows[0];
            Ortoedro ortoedro = r.Tag as Ortoedro;
            Frm_Nuevo frm = new Frm_Nuevo() { Text = "Editar datos " };
            frm.setOrtoedro(ortoedro);

            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }
            ortoedro = frm.GetOrtoedro();
            setearFila(r, ortoedro);
            repo.Guardar();
            MessageBox.Show("fila agregada ");
        }

        private void tsbRefrescar_Click(object sender, EventArgs e)
        {
            listaOrtoedro = repo.GetLista();
            mostrarLista();
            cantidad = repo.GetCantidad();
            mostrarTotal();
        }

        private void GuardartoolStripButton1_Click(object sender, EventArgs e)
        {
            ManejadorDeArchivoSecuenciales.GuardarArchivoSecuenciales(repo.GetLista());
            MessageBox.Show("Registros Guardados ", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void ascendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ordenar = Orden.Acendente;
            listaOrtoedro = repo.OrdenarLista(ordenar);
            mostrarLista();
        }

        private void descendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ordenar = Orden.Decendente;
            listaOrtoedro = repo.OrdenarLista(ordenar);
            mostrarLista();
        }

        private void tsbOrdenar_Click(object sender, EventArgs e)
        {

        }
    }
}
