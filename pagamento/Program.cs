namespace pagamento;

public class Program
{
    static void Main(string[] args)
    {

        //Fazer um programa para ler o nome de um funcionario, o valor que ele recebe por hopra, e a quantidade de
        //horas trabalhadas por ele.
        //Ao final, mostrar o valor do pagamento do funcionario com uma mensagem explicativa.

        
        string nome = "";
        double VHora, THora, pagamento;

        Console.WriteLine("Por favor, entre com o nome do funcionario(a).");
        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Agora por favor, entre com o valor por hora deste funcionario:");
        Console.Write("Valor das Horas: ");
        VHora = double.Parse(Console.ReadLine().ToLower());

        Console.WriteLine();

        Console.WriteLine("Agora, por favor, entre com o total das horas trabalhadas por este funcionario");
        Console.Write("Total das horas ");
        THora = double.Parse(Console.ReadLine());

        Console.WriteLine();

        pagamento = THora * VHora;

        Console.WriteLine("O pagamento para " + nome + " deve ser de " + pagamento.ToString("C"));


    }
}