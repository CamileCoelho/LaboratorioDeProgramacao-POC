namespace LaboratorioDeProgramacao.WinApp.ModuloVenda
{
    partial class TelaVendaForm
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
            txtId = new TextBox();
            lblData = new Label();
            lblCpf = new Label();
            panelAlternativas = new Panel();
            btnCancelar = new Button();
            btnGravar = new Button();
            lblItem = new Label();
            btnAdicionar = new Button();
            btnRemover = new Button();
            lblTabelaItens = new Label();
            dateTimePicker1 = new DateTimePicker();
            cmbFormaPagamento = new ComboBox();
            lblFormaPgto = new Label();
            lblQuantidade = new Label();
            cmbItens = new ComboBox();
            dateTimePicker = new DateTimePicker();
            txtQuantidade = new TextBox();
            txtCpf = new TextBox();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(271, 25);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(519, 34);
            txtId.TabIndex = 74;
            txtId.Text = "0";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblData.Location = new Point(211, 79);
            lblData.Name = "lblData";
            lblData.Size = new Size(57, 28);
            lblData.TabIndex = 84;
            lblData.Text = "Data:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCpf.Location = new Point(216, 134);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(49, 28);
            lblCpf.TabIndex = 72;
            lblCpf.Text = "CPF:";
            // 
            // panelAlternativas
            // 
            panelAlternativas.Location = new Point(271, 341);
            panelAlternativas.Margin = new Padding(3, 4, 3, 4);
            panelAlternativas.MaximumSize = new Size(519, 189);
            panelAlternativas.MinimumSize = new Size(519, 189);
            panelAlternativas.Name = "panelAlternativas";
            panelAlternativas.Size = new Size(519, 189);
            panelAlternativas.TabIndex = 78;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(683, 572);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 53);
            btnCancelar.TabIndex = 80;
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
            btnGravar.Location = new Point(569, 572);
            btnGravar.Margin = new Padding(5);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(107, 53);
            btnGravar.TabIndex = 79;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItem.Location = new Point(210, 257);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(55, 25);
            lblItem.TabIndex = 82;
            lblItem.Text = "Item:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdicionar.Location = new Point(569, 248);
            btnAdicionar.Margin = new Padding(3, 4, 3, 4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(107, 76);
            btnAdicionar.TabIndex = 81;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemover.Location = new Point(683, 248);
            btnRemover.Margin = new Padding(3, 4, 3, 4);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(107, 76);
            btnRemover.TabIndex = 86;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // lblTabelaItens
            // 
            lblTabelaItens.AutoSize = true;
            lblTabelaItens.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTabelaItens.Location = new Point(216, 341);
            lblTabelaItens.Name = "lblTabelaItens";
            lblTabelaItens.RightToLeft = RightToLeft.No;
            lblTabelaItens.Size = new Size(60, 25);
            lblTabelaItens.TabIndex = 90;
            lblTabelaItens.Text = "Itens:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(271, 81);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(519, 27);
            dateTimePicker1.TabIndex = 91;
            // 
            // cmbFormaPagamento
            // 
            cmbFormaPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormaPagamento.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbFormaPagamento.FormattingEnabled = true;
            cmbFormaPagamento.Location = new Point(271, 188);
            cmbFormaPagamento.Margin = new Padding(3, 4, 3, 4);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.Size = new Size(519, 33);
            cmbFormaPagamento.TabIndex = 93;
            // 
            // lblFormaPgto
            // 
            lblFormaPgto.AutoSize = true;
            lblFormaPgto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFormaPgto.Location = new Point(62, 188);
            lblFormaPgto.Name = "lblFormaPgto";
            lblFormaPgto.Size = new Size(203, 28);
            lblFormaPgto.TabIndex = 92;
            lblFormaPgto.Text = "Forma de Pagamento:";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuantidade.Location = new Point(145, 299);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(120, 25);
            lblQuantidade.TabIndex = 96;
            lblQuantidade.Text = "Quantidade:";
            // 
            // cmbItens
            // 
            cmbItens.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItens.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbItens.FormattingEnabled = true;
            cmbItens.Location = new Point(271, 248);
            cmbItens.Margin = new Padding(3, 4, 3, 4);
            cmbItens.Name = "cmbItens";
            cmbItens.Size = new Size(288, 33);
            cmbItens.TabIndex = 97;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(270, 81);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(520, 27);
            dateTimePicker.TabIndex = 98;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantidade.Location = new Point(270, 290);
            txtQuantidade.Margin = new Padding(3, 4, 3, 4);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(289, 34);
            txtQuantidade.TabIndex = 100;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpf.Location = new Point(271, 134);
            txtCpf.Margin = new Padding(3, 4, 3, 4);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(519, 34);
            txtCpf.TabIndex = 101;
            // 
            // TelaVendaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 663);
            Controls.Add(txtCpf);
            Controls.Add(txtQuantidade);
            Controls.Add(dateTimePicker);
            Controls.Add(cmbItens);
            Controls.Add(lblQuantidade);
            Controls.Add(cmbFormaPagamento);
            Controls.Add(lblFormaPgto);
            Controls.Add(lblTabelaItens);
            Controls.Add(btnAdicionar);
            Controls.Add(btnRemover);
            Controls.Add(lblItem);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(panelAlternativas);
            Controls.Add(txtId);
            Controls.Add(lblData);
            Controls.Add(lblCpf);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaVendaForm";
            Text = "Venda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMaterias;
        private TextBox txtId;
        private Label lblData;
        private Label lblCpf;
        private TextBox txtEnunciado;
        private Panel panelAlternativas;
        private Button btnCancelar;
        private Button btnGravar;
        private Label lblItem;
        private Button btnAdicionar;
        private TextBox txtAlternativa;
        private Label label2;
        private Button btnRemover;
        private Label label3;
        private ComboBox cmbAlternativas;
        private Label lblTabelaItens;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbFormaPagamento;
        private Label lblFormaPgto;
        private TextBox txtCpf;
        private TextBox textBox2;
        private Label lblQuantidade;
        private ComboBox cmbItens;
        private DateTimePicker dateTimePicker;
        private TextBox txtQuantidade;
        private TextBox textBox3;
    }
}