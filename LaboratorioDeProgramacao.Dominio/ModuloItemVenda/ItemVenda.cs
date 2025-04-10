using LaboratorioDeProgramacao.Dominio.ModuloProduto;

namespace LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloItemVenda
{
    [Serializable]
    public class ItemVenda : EntidadeBase<ItemVenda>
    {
        public int id_venda { get; set; }
        public Produto produto { get; set; }
        public int quantidade { get; set; }

        public ItemVenda()
        {

        }

        public ItemVenda(int id, Produto produto, int quantidade)
        {
            this.id = id;
            this.produto = produto;
            this.quantidade = quantidade;
        }

        public override void AtualizarInformacoes(ItemVenda registroAtualizado)
        {
            produto = registroAtualizado.produto;
            quantidade = registroAtualizado.quantidade;
        }

        public override string Validar()
        {
            if (produto == null)
                return "O produto não pode ser nulo.";

            if (quantidade <= 0)
                return "A quantidade deve ser maior que zero.";

            return "";
        }

        public override string ToString()
        {
            return $"{produto?.titulo} - {quantidade}";
        }
    }
}