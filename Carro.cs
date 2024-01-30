using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exercicio3
{
    internal class Carro : Veículo
    {
        private int potencia;
 
        public int Potencia { get => potencia; set => potencia = value; }

        public Carro(int _tempo, int _distancia, string _modelo, string _ano, int _potencia) : base(_modelo, _ano, _distancia, _tempo) 
        {
            Potencia = _potencia;  
        }

        

        public override int CalcularVelocidadeMedia()
        {
            try 
            {
                return Distancia / Tempo;
            } 
            catch(DivideByZeroException e) { Console.WriteLine("Nao é possivel dividir por 0\n " + e.Message); }
            return 0;
            
        }

        public override string Obtertipo()
        {
            return $"Carro\n Modelo: {Modelo}\n Ano: {Ano}\n Velocidade Media: {CalcularVelocidadeMedia()}\n Potencia: {Potencia}\n " ;
        }
        

    }
}
