using System;

namespace FiapHello_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            FiapHello_Word.Models.HelloModel model = new Models.HelloModel();
            Console.WriteLine(model.Mensagem);
            Console.Read();
        }
    }
}
