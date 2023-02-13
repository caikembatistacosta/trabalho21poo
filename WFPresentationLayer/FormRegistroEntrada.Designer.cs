﻿namespace WFPresentationLayer
{
    partial class FormRegistroEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroEntrada));
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarNovoFornecedor = new System.Windows.Forms.Button();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProdutosEntrada = new System.Windows.Forms.DataGridView();
            this.ProdutosEntradaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosEntradaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosEntradaQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosEntradaUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosEntradaValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosEntradaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastroNovoProduto = new System.Windows.Forms.Button();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQtde = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.btnRetirarProduto = new System.Windows.Forms.Button();
            this.btnRegistrarEntrada = new System.Windows.Forms.Button();
            this.nudValorUnitario = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumItens = new System.Windows.Forms.TextBox();
            this.txtTotalPago = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorUnitario)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(407, 47);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(121, 23);
            this.cmbFornecedor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fornecedor";
            // 
            // btnCadastrarNovoFornecedor
            // 
            this.btnCadastrarNovoFornecedor.Location = new System.Drawing.Point(626, 415);
            this.btnCadastrarNovoFornecedor.Name = "btnCadastrarNovoFornecedor";
            this.btnCadastrarNovoFornecedor.Size = new System.Drawing.Size(161, 23);
            this.btnCadastrarNovoFornecedor.TabIndex = 2;
            this.btnCadastrarNovoFornecedor.Text = "Cadastrar novo Fornecedor";
            this.btnCadastrarNovoFornecedor.UseVisualStyleBackColor = true;
            this.btnCadastrarNovoFornecedor.Click += new System.EventHandler(this.btnCadastrarNovoFornecedor_Click);
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Location = new System.Drawing.Point(200, 47);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(200, 23);
            this.dtpDataEntrada.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Entrada";
            // 
            // dgvProdutosEntrada
            // 
            this.dgvProdutosEntrada.AllowUserToAddRows = false;
            this.dgvProdutosEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutosEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdutosEntradaID,
            this.ProdutosEntradaNome,
            this.ProdutosEntradaQtde,
            this.ProdutosEntradaUn,
            this.ProdutosEntradaValor,
            this.ProdutosEntradaTotal});
            this.dgvProdutosEntrada.Location = new System.Drawing.Point(27, 177);
            this.dgvProdutosEntrada.Name = "dgvProdutosEntrada";
            this.dgvProdutosEntrada.ReadOnly = true;
            this.dgvProdutosEntrada.RowTemplate.Height = 25;
            this.dgvProdutosEntrada.Size = new System.Drawing.Size(501, 147);
            this.dgvProdutosEntrada.TabIndex = 5;
            // 
            // ProdutosEntradaID
            // 
            this.ProdutosEntradaID.HeaderText = "ID";
            this.ProdutosEntradaID.Name = "ProdutosEntradaID";
            this.ProdutosEntradaID.ReadOnly = true;
            // 
            // ProdutosEntradaNome
            // 
            this.ProdutosEntradaNome.HeaderText = "Nome";
            this.ProdutosEntradaNome.Name = "ProdutosEntradaNome";
            this.ProdutosEntradaNome.ReadOnly = true;
            // 
            // ProdutosEntradaQtde
            // 
            this.ProdutosEntradaQtde.HeaderText = "Qtde";
            this.ProdutosEntradaQtde.Name = "ProdutosEntradaQtde";
            this.ProdutosEntradaQtde.ReadOnly = true;
            // 
            // ProdutosEntradaUn
            // 
            this.ProdutosEntradaUn.HeaderText = "Un";
            this.ProdutosEntradaUn.Name = "ProdutosEntradaUn";
            this.ProdutosEntradaUn.ReadOnly = true;
            // 
            // ProdutosEntradaValor
            // 
            this.ProdutosEntradaValor.HeaderText = "Valor Un";
            this.ProdutosEntradaValor.Name = "ProdutosEntradaValor";
            this.ProdutosEntradaValor.ReadOnly = true;
            // 
            // ProdutosEntradaTotal
            // 
            this.ProdutosEntradaTotal.HeaderText = "Total";
            this.ProdutosEntradaTotal.Name = "ProdutosEntradaTotal";
            this.ProdutosEntradaTotal.ReadOnly = true;
            // 
            // btnCadastroNovoProduto
            // 
            this.btnCadastroNovoProduto.Location = new System.Drawing.Point(478, 415);
            this.btnCadastroNovoProduto.Name = "btnCadastroNovoProduto";
            this.btnCadastroNovoProduto.Size = new System.Drawing.Size(142, 23);
            this.btnCadastroNovoProduto.TabIndex = 6;
            this.btnCadastroNovoProduto.Text = "Cadastrar novo Produto";
            this.btnCadastroNovoProduto.UseVisualStyleBackColor = true;
            this.btnCadastroNovoProduto.Click += new System.EventHandler(this.btnCadastroNovoProduto_Click);
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(279, 148);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(121, 23);
            this.cmbProduto.TabIndex = 7;
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Produto";
            // 
            // nudQtde
            // 
            this.nudQtde.Location = new System.Drawing.Point(155, 148);
            this.nudQtde.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudQtde.Name = "nudQtde";
            this.nudQtde.Size = new System.Drawing.Size(74, 23);
            this.nudQtde.TabIndex = 9;
            this.nudQtde.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Qtde.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(664, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "n itens";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(664, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Total Pago";
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(232, 148);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.ReadOnly = true;
            this.txtUnidade.Size = new System.Drawing.Size(44, 23);
            this.txtUnidade.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "Un";
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(406, 146);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(122, 24);
            this.btnAdicionarProduto.TabIndex = 39;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // btnRetirarProduto
            // 
            this.btnRetirarProduto.Location = new System.Drawing.Point(406, 120);
            this.btnRetirarProduto.Name = "btnRetirarProduto";
            this.btnRetirarProduto.Size = new System.Drawing.Size(122, 24);
            this.btnRetirarProduto.TabIndex = 40;
            this.btnRetirarProduto.Text = "Retirar Produto";
            this.btnRetirarProduto.UseVisualStyleBackColor = true;
            this.btnRetirarProduto.Click += new System.EventHandler(this.btnRetirarProduto_Click);
            // 
            // btnRegistrarEntrada
            // 
            this.btnRegistrarEntrada.Location = new System.Drawing.Point(534, 301);
            this.btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            this.btnRegistrarEntrada.Size = new System.Drawing.Size(120, 23);
            this.btnRegistrarEntrada.TabIndex = 41;
            this.btnRegistrarEntrada.Text = "Registrar Entrada";
            this.btnRegistrarEntrada.UseVisualStyleBackColor = true;
            this.btnRegistrarEntrada.Click += new System.EventHandler(this.btnRegistrarEntrada_Click);
            // 
            // nudValorUnitario
            // 
            this.nudValorUnitario.DecimalPlaces = 2;
            this.nudValorUnitario.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudValorUnitario.Location = new System.Drawing.Point(61, 147);
            this.nudValorUnitario.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudValorUnitario.Name = "nudValorUnitario";
            this.nudValorUnitario.Size = new System.Drawing.Size(88, 23);
            this.nudValorUnitario.TabIndex = 42;
            this.nudValorUnitario.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "Valor Un";
            // 
            // txtNumItens
            // 
            this.txtNumItens.Enabled = false;
            this.txtNumItens.Location = new System.Drawing.Point(664, 175);
            this.txtNumItens.Name = "txtNumItens";
            this.txtNumItens.Size = new System.Drawing.Size(100, 23);
            this.txtNumItens.TabIndex = 44;
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.Enabled = false;
            this.txtTotalPago.Location = new System.Drawing.Point(664, 218);
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.Size = new System.Drawing.Size(100, 23);
            this.txtTotalPago.TabIndex = 45;
            // 
            // FormRegistroEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotalPago);
            this.Controls.Add(this.txtNumItens);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudValorUnitario);
            this.Controls.Add(this.btnRegistrarEntrada);
            this.Controls.Add(this.btnRetirarProduto);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudQtde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.btnCadastroNovoProduto);
            this.Controls.Add(this.dgvProdutosEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDataEntrada);
            this.Controls.Add(this.btnCadastrarNovoFornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFornecedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistroEntrada";
            this.Text = "Registro Entrada";
            this.Load += new System.EventHandler(this.FormRegistroEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorUnitario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbFornecedor;
        private Label label1;
        private Button btnCadastrarNovoFornecedor;
        private DateTimePicker dtpDataEntrada;
        private Label label2;
        private DataGridView dgvProdutosEntrada;
        private Button btnCadastroNovoProduto;
        private ComboBox cmbProduto;
        private Label label3;
        private NumericUpDown nudQtde;
        private Label label4;
        private Label label9;
        private Label label10;
        private TextBox txtUnidade;
        private Label label5;
        private Button btnAdicionarProduto;
        private Button btnRetirarProduto;
        private DataGridViewTextBoxColumn qtdeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn UnDataGridViewTextBoxColumn;
        private Button btnRegistrarEntrada;
        private NumericUpDown nudValorUnitario;
        private Label label6;
        private TextBox txtNumItens;
        private TextBox txtTotalPago;
        private DataGridViewTextBoxColumn ProdutosEntradaID;
        private DataGridViewTextBoxColumn ProdutosEntradaNome;
        private DataGridViewTextBoxColumn ProdutosEntradaQtde;
        private DataGridViewTextBoxColumn ProdutosEntradaUn;
        private DataGridViewTextBoxColumn ProdutosEntradaValor;
        private DataGridViewTextBoxColumn ProdutosEntradaTotal;
    }
}