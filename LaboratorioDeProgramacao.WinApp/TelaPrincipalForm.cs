using LaboratorioDeProgramacao.Dominio.ModuloFornecedor;
using LaboratorioDeProgramacao.Dominio.ModuloProduto;
using LaboratorioDeProgramacao.Dominio.ModuloVenda;
using LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloFornecedor;
using LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloItemVenda;
using LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloProduto;
using LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloVenda;
using LaboratorioDeProgramacao.WinApp.Config;
using LaboratorioDeProgramacao.WinApp.ModuloFornecedor;
using LaboratorioDeProgramacao.WinApp.ModuloProduto;
using LaboratorioDeProgramacao.WinApp.ModuloVenda;
using LaboratorioDeProgramacao.WinApp.Translation;

namespace LaboratorioDeProgramacao.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;

        private IRepositorioProduto repositorioProduto = new RepositorioProdutoSql();
        private IRepositorioFornecedor repositorioFornecedor = new RepositorioFornecedorSql();
        private IRepositorioVenda repositorioVenda = new RepositorioVendaSql();
        private IRepositorioItemVenda repositorioItemVenda = new RepositorioItemVendaSql();

        public static TelaPrincipalForm Tela { get; private set; }

        public static ServicoDeTraducao servicoDeTraducao = new ServicoDeTraducao();

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

        private void ProdutosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorProduto(repositorioProduto, repositorioFornecedor, repositorioVenda);

            ConfigurarTelaPrincipal(controlador);
        }

        private void FornecedoresMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorFornecedor(repositorioFornecedor, repositorioProduto);

            ConfigurarTelaPrincipal(controlador);
        }

        private void VendasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorVenda(repositorioVenda, repositorioProduto);

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
            btnInserir.ToolTipText = servicoDeTraducao.ObterTexto("Insert");
            btnEditar.ToolTipText = servicoDeTraducao.ObterTexto("Edit");
            btnDuplicar.ToolTipText = servicoDeTraducao.ObterTexto("Duplicate");
            btnExcluir.ToolTipText = servicoDeTraducao.ObterTexto("Delete");
            btnFiltrar.ToolTipText = servicoDeTraducao.ObterTexto("Filter");
            btnAdicionarItens.ToolTipText = servicoDeTraducao.ObterTexto("AddItems");
            btnRemoverItens.ToolTipText = servicoDeTraducao.ObterTexto("RemoveItems");
            btnFinalizarPgto.ToolTipText = servicoDeTraducao.ObterTexto("FinalizePayment");
            btnConfigDesconto.ToolTipText = servicoDeTraducao.ObterTexto("DiscountSettings");
            btnVisualizar.ToolTipText = servicoDeTraducao.ObterTexto("View");
            btnVisualizarGabarito.ToolTipText = servicoDeTraducao.ObterTexto("ViewAnswerKey");
            btnGerarPdf.ToolTipText = servicoDeTraducao.ObterTexto("GeneratePdf");
            btnHome.ToolTipText = servicoDeTraducao.ObterTexto("Home");


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
            produtosMenuItem.Text = servicoDeTraducao.ObterTexto("Products");
            fornecedoresMenuItem.Text = servicoDeTraducao.ObterTexto("Suppliers");
            vendasMenuItem.Text = servicoDeTraducao.ObterTexto("Sales");
            toolStripButtonSelectedLanguage.Text = servicoDeTraducao.ObterTexto("SelectedLanguage");
            inglêsToolStripMenuItem.Text = servicoDeTraducao.ObterTexto("English");
            portuguêsToolStripMenuItem.Text = servicoDeTraducao.ObterTexto("Portuguese");
            espanholToolStripMenuItem.Text = servicoDeTraducao.ObterTexto("Spanish");
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