
void crescente(int nI, int nF)
{
  if (nI <= nF)
  {
    Console.WriteLine(nI);
    crescente(nI + 1, nF);
  }
}


string op = "0";
while (op != "3")
{
  Console.WriteLine("Menu Principal");
  Console.WriteLine("1- Função sem vetor");
  Console.WriteLine("2- Função com vetor ");
  Console.WriteLine("3 - Sair");
  Console.Write("Opção desejada ");
  op = Console.ReadLine();

  if (op == "1")
  {
    int numI, numF;
    Console.Write("Numero inicial: ");
    numI = Convert.ToInt32(Console.ReadLine());
    Console.Write("Numero final");
    numF = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Menu Secundário");
    Console.WriteLine("1- Inteiros crescente");
    Console.WriteLine("2- Inteiros decrescente");
    Console.WriteLine("3- Inteiros Impares");
    Console.WriteLine("4- Somatorios");
    Console.WriteLine("5- Voltar");
    Console.Write("Opção desejada ");
    string op2 = Console.ReadLine();

    if (op2 == "1")
    {
      crescente(numI, numF);
    }
  }
}



