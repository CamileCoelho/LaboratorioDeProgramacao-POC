using LaboratorioDeProgramacao.WinApp.Translation;

namespace LaboratorioDeProgramacao.WinApp.ModuloDisciplina
{
    partial class TelaDisciplinaForm
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
            txtDisciplina = new TextBox();
            labelDisciplina = new Label();
            txtId = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            SuspendLayout();
            // 
            // txtDisciplina
            // 
            txtDisciplina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDisciplina.Location = new Point(127, 80);
            txtDisciplina.Margin = new Padding(3, 4, 3, 4);
            txtDisciplina.Name = "txtDisciplina";
            txtDisciplina.Size = new Size(500, 34);
            txtDisciplina.TabIndex = 9;
            // 
            // labelDisciplina
            // 
            labelDisciplina.AutoSize = true;
            labelDisciplina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDisciplina.Location = new Point(29, 80);
            labelDisciplina.Name = "labelDisciplina";
            labelDisciplina.Size = new Size(100, 28);
            labelDisciplina.TabIndex = 7;
            labelDisciplina.Text = "Disciplina:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(127, 29);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(500, 34);
            txtId.TabIndex = 34;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(90, 29);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 33;
            label1.Text = "Id:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(504, 160);
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
            btnGravar.Location = new Point(365, 160);
            btnGravar.Margin = new Padding(5);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(120, 60);
            btnGravar.TabIndex = 77;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // TelaDisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 261);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(txtDisciplina);
            Controls.Add(labelDisciplina);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaDisciplinaForm";
            Text = "TelaDisciplinaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisciplina;
        private Label labelDisciplina;
        private TextBox txtId;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
    }
}