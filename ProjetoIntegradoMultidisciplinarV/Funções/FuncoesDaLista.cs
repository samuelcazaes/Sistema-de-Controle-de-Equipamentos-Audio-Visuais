using ProjetoIntegradoMultidisciplinarV.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoIntegradoMultidisciplinarV.Funções
{
    public static class FuncoesDaLista
    {


        public static List<EquipamentosAudioVisuais> AdicionaNaLista
            (this List<EquipamentosAudioVisuais> ListaDeEquipamentos, string nome, string marca, string serie, string nomeProfessor, 
            string nomeSala, string dataAgendada) 
        {
            var id = 1;
            if (ListaDeEquipamentos.Count > 0)
                id = ListaDeEquipamentos.Max(x => x.Id) +1;
          
            ListaDeEquipamentos.Add(new EquipamentosAudioVisuais(nome, marca, serie, nomeProfessor, nomeSala, id, dataAgendada)) ;
            
            
            return ListaDeEquipamentos;
        }

        public static void VerLista(this List<EquipamentosAudioVisuais> ListaDeEquipamentos)
        {
            foreach(EquipamentosAudioVisuais item in ListaDeEquipamentos)
            {
                Console.WriteLine(

                
                    $" -> Equipamento:      {item.Nome                  }    \n" +
                    $" -> Marca:            {item.Marca                 }    \n" +
                    $" -> Serie:            {item.Serie                 }    \n" +
                    $" -> Reservado Para:   {item.Escola.Professor.Nome }    \n" +
                    $" -> Sala:             {item.Escola.Sala.Nome      }    \n" +
                    $" -> Data Agendada:    {item.Horarios.DataAgendada }    \n" +
                    $" -> Data de Registro: {item.Horarios.DataHoje     }    \n" +
                    $" -> Numero ID:        {item.Id                    }    \n" +
                "\n--------------------------------------------------------------------" + "\n") ;
                   
            }
        }

        public static void RemoverDaLista ( this List<EquipamentosAudioVisuais> ListaDeEquipamentos, int Id)
        {

            ListaDeEquipamentos.RemoveAll(x => x.Id == Id);
        }

        public static void AtualizarNaLista (this List<EquipamentosAudioVisuais> ListaDeEquipamentos, int Id,
        string novoNome, string novaMarca, string novaSerie, string novoProfessor, string novaSala, string novaData)
        {
            foreach (EquipamentosAudioVisuais item in ListaDeEquipamentos.ToList())
            {
                if (Id == item.Id)
                {
                    item.Nome = novoNome;
                    item.Marca = novaMarca;
                    item.Serie = novaSerie;
                    item.Escola.Professor.Nome = novoProfessor;
                    item.Escola.Sala.Nome = novaSala;

                    if(novaData != item.Horarios.DataAgendada)
                    {
                        item.Horarios.DataHoje = DateTime.Now;
                    }
                    item.Horarios.DataAgendada = novaData;
                }
            }
        }
    }
}
