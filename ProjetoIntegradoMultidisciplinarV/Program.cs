using ProjetoIntegradoMultidisciplinarV.Classes;
using ProjetoIntegradoMultidisciplinarV.Funções;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradoMultidisciplinarV
{
    class Program
    {

        static void Main(string[] args)
        {

            //--------------------------------------------------------------
            // INICIADOR DA LISTA DE EQUIPAMENTO E GERENCIADOR DE CABEÇALHO
            //______________________________________________________________

            List<EquipamentosAudioVisuais> ListaDeEquipamentos = new List<EquipamentosAudioVisuais>();
            GerenciadorCabecalho gerenciadorCabecalho = new GerenciadorCabecalho();
            
            //-------------------------------------------------------------------------------------------                                      
            // CRIAR, LER, E SOBRESCREVER UM ARQUIVO DE TEXTO COM O CONTEÚDO DA LISTA (EXISTENTE OU NÃO)
            //___________________________________________________________________________________________

            string enderecoArquivo = "ListaDeEquipamentos.txt";
            var leInformacao = new string[0];
           
            if (File.Exists(enderecoArquivo))
            {
                 leInformacao = File.ReadAllLines(enderecoArquivo);

                  File.Delete(enderecoArquivo);

                foreach(var item in leInformacao) {

                    var guardaInfos   = item.Split(',');

                    var nome          = guardaInfos [0];
                    var marca         = guardaInfos [1];
                    var serie         = guardaInfos [2];
                    var nomeProfessor = guardaInfos [3];
                    var nomeSala      = guardaInfos [4];
                    var dataAgendada  = guardaInfos [5];

                    ListaDeEquipamentos.AdicionaNaLista(nome, marca, serie, nomeProfessor, nomeSala, dataAgendada);
                }
            }
              
            StreamWriter EscreveArquivo;
            if (ListaDeEquipamentos == null)
            {
                    FileStream criaArquivo = File.Create(enderecoArquivo);
                    criaArquivo.Close();
                
            }
            EscreveArquivo = File.AppendText(enderecoArquivo);

            int x = -3;
            
            while (x < 0)
                {


                    if (x == -3)
                    {
                        gerenciadorCabecalho.EscreveCabecalho();
                    }

                    if (x == -2)
                    {
                        gerenciadorCabecalho.EscreveCabecalhoNovo();
                        
                    }

                    if (x == -1)
                    {
                        gerenciadorCabecalho.EscreveCabecalhoDeFuncaoInvalida();
                        
                    }

                try
                {
                    int escolherFuncao = int.Parse(Console.ReadLine());


                    //---------------------------------
                    // ADICIONA UM EQUIPAMENTO A LISTA
                    //_________________________________


                    if (escolherFuncao == 1)
                    {
                        Console.Clear();
                        Console.Write(

                            "\n-----------------------------------------------------------------------------------------------------\n" +
                            "Por favor, digite o nome do produto que deseja inserir na lista. ex: Televisão" +
                            "\n-----------------------------------------------------------------------------------------------------\n" +
                            "Nome do Equipamento: "  
                         );
                            string nome = Console.ReadLine();
                                                 
                        Console.Write(
                            "\n-----------------------------------------------------------------------------------------------------\n" +
                            "Por favor, insira a marca do equipamento. ex: Samsung" +
                            "\n-----------------------------------------------------------------------------------------------------\n" +
                            "Marca do Equipamento: "
                         );

                        string marca = Console.ReadLine();

                        Console.Write(
                            "\n-----------------------------------------------------------------------------------------------------\n" +
                            "Por favor, insira o numero de série do produto. ex: 09712938475123" +
                            "\n-----------------------------------------------------------------------------------------------------\n" +
                            "Numero de Serie: "
                        );

                        string serie = Console.ReadLine();

                        Console.Write(
                            "\n-----------------------------------------------------------------------------------------------------\n" +
                            "Por favor, insira o nome do funcionario a qual o equipamento sera reservado. ex: Prof.José/Coord.Jessica " +
                            "\nOBS: Não Utilizar virgula." +
                            "\n-----------------------------------------------------------------------------------------------------\n" +
                            "Professor/Coordenador(a): "
                        );

                        string nomeProfessor = Console.ReadLine();

                        Console.Write(
                            "\n-----------------------------------------------------------------------------------------------------\n" +
                            "Por favor, insira para qual sala/auditorio o equipamento será reservado. ex: Sala(s): A1/A2/A3" +
                            "\nOBS: Não Utilizar virgula." +
                            "\n-----------------------------------------------------------------------------------------------------\n" +
                            "Sala(s): "
                        );

                        string nomeSala = Console.ReadLine();

                        Console.Write(
                           "\n-----------------------------------------------------------------------------------------------------\n" +
                           "Por favor, insira para qual data o equipamento será reservado ex: 01/04/2025" +
                           "\nOBS: Não Utilizar virgula." +
                           "\n-----------------------------------------------------------------------------------------------------\n" +
                           "Data para Agendamento: "
                       );

                        string dataAgendada = Console.ReadLine();

                        Console.Clear();

                        ListaDeEquipamentos.AdicionaNaLista(nome, marca, serie, nomeProfessor, nomeSala, dataAgendada);





                        Console.WriteLine(
                           "********************************************************************" +
                            "\n          < EQUIPAMENTO ADICIONADO A LISTA COM SUCESSO! >              \n" +
                            "--------------------------------------------------------------------" + "\n" +
                            "                     < LISTA DE EQUIPAMENTOS >" + "\n" +
                            "--------------------------------------------------------------------" + "\n"
                        );

                        ListaDeEquipamentos.VerLista();

                        Console.WriteLine(
                            "              < PRESSIONE ENTER PARA VOLTAR AO MENU >      \n" +
                        "\n********************************************************************");
                        Console.ReadLine();

                        Console.Clear();

                        x = -2;
                    }

                    //---------------------------------
                    // RETORNA A LISTA DE EQUIPAMENTOS
                    //_________________________________

                    if (escolherFuncao == 2)
                    {
                        Console.Clear();

                        Console.Write(
                            "--------------------------------------------------------------------" + "\n" +
                             "                   < LISTA DE EQUIPAMENTOS >" + "\n" +
                            "--------------------------------------------------------------------" + "\n" + "\n"
                        );

                        ListaDeEquipamentos.VerLista();

                        Console.WriteLine("              < PRESSIONE ENTER PARA VOLTAR AO MENU >      \n" +
                                          "\n********************************************************************");
                        Console.ReadLine();

                        Console.Clear();
                        x = -2;
                    }

                    //---------------------------------
                    // REMOVE UM EQUIPAMENTO DA LISTA
                    //_________________________________

                    if (escolherFuncao == 3)
                    {
                        Console.Clear();

                        Console.Write(
                            "----------------------------------------------------------------------------------" + "\n" +
                             "                           < LISTA DE EQUIPAMENTOS >" + "\n" +
                            "----------------------------------------------------------------------------------" + "\n"
                        );

                        ListaDeEquipamentos.VerLista();

                        Console.Write(
                            "\n--------------------------------------------------------------------------------\n" +
                                     "Por favor, digite o id do produto que deseja retirar da lista,\n" +
                                     "caso não saiba o Id, consulte a lista de equipamentos.ex: 10" +
                            "\n--------------------------------------------------------------------------------\n" +
                            "ID do Equipamento: "
                        );

                        int Id = int.Parse(Console.ReadLine());

                        ListaDeEquipamentos.RemoverDaLista(Id);

                        Console.Clear();

                        Console.WriteLine(
                           "********************************************************************" +
                            "\n          < EQUIPAMENTO RETIRADO DA LISTA COM SUCESSO! >               \n" +
                            "--------------------------------------------------------------------" + "\n" +
                            "                    < LISTA DE EQUIPAMENTOS >" + "\n" +
                            "--------------------------------------------------------------------" + "\n"
                         );

                        ListaDeEquipamentos.VerLista();

                        Console.WriteLine("              < PRESSIONE ENTER PARA VOLTAR AO MENU >      \n" +
                                          "\n********************************************************************");
                        Console.ReadLine();

                        Console.Clear();

                        x = -2;
                    }

                    //---------------------------------
                    // ATUALIZA UM EQUIPAMENTO NA LISTA
                    //_________________________________

                    if (escolherFuncao == 4)
                    {
                        Console.Clear();
                        Console.Write(
                            "--------------------------------------------------------------------" + "\n" +
                             "                       < LISTA DE EQUIPAMENTOS >" + "\n" +
                            "--------------------------------------------------------------------" + "\n"
                        );
                        ListaDeEquipamentos.VerLista();

                        Console.Write(
                            "\n--------------------------------------------------------------------\n" +
                                     "Por favor, digite o id do produto que deseja atualizar na lista,\n" +
                                     "caso não saiba o Id, consulte a lista de equipamentos. ex: 10" +
                            "\n--------------------------------------------------------------------\n" +
                            "ID do Equipamento: "
                        );

                        int Id = int.Parse(Console.ReadLine());


                        Console.Write(
                            "\n----------------------------------------------------------------------------------------\n" +
                            "Por favor, insira o novo nome do produto a ser atualizado. ex: Datashow" +
                            "\n----------------------------------------------------------------------------------------\n" +
                            "Novo Nome: "
                        );

                        string novoNome = Console.ReadLine();

                        Console.Write(
                            "\n----------------------------------------------------------------------------------------\n" +
                            "Por favor, insira a nova marca do produto a ser atualizada. ex: Xiaomi" +
                            "\n----------------------------------------------------------------------------------------\n" +
                            "Nova Marca: "
                        );

                        string novaMarca = Console.ReadLine();

                        Console.Write(
                            "\n----------------------------------------------------------------------------------------\n" +
                            "Por favor, insira o novo numero de serie do equipamento.  ex: A108310840802390" +
                            "\n----------------------------------------------------------------------------------------\n" +
                            "Novo Numero de Serie: "
                        );

                        string novaSerie = Console.ReadLine();


                        Console.Write(
                            "\n----------------------------------------------------------------------------------------\n" +
                            "Por favor, insira o novo nome do(s) funcionario(os) que deseja atualizar. ex: Paula/Roberto" +
                            "\n----------------------------------------------------------------------------------------\n" +
                            "Novo Nome: "
                        );

                        string novoProfessor = Console.ReadLine();

                        Console.Write(
                            "\n----------------------------------------------------------------------------------------\n" +
                            "Por favor, insira para qual nova sala o equipamento deve ser reservado.  ex: A4/A5" +
                            "\n----------------------------------------------------------------------------------------\n" +
                            "Nova Sala: "
                        );

                        string novaSala = Console.ReadLine();

                        Console.Write(
                               "\n----------------------------------------------------------------------------------------\n" +
                               "Por favor, insira para qual nova data o equipamento será reservado. ex: 01/04/2025 " +
                               "\n----------------------------------------------------------------------------------------\n" +
                               "Data para Agendamento: "
                           );

                        string novaData = Console.ReadLine();


                        Console.Clear();

                        ListaDeEquipamentos.AtualizarNaLista(Id, novoNome, novaMarca, novaSerie, novoProfessor, novaSala, novaData);

                        Console.WriteLine(
                           "********************************************************************" +
                            "\n         < EQUIPAMENTO ATUALIZADO NA LISTA COM SUCESSO! >              \n" +
                            "--------------------------------------------------------------------" + "\n" +
                            "                    < LISTA DE EQUIPAMENTOS >" + "\n" +
                            "--------------------------------------------------------------------" + "\n"
                         );


                        ListaDeEquipamentos.VerLista();

                        Console.WriteLine("              < PRESSIONE ENTER PARA VOLTAR AO MENU >      \n" +
                                          "\n********************************************************************");
                        Console.ReadLine();
                        Console.Clear();

                        x = -2;
                    }

                    //--------------------------------------
                    // CHAMA O CABEÇALHO DE FUNÇÃO INVALIDA
                    //______________________________________

                    if (escolherFuncao > 5)
                    {
                        Console.Clear();
                        x = -1;

                    }

                    //---------------------------------
                    // SAI DO PROGRAMA
                    //_________________________________

                    if (escolherFuncao == 5)
                    {
                        x = 0;
                    }

                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                    Console.WriteLine("**************************************************************************************************************" +
                                        "\n  < ENTRADA DE DADOS DESCONHECIDA, POR FAVOR INSIRA A INFORMAÇÃO QUE SE PEDE DESCRITA NO ENUNCIADO >" +
                                      "\n**************************************************************************************************************\n" +
                                        "                               < PRESSIONE ENTER PARA VOLTAR AO MENU >      \n" +
                                        "--------------------------------------------------------------------------------------------------------------");
                    Console.ReadLine();
                        Console.Clear();

                        x = -3;
                    }
            }
            foreach (EquipamentosAudioVisuais item in ListaDeEquipamentos)
            {
                EscreveArquivo.WriteLine(  item.Nome + ',' + item.Marca + ',' + item.Serie + ',' + 
                                             item.Escola.Professor.Nome + ',' + item.Escola.Sala.Nome + ',' +
                                             item.Horarios.DataAgendada + ',' + item.Horarios.DataHoje + ',' + item.Id);
            }
            EscreveArquivo.Close();
        }
    }
}
