using System;
using System.Windows.Forms;
using Entidades;
using Capsula;

namespace FrontEnd
{
    public partial class Register : Form
    {
        #region inicializadores
        public Persona objPersona = new Persona();
        public Tarjeta objTarjeta = new Tarjeta();

        public CapsulaPersona objCapsulaPersona = new CapsulaPersona();
        public CapsulaTarjeta capsulaTarjeta = new CapsulaTarjeta();

        bool validar = true;

        #endregion

        public Register()
        {
            InitializeComponent();            
        }

        public bool validacion()
        {          
            if (txtCUIT.Text == null || txtDNI.Text == null || txtNombre.Text == null || cbTDni.SelectedItem == null ||cbSexo.SelectedItem == null)
            { validar = false; }

            return validar;
        }


        private void TxtBox_a_Obj()
        {
            
                objPersona.DNI = int.Parse(txtDNI.Text);
                objPersona.CUIT = long.Parse(txtCUIT.Text);
                objPersona.Nombre = txtNombre.Text;
                objPersona.Sexo = Convert.ToChar(cbSexo.SelectedItem);
                objPersona.Tdni = Convert.ToString(cbTDni.SelectedItem);
                objPersona.FechaNac = dtFechaNac.Value;
                //objPersona.NroTarjeta = int.Parse(txtNroTar.Text);
                
  
            
            
        }

        #region KeyPress
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlLetra(e);
        }
        private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlNumero(e);
           
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ControlLetra(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion

        private void btnReg_Click(object sender, EventArgs e)
        {       
        validacion();
         
            int nGrabados = -1;
            

            TxtBox_a_Obj();

               
            nGrabados = objCapsulaPersona.abmPersona("Alta", objPersona);

            if (nGrabados == -1)
            { lblInfo.Text = " Error al registrar la persona"; }

            else
            {
                  lblInfo.Text = "  Se grabó con éxito Persona.";
            }
                

                                                            
        }

        private void dtFechaNac_ValueChanged(object sender, EventArgs e)
        {
            // Guardar la fecha actual en una variable
            var today = DateTime.Today;
            // Calcular la edad
            var age = today.Year - dtFechaNac.Value.Year;
            // Restar un año si no cumplio años 
            if (dtFechaNac.Value.Date > today.AddYears(-age)) age--;
            lbledad.Text = age.ToString();
        }

 
    }
    
}
