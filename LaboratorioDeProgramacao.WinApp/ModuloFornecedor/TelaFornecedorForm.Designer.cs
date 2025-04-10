namespace LaboratorioDeProgramacao.WinApp.ModuloFornecedor
{
    partial class TelaFornecedorForm
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
            txtId = new TextBox();
            lblId = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            lblTitulo = new Label();
            lblEndereco = new Label();
            txtValor = new TextBox();
            lblNome = new Label();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitulo.Location = new Point(119, 88);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(738, 34);
            txtTitulo.TabIndex = 9;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(119, 30);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(738, 34);
            txtId.TabIndex = 34;
            txtId.Text = "0";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(80, 30);
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
            btnCancelar.Location = new Point(734, 219);
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
            btnGravar.Location = new Point(595, 219);
            btnGravar.Margin = new Padding(5);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(120, 60);
            btnGravar.TabIndex = 77;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(100, 23);
            lblTitulo.TabIndex = 0;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEndereco.Location = new Point(16, 141);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(97, 28);
            lblEndereco.TabIndex = 89;
            lblEndereco.Text = "Endereço:";
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.Location = new Point(119, 141);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(738, 34);
            txtValor.TabIndex = 88;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(43, 91);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(70, 28);
            lblNome.TabIndex = 90;
            lblNome.Text = "Nome:";
            // 
            // TelaFornecedorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 320);
            Controls.Add(lblNome);
            Controls.Add(lblEndereco);
            Controls.Add(txtValor);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(txtTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaFornecedorForm";
            Text = "Cadastro de fornecedor";
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
        private Label lblEndereco;
        private TextBox txtValor;
        private Label lblQuantidadeEstoque;
        private TextBox txtQuantidade;
        private Label lblNome;
    }
}