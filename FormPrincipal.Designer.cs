namespace EstacionamentoForms
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.gbCadastro = new System.Windows.Forms.GroupBox();
      this.tbPlaca = new System.Windows.Forms.TextBox();
      this.lblPlaca = new System.Windows.Forms.Label();
      this.btnAdicionar = new System.Windows.Forms.Button();
      this.gpGaragem = new System.Windows.Forms.GroupBox();
      this.lvListaPlacas = new System.Windows.Forms.ListView();
      this.columnPlacas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.btnLiberar = new System.Windows.Forms.Button();
      this.gbCusto = new System.Windows.Forms.GroupBox();
      this.lblPlacaCustoResult = new System.Windows.Forms.Label();
      this.lblHorasResult = new System.Windows.Forms.Label();
      this.lblPlacaCusto = new System.Windows.Forms.Label();
      this.lblHoras = new System.Windows.Forms.Label();
      this.btnPago = new System.Windows.Forms.Button();
      this.lblAPagarResult = new System.Windows.Forms.Label();
      this.lblAPagar = new System.Windows.Forms.Label();
      this.gbCadastro.SuspendLayout();
      this.gpGaragem.SuspendLayout();
      this.gbCusto.SuspendLayout();
      this.SuspendLayout();
      // 
      // gbCadastro
      // 
      this.gbCadastro.Controls.Add(this.tbPlaca);
      this.gbCadastro.Controls.Add(this.lblPlaca);
      this.gbCadastro.Controls.Add(this.btnAdicionar);
      this.gbCadastro.Location = new System.Drawing.Point(12, 8);
      this.gbCadastro.Name = "gbCadastro";
      this.gbCadastro.Size = new System.Drawing.Size(345, 53);
      this.gbCadastro.TabIndex = 1;
      this.gbCadastro.TabStop = false;
      this.gbCadastro.Text = "Cadastro";
      // 
      // tbPlaca
      // 
      this.tbPlaca.Location = new System.Drawing.Point(47, 21);
      this.tbPlaca.Name = "tbPlaca";
      this.tbPlaca.Size = new System.Drawing.Size(206, 20);
      this.tbPlaca.TabIndex = 0;
      this.tbPlaca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPlaca_KeyDown);
      // 
      // lblPlaca
      // 
      this.lblPlaca.AutoSize = true;
      this.lblPlaca.Location = new System.Drawing.Point(10, 24);
      this.lblPlaca.Name = "lblPlaca";
      this.lblPlaca.Size = new System.Drawing.Size(34, 13);
      this.lblPlaca.TabIndex = 1;
      this.lblPlaca.Text = "Placa";
      // 
      // btnAdicionar
      // 
      this.btnAdicionar.Location = new System.Drawing.Point(259, 19);
      this.btnAdicionar.Name = "btnAdicionar";
      this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
      this.btnAdicionar.TabIndex = 1;
      this.btnAdicionar.Text = "Adicionar";
      this.btnAdicionar.UseVisualStyleBackColor = true;
      this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
      // 
      // gpGaragem
      // 
      this.gpGaragem.Controls.Add(this.lvListaPlacas);
      this.gpGaragem.Controls.Add(this.btnLiberar);
      this.gpGaragem.Location = new System.Drawing.Point(12, 64);
      this.gpGaragem.Name = "gpGaragem";
      this.gpGaragem.Size = new System.Drawing.Size(345, 197);
      this.gpGaragem.TabIndex = 2;
      this.gpGaragem.TabStop = false;
      this.gpGaragem.Text = "Garagem";
      // 
      // lvListaPlacas
      // 
      this.lvListaPlacas.BackgroundImageTiled = true;
      this.lvListaPlacas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPlacas});
      this.lvListaPlacas.FullRowSelect = true;
      this.lvListaPlacas.HideSelection = false;
      this.lvListaPlacas.Location = new System.Drawing.Point(15, 19);
      this.lvListaPlacas.MultiSelect = false;
      this.lvListaPlacas.Name = "lvListaPlacas";
      this.lvListaPlacas.Size = new System.Drawing.Size(238, 167);
      this.lvListaPlacas.TabIndex = 3;
      this.lvListaPlacas.UseCompatibleStateImageBehavior = false;
      this.lvListaPlacas.View = System.Windows.Forms.View.Details;
      this.lvListaPlacas.SelectedIndexChanged += new System.EventHandler(this.lvListaPlacas_SelectedIndexChanged);
      // 
      // columnPlacas
      // 
      this.columnPlacas.Text = "Placas Adicionadas";
      this.columnPlacas.Width = 114;
      // 
      // btnLiberar
      // 
      this.btnLiberar.Location = new System.Drawing.Point(259, 19);
      this.btnLiberar.Name = "btnLiberar";
      this.btnLiberar.Size = new System.Drawing.Size(75, 23);
      this.btnLiberar.TabIndex = 4;
      this.btnLiberar.Text = "Liberar";
      this.btnLiberar.UseVisualStyleBackColor = true;
      this.btnLiberar.Click += new System.EventHandler(this.btnLiberar_Click);
      // 
      // gbCusto
      // 
      this.gbCusto.Controls.Add(this.lblAPagarResult);
      this.gbCusto.Controls.Add(this.lblAPagar);
      this.gbCusto.Controls.Add(this.lblPlacaCustoResult);
      this.gbCusto.Controls.Add(this.lblHorasResult);
      this.gbCusto.Controls.Add(this.lblPlacaCusto);
      this.gbCusto.Controls.Add(this.lblHoras);
      this.gbCusto.Location = new System.Drawing.Point(12, 263);
      this.gbCusto.Name = "gbCusto";
      this.gbCusto.Size = new System.Drawing.Size(345, 55);
      this.gbCusto.TabIndex = 3;
      this.gbCusto.TabStop = false;
      this.gbCusto.Text = "Custo";
      // 
      // lblPlacaCustoResult
      // 
      this.lblPlacaCustoResult.AutoSize = true;
      this.lblPlacaCustoResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.lblPlacaCustoResult.Location = new System.Drawing.Point(58, 18);
      this.lblPlacaCustoResult.Name = "lblPlacaCustoResult";
      this.lblPlacaCustoResult.Size = new System.Drawing.Size(43, 13);
      this.lblPlacaCustoResult.TabIndex = 7;
      this.lblPlacaCustoResult.Text = "lblplaca";
      // 
      // lblHorasResult
      // 
      this.lblHorasResult.AutoSize = true;
      this.lblHorasResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.lblHorasResult.Location = new System.Drawing.Point(297, 19);
      this.lblHorasResult.Name = "lblHorasResult";
      this.lblHorasResult.Size = new System.Drawing.Size(35, 13);
      this.lblHorasResult.TabIndex = 6;
      this.lblHorasResult.Text = "label2";
      // 
      // lblPlacaCusto
      // 
      this.lblPlacaCusto.AutoSize = true;
      this.lblPlacaCusto.Location = new System.Drawing.Point(21, 17);
      this.lblPlacaCusto.Name = "lblPlacaCusto";
      this.lblPlacaCusto.Size = new System.Drawing.Size(37, 13);
      this.lblPlacaCusto.TabIndex = 4;
      this.lblPlacaCusto.Text = "Placa:";
      // 
      // lblHoras
      // 
      this.lblHoras.AutoSize = true;
      this.lblHoras.Location = new System.Drawing.Point(259, 18);
      this.lblHoras.Name = "lblHoras";
      this.lblHoras.Size = new System.Drawing.Size(38, 13);
      this.lblHoras.TabIndex = 3;
      this.lblHoras.Text = "Horas:";
      // 
      // btnPago
      // 
      this.btnPago.Location = new System.Drawing.Point(289, 321);
      this.btnPago.Name = "btnPago";
      this.btnPago.Size = new System.Drawing.Size(68, 21);
      this.btnPago.TabIndex = 5;
      this.btnPago.Text = "Pago";
      this.btnPago.UseVisualStyleBackColor = true;
      this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
      // 
      // lblAPagarResult
      // 
      this.lblAPagarResult.AutoSize = true;
      this.lblAPagarResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.lblAPagarResult.Location = new System.Drawing.Point(58, 35);
      this.lblAPagarResult.Name = "lblAPagarResult";
      this.lblAPagarResult.Size = new System.Drawing.Size(35, 13);
      this.lblAPagarResult.TabIndex = 9;
      this.lblAPagarResult.Text = "label1";
      // 
      // lblAPagar
      // 
      this.lblAPagar.AutoSize = true;
      this.lblAPagar.Location = new System.Drawing.Point(10, 34);
      this.lblAPagar.Name = "lblAPagar";
      this.lblAPagar.Size = new System.Drawing.Size(47, 13);
      this.lblAPagar.TabIndex = 8;
      this.lblAPagar.Text = "A pagar:";
      // 
      // FormPrincipal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(371, 351);
      this.Controls.Add(this.btnPago);
      this.Controls.Add(this.gbCusto);
      this.Controls.Add(this.gpGaragem);
      this.Controls.Add(this.gbCadastro);
      this.MaximizeBox = false;
      this.Name = "FormPrincipal";
      this.Text = "Estacionamento";
      this.gbCadastro.ResumeLayout(false);
      this.gbCadastro.PerformLayout();
      this.gpGaragem.ResumeLayout(false);
      this.gbCusto.ResumeLayout(false);
      this.gbCusto.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadastro;
        private System.Windows.Forms.GroupBox gpGaragem;
        private System.Windows.Forms.GroupBox gbCusto;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.ListView lvListaPlacas;
        private System.Windows.Forms.Label lblPlacaCusto;
        private System.Windows.Forms.Label lblPlacaCustoResult;
        private System.Windows.Forms.ColumnHeader columnPlacas;
    private System.Windows.Forms.Label lblHorasResult;
    private System.Windows.Forms.Label lblHoras;
    private System.Windows.Forms.Label lblAPagarResult;
    private System.Windows.Forms.Label lblAPagar;
  }
}

