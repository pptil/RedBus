using System;
using System.Data;
using System.Windows.Forms;
using Entidades;
using Capsula;
using FrontEnd;

namespace NewFront
{
    public partial class Checking : Form
    {
        #region Inicializadores
        public Tarjeta objTarjeta = new Tarjeta();
        public Persona objPersona = new Persona();
        public CapsulaTarjeta objCapsulaTarjeta = new CapsulaTarjeta();
        public CapsulaPersona objCapsulaPersona = new CapsulaPersona();
        bool bresultado = false;
        bool check = false;
        #endregion

        //ctor
        public Checking()
        {
            InitializeComponent();
        }


        #region KeyPress

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

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlNumero(e);
        }

        private void txtNroTar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlNumero(e);
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlNumero(e);
        }

        #endregion

        private void TxtBox_a_Obj()
        {
            objTarjeta.NroTarjeta = int.Parse(txtNroTar.Text);
            objTarjeta.Saldo = int.Parse(txtSaldo.Text);
            objTarjeta.Dni = int.Parse(txtDNI.Text);

        }


        #region verificadores
        private void Verificaciones()
        {

            int tresultado = -1;
            int dniresultado = -1;
            tresultado = objCapsulaTarjeta.GetTarjeta(objTarjeta.NroTarjeta.ToString());
            dniresultado = objCapsulaTarjeta.GetDNI(objTarjeta.Dni.ToString());
            bool verificartar;
            bool verificarper;

            //verificacion tarjeta
            if (tresultado == 1) { verificartar = true; }
            else { verificartar = false; }





            //verificacion persona
            if (dniresultado == 1)
            {
                lblNombre.Text = objCapsulaPersona.GetNombre(objTarjeta.Dni.ToString());
                verificarper = true;
            }
            else
            {
                verificarper = false;
                var result = MessageBox.Show("La Persona no existe. ¿Desea registrar una nueva persona?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Register register = new Register();
                    register.ShowDialog();
                }
            }

           //Verificacion tarjeta si persona si
           if (verificartar == true && verificarper == true)
            {
               bresultado = objCapsulaTarjeta.Verificar(objTarjeta.NroTarjeta.ToString(), objTarjeta.Dni.ToString());
                check = true;
            }


            //verificacion Tarjeta no, Persona Si
            if (verificartar == false && verificarper == true)
            {
                TxtBox_a_Obj();

                int nGrabados = -1;
                nGrabados = objCapsulaTarjeta.abmTarjetas("Alta", objTarjeta);

                if (nGrabados == -1)
                { MessageBox.Show(" Error al registrar la Tarjeta", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error); bresultado = false; }


                else
                {
                    MessageBox.Show(" Se grabó con éxito la Tarjeta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bresultado = true;
                    check = true;
                }
            }
            Check();

        }
        private void Check()
        {
            if (check == true)
            {
                btnAdd.Enabled = true;
                btnRes.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnRes.Enabled = false;
            }
        }
        #endregion


        #region clicks
        private void btnVerify_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            TxtBox_a_Obj();
            Verificaciones();          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Verificaciones();
            
                if (bresultado == true)
                {
                    btnAdd.Enabled = true;
                    btnRes.Enabled = true;

                    int nResultado = -1;
                    objTarjeta.Sumar(int.Parse(txtSaldo.Text));
                    nResultado = objCapsulaTarjeta.SumRes("Sumar", objTarjeta);
                    if (nResultado != -1)
                    {
                        MessageBox.Show("La Suma fue hecha con éxito", "AVISO", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Se produjo un error al intentar Sumar saldo a la tarjeta", "ATENCION", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("La tarjeta no coincide con el DNI", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }
           
                  

        private void btnRes_Click(object sender, EventArgs e)
        {
            Verificaciones();
            if (bresultado == true)
            {
                int nResultado = -1;
                objTarjeta.Restar(int.Parse(txtSaldo.Text));
                nResultado = objCapsulaTarjeta.SumRes("Restar", objTarjeta);
                if (nResultado != -1)
                {
                    MessageBox.Show("El Descuento fue hecho con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Se produjo un error al intentar descontar saldo de la tarjeta", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("La tarjeta no coincide con el DNI", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        private void btnTarjetas_Click_1(object sender, EventArgs e)
        {
            Front front = new Front();
            front.ShowDialog();
        }

        private void txtDNI_MouseClick(object sender, MouseEventArgs e)
        {
            btnAdd.Enabled = false;
            btnRes.Enabled = false;
        }

        private void txtNroTar_MouseClick(object sender, MouseEventArgs e)
        {
            btnAdd.Enabled = false;
            btnRes.Enabled = false;
        }
        #endregion

    }

}
