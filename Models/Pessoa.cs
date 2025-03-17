namespace Formação_.NET_Developer.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        /*
         Método ação ou Funçao que a pessoa pode realizar
         O abrir e fechar () indica que é um método ou uma função
         E pelas cores também pode se indicar o que se representa
         Os valores de dentro das () chama-se parameotro ou argumentos
         */
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}