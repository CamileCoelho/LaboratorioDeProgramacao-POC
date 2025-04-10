using LaboratorioDeProgramacao.Dominio.ModuloFornecedor;

namespace LaboratorioDeProgramacao.Dominio.ModuloProduto
{
    [Serializable]
    public class Produto : EntidadeBase<Produto>
    {
        public string titulo { get; set; }
        public float valorUnitario { get; set; }
        public int quantidade { get; set; }
        public Fornecedor fornecedor { get; set; }

        public Produto()
        {

        }

        public Produto(int id, string titulo, float valorUnitario, int quantidade, Fornecedor fornecedor)
        {
            this.id = id;
            this.titulo = titulo;
            this.valorUnitario = valorUnitario;
            this.quantidade = quantidade;
            this.fornecedor = fornecedor;
        }

        public override void AtualizarInformacoes(Produto registroAtualizado)
        {
            titulo = registroAtualizado.titulo;
            valorUnitario = registroAtualizado.valorUnitario;
            quantidade = registroAtualizado.quantidade;
            fornecedor = registroAtualizado.fornecedor;
        }

        //public override string Validar()
        //{
        //    Validador valida = new();

        //    if (valida.ValidaString(titulo))
        //        return $"Você deve escrever uma disciplina!";

        //    if (titulo.Length <= 4)
        //        return $"O nome da disciplina deve conter no mínimo 5 caracteres!";

        //    return "";
        //}
        public override string Validar()
        {
            if (string.IsNullOrWhiteSpace(titulo))
                return "O título do produto é obrigatório.";

            if (titulo.Length < 3)
                return "O título do produto deve ter pelo menos 3 caracteres.";

            if (valorUnitario <= 0)
                return "O valor unitário deve ser maior que zero.";

            if (quantidade < 0)
                return "A quantidade não pode ser negativa.";

            if (fornecedor == null)
                return "O fornecedor do produto é obrigatório.";

            return "";
        }

        public override string ToString()
        {
            return titulo;
        }
    }
}
