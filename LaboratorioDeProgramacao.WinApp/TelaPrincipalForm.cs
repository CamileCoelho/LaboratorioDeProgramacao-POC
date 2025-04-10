using LaboratorioDeProgramacao.Dominio.ModuloDisciplina;
using LaboratorioDeProgramacao.Dominio.ModuloMateria;
using LaboratorioDeProgramacao.Dominio.ModuloQuestao;
using LaboratorioDeProgramacao.Dominio.ModuloTeste;
using LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloDisciplina;
using LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloMateria;
using LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloQuestao;
using LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloTeste;
using LaboratorioDeProgramacao.WinApp.Config;
using LaboratorioDeProgramacao.WinApp.ModuloDisciplina;
using LaboratorioDeProgramacao.WinApp.ModuloMateria;
using LaboratorioDeProgramacao.WinApp.ModuloQuestao;
using LaboratorioDeProgramacao.WinApp.ModuloTeste;
using LaboratorioDeProgramacao.WinApp.Translation;

namespace LaboratorioDeProgramacao.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;

        private IRepositorioDisciplina repositorioDisciplina = new RepositorioDisciplinaSql();
        private IRepositorioMateria repositorioMateria = new RepositorioMateriaSql();
        private IRepositorioQuestao repositorioQuestao = new RepositorioQuestaoSql();
        private IRepositorioTeste repositorioTeste = new RepositorioTesteSql();

        public static TelaPrincipalForm Tela { get; private set; }

        public static ServicoDeTraducao translationService = new ServicoDeTraducao();

        public TelaPrincipalForm()
        {
            var lang = AppConfig.ObterIdioma();

            InitializeComponent();

            this.ConfigurarDialog();

            ConfigurarTextos();

            Tela = this;
        }

        public void AtualizarRodape(string status)
        {
            lableRodape.Text = status;
        }

        private void DisciplinasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDisciplina(repositorioDisciplina, repositorioMateria);

            ConfigurarTelaPrincipal(controlador);
        }

        private void materiasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorMateria(repositorioMateria, repositorioDisciplina, repositorioQuestao);

            ConfigurarTelaPrincipal(controlador);
        }

        private void questoesMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorQuestao(repositorioQuestao, repositorioDisciplina, repositorioTeste);

            ConfigurarTelaPrincipal(controlador);
        }

        private void testesMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTeste(repositorioTeste, repositorioDisciplina);

            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);
        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = translationService.ObterTexto("Insert");
            btnEditar.ToolTipText = translationService.ObterTexto("Edit");
            btnDuplicar.ToolTipText = translationService.ObterTexto("Duplicate");
            btnExcluir.ToolTipText = translationService.ObterTexto("Delete");
            btnFiltrar.ToolTipText = translationService.ObterTexto("Filter");
            btnAdicionarItens.ToolTipText = translationService.ObterTexto("AddItems");
            btnRemoverItens.ToolTipText = translationService.ObterTexto("RemoveItems");
            btnFinalizarPgto.ToolTipText = translationService.ObterTexto("FinalizePayment");
            btnConfigDesconto.ToolTipText = translationService.ObterTexto("DiscountSettings");
            btnVisualizar.ToolTipText = translationService.ObterTexto("View");
            btnVisualizarGabarito.ToolTipText = translationService.ObterTexto("ViewAnswerKey");
            btnGerarPdf.ToolTipText = translationService.ObterTexto("GeneratePdf");
            btnHome.ToolTipText = translationService.ObterTexto("Home");


            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnDuplicar.Enabled = controlador.DuplicarHabilitado;
            btnExcluir.Enabled = controlador.ExcluirHabilitado;
            btnHome.Enabled = controlador.HomeHabilitado;
            btnFiltrar.Enabled = controlador.FiltrarHabilitado;
            btnAdicionarItens.Enabled = controlador.AdicionarItensHabilitado;
            btnRemoverItens.Enabled = controlador.RemoverItensHabilitado;
            btnFinalizarPgto.Enabled = controlador.FinalizarPagamentoHabilitado;
            btnConfigDesconto.Enabled = controlador.ConfigDescontoHabilitado;
            btnVisualizar.Enabled = controlador.VisualizarHabilitado;
            btnVisualizarGabarito.Enabled = controlador.VisualizarGabaritoHabilitado;
            btnGerarPdf.Enabled = controlador.GerarPdfHabilitado;

            btnInserir.Visible = controlador.InserirVisivel;
            btnEditar.Visible = controlador.EditarVisivel;
            btnDuplicar.Visible = controlador.DuplicarVisivel;
            btnExcluir.Visible = controlador.ExcluirVisivel;
            btnHome.Visible = controlador.HomeVisivel;
            btnFiltrar.Visible = controlador.FiltrarVisivel;
            btnAdicionarItens.Visible = controlador.AdicionarItensVisivel;
            btnRemoverItens.Visible = controlador.RemoverItensVisivel;
            btnFinalizarPgto.Visible = controlador.FinalizarPagamentoVisivel;
            btnConfigDesconto.Visible = controlador.ConfigDescontoVisivel;
            btnVisualizar.Visible = controlador.VisualizarVisivel;
            btnVisualizarGabarito.Visible = controlador.VisualizarGabaritoVisivel;
            btnGerarPdf.Visible = controlador.GerarPdfVisivel;

            toolStripSeparator0.Visible = controlador.SeparadorVisivel0;
            toolStripSeparator1.Visible = controlador.SeparadorVisivel1;
            toolStripSeparator2.Visible = controlador.SeparadorVisivel2;
            toolStripSeparator3.Visible = controlador.SeparadorVisivel3;
            toolStripSeparator4.Visible = controlador.SeparadorVisivel4;
            toolStripSeparator5.Visible = controlador.SeparadorVisivel5;
        }

        private void ConfigurarTextos()
        {
            DisciplinasMenuItem.Text = translationService.ObterTexto("Disciplines");
            materiasMenuItem.Text = translationService.ObterTexto("Subjects");
            questoesMenuItem.Text = translationService.ObterTexto("Questions");
            toolStripButtonSelectedLanguage.Text = translationService.ObterTexto("SelectedLanguage");
            inglêsToolStripMenuItem.Text = translationService.ObterTexto("English");
            portuguêsToolStripMenuItem.Text = translationService.ObterTexto("Portuguese");
            espanholToolStripMenuItem.Text = translationService.ObterTexto("Spanish");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btdDuplicar_Click(object sender, EventArgs e)
        {
            controlador.Duplicar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            controlador.Filtrar();
        }

        private void btnAdicionarItens_Click(object sender, EventArgs e)
        {
            controlador.AdicionarItens();
        }

        private void btnRemoverItens_Click(object sender, EventArgs e)
        {
            controlador.RemoverItens();
        }

        private void btnFinalizarPgto_Click(object sender, EventArgs e)
        {
            controlador.FinalizarPagamento();
        }

        private void btnConfigDesconto_Click(object sender, EventArgs e)
        {
            controlador.ConfigurarDesconto();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            controlador.VisualizarTeste();
        }

        private void btnVisualizarGabarito_Click(object sender, EventArgs e)
        {
            controlador.VisualizarGabarito();
        }

        private void btnGerarPdf_Click(object sender, EventArgs e)
        {
            controlador.GerarPdf();
        }

        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppConfig.SetarIdioma("en");
            Application.Restart();
        }

        private void portuguesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppConfig.SetarIdioma("pt");
            Application.Restart();
        }

        private void espanholToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppConfig.SetarIdioma("es");
            Application.Restart();
        }
    }
}