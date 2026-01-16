namespace sistemaNomina2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtNSS = new TextBox();
            dgv = new DataGridView();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            cboTipo = new ComboBox();
            label1 = new Label();
            lblCampo1 = new Label();
            txtCampo1 = new TextBox();
            lblCampo2 = new Label();
            lblCampo3 = new Label();
            txtCampo2 = new TextBox();
            txtCampo3 = new TextBox();
            lblSueldoSemanal = new Label();
            rbtReporte = new RichTextBox();
            btnReporte = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(18, 92);
            label6.Name = "label6";
            label6.Size = new Size(187, 23);
            label6.TabIndex = 25;
            label6.Text = "Tipo de Empleado";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(18, 179);
            label5.Name = "label5";
            label5.Size = new Size(187, 23);
            label5.TabIndex = 24;
            label5.Text = "Numero de Seguridad Social";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(18, 150);
            label4.Name = "label4";
            label4.Size = new Size(187, 23);
            label4.TabIndex = 23;
            label4.Text = "Apellido";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(18, 121);
            label3.Name = "label3";
            label3.Size = new Size(187, 23);
            label3.TabIndex = 22;
            label3.Text = "Nombre ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNSS
            // 
            txtNSS.Location = new Point(211, 179);
            txtNSS.Name = "txtNSS";
            txtNSS.Size = new Size(299, 23);
            txtNSS.TabIndex = 21;
            txtNSS.KeyPress += txtNSS_KeyPress;
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(18, 393);
            dgv.Name = "dgv";
            dgv.Size = new Size(856, 283);
            dgv.TabIndex = 19;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(19, 321);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(186, 32);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar / Calcular";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(19, 355);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(186, 32);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(211, 150);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(299, 23);
            txtApellido.TabIndex = 16;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(211, 121);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(299, 23);
            txtNombre.TabIndex = 15;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(211, 92);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(299, 23);
            cboTipo.TabIndex = 14;
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoEllipsis = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(862, 56);
            label1.TabIndex = 13;
            label1.Text = "Menú";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCampo1
            // 
            lblCampo1.BackColor = Color.White;
            lblCampo1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCampo1.ForeColor = Color.Black;
            lblCampo1.Location = new Point(18, 208);
            lblCampo1.Name = "lblCampo1";
            lblCampo1.Size = new Size(187, 23);
            lblCampo1.TabIndex = 27;
            lblCampo1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCampo1
            // 
            txtCampo1.Location = new Point(211, 208);
            txtCampo1.Name = "txtCampo1";
            txtCampo1.Size = new Size(299, 23);
            txtCampo1.TabIndex = 26;
            txtCampo1.KeyPress += txtCampo1_KeyPress;
            // 
            // lblCampo2
            // 
            lblCampo2.BackColor = Color.White;
            lblCampo2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCampo2.ForeColor = Color.Black;
            lblCampo2.Location = new Point(18, 238);
            lblCampo2.Name = "lblCampo2";
            lblCampo2.Size = new Size(187, 23);
            lblCampo2.TabIndex = 29;
            lblCampo2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCampo3
            // 
            lblCampo3.BackColor = Color.White;
            lblCampo3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCampo3.ForeColor = Color.Black;
            lblCampo3.Location = new Point(18, 267);
            lblCampo3.Name = "lblCampo3";
            lblCampo3.Size = new Size(187, 23);
            lblCampo3.TabIndex = 30;
            lblCampo3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCampo2
            // 
            txtCampo2.Location = new Point(211, 240);
            txtCampo2.Name = "txtCampo2";
            txtCampo2.Size = new Size(299, 23);
            txtCampo2.TabIndex = 34;
            txtCampo2.KeyPress += txtCampo2_KeyPress;
            // 
            // txtCampo3
            // 
            txtCampo3.Location = new Point(211, 269);
            txtCampo3.Name = "txtCampo3";
            txtCampo3.Size = new Size(299, 23);
            txtCampo3.TabIndex = 35;
            txtCampo3.KeyPress += txtCampo3_KeyPress;
            // 
            // lblSueldoSemanal
            // 
            lblSueldoSemanal.BackColor = Color.White;
            lblSueldoSemanal.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSueldoSemanal.ForeColor = Color.Black;
            lblSueldoSemanal.Location = new Point(239, 325);
            lblSueldoSemanal.Name = "lblSueldoSemanal";
            lblSueldoSemanal.Size = new Size(187, 23);
            lblSueldoSemanal.TabIndex = 36;
            lblSueldoSemanal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rbtReporte
            // 
            rbtReporte.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rbtReporte.BackColor = SystemColors.Control;
            rbtReporte.BorderStyle = BorderStyle.None;
            rbtReporte.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtReporte.Location = new Point(527, 92);
            rbtReporte.Name = "rbtReporte";
            rbtReporte.ReadOnly = true;
            rbtReporte.Size = new Size(347, 213);
            rbtReporte.TabIndex = 37;
            rbtReporte.Text = "";
            rbtReporte.WordWrap = false;
            // 
            // btnReporte
            // 
            btnReporte.Location = new Point(211, 355);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(186, 32);
            btnReporte.TabIndex = 38;
            btnReporte.Text = "Reporte";
            btnReporte.UseVisualStyleBackColor = true;
            btnReporte.Click += btnReporte_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(890, 688);
            Controls.Add(btnReporte);
            Controls.Add(rbtReporte);
            Controls.Add(lblSueldoSemanal);
            Controls.Add(txtCampo3);
            Controls.Add(txtCampo2);
            Controls.Add(lblCampo3);
            Controls.Add(lblCampo2);
            Controls.Add(lblCampo1);
            Controls.Add(txtCampo1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNSS);
            Controls.Add(dgv);
            Controls.Add(btnAgregar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(cboTipo);
            Controls.Add(label1);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtNSS;
        private Label lbPago;
        private DataGridView dgv;
        private Button btnAgregar;
        private Button btnLimpiar;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private ComboBox cboTipo;
        private Label label1;
        private Label lblCampo1;
        private TextBox txtCampo1;
        private Label lblCampo2;
        private Label lblCampo3;
        private TextBox textBox2;
        private TextBox txtCampo2;
        private TextBox textBox4;
        private TextBox txtCampo3;
        private Label lblSueldoSemanal;
        private RichTextBox rbtReporte;
        private Button btnReporte;
    }
}
