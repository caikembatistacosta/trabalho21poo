﻿namespace WFPresentationLayer
{
    partial class FormHistoricoEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoricoEntrada));
            this.panelMenuFuncionarios = new System.Windows.Forms.Panel();
            this.btnFiltrarDatas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataSaída = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTabelaEntrada = new System.Windows.Forms.Button();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.btnInformacoesEntrada = new System.Windows.Forms.Button();
            this.panelDesktopEntradas = new System.Windows.Forms.Panel();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.EntradaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenuFuncionarios.SuspendLayout();
            this.panelDesktopEntradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuFuncionarios
            // 
            this.panelMenuFuncionarios.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenuFuncionarios.Controls.Add(this.btnFiltrarDatas);
            this.panelMenuFuncionarios.Controls.Add(this.label1);
            this.panelMenuFuncionarios.Controls.Add(this.dtpDataSaída);
            this.panelMenuFuncionarios.Controls.Add(this.label2);
            this.panelMenuFuncionarios.Controls.Add(this.btnTabelaEntrada);
            this.panelMenuFuncionarios.Controls.Add(this.dtpDataEntrada);
            this.panelMenuFuncionarios.Controls.Add(this.btnInformacoesEntrada);
            this.panelMenuFuncionarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenuFuncionarios.Location = new System.Drawing.Point(652, 0);
            this.panelMenuFuncionarios.Name = "panelMenuFuncionarios";
            this.panelMenuFuncionarios.Size = new System.Drawing.Size(144, 456);
            this.panelMenuFuncionarios.TabIndex = 4;
            // 
            // btnFiltrarDatas
            // 
            this.btnFiltrarDatas.Location = new System.Drawing.Point(8, 276);
            this.btnFiltrarDatas.Name = "btnFiltrarDatas";
            this.btnFiltrarDatas.Size = new System.Drawing.Size(120, 23);
            this.btnFiltrarDatas.TabIndex = 42;
            this.btnFiltrarDatas.Text = "Filtrar Datas";
            this.btnFiltrarDatas.UseVisualStyleBackColor = true;
            this.btnFiltrarDatas.Click += new System.EventHandler(this.btnFiltrarDatas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Data Fim";
            // 
            // dtpDataSaída
            // 
            this.dtpDataSaída.Location = new System.Drawing.Point(8, 227);
            this.dtpDataSaída.Name = "dtpDataSaída";
            this.dtpDataSaída.Size = new System.Drawing.Size(129, 23);
            this.dtpDataSaída.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data Inicio";
            // 
            // btnTabelaEntrada
            // 
            this.btnTabelaEntrada.BackColor = System.Drawing.Color.Transparent;
            this.btnTabelaEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTabelaEntrada.FlatAppearance.BorderSize = 0;
            this.btnTabelaEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTabelaEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTabelaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabelaEntrada.ForeColor = System.Drawing.Color.White;
            this.btnTabelaEntrada.Location = new System.Drawing.Point(6, 12);
            this.btnTabelaEntrada.Name = "btnTabelaEntrada";
            this.btnTabelaEntrada.Size = new System.Drawing.Size(92, 59);
            this.btnTabelaEntrada.TabIndex = 19;
            this.btnTabelaEntrada.Text = "Tabela Entrada";
            this.btnTabelaEntrada.UseMnemonic = false;
            this.btnTabelaEntrada.UseVisualStyleBackColor = false;
            this.btnTabelaEntrada.Click += new System.EventHandler(this.btnTabelaFuncionarios_Click);
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Location = new System.Drawing.Point(5, 172);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(129, 23);
            this.dtpDataEntrada.TabIndex = 6;
            // 
            // btnInformacoesEntrada
            // 
            this.btnInformacoesEntrada.BackColor = System.Drawing.Color.Transparent;
            this.btnInformacoesEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInformacoesEntrada.FlatAppearance.BorderSize = 0;
            this.btnInformacoesEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInformacoesEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInformacoesEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacoesEntrada.ForeColor = System.Drawing.Color.White;
            this.btnInformacoesEntrada.Location = new System.Drawing.Point(6, 77);
            this.btnInformacoesEntrada.Name = "btnInformacoesEntrada";
            this.btnInformacoesEntrada.Size = new System.Drawing.Size(92, 59);
            this.btnInformacoesEntrada.TabIndex = 16;
            this.btnInformacoesEntrada.Text = "Informações da Entrada";
            this.btnInformacoesEntrada.UseMnemonic = false;
            this.btnInformacoesEntrada.UseVisualStyleBackColor = false;
            this.btnInformacoesEntrada.Click += new System.EventHandler(this.btnInformacoesEntrada_Click);
            // 
            // panelDesktopEntradas
            // 
            this.panelDesktopEntradas.Controls.Add(this.dgvEntradas);
            this.panelDesktopEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopEntradas.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopEntradas.Name = "panelDesktopEntradas";
            this.panelDesktopEntradas.Size = new System.Drawing.Size(652, 456);
            this.panelDesktopEntradas.TabIndex = 5;
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.AllowUserToAddRows = false;
            this.dgvEntradas.AllowUserToDeleteRows = false;
            this.dgvEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntradas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEntradas.BackgroundColor = System.Drawing.Color.White;
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EntradaID,
            this.EntradaFornecedor,
            this.EntradaFuncionario,
            this.EntradaData,
            this.EntradaValor});
            this.dgvEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEntradas.Location = new System.Drawing.Point(0, 0);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.ReadOnly = true;
            this.dgvEntradas.RowHeadersVisible = false;
            this.dgvEntradas.RowHeadersWidth = 51;
            this.dgvEntradas.RowTemplate.Height = 25;
            this.dgvEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntradas.Size = new System.Drawing.Size(652, 456);
            this.dgvEntradas.TabIndex = 7;
            // 
            // EntradaID
            // 
            this.EntradaID.HeaderText = "ID";
            this.EntradaID.MinimumWidth = 6;
            this.EntradaID.Name = "EntradaID";
            this.EntradaID.ReadOnly = true;
            // 
            // EntradaFornecedor
            // 
            this.EntradaFornecedor.HeaderText = "Fornecedor";
            this.EntradaFornecedor.MinimumWidth = 6;
            this.EntradaFornecedor.Name = "EntradaFornecedor";
            this.EntradaFornecedor.ReadOnly = true;
            // 
            // EntradaFuncionario
            // 
            this.EntradaFuncionario.HeaderText = "Funcionario";
            this.EntradaFuncionario.MinimumWidth = 6;
            this.EntradaFuncionario.Name = "EntradaFuncionario";
            this.EntradaFuncionario.ReadOnly = true;
            // 
            // EntradaData
            // 
            this.EntradaData.HeaderText = "Data";
            this.EntradaData.MinimumWidth = 6;
            this.EntradaData.Name = "EntradaData";
            this.EntradaData.ReadOnly = true;
            // 
            // EntradaValor
            // 
            this.EntradaValor.HeaderText = "Valor";
            this.EntradaValor.MinimumWidth = 6;
            this.EntradaValor.Name = "EntradaValor";
            this.EntradaValor.ReadOnly = true;
            // 
            // FormHistoricoEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 456);
            this.Controls.Add(this.panelDesktopEntradas);
            this.Controls.Add(this.panelMenuFuncionarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHistoricoEntrada";
            this.Text = "FormHistoricoEntrada";
            this.Load += new System.EventHandler(this.FormHistoricoEntrada_Load);
            this.panelMenuFuncionarios.ResumeLayout(false);
            this.panelMenuFuncionarios.PerformLayout();
            this.panelDesktopEntradas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenuFuncionarios;
        private Button btnTabelaEntrada;
        private Button btnInformacoesEntrada;
        private Panel panelDesktopEntradas;
        private DataGridView dgvEntradas;
        private DataGridViewTextBoxColumn EntradaID;
        private DataGridViewTextBoxColumn EntradaFornecedor;
        private DataGridViewTextBoxColumn EntradaFuncionario;
        private DataGridViewTextBoxColumn EntradaData;
        private DataGridViewTextBoxColumn EntradaValor;
        private Label label1;
        private DateTimePicker dtpDataSaída;
        private Label label2;
        private DateTimePicker dtpDataEntrada;
        private Button btnFiltrarDatas;
    }
}