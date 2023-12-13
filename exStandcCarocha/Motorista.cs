using System;
using System.Collections.Generic;
using System.Text;

namespace exStandcCarocha
{
    class Motorista
    {
        public string Nome { get; set; }

        public Motorista(string nome)
        {
            Nome = nome;
        } 

        public void Conduzir(Carros carro)
        {
            Console.WriteLine($"O motorista {Nome} está a conduzir o carro" +
                $"{carro.Marca}, {carro.Modelo}!");
        }

        public void Acelerar(Carros carro, int valor)
        {
            carro.Acelerar(valor);
        }

        public void Travar(Carros carro, int valor)
        {
            carro.Travar(valor);
        }

        public void LigarMotor(Carros carro)
        {
            carro.LigarMotor();
        }

        public void DesligarMotor(Carros carro)
        {
            carro.DesligarMotor();
        }

    }
}
