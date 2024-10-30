
namespace fixingPOO {
    class Program{

        static void Main(string[] args ){
            Produto A;

            A = new Produto(); 

            Console.WriteLine("Cadastro de Produto");
            Console.WriteLine("Qual o nome do produto?");
            A.Name = Console.ReadLine();
            Console.WriteLine("Qual o valor dele?");
            A.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Vamos adicionar quanto em estoque?");
            A.Amount = int.Parse(Console.ReadLine());

            Console.WriteLine(A);
            
            Console.WriteLine("Deseja fazer alguma alteração no Produto?");
            char answer = char.Parse(Console.ReadLine());

            while (answer == 's') {
                Console.WriteLine("Vamos:\n1 - Adicionar mais produtos em estoque\n2 - Remover produtos do estoque.");
                byte answerL = byte.Parse(Console.ReadLine()); 
                switch (answerL) {
                    case 1:
                        Console.WriteLine("Vamos adicionar quantos produtos?");
                        int add = int.Parse(Console.ReadLine());
                        A.addProdut(add);
                        break;
                    case 2:
                        Console.WriteLine("Vamos remover quantos produtos?");
                        int remove = int.Parse(Console.ReadLine());
                        A.removeProdut(remove);
                        break;
                }

                Console.WriteLine("Deseja fazer alguma alteração no Produto?");
                answer = char.Parse(Console.ReadLine());
            }


            Console.WriteLine(A);

        }
       
    }
}
