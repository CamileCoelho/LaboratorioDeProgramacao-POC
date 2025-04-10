using iText.Kernel.Colors;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using LaboratorioDeProgramacao.Dominio.ModuloVenda;
using LaboratorioDeProgramacao.WinApp;
using iText.Layout;

public class ControladorCupom : ControladorBase
{
    public override string ToolTipInserir => TelaPrincipalForm.servicoDeTraducao.ObterTexto("RegisterSale");
    public override string ToolTipEditar => TelaPrincipalForm.servicoDeTraducao.ObterTexto("EditSale");
    public override string ToolTipExcluir => TelaPrincipalForm.servicoDeTraducao.ObterTexto("DeleteSale");
    public override string ToolTipHome => TelaPrincipalForm.servicoDeTraducao.ObterTexto("GoToHome");


    public override bool GerarPdfHabilitado => true;
    public override bool GerarPdfVisivel => true;
    public override bool SeparadorVisivel4 => true;
    public override bool HomeHabilitado => true;
    public override bool InserirHabilitado => true;
    public override bool EditarHabilitado => true;
    public override bool EditarVisivel => true;
    public override bool ExcluirHabilitado => true;

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

    protected void GerarPdfCupom(Venda venda)
    {
        if (venda == null)
        {
            MessageBox.Show("Selecione uma venda primeiro!", "Cupom Fiscal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "CupomFiscal.pdf");

        using (PdfWriter writer = new PdfWriter(path))
        using (PdfDocument pdf = new PdfDocument(writer))
        using (Document document = new Document(pdf))
        {
            document.SetMargins(20, 20, 20, 20);

            LineSeparator linhaSolida = new LineSeparator(new SolidLine()).SetWidth(UnitValue.CreatePercentValue(100));
            document.Add(linhaSolida);

            document.Add(new Paragraph("Empresa SUPERMERCADO CENTRAL LTDA")
                .SetBold()
                .SetFontSize(14)
                .SetFontColor(ColorConstants.BLACK)
                .SetMarginTop(5)
                .SetMarginBottom(5));

            document.Add(new Paragraph(new string('*', 142)).SetFontSize(10));

            document.Add(new Paragraph($"Cliente: {venda.cpf}")
                .SetMarginTop(10)
                .SetFontSize(10));

            decimal total = 0;
            int index = 1;

            foreach (var item in venda.itens)
            {
                decimal subtotal = item.produto.valorUnitario * item.quantidade;
                total += subtotal;

                document.Add(new Paragraph($"{index++}. {item.produto.titulo} x{item.quantidade} = R$ {subtotal:F2}")
                    .SetFontSize(10)
                    .SetMarginBottom(2));
            }

            document.Add(new Paragraph($"{index++}. Total: R$ {total:F2}")
                .SetFontSize(10)
                .SetBold()
                .SetMarginBottom(2));

            document.Add(new Paragraph(new string('*', 142)).SetFontSize(10));

            document.Add(new Paragraph($"Pagamento: {venda.formaPagamento}")
                .SetFontSize(10));

            document.Add(new LineSeparator(new DashedLine())
                .SetMarginTop(10)
                .SetMarginBottom(5));
        }

        MessageBox.Show("Cupom fiscal gerado com sucesso!", "PDF Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
