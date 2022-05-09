using System;

namespace ProjetoIntegradoMultidisciplinarV.Funções
{
    public class GerenciadorCabecalho
    {
        public void EscreveCabecalho()
        {

            
            Console.Write(

                    "********************************************************************\n" +
                    "\nDigite o numero da função:\n" +

                    "\n********************************************************************\n" +
                    " -> Adicionar item na lista     = 1\n" +

                    " -> Ver a lista de equipamentos = 2\n" +

                    " -> Remover item da lista       = 3\n" +

                    " -> Atualizar item na lista     = 4\n" +

                    " -> Sair do programa            = 5"   +
                    "\n********************************************************************" +
                    "\n Função : "

                    );
        }

        public void EscreveCabecalhoNovo()
        {
            Console.Write(

                  "********************************************************************\n" +
                  "\nCaso deseje utilizar uma função novamente, digite o numero da mesma:\n" +

                "\n********************************************************************\n" +
                    " -> Adicionar item na lista     = 1\n" +

                    " -> Ver a lista de equipamentos = 2\n" +

                    " -> Remover item da lista       = 3\n" +

                    " -> Atualizar item na lista     = 4\n" +

                    " -> Sair do programa            = 5" +
                    "\n********************************************************************" +
                    "\n Função : "


                  );
        }

        public void EscreveCabecalhoDeFuncaoInvalida()
        {
            Console.Write(

                  "****************************************************************************\n" +
                  "\nOps! função não encontrada, por favor digite o numero da função novamente:\n" +

                  "\n****************************************************************************\n" +
                    " -> Adicionar item na lista     = 1\n" +

                    " -> Ver a lista de equipamentos = 2\n" +

                    " -> Remover item da lista       = 3\n" +

                    " -> Atualizar item na lista     = 4\n" +

                    " -> Sair do programa            = 5" +
                    "\n****************************************************************************" +
                    "\n Função : "


                  );
        }
    }
}
