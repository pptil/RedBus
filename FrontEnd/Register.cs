using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Capsula;

namespace FrontEnd
{
    public partial class Register : Form
    {
        public Persona objPersona = new Persona();
    
        public CapsulaPersona objCapsulaPersona = new CapsulaPersona();
        


        public Register()
        {
            InitializeComponent();
        }

        private void TxtBox_a_Obj()
        {
            objPersona.DNI = int.Parse(txtDNI.Text);
            objPersona.CUIT = long.Parse(txtDNI.Text);
            objPersona.Nombre = txtNombre.Text;
            objPersona.Sexo = Convert.ToChar(cbSexo.SelectedItem);
            objPersona.Tdni = Convert.ToString(cbTDni.SelectedItem);
            objPersona.FechaNac = dtFechaNac.Value;
            objPersona.NroTarjeta = int.Parse(txtNroTar.Text);
            
        }
        private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlNumero(e);
           
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlNumero(e);
        }

        private void txtNroTar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlNumero(e);
        }

        private void ControlNumero(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            TxtBox_a_Obj();
            
            nGrabados = objCapsulaPersona.abmPersona("Alta", objPersona);

            if (nGrabados == -1)
            { lblInfo.Text = "  No pudo grabar la Persona en el sistema"; }
            else
            {
                lblInfo.Text = "  Se grabó con éxito Persona.";
            }

            
        }
    }
    
}
