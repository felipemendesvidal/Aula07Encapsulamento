using System;

namespace quintaPOO
{
    public class Mastercard : Cartao
    {
        public int parcelas{ get; set;}
        public void ComprarComDescontoMastercard( float desconto){
            cvv = 1234;
            Console.WriteLine($"aplicado desconto de {desconto}, no total de {parcelas} parcelas");
        }
        
    }
}