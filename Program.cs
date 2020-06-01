using System;

namespace quintaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao cartao = new Cartao();
            Mastercard master = new Mastercard();
            master.parcelas = 6;
            master.titular = "teste";
            master.ComprarComDescontoMastercard(45f);

           Console.WriteLine(master.parcelas);

            


        }
    }
}
