using LaboratorioDeProgramacao.WinApp.Translation;

namespace LaboratorioDeProgramacao.WinApp.ModuloDisciplina
{
    partial class TelaProdutoForm
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
            txtTitulo = new TextBox();
            labelFornecedor = new Label();
            txtId = new TextBox();
            lblId = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            cmbFornecedores = new ComboBox();
            lblTitulo = new Label();
            lblValorUnitario = new Label();
            txtValor = new TextBox();
            lblQuantidadeEstoque = new Label();
            txtQuantidade = new TextBox();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitulo.Location = new Point(275, 132);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(500, 34);
            txtTitulo.TabIndex = 9;
            // 
            // labelFornecedor
            // 
            labelFornecedor.AutoSize = true;
            labelFornecedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFornecedor.Location = new Point(153, 84);
            labelFornecedor.Name = "labelFornecedor";
            labelFornecedor.Size = new Size(116, 28);
            labelFornecedor.TabIndex = 7;
            labelFornecedor.Text = "Fornecedor:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(275, 30);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(500, 34);
            txtId.TabIndex = 34;
            txtId.Text = "0";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(238, 33);
            lblId.Name = "lblId";
            lblId.Size = new Size(33, 28);
            lblId.TabIndex = 33;
            lblId.Text = "Id:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(652, 314);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 60);
            btnCancelar.TabIndex = 78;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.ImageAlign = ContentAlignment.BottomRight;
            btnGravar.Location = new Point(513, 314);
            btnGravar.Margin = new Padding(5);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(120, 60);
            btnGravar.TabIndex = 77;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // cmbFornecedores
            // 
            cmbFornecedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFornecedores.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbFornecedores.FormattingEnabled = true;
            cmbFornecedores.Location = new Point(275, 81);
            cmbFornecedores.Margin = new Padding(3, 4, 3, 4);
            cmbFornecedores.Name = "cmbFornecedores";
            cmbFornecedores.Size = new Size(500, 33);
            cmbFornecedores.TabIndex = 86;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(203, 135);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(66, 28);
            lblTitulo.TabIndex = 87;
            lblTitulo.Text = "Titulo:";
            // 
            // lblValorUnitario
            // 
            lblValorUnitario.AutoSize = true;
            lblValorUnitario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorUnitario.Location = new Point(96, 188);
            lblValorUnitario.Name = "lblValorUnitario";
            lblValorUnitario.Size = new Size(173, 28);
            lblValorUnitario.TabIndex = 89;
            lblValorUnitario.Text = "Valor por unidade:";
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.Location = new Point(275, 185);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(500, 34);
            txtValor.TabIndex = 88;
            // 
            // lblQuantidadeEstoque
            // 
            lblQuantidadeEstoque.AutoSize = true;
            lblQuantidadeEstoque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuantidadeEstoque.Location = new Point(43, 243);
            lblQuantidadeEstoque.Name = "lblQuantidadeEstoque";
            lblQuantidadeEstoque.Size = new Size(226, 28);
            lblQuantidadeEstoque.TabIndex = 91;
            lblQuantidadeEstoque.Text = "Quantidade em estoque:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantidade.Location = new Point(275, 240);
            txtQuantidade.Margin = new Padding(3, 4, 3, 4);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(500, 34);
            txtQuantidade.TabIndex = 90;
            // 
            // TelaProdutoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 415);
            Controls.Add(lblQuantidadeEstoque);
            Controls.Add(txtQuantidade);
            Controls.Add(lblValorUnitario);
            Controls.Add(txtValor);
            Controls.Add(lblTitulo);
            Controls.Add(cmbFornecedores);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(txtTitulo);
            Controls.Add(labelFornecedor);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaProdutoForm";
            Text = "Cadastro de produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private Label labelFornecedor;
        private TextBox txtId;
        private Label lblId;
        private Button btnCancelar;
        private Button btnGravar;
        private ComboBox cmbFornecedores;
        private Label lblTitulo;
        private Label lblValorUnitario;
        private TextBox txtValor;
        private Label lblQuantidadeEstoque;
        private TextBox txtQuantidade;
    }
}