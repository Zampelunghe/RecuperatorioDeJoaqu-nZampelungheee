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

namespace POOOrtoedro.windows
{
    public partial class Frm_Nuevo : Form
    {
        private Ortoedro ortoedro;
        public Frm_Nuevo()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LlenarComboBOX();
            if (ortoedro != null)
            {
                AristaATextBox.Text = ortoedro.AristaA.ToString();
                AristaBtextBox1.Text = ortoedro.AristaB.ToString();
                AristaCtextBox2.Text = ortoedro.AristaC.ToString();
                RellenoComboBox.SelectedItem = (ColorRelleno)ortoedro.Relleno;
            }

        }

        private void LlenarComboBOX()
        {
            RellenoComboBox.DataSource = Enum.GetValues(typeof(ColorRelleno));
            RellenoComboBox.SelectedItem = 0;
                
        }

        private void RellenoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        internal Ortoedro GetOrtoedro()
        {
            return ortoedro;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (validarDatos()) 
            {
                if (ortoedro==null)
                {
                    ortoedro = new Ortoedro();
                }
                ortoedro.AristaA = int.Parse(AristaATextBox.Text);
                ortoedro.AristaB = int.Parse(AristaBtextBox1.Text);
                ortoedro.AristaC = int.Parse(AristaCtextBox2.Text);
                ortoedro.Relleno = (ColorRelleno)RellenoComboBox.SelectedItem;

                if (ortoedro.validarOrtoedro())
                {
                    DialogResult = DialogResult.OK; 
                }
            }
            
            

        }

        private bool validarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (!int.TryParse(AristaATextBox.Text,out int AristaA))
            {
                errorProvider1.SetError(AristaATextBox,"Arista mal Escrita ");
                valido = false;
            }
            else if (AristaA<=0)
            {
                errorProvider1.SetError(AristaATextBox, "La arista debe ser mayor a 0 ");
                valido = false;
            }
             if (!int.TryParse(AristaBtextBox1.Text,out int AristaB))
            {
                errorProvider1.SetError(AristaBtextBox1, "Arista mal escrita ");
                    valido = false;
            }
            else if (AristaB<=0)
            {
                errorProvider1.SetError(AristaBtextBox1, "Arista debe ser mayor a 0 ");
                    valido = false;
            }

            if (!int.TryParse(AristaCtextBox2.Text,out int AristaC))
            {
                errorProvider1.SetError(AristaCtextBox2, "arista mal escrita ");
                valido = false;
            }
            else if (AristaC<0)
            {
                errorProvider1.SetError(AristaCtextBox2, "arista tiene que ser mayor a 0 ");
                valido = false;
            }
            return valido;


        }

        internal void setOrtoedro(Ortoedro ortoed)
        {
            ortoedro = ortoed;
        }
    }
}
