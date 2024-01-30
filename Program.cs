using exercicio3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//FEITO POR IGOR DOS REIS ALVES

namespace exercicio3
{
    internal class Program
    {

        static Veículo[] veiculos = new Veículo[10];
        static int index = 0;
        static int inp = 0;

        static void Main(string[] args)
        {

            void Tela()
            {
                Console.WriteLine("Bem-Vindo(a)!\n" +
                "\nInforme a opção desejada" +
                "\n[1] - Incluir Veículo" +
                "\n[2] - Mostrar Lista de Veículos" +
                "\n[3] - Salvar Veículos no Arquivo" +
                "\n[4] - Sair\n");
            }
            
                
            while(inp < 4) 
            {
                Tela();
                inp = int.Parse(Console.ReadLine());
                Console.Clear();
                if (inp == 1) IncluirVeículo();
                if (inp == 2) MostrarLista();
                if (inp == 3) SalvarVeiculos();
                
            }
            
            
        }
        static void IncluirVeículo()
            {
                int inp2;
                Console.WriteLine("\n[1] - Carro" + "\n[2] - Moto\n");
                inp2 = int.Parse(Console.ReadLine()) ;
                if (inp2 == 1) { IncluirCarro(); } 
                    else if (inp2 == 2) 
                        { IncluirMoto(); }
                
            }

            static void IncluirCarro()
            {
                    try
                    {
                        Console.Write("Digite o modelo: ");
                        string modelo = Console.ReadLine();
                        Console.Write("Digite o ano: ");
                        string ano = Console.ReadLine();
                        Console.Write("Digite a distancia: ");
                        int distancia = int.Parse(Console.ReadLine());
                        Console.Write("Digite o tempo: ");
                        int tempo = int.Parse(Console.ReadLine());
                        Console.Write("Digite a potencia do carro: ");
                        int potencia = int.Parse(Console.ReadLine());
                        Carro carro = new Carro(tempo, distancia, modelo, ano, potencia);
                        veiculos[index] = carro;
                        index++;
                        Console.Clear();
                    }
                    catch (FormatException e) { Console.WriteLine("Digite apenas numeros na Distancia e tempo\n " + e.Message); inp = 4; }
                    
                    
            }

            static void IncluirMoto() 
            {
                    try 
                    { 
                        Console.Write("Digite o modelo: ");
                        string modelo = Console.ReadLine();
                        Console.Write("Digite o ano: ");
                        string ano = Console.ReadLine();
                        Console.Write("Digite a Distancia em Km: ");
                        int distancia = int.Parse(Console.ReadLine());
                        Console.Write("Digite o Tempo em Horas: ");
                        int tempo = int.Parse(Console.ReadLine());
                        Console.Write("A moto possui sistema anti travamento: ");
                        string anti = Console.ReadLine();
                        Moto moto = new Moto(modelo, ano, distancia, tempo, anti);
                        veiculos[index] = moto;
                        index++;
                        Console.Clear();
                    }catch(FormatException e) { Console.WriteLine("Digite apenas numeros na Distancia e tempo\n " + e.Message); }
               
                }

                static void MostrarLista() 
                {
                    if (veiculos[0] == null) { Console.WriteLine("Nao ha veiculos inclusos"); }
                    else
                    {
                        for (int i = 0; i < index; i++) 
                        {
                            if (veiculos[i].GetType() == typeof(Carro)) 
                            { 
                                Carro carro1 = (Carro)veiculos[i];
                                Console.WriteLine(carro1.Obtertipo());
                            } else if (veiculos[i].GetType() == typeof(Moto)) 
                            { 
                                Moto moto1 = (Moto)veiculos[i];
                                Console.WriteLine(moto1.Obtertipo());
                            }    
                        }
                    }
                    inp = 4;
                }

                
                    static void SalvarVeiculos() 
                    {
                    if (veiculos[0] == null) { Console.WriteLine("Nao ha veiculos para serem salvos"); inp = 4; }
                    else {
                        Console.WriteLine("Digite o caminho para salvar");                      
                        string caminho = Console.ReadLine();
                        Console.WriteLine("Digite o nome do arquivo");
                        string nomearquivo = Console.ReadLine();
                        nomearquivo = Path.ChangeExtension(nomearquivo, "txt");
                        string nomecompleto = Path.Combine(caminho, nomearquivo);
                        try
                        {
                            using (StreamWriter writer = new StreamWriter(nomecompleto, true))
                            {
                                for(int i = 0; i < index;  i++) 
                                {  
                                    if (veiculos[i].GetType() == typeof(Carro)) 
                                    { 
                                        Carro carro1 = (Carro)veiculos[i];
                                        writer.WriteLine(carro1.Obtertipo() + "\n");
                                        } if (veiculos[i].GetType() == typeof(Moto)) 
                                        { 
                                            Moto moto1 = (Moto)veiculos[i];
                                            writer.WriteLine(moto1.Obtertipo() + "\n");
                                        }
                                }
                            }
                                    
                            
                        }
                        catch (Exception ex) { Console.WriteLine("Caminho incorreto\n " + ex.Message); }
                    }
                    inp = 4;
                    }

    }
}

