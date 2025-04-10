namespace LaboratorioDeProgramacao.Dominio.ModuloFornecedor
{
    [Serializable]
    public class Fornecedor : EntidadeBase<Fornecedor>
    {
        public string nome { get; set; }
        public string endereco { get; set; }

        public Fornecedor()
        {

        }

        public Fornecedor(int id, string nome, string endereco)
        {
            this.id = id;
            this.nome = nome;
            this.endereco = endereco;
        }

        public override void AtualizarInformacoes(Fornecedor registroAtualizado)
        {
            nome = registroAtualizado.nome;
            endereco = registroAtualizado.endereco;
        }

        public override string Validar()
        {
            if (string.IsNullOrWhiteSpace(nome))
                return "O nome do fornecedor é obrigatório.";

            if (nome.Length < 3)
                return "O nome do fornecedor deve ter pelo menos 3 caracteres.";

            if (string.IsNullOrWhiteSpace(endereco))
                return "O endereço do fornecedor é obrigatório.";

            return "";
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
