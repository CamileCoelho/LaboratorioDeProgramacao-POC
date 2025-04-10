namespace LaboratorioDeProgramacao.WinApp.ModuloTeste
{
    partial class TelaGerarPdfForm
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
            lblTitulo = new Label();
            txtLocalizacao = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnGerarPDF = new Button();
            btnLocalizar = new Button();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitulo.Location = new Point(229, 25);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(544, 34);
            txtTitulo.TabIndex = 84;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(157, 31);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(66, 28);
            lblTitulo.TabIndex = 83;
            lblTitulo.Text = "Título:";
            // 
            // txtLocalizacao
            // 
            txtLocalizacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLocalizacao.Location = new Point(229, 87);
            txtLocalizacao.Margin = new Padding(3, 4, 3, 4);
            txtLocalizacao.Name = "txtLocalizacao";
            txtLocalizacao.Size = new Size(411, 34);
            txtLocalizacao.TabIndex = 86;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 87);
            label1.Name = "label1";
            label1.Size = new Size(196, 28);
            label1.TabIndex = 85;
            label1.Text = "Diretório do arquivo:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(655, 158);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 57);
            btnCancelar.TabIndex = 94;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGerarPDF
            // 
            btnGerarPDF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGerarPDF.DialogResult = DialogResult.OK;
            btnGerarPDF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGerarPDF.ImageAlign = ContentAlignment.BottomRight;
            btnGerarPDF.Location = new Point(522, 158);
            btnGerarPDF.Margin = new Padding(5);
            btnGerarPDF.Name = "btnGerarPDF";
            btnGerarPDF.Size = new Size(118, 57);
            btnGerarPDF.TabIndex = 93;
            btnGerarPDF.Text = "Gerar PDF";
            btnGerarPDF.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGerarPDF.UseVisualStyleBackColor = true;
            btnGerarPDF.Click += btnGerarPDF_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLocalizar.DialogResult = DialogResult.Cancel;
            btnLocalizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLocalizar.ImageAlign = ContentAlignment.BottomRight;
            btnLocalizar.Location = new Point(655, 85);
            btnLocalizar.Margin = new Padding(5);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(118, 39);
            btnLocalizar.TabIndex = 95;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // TelaGerarPdfForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 248);
            Controls.Add(btnLocalizar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGerarPDF);
            Controls.Add(txtLocalizacao);
            Controls.Add(label1);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaGerarPdfForm";
            Text = "Gerador de PDF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private Label lblTitulo;
        private TextBox txtLocalizacao;
        private Label label1;
        private Button btnCancelar;
        private Button btnGerarPDF;
        private Button btnLocalizar;
    }
}