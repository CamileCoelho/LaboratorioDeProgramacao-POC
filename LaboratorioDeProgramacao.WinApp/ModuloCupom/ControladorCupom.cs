﻿
namespace LaboratorioDeProgramacao.WinApp.ModuloCupom
{
    public class ControladorCupom : ControladorBase
    {
        //IRepositorioProduto repositorioDisciplina;
        //IRepositorioTeste repositorioTeste;
        //TabelaTesteControl tabelaTeste;

        //public ControladorCupom(IRepositorioTeste repositorioTeste, IRepositorioProduto repositorioDisciplina)
        //{
        //    this.repositorioTeste = repositorioTeste;
        //    this.repositorioDisciplina = repositorioDisciplina;
        //}

        //public override string ToolTipInserir => "Cadastrar Teste";
        //public override string ToolTipDuplicar => "Duplicar Teste Existente";
        //public override string ToolTipExcluir => "Excluir Teste Existente";
        //public override string ToolTipVisualizar => "Visualizar Detalhes Teste Existente";
        //public override string ToolTipGerarPdf => "Gerar PDF de um Teste Existente";
        //public override string ToolTipHome => "Voltar a tela inicial";

        //public override bool HomeHabilitado => true;
        //public override bool InserirHabilitado => true;
        //public override bool DuplicarHabilitado => true;
        //public override bool DuplicarVisivel => true;
        //public override bool ExcluirHabilitado => true;
        //public override bool VisualizarHabilitado => true;
        //public override bool VisualizarVisivel => true;
        //public override bool GerarPdfHabilitado => true;
        //public override bool GerarPdfVisivel => true;
        //public override bool SeparadorVisivel3 => true;
        //public override bool SeparadorVisivel4 => true;

        //public override void Inserir()
        //{
        //    TelaTesteForm tela = new(repositorioTeste.SelecionarTodos(), repositorioDisciplina.SelecionarTodos());

        //    if (tela.ShowDialog() == DialogResult.OK)
        //    {
        //        Teste teste = tela.ObterTeste();

        //        repositorioTeste.Inserir(teste);

        //        CarregarTeste();
        //    }
        //    else
        //    {
        //        TelaPrincipalForm.Tela.AtualizarRodape("");
        //    }
        //}

        //public override void Duplicar()
        //{
        //    Teste testeSelecionado = ObterTesteSelecionado();

        //    if (testeSelecionado == null)
        //    {
        //        MessageBox.Show($"Selecione um questao primeiro!",
        //            "Edição de clientes",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Exclamation);
        //        return;
        //    }

        //    TelaTesteForm tela = new(repositorioTeste.SelecionarTodos(), repositorioDisciplina.SelecionarTodos());

        //    tela.ConfigurarTelaDuplicacao(testeSelecionado);

        //    if (tela.ShowDialog() == DialogResult.OK)
        //    {
        //        Teste teste = tela.ObterTeste();

        //        repositorioTeste.Inserir(teste);

        //        CarregarTeste();
        //    }
        //    else
        //    {
        //        TelaPrincipalForm.Tela.AtualizarRodape("");
        //    }
        //}

        //public override void Excluir()
        //{
        //    Teste testeSelecionado = ObterTesteSelecionado();

        //    if (testeSelecionado == null)
        //    {
        //        MessageBox.Show($"Selecione um teste primeiro!",
        //            "Exclusão de Testes",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Exclamation);

        //        return;
        //    }

        //    DialogResult opcaoEscolhida = MessageBox.Show(
        //        $"Deseja excluir o questao {testeSelecionado.id}?",
        //        "Exclusão de Questóes",
        //        MessageBoxButtons.OKCancel,
        //        MessageBoxIcon.Question);

        //    if (opcaoEscolhida == DialogResult.OK)
        //    {
        //        repositorioTeste.Excluir(testeSelecionado);

        //        CarregarTeste();
        //    }
        //}

        //public override void VisualizarTeste()
        //{
        //    Teste testeSelecionado = ObterTesteSelecionado();

        //    if (testeSelecionado == null)
        //    {
        //        MessageBox.Show($"Selecione um teste primeiro!",
        //            "Exclusão de Testes",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Exclamation);

        //        return;
        //    }

        //    TelaTesteForm tela = new(repositorioTeste.SelecionarTodos(), repositorioDisciplina.SelecionarTodos());

        //    tela.ConfigurarTelaVisualizarDetalhes(testeSelecionado);

        //    if (tela.ShowDialog() == DialogResult.OK)
        //        TelaPrincipalForm.Tela.AtualizarRodape("");
        //    else
        //        TelaPrincipalForm.Tela.AtualizarRodape("");
        //}

        //public override void GerarPdf()
        //{
        //    Teste testeSelecionado = ObterTesteSelecionado();

        //    if (testeSelecionado == null)
        //    {
        //        MessageBox.Show($"Selecione um teste primeiro!",
        //            "Exclusão de Testes",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Exclamation);

        //        return;
        //    }

        //    TelaGerarPdfForm telaPdf = new(testeSelecionado);

        //    telaPdf.ConfigurarTelaPdf(testeSelecionado);

        //    if (telaPdf.ShowDialog() == DialogResult.OK)
        //    {
        //        CarregarTeste();
        //    }

        //    TelaPrincipalForm.Tela.AtualizarRodape("");
        //}

        //private void CarregarTeste()
        //{
        //    List<Teste> testes = repositorioTeste.SelecionarTodos();

        //    tabelaTeste.AtualizarRegistros(testes);
        //}

        //private Teste ObterTesteSelecionado()
        //{
        //    int id = tabelaTeste.ObterNumeroTesteSelecionado();

        //    return repositorioTeste.SelecionarPorId(id);
        //}

        //public override UserControl ObterListagem()
        //{
        //    if (tabelaTeste == null)
        //        tabelaTeste = new TabelaTesteControl();

        //    CarregarTeste();

        //    return tabelaTeste;
        //}
        public override string ToolTipInserir => throw new NotImplementedException();

        public override string ToolTipExcluir => throw new NotImplementedException();

        public override string ToolTipHome => throw new NotImplementedException();

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
