namespace sistemaNomina2
{
    public partial class Form1 : Form
    {
        private List<Empleado> empleados = new List<Empleado>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarCombox();
            EstiloDataGridView();
        }
        //Botones
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            InsertaLinea();
            LimpiarFormulario();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.dgv.Rows.Clear();
            this.dgv.Refresh();
            LimpiarFormulario();
            rbtReporte.Clear();
        }
        private void btnReporte_Click(object sender, EventArgs e)
        {
            rbtReporte.Clear();
            foreach (Empleado emp in empleados)
            {
                rbtReporte.AppendText(emp.ToString() + "\n\n");
            }
        }

        //Metodos
        private void LimpiarFormulario()
        {
            cboTipo.Text = "";
            txtNombre.Clear();
            txtApellido.Clear();
            txtNSS.Clear();
            txtCampo1.Clear();
            txtCampo2.Clear();
            txtCampo3.Clear();
        }
        private Empleado CrearEmpleado()
        {
            Empleado empleado = null;
            switch (cboTipo.SelectedIndex)
            {
                case 0: 
                    empleado = new EmpAsalariado
                    {
                        nombre = txtNombre.Text,
                        apellido = txtApellido.Text,
                        nss = txtNSS.Text,
                        salarioSemanal = Convert.ToDecimal(txtCampo1.Text)
                    };
                    break;
                case 1: 
                    empleado = new EmpPorHoras
                    {
                        nombre = txtNombre.Text,
                        apellido = txtApellido.Text,
                        nss = txtNSS.Text,
                        sueldohora = Convert.ToDecimal(txtCampo1.Text),
                        horastrabajadas = Convert.ToDecimal(txtCampo2.Text)
                    };
                    break;
                case 2: 
                    empleado = new EmpPorComision
                    {
                        nombre = txtNombre.Text,
                        apellido = txtApellido.Text,
                        nss = txtNSS.Text,
                        ventasBrutas = Convert.ToDecimal(txtCampo1.Text),
                        tarifaComision = Convert.ToDecimal(txtCampo2.Text)
                    };
                    break;
                case 3:
                    empleado = new EmAslPorComision
                    {
                        nombre = txtNombre.Text,
                        apellido = txtApellido.Text,
                        nss = txtNSS.Text,
                        ventasBrutas = Convert.ToDecimal(txtCampo1.Text),
                        tarifaComision = Convert.ToDecimal(txtCampo2.Text),
                        salarioBase = Convert.ToDecimal(txtCampo3.Text)
                    };
                    break;
            }
            return empleado;
        }
        private void InsertaLinea()
        {
            Empleado empleado = CrearEmpleado();
            empleados.Add(empleado);
            decimal sueldoSemanal = empleado.CalcularSalario();
            int xRows = dgv.Rows.Add();

            dgv[00, xRows].Value = txtNombre.Text;
            dgv[01, xRows].Value = txtApellido.Text;
            dgv[02, xRows].Value = txtNSS.Text;
            dgv[03, xRows].Value = cboTipo.Text;
            dgv[04, xRows].Value = sueldoSemanal.ToString("C");
        }

        //Deco.
        private void LlenarCombox()
        {
            cboTipo.Items.Add("Asalariado");
            cboTipo.Items.Add("Por Horas");
            cboTipo.Items.Add("Por Comisión");
            cboTipo.Items.Add("Asalariado por Comisión");

            cboTipo.SelectedIndex = 0;
        }
        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCampo1.Visible = false;
            lblCampo2.Visible = false;
            lblCampo3.Visible = false;

            txtCampo1.Visible = false;
            txtCampo2.Visible = false;
            txtCampo3.Visible = false;

            switch (cboTipo.SelectedIndex)
            {
                // Asalariado
                case 0:
                    lblCampo1.Text = "Salario Semanal";
                    lblCampo1.Visible = true;
                    txtCampo1.Visible = true;
                    break;
                // Por Horas
                case 1:
                    lblCampo1.Text = "Sueldo por Hora";
                    lblCampo2.Text = "Horas Trabajadas";

                    lblCampo1.Visible = true;
                    lblCampo2.Visible = true;

                    txtCampo1.Visible = true;
                    txtCampo2.Visible = true;
                    break;
                // Por Comisión
                case 2:
                    lblCampo1.Text = "Ventas Brutas";
                    lblCampo2.Text = "Tarifa Comisión";

                    lblCampo1.Visible = true;
                    lblCampo2.Visible = true;

                    txtCampo1.Visible = true;
                    txtCampo2.Visible = true;
                    break;
                //Asalariado por Comisión
                case 3:
                    lblCampo1.Text = "Ventas Brutas";
                    lblCampo2.Text = "Tarifa Comisión";
                    lblCampo3.Text = "Salario Base";

                    lblCampo1.Visible = true;
                    lblCampo2.Visible = true;
                    lblCampo3.Visible = true;

                    txtCampo1.Visible = true;
                    txtCampo2.Visible = true;
                    txtCampo3.Visible = true;
                    break;
            }
        }
        private void EstiloDataGridView()
        {
            this.dgv.EnableHeadersVisualStyles = true;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersVisible = true;
            this.dgv.RowHeadersVisible = false;

            this.dgv.Columns.Add("Col00", "Nombre");
            this.dgv.Columns.Add("Col01", "Apellido");
            this.dgv.Columns.Add("Col02", "NSS");
            this.dgv.Columns.Add("Col03", "Tipo Empleado");
            this.dgv.Columns.Add("Col04", "Sueldo Semanal");

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dgv.BorderStyle = BorderStyle.None;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            this.dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            this.dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            this.dgv.BackgroundColor = Color.LightGray;

            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 6, 0, 6);
            this.dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 64);
            this.dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        //Eventos KeyPress
        #region
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                txtApellido.Focus();
            }
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                txtNSS.Focus();
            }
        }
        private void txtNSS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                txtCampo1.Focus();
            }
        }
        private void txtCampo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                txtCampo2.Focus();
            }
        }
        private void txtCampo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                txtCampo3.Focus();
            }
        }
        private void txtCampo3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                btnAgregar.PerformClick();
            }
            return;
        }
        #endregion

       
    }
}
