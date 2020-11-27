using System;

namespace ProjetoPassagens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("- Sistema de Check-In Tolentino Airlines -");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Para começar, insira suas credenciais");
            // Console.Write("Login:");
            // string login = Console.ReadLine();
            // int senha = int.Parse(Console.ReadLine());

            int senha = 0;

            do{
                Console.Write("Login: ");
                string login = Console.ReadLine();
                Console.Write("Senha: ");
                senha = int.Parse(Console.ReadLine());
            }while(senha != 1945);

            Console.WriteLine("Login concluido com sucesso!");
            System.Threading.Thread.Sleep(1200);
            Console.Clear();

            // if(senha != 1945){
            //     Console.WriteLine("Login ou senha incorretos, tente novamente");
            //     int senha = int.Parse(Console.ReadLine());
            // }else{
            //     Console.WriteLine("Login concluido com sucesso!");
            //     System.Threading.Thread.Sleep(500);
            //     Console.Clear();
            // }

            // Arrays com os dados do passageiros
            string[] nomes = new string [5];
            string[] origem = new string[5];
            string[] destino = new string[5]; 
            int[] data = new int [5];

            string decisao = "a";

            Console.WriteLine("O que voce deseja fazer?\n [1] - Cadastrar passagem\n [2] - Listagem de passageiros cadastrados\n [0] - Sair");
            int escolha = int.Parse(Console.ReadLine());

            switch(escolha){
                case 1:
                Console.WriteLine("Otimo, voce sera redirecionado para o campo de cadastro de passagens");
                System.Threading.Thread.Sleep(1900);
                Console.Clear();
                //Inicio do Cadastro de passagens
                    do{
                    Console.WriteLine("Agora insira os dados do Passageiro.");
                    Console.Write("Nome: ");
                    nomes[0] = Console.ReadLine();
                    Console.Write("Origem do Voo: ");
                    origem[0] = Console.ReadLine();
                    Console.Write("Desino: ");
                    destino[0] = Console.ReadLine();
                    Console.Write("Data do Voo: ");
                    data[0] = int.Parse(Console.ReadLine());

                    Console.WriteLine("Voce deseja cadastrar mais algum passageiro?");
                    decisao = Console.ReadLine();
                    }while(decisao == "sim");
                break;

                default:
                break;    
            }

            System.Threading.Thread.Sleep(1900);
            Console.Clear();

            Console.WriteLine("Ok, os passageiros ja foram cadastrados.");
            Console.WriteLine("Oque voce deseja fazer agora? Listar passageiros cadastrados - 1   Sair - 2   ");
            int esco = int.Parse(Console.ReadLine());
                switch(esco){
                    case 2:
                    Console.WriteLine("Tolentino AirLines agradece sua preferncia.");
                    break;

                    case 1:
                    Console.WriteLine($"Passageiron nº 1: \nNome:{ nomes[0] } \nOrigem do Voo: { origem[0] } \nDestino: { destino[0] } \nData: { data[0] }");
                    System.Threading.Thread.Sleep(3600);
                    Console.Clear();
                    Console.WriteLine("O que deseja fazer agora? 1 - Sair   2 - Entrar em contato com o suporte");
                    break;

                    default:
                    break;
                }
        }
    }
}
