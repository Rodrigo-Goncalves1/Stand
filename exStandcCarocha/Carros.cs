using System;
using System.Collections.Generic;
using System.Text;

namespace exStandcCarocha
{
    class Carros
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public short Ano { get; set; }
        public string Cor { get;  set }

        private bool _motorLigado;

        public int Velocidade { get; private set; }

        public Carros(string marca, string modelo, short ano, string cor)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Cor = cor;
            _motorLigado = false;
            Velocidade =0;
        }

        public void LigarMotor()
        {
            if (!_motorLigado)
            {
                _motorLigado = true;
                Console.WriteLine("Motor ligado!");
            }
            else
                Console.WriteLine("O Motor já se encontra ligado!");
        }

        public void DesligarMotor()
        {
            if (!_motorLigado)
            {
                _motorLigado = false;
                Console.WriteLine("Motor desligado!");
            }
            else
                Console.WriteLine("O Motor já se encontra desligado!");
        }

        public void Acelerar(int valor)
        {
            if (_motorLigado) Velocidade += valor;
        }

        public void Travar(int valor)
        {
            if (_motorLigado)
            {
                Velocidade -= valor;
                if (Velocidade <= 0) DesligarMotor();
            }
        }

        public override string ToString()
        {
            return $"Dados do automóvel:" +
                $"\nMarca: {Marca}" +
                $"\n:Modelo {Modelo}" +
                $"\nAno: {Ano}" +
                $"\nCor: {Cor}" +
                $"\nMotor: {(_motorLigado ? "Ligado": "Desligado")}" +
                $"\nVelocidade: {Velocidade}";
        }
    }
}
