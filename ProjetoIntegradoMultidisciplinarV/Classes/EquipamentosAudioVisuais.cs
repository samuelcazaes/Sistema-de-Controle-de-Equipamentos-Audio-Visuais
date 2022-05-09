namespace ProjetoIntegradoMultidisciplinarV.Classes
{
    public class EquipamentosAudioVisuais
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Serie { get; set; }
        public int Id{ get;  set; }

        public Escola Escola = new Escola();
        public Horarios Horarios= new Horarios();
        public EquipamentosAudioVisuais(string nome, string marca, string serie, string nomeProfessor, string nomeSala, int id, string dataAgendada)
        {
            Nome = nome;
            Marca = marca;
            Serie = serie;
            Id = id;
            Escola.Professor.Nome = nomeProfessor;
            Escola.Sala.Nome = nomeSala;
            Horarios.DataAgendada = dataAgendada;
            Horarios.DataHoje = System.DateTime.Now;
           
        }
    }
}
