using System;

namespace exStandcCarocha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stand Carocha");
            Carros meuCarro = new Carros("Citroen", "C4", 2010, "Cinza");
            Console.WriteLine("\n\nInformações inicias: ");
            meuCarro.ToString();

            Motorista motorista = new Motorista("Ana Paula");
            motorista.Conduzir(meuCarro);

            meuCarro.LigarMotor();
            Console.WriteLine("\n\nInformações após ligar motor: ");
            meuCarro.ToString();

            motorista.Acelerar(meuCarro, 60);
            Console.WriteLine("\n\nInformações após o motororista: " +
                $"{motorista.Nome} acelerar:\n{meuCarro.ToString()}");
            
        }
    }
}
