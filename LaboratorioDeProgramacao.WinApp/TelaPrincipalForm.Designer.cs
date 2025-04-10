namespace LaboratorioDeProgramacao.WinApp
{
    partial class TelaPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            pictureBox1 = new PictureBox();
            DisciplinasMenuItem = new ToolStripMenuItem();
            panelRegistros = new Panel();
            toolStrip1 = new ToolStrip();
            btnHome = new ToolStripButton();
            toolStripSeparator0 = new ToolStripSeparator();
            btnConfigDesconto = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnInserir = new ToolStripButton();
            btnDuplicar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnAdicionarItens = new ToolStripButton();
            btnRemoverItens = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnFinalizarPgto = new ToolStripButton();
            btnVisualizar = new ToolStripButton();
            btnVisualizarGabarito = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnGerarPdf = new ToolStripButton();
            btnFiltrar = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripLabel3 = new ToolStripLabel();
            toolStripButtonSelectedLanguage = new ToolStripDropDownButton();
            inglêsToolStripMenuItem = new ToolStripMenuItem();
            portuguêsToolStripMenuItem = new ToolStripMenuItem();
            espanholToolStripMenuItem = new ToolStripMenuItem();
            rodape = new StatusStrip();
            lableRodape = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            materiasMenuItem = new ToolStripMenuItem();
            questoesMenuItem = new ToolStripMenuItem();
            testesMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelRegistros.SuspendLayout();
            toolStrip1.SuspendLayout();
            rodape.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1184, 586);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DisciplinasMenuItem
            // 
            DisciplinasMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DisciplinasMenuItem.Name = "DisciplinasMenuItem";
            DisciplinasMenuItem.Size = new Size(88, 24);
            DisciplinasMenuItem.Text = "Disciplina";
            DisciplinasMenuItem.Click += DisciplinasMenuItem_Click;
            // 
            // panelRegistros
            // 
            panelRegistros.BorderStyle = BorderStyle.FixedSingle;
            panelRegistros.Controls.Add(pictureBox1);
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 69);
            panelRegistros.Margin = new Padding(4);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(1188, 562);
            panelRegistros.TabIndex = 7;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnHome, toolStripSeparator0, btnConfigDesconto, toolStripSeparator1, btnInserir, btnDuplicar, btnEditar, btnExcluir, toolStripSeparator2, btnAdicionarItens, btnRemoverItens, toolStripSeparator3, btnFinalizarPgto, btnVisualizar, btnVisualizarGabarito, toolStripSeparator4, btnGerarPdf, btnFiltrar, toolStripSeparator5, toolStripLabel3, toolStripButtonSelectedLanguage, toolStripSeparator6 });
            toolStrip1.Location = new Point(0, 30);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1188, 39);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnHome
            // 
            btnHome.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnHome.Enabled = false;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageTransparentColor = Color.Magenta;
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(6);
            btnHome.Size = new Size(36, 36);
            btnHome.Text = "Home";
            btnHome.ToolTipText = "Botão Home indisponível.";
            btnHome.Visible = false;
            btnHome.Click += btnHome_Click;
            // 
            // toolStripSeparator0
            // 
            toolStripSeparator0.Name = "toolStripSeparator0";
            toolStripSeparator0.Size = new Size(6, 39);
            toolStripSeparator0.Visible = false;
            // 
            // btnConfigDesconto
            // 
            btnConfigDesconto.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnConfigDesconto.Enabled = false;
            btnConfigDesconto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfigDesconto.Image = (Image)resources.GetObject("btnConfigDesconto.Image");
            btnConfigDesconto.ImageTransparentColor = Color.Magenta;
            btnConfigDesconto.Name = "btnConfigDesconto";
            btnConfigDesconto.Padding = new Padding(6);
            btnConfigDesconto.Size = new Size(36, 36);
            btnConfigDesconto.Visible = false;
            btnConfigDesconto.Click += btnConfigDesconto_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            toolStripSeparator1.Visible = false;
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Enabled = false;
            btnInserir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInserir.Image = (Image)resources.GetObject("btnInserir.Image");
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(6);
            btnInserir.Size = new Size(36, 36);
            btnInserir.Text = "Inserir";
            btnInserir.Visible = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnDuplicar
            // 
            btnDuplicar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDuplicar.Enabled = false;
            btnDuplicar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDuplicar.Image = (Image)resources.GetObject("btnDuplicar.Image");
            btnDuplicar.ImageTransparentColor = Color.Magenta;
            btnDuplicar.Name = "btnDuplicar";
            btnDuplicar.Padding = new Padding(6);
            btnDuplicar.Size = new Size(36, 36);
            btnDuplicar.Text = "Editar";
            btnDuplicar.Visible = false;
            btnDuplicar.Click += btdDuplicar_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(6);
            btnEditar.Size = new Size(36, 36);
            btnEditar.Text = "Editar";
            btnEditar.Visible = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(6);
            btnExcluir.Size = new Size(36, 36);
            btnExcluir.Text = "Excluir";
            btnExcluir.Visible = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 39);
            toolStripSeparator2.Visible = false;
            // 
            // btnAdicionarItens
            // 
            btnAdicionarItens.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionarItens.Enabled = false;
            btnAdicionarItens.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdicionarItens.Image = (Image)resources.GetObject("btnAdicionarItens.Image");
            btnAdicionarItens.ImageTransparentColor = Color.Magenta;
            btnAdicionarItens.Name = "btnAdicionarItens";
            btnAdicionarItens.Padding = new Padding(6);
            btnAdicionarItens.Size = new Size(36, 36);
            btnAdicionarItens.Visible = false;
            btnAdicionarItens.Click += btnAdicionarItens_Click;
            // 
            // btnRemoverItens
            // 
            btnRemoverItens.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRemoverItens.Enabled = false;
            btnRemoverItens.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoverItens.Image = (Image)resources.GetObject("btnRemoverItens.Image");
            btnRemoverItens.ImageTransparentColor = Color.Magenta;
            btnRemoverItens.Name = "btnRemoverItens";
            btnRemoverItens.Padding = new Padding(6);
            btnRemoverItens.Size = new Size(36, 36);
            btnRemoverItens.Visible = false;
            btnRemoverItens.Click += btnRemoverItens_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 39);
            toolStripSeparator3.Visible = false;
            // 
            // btnFinalizarPgto
            // 
            btnFinalizarPgto.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFinalizarPgto.Enabled = false;
            btnFinalizarPgto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinalizarPgto.Image = (Image)resources.GetObject("btnFinalizarPgto.Image");
            btnFinalizarPgto.ImageTransparentColor = Color.Magenta;
            btnFinalizarPgto.Name = "btnFinalizarPgto";
            btnFinalizarPgto.Padding = new Padding(6);
            btnFinalizarPgto.Size = new Size(36, 36);
            btnFinalizarPgto.Visible = false;
            btnFinalizarPgto.Click += btnFinalizarPgto_Click;
            // 
            // btnVisualizar
            // 
            btnVisualizar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizar.Enabled = false;
            btnVisualizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVisualizar.Image = (Image)resources.GetObject("btnVisualizar.Image");
            btnVisualizar.ImageTransparentColor = Color.Magenta;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Padding = new Padding(6);
            btnVisualizar.Size = new Size(36, 36);
            btnVisualizar.Text = "VisualizarTeste";
            btnVisualizar.Visible = false;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnVisualizarGabarito
            // 
            btnVisualizarGabarito.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizarGabarito.Enabled = false;
            btnVisualizarGabarito.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVisualizarGabarito.Image = (Image)resources.GetObject("btnVisualizarGabarito.Image");
            btnVisualizarGabarito.ImageTransparentColor = Color.Magenta;
            btnVisualizarGabarito.Name = "btnVisualizarGabarito";
            btnVisualizarGabarito.Padding = new Padding(6);
            btnVisualizarGabarito.Size = new Size(36, 36);
            btnVisualizarGabarito.Text = "VisualizarTeste Gabarito";
            btnVisualizarGabarito.Visible = false;
            btnVisualizarGabarito.Click += btnVisualizarGabarito_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 39);
            toolStripSeparator4.Visible = false;
            // 
            // btnGerarPdf
            // 
            btnGerarPdf.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnGerarPdf.Enabled = false;
            btnGerarPdf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGerarPdf.Image = (Image)resources.GetObject("btnGerarPdf.Image");
            btnGerarPdf.ImageTransparentColor = Color.Magenta;
            btnGerarPdf.Name = "btnGerarPdf";
            btnGerarPdf.Padding = new Padding(6);
            btnGerarPdf.Size = new Size(36, 36);
            btnGerarPdf.Text = "Filtrar";
            btnGerarPdf.Visible = false;
            btnGerarPdf.Click += btnGerarPdf_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFiltrar.Enabled = false;
            btnFiltrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFiltrar.Image = (Image)resources.GetObject("btnFiltrar.Image");
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Padding = new Padding(6);
            btnFiltrar.Size = new Size(36, 36);
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.Visible = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 39);
            toolStripSeparator5.Visible = false;
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(101, 36);
            toolStripLabel3.Text = "                       ";
            // 
            // toolStripButtonSelectedLanguage
            // 
            toolStripButtonSelectedLanguage.Alignment = ToolStripItemAlignment.Right;
            toolStripButtonSelectedLanguage.DropDownItems.AddRange(new ToolStripItem[] { inglêsToolStripMenuItem, portuguêsToolStripMenuItem, espanholToolStripMenuItem });
            toolStripButtonSelectedLanguage.Image = (Image)resources.GetObject("toolStripButtonSelectedLanguage.Image");
            toolStripButtonSelectedLanguage.ImageTransparentColor = Color.Magenta;
            toolStripButtonSelectedLanguage.Name = "toolStripButtonSelectedLanguage";
            toolStripButtonSelectedLanguage.Size = new Size(108, 36);
            toolStripButtonSelectedLanguage.Text = "Português";
            toolStripButtonSelectedLanguage.TextAlign = ContentAlignment.MiddleRight;
            toolStripButtonSelectedLanguage.ToolTipText = "Português";
            // 
            // inglêsToolStripMenuItem
            // 
            inglêsToolStripMenuItem.Name = "inglêsToolStripMenuItem";
            inglêsToolStripMenuItem.Size = new Size(157, 26);
            inglêsToolStripMenuItem.Text = "Inglês";
            inglêsToolStripMenuItem.Click += inglesToolStripMenuItem_Click;
            // 
            // portuguêsToolStripMenuItem
            // 
            portuguêsToolStripMenuItem.Name = "portuguêsToolStripMenuItem";
            portuguêsToolStripMenuItem.Size = new Size(157, 26);
            portuguêsToolStripMenuItem.Text = "Português";
            portuguêsToolStripMenuItem.Click += portuguesToolStripMenuItem_Click;
            // 
            // espanholToolStripMenuItem
            // 
            espanholToolStripMenuItem.Name = "espanholToolStripMenuItem";
            espanholToolStripMenuItem.Size = new Size(157, 26);
            espanholToolStripMenuItem.Text = "Espanhol";
            espanholToolStripMenuItem.Click += espanholToolStripMenuItem_Click;
            // 
            // rodape
            // 
            rodape.ImageScalingSize = new Size(20, 20);
            rodape.Items.AddRange(new ToolStripItem[] { lableRodape });
            rodape.Location = new Point(0, 631);
            rodape.Name = "rodape";
            rodape.Padding = new Padding(1, 0, 18, 0);
            rodape.Size = new Size(1188, 34);
            rodape.TabIndex = 5;
            rodape.Text = "statusStrip1";
            // 
            // lableRodape
            // 
            lableRodape.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lableRodape.Name = "lableRodape";
            lableRodape.Size = new Size(62, 28);
            lableRodape.Text = "          ";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { DisciplinasMenuItem, materiasMenuItem, questoesMenuItem, testesMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1188, 30);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // materiasMenuItem
            // 
            materiasMenuItem.Name = "materiasMenuItem";
            materiasMenuItem.Size = new Size(74, 24);
            materiasMenuItem.Text = "Matéria";
            materiasMenuItem.Click += materiasMenuItem_Click;
            // 
            // questoesMenuItem
            // 
            questoesMenuItem.Name = "questoesMenuItem";
            questoesMenuItem.Size = new Size(84, 24);
            questoesMenuItem.Text = "Questões";
            questoesMenuItem.Click += questoesMenuItem_Click;
            // 
            // testesMenuItem
            // 
            testesMenuItem.Name = "testesMenuItem";
            testesMenuItem.Size = new Size(63, 24);
            testesMenuItem.Text = "Testes";
            testesMenuItem.Click += testesMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator6.AutoSize = false;
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 39);
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 665);
            Controls.Add(panelRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(rodape);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "   Testes Dona Mariana";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelRegistros.ResumeLayout(false);
            panelRegistros.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            rodape.ResumeLayout(false);
            rodape.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ToolStripMenuItem DisciplinasMenuItem;
        private Panel panelRegistros;
        private ToolStrip toolStrip1;
        private ToolStripButton btnHome;
        private ToolStripSeparator toolStripSeparator0;
        private ToolStripButton btnConfigDesconto;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnAdicionarItens;
        private ToolStripButton btnRemoverItens;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnFinalizarPgto;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnVisualizar;
        private ToolStripButton btnFiltrar;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripLabel labelTipoDoCadastro;
        private StatusStrip rodape;
        private ToolStripStatusLabel lableRodape;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem materiasMenuItem;
        private ToolStripMenuItem questoesMenuItem;
        private ToolStripMenuItem testesMenuItem;
        private ToolStripButton btnDuplicar;
        private ToolStripButton btnVisualizarGabarito;
        private ToolStripButton btnGerarPdf;
        private ToolStripLabel toolStripLabel3;
        private ToolStripLabel toolStripLabel2;
        private ToolStripLabel toolStripLabel1;
        private ToolStripDropDownButton toolStripButtonSelectedLanguage;
        private ToolStripMenuItem inglêsToolStripMenuItem;
        private ToolStripMenuItem portuguêsToolStripMenuItem;
        private ToolStripMenuItem espanholToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
    }
}