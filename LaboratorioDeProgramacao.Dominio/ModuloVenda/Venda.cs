using LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloItemVenda;

namespace LaboratorioDeProgramacao.Dominio.ModuloVenda
{
    [Serializable]
    public class Venda : EntidadeBase<Venda>
    {
        public DateTime data { get; set; }
        public string cpf { get; set; }
        public string formaPagamento { get; set; }
        public float total { get; set; }

        public List<ItemVenda> itens { get; set; }

        public Venda()
        {
            itens = new();
        }

        public Venda(int id, DateTime data, string cpf, string formaPagamento, float total)
        {
            this.id = id;
            this.data = data;
            this.cpf = cpf;
            this.formaPagamento = formaPagamento;
            this.total = total;
            this.itens = new();
        }

        public override void AtualizarInformacoes(Venda registroAtualizado)
        {
            data = registroAtualizado.data;
            cpf = registroAtualizado.cpf;
            formaPagamento = registroAtualizado.formaPagamento;
            total = registroAtualizado.total;
            itens = registroAtualizado.itens;
        }

        public override string Validar()
        {
            if (string.IsNullOrWhiteSpace(formaPagamento))
                return "A forma de pagamento é obrigatória.";

            if (string.IsNullOrWhiteSpace(cpf) || cpf.Length != 11)
                return "O CPF deve conter exatamente 11 dígitos.";

            if (total < 0)
                return "O total da venda não pode ser negativo.";

            if (itens == null || itens.Count == 0)
                return "A venda deve conter pelo menos um item.";

            foreach (var item in itens)
            {
                var erro = item.Validar();
                if (!string.IsNullOrEmpty(erro))
                    return $"Item da venda inválido: {erro}";
            }

            return "";
        }

        public override string ToString()
        {
            return $"Venda {id} - {data.ToShortDateString()} - CPF: {cpf} - Total: R$ {total:F2}";
        }
    }
}