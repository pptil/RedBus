using System;
using System.Data;
using System.Windows.Forms;
using Entidades;
using Capsula;

namespace FrontEnd
{
    public partial class Front : Form
    {
        public Tarjeta objTarjeta = new Tarjeta();
        public Persona objPersona = new Persona();
        public CapsulaTarjeta objCapsulaTarjeta = new CapsulaTarjeta();
        public CapsulaPersona objCapsulaPersona = new CapsulaPersona();

        public Front()
        {
            InitializeComponent();
            ArmarDGV();
            LlenarDGV();

        }

        private void ArmarDGV()
        {
            dgvTarjetas.ColumnCount = 4;
            dgvTarjetas.Columns[0].HeaderText = "NroTarjeta";
            dgvTarjetas.Columns[1].HeaderText = "Saldo";
            dgvTarjetas.Columns[2].HeaderText = "DNI";
            dgvTarjetas.Columns[3].HeaderText = "Nombre";
            dgvTarjetas.Columns[0].Width = 70;
            dgvTarjetas.Columns[1].Width = 70;
            dgvTarjetas.Columns[2].Width = 70;
            dgvTarjetas.Columns[3].Width = 70;
        }
        private void LlenarDGV()
        {
            dgvTarjetas.Rows.Clear();

            DataSet ds = new DataSet();
            DataSet dsp = new DataSet();
            ds = objCapsulaTarjeta.listadoTarjetas("Todos");
            dsp = objCapsulaPersona.listadopersonas("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvTarjetas.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3]);
                }

            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvTarjetas.Columns.Clear();
            ArmarDGV();
            LlenarDGV();

        }

        private void DgvTarjetas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();

            objTarjeta.NroTarjeta = Convert.ToInt32(dgvTarjetas.CurrentRow.Cells[0].Value);
            objTarjeta.Saldo = Convert.ToInt32(dgvTarjetas.CurrentRow.Cells[1].Value);



            ds = objCapsulaTarjeta.listadoTarjetas(objTarjeta.NroTarjeta.ToString());


            if (ds.Tables[0].Rows.Count > 0)
            {
                //Ds_a_TxtBox(ds);               
                //lblMensaje.Text = string.Empty;
            }
        }



        //private void TxtBox_a_Obj()
        //{
        // objTarjeta.NroTarjeta = int.Parse(txtNro.Text);       
        //objTarjeta.Saldo = int.Parse(txtSaldo.Text);           
        //objTarjeta.AddRes = int.Parse(txtAddRes.Text);
        //}



        //private void Button1_Click(object sender, EventArgs e)
        // {
        //Register registro = new Register();
        //registro.ShowDialog();


        // int nGrabados = -1;           
        //TxtBox_a_Obj(); 

        //nGrabados = objCapsulaTarjeta.abmTarjetas("Buscar", objTarjeta);

        //if (nGrabados == -1)
        //{ lblMensaje.Text = "  No pudo grabar la Tarjeta en el sistema"; }
        //else
        //{
        //    lblMensaje.Text = "  Se grabó con éxito Tarjeta.";
        //    LlenarDGV();
        //    Limpiar();
        //}
        //}
        //private void Limpiar()
        //{ txtNro.Text = string.Empty; txtSaldo.Text = string.Empty; }



        //private void Ds_a_TxtBox(DataSet ds)
        //{
        //txtNro.Text = ds.Tables[0].Rows[0]["NroTarjeta"].ToString();           
        //txtSaldo.Text = ds.Tables[0].Rows[0]["Saldo"].ToString();            
        //txtNro.Enabled = false;
        //txtSaldo.Enabled = false;
        //}

        //private void BtnModificar_Click(object sender, EventArgs e)
        //{
        //    int nResultado = -1;
        //    TxtBox_a_Obj();
        //    nResultado = objCapsulaTarjeta.abmTarjetas("Modificar", objTarjeta);          
        //    if (nResultado != -1)
        //    {
        //        MessageBox.Show("Aviso", "La Tarjeta fue Modificada con éxito");
        //        Limpiar();
        //        LlenarDGV();
        //        txtNro.Enabled = true;
        //        txtSaldo.Enabled = true;


        //    }
        //    else
        //        MessageBox.Show("Error", "Se produjo un error al intentar modificar la tarjeta"); 
        //}

        //private void BtnAgregar_Click(object sender, EventArgs e)
        //{
        //    int nResultado = -1;
        //    objTarjeta.Sumar(int.Parse(txtAddRes.Text));
        //    nResultado = objCapsulaTarjeta.SumRes("Sumar", objTarjeta);
        //    if (nResultado != -1)
        //    {
        //        MessageBox.Show("Aviso", "La Suma fue hecha con éxito");
        //        Limpiar();
        //        LlenarDGV();
        //        txtNro.Enabled = true;
        //        txtSaldo.Enabled = true;
        //    }
        //    else
        //        MessageBox.Show("Error", "Se produjo un error al intentar Sumar saldo a la tarjeta");
        //}

        //private void BtnDescontar_Click(object sender, EventArgs e)
        //{
        //    int nResultado = -1;
        //    objTarjeta.Restar(int.Parse(txtAddRes.Text));
        //    nResultado = objCapsulaTarjeta.SumRes("Restar", objTarjeta);
        //    if (nResultado != -1)
        //    {
        //        MessageBox.Show("Aviso", "El Descuento fue hecho con éxito");
        //        Limpiar();
        //        LlenarDGV();
        //        txtNro.Enabled = true;
        //    }
        //    else
        //        MessageBox.Show("Error", "Se produjo un error al intentar descontar saldo de la tarjeta");
        //}


        //private void TxtDni_TextChanged(object sender, EventArgs e)
        //{

        //}
        private void DgvTarjetas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}


