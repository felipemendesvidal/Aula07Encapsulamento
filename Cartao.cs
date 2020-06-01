namespace quintaPOO
{
    public class Cartao
    {
        public string titular {get; set;}
        public string numero {get; set;}
        public string bandeira {get; set;}
        private string token{get; set;}
        protected int cvv{get; set;}
         
        //metodo retorna mesnagm aprovado
        public string AprovarCompra(){
            return "compra aprovada";
        }

        /// <summary>
        ///  verifica se é true ou falso o valor inserido
        /// </summary>
        /// <returns> true or false</returns>
        private bool ValidarToken(){
            if(token != null && token != ""){
                return true;
            }
            return false;
        }
        protected bool ValidarCompra(){
            return true;
        }
    }
}