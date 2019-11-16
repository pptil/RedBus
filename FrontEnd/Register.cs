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
        public Tarjeta objTarjeta = new Tarjeta();

        public CapsulaPersona objCapsulaPersona = new CapsulaPersona();
        public CapsulaTarjeta capsulaTarjeta = new CapsulaTarjeta();

        bool validar = true;

        public Register()
        {
            InitializeComponent();
            
        }

        public bool validacion()
        {
           
            if (txtCUIT.Text == null || txtDNI.Text == null || txtNombre.Text == null || cbTDni.SelectedItem == null ||cbSexo.SelectedItem == null || txtNroTar.Text == null )
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
            //try
            //{
            //    objTarjeta.NroTarjeta = int.Parse(txtNroTar.Text);
            //    DataSet ds = new DataSet();

            //    ds = capsulaTarjeta.listadoTarjetas(objTarjeta.NroTarjeta.ToString());


            //}
            //catch
            //{
            //    MessageBox.Show("La tarjeta ya existe");
            //}
            validacion();
          if (validar == true )
          {
                int nGrabados = -1;
                int verificacion = -1;

                TxtBox_a_Obj();


                verificacion = objCapsulaPersona.abmPersona("Verify", objPersona);

                if (verificacion == -1)
                {
                    nGrabados = objCapsulaPersona.abmPersona("Alta", objPersona);

                    if (nGrabados == -1)
                    { lblInfo.Text = " Error al registrar la persona"; }

                    else
                    {
                        lblInfo.Text = "  Se grabó con éxito Persona.";
                    }
                }

                else
                {
                    MessageBox.Show("La Tarjeta ya Existe", "Error");
                }
          }
          if (validar == false)
            { MessageBox.Show("Controle los datos", "Error"); }
                                                            
        }

        private void dtFechaNac_ValueChanged(object sender, EventArgs e)
        {

            // Save today's date.
            var today = DateTime.Today;
            // Calculate the age.
            var age = today.Year - dtFechaNac.Value.Year;
            // Go back to the year the person was born in case of a leap year
            if (dtFechaNac.Value.Date > today.AddYears(-age)) age--;
            lbledad.Text = age.ToString();
        }
    }
    
}
