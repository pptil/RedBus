using System;
using System.Data;
using System.Windows.Forms;
using Entidades;
using Capsula;

namespace FrontEnd
{
    public partial class Front : Form
    {
        #region inicializadores
        public Tarjeta objTarjeta = new Tarjeta();
        public Persona objPersona = new Persona();
        public CapsulaTarjeta objCapsulaTarjeta = new CapsulaTarjeta();
        public CapsulaPersona objCapsulaPersona = new CapsulaPersona();
        #endregion

        public Front()
        {
            InitializeComponent();
            ArmarDGV();
            LlenarDGV();

        }

        private void Borrar()
        {
            int nResultado = -1;            
            nResultado = objCapsulaTarjeta.DeleteTarjeta(objTarjeta);

            if (nResultado != -1)
            {
                MessageBox.Show("La tarjeta se ha borrado exitosamente", "AVISO", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Error al borrar la tarjeta", "ATENCION", MessageBoxButtons.OK);
        }

        #region DGV
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
        #endregion

        #region Clicks
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvTarjetas.Columns.Clear();
            ArmarDGV();
            LlenarDGV();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea Borrar la Tarjeta?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Borrar();
                dgvTarjetas.Columns.Clear();
                ArmarDGV();
                LlenarDGV();

            }
        }

        private void DgvTarjetas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();

            objTarjeta.NroTarjeta = Convert.ToInt32(dgvTarjetas.CurrentRow.Cells[0].Value);
            objTarjeta.Saldo = Convert.ToInt32(dgvTarjetas.CurrentRow.Cells[1].Value);
            ds = objCapsulaTarjeta.listadoTarjetas(objTarjeta.NroTarjeta.ToString());

            #region comentado
            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    Ds_a_TxtBox(ds);

            //}
            #endregion
        }

        #endregion

        #region mas comentado
        //private void TxtBox_a_Obj()
        //{
        //    objTarjeta.NroTarjeta = int.Parse(txtNro.Text);
        //    objTarjeta.Saldo = int.Parse(txtSaldo.Text);
        //}

        //private void Limpiar()
        //{ txtNro.Text = string.Empty; txtSaldo.Text = string.Empty; }

        //private void Ds_a_TxtBox(DataSet ds)
        //{
        //    txtNro.Text = ds.Tables[0].Rows[0]["NroTarjeta"].ToString();
        //    txtSaldo.Text = ds.Tables[0].Rows[0]["Saldo"].ToString();
        //    txtNro.Enabled = false;
        //    txtSaldo.Enabled = false;
        //}
        #endregion

      
    }
}


