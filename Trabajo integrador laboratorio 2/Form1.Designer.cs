namespace Trabajo_integrador_laboratorio_2
{
    partial class FrmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            lblResultado = new Label();
            grpSistema = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            LblPrimerOperador = new Label();
            LblOperacion = new Label();
            LblSegundoOperador = new Label();
            txtPrimerOperador = new TextBox();
            txtSegundoOperador = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cmbOperacion = new ComboBox();
            lbl = new Label();
            label1 = new Label();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(12, 72);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(174, 46);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado:";
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Location = new Point(269, 151);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(208, 68);
            grpSistema.TabIndex = 1;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            grpSistema.Enter += grpSistema_Enter;
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(106, 33);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 19);
            rdbBinario.TabIndex = 8;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Checked = true;
            rdbDecimal.Location = new Point(6, 33);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(68, 19);
            rdbDecimal.TabIndex = 7;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btnOperar
            // 
            btnOperar.BackColor = SystemColors.Control;
            btnOperar.FlatStyle = FlatStyle.Popup;
            btnOperar.Location = new Point(90, 365);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(144, 32);
            btnOperar.TabIndex = 0;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = false;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Location = new Point(514, 365);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(144, 32);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(298, 365);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(144, 32);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // LblPrimerOperador
            // 
            LblPrimerOperador.AutoSize = true;
            LblPrimerOperador.Location = new Point(95, 288);
            LblPrimerOperador.Name = "LblPrimerOperador";
            LblPrimerOperador.Size = new Size(96, 15);
            LblPrimerOperador.TabIndex = 4;
            LblPrimerOperador.Text = "Primer operador:";
            LblPrimerOperador.Click += LblPrimerOperador_Click;
            // 
            // LblOperacion
            // 
            LblOperacion.AutoSize = true;
            LblOperacion.Location = new Point(303, 288);
            LblOperacion.Name = "LblOperacion";
            LblOperacion.Size = new Size(65, 15);
            LblOperacion.TabIndex = 5;
            LblOperacion.Text = "Operacion:";
            LblOperacion.Click += LblOperacion_Click;
            // 
            // LblSegundoOperador
            // 
            LblSegundoOperador.AutoSize = true;
            LblSegundoOperador.Location = new Point(514, 288);
            LblSegundoOperador.Name = "LblSegundoOperador";
            LblSegundoOperador.Size = new Size(108, 15);
            LblSegundoOperador.TabIndex = 6;
            LblSegundoOperador.Text = "Segundo operador:";
            LblSegundoOperador.Click += LblSegundoOperador_Click;
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Location = new Point(95, 306);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(139, 23);
            txtPrimerOperador.TabIndex = 7;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Location = new Point(514, 306);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(139, 23);
            txtSegundoOperador.TabIndex = 8;
            txtSegundoOperador.TextChanged += lbl_TextChanged;
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.FlatStyle = FlatStyle.Popup;
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(303, 306);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(139, 23);
            cmbOperacion.TabIndex = 9;
            cmbOperacion.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Location = new Point(201, 78);
            lbl.Name = "lbl";
            lbl.Size = new Size(0, 37);
            lbl.TabIndex = 10;
            lbl.Click += lbl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(192, 69);
            label1.Name = "label1";
            label1.Size = new Size(0, 46);
            label1.TabIndex = 11;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 465);
            Controls.Add(label1);
            Controls.Add(lbl);
            Controls.Add(cmbOperacion);
            Controls.Add(txtSegundoOperador);
            Controls.Add(txtPrimerOperador);
            Controls.Add(LblSegundoOperador);
            Controls.Add(LblOperacion);
            Controls.Add(LblPrimerOperador);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(grpSistema);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Gaston Cvitanich";
            Load += Form1_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private GroupBox grpSistema;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private Label LblPrimerOperador;
        private Label LblOperacion;
        private Label LblSegundoOperador;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private TextBox txtPrimerOperador;
        private TextBox txtSegundoOperador;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cmbOperacion;
        private Label lbl;
        private Label label1;
    }
}