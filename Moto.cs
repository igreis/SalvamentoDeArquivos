using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exercicio3
{
    internal class Moto : Veículo
    {
        private string temSistemaAntiTravamento;

        public string TemSistemaAntiTravamento { get 
            { return temSistemaAntiTravamento; } set { temSistemaAntiTravamento = value; } }

        public Moto(string _modelo, string _ano, int _distancia, int _tempo, string _anti) : base(_modelo, _ano, _distancia, _tempo) 
        {
            TemSistemaAntiTravamento = _anti;
        }

        public override int CalcularVelocidadeMedia()
        {
            try
            {
                return Distancia / Tempo;
            }
            catch (DivideByZeroException e) { Console.WriteLine("Nao é possivel dividir por 0" + e.Message); }
            return 0;

        }

        public override string Obtertipo()
        {
            return $"Moto\n Modelo: {Modelo}\n Ano: {Ano}\n Velocidade Media: {CalcularVelocidadeMedia()}\n Tem Sistema AntiTravamento: {TemSistemaAntiTravamento}";
        }
        

    }
}

