using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    internal class Veículo
    {
        private string modelo;
        private string ano;
        private int distancia;
        private int tempo;

        public string Modelo { get { return modelo; } set {  modelo = value; } }
        public string Ano { get { return ano; } set { ano = value; } }
        public int Distancia { get => distancia; set { distancia = value; } }
        public int Tempo { get => tempo; set { tempo = value; } }

        public Veículo(string _modelo, string _ano, int _distancia, int _tempo )
        {
            Modelo = _modelo;
            Ano = _ano; 
            Distancia = _distancia; 
            Tempo = _tempo;
        }

        public virtual int CalcularVelocidadeMedia() 
        {
            return 60;
        }

        

    public virtual string Obtertipo() 
        {
            return "Veiculo";
        }

    }
}
