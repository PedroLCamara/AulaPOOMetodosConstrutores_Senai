namespace AulaPOOMetodosConstrutores.classes
{
    public class assinante
    {
        private string nome;
        private string endereco;
        private string email;
        public assinante(){

        }
        public assinante(string Nome){
            nome = Nome;
        }
        public assinante(string Nome, string Endereco, string Email){
            nome = Nome;
            endereco = Endereco;
            email = Email;
        }
    }
}