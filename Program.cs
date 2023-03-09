
void crescente(int nI, int nF)
{
  if (nI <= nF)
  {
    Console.WriteLine(nI);
    crescente(nI + 1, nF);
  }

}
void decrescente(int nI, int nF)
{
  if (nF >= nI)
  {
    Console.WriteLine(nF);
    decrescente(nI, nF - 1);

  }

}

void impares(int nI, int nF)
{
  if (nI <= nF)
  {
    if (nI % 2 != 0)
    {
      Console.WriteLine("Caio no debug" + nI);
      impares(nI + 1, nF);
    }
  }
}

int somatorio(int nI, int nF)
{
  if (nI < nF)
  {
    Console.WriteLine(nI);
    return somatorio(nI + 1, nF) + nI;
  }
  else
  {
    return nI;
  }
}

int vetSomatorio(int[] vet, int nI, int nF)
{
  if (nI < nF)
  {
    return vetSomatorio(vet, nI + 1, nF) + vet[nI];
  }
  else
    return vet[nI];
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

  if (op == "2")
  {
    int[] vet = new int[10];
    int i = 0;
    int num = 1;

    while (num != 0)
    {
      i += 1;
      Console.WriteLine("Digite um numero: ");
      num = Convert.ToInt32(Console.ReadLine());
      vet[i] = num;
    }
    int s;
    s = vetSomatorio(vet, 1, i);
    Console.WriteLine(s);
  }






  if (op == "1")
  {
    int numI, numF;
    Console.Write("Numero inicial: ");
    numI = Convert.ToInt32(Console.ReadLine());
    Console.Write("Numero final ");
    numF = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Menu Secundário");
    Console.WriteLine("1- Inteiros crescente");
    Console.WriteLine("2- Inteiros decrescente");
    Console.WriteLine("3- Inteiros Impares");
    Console.WriteLine("4- Somatorios");
    Console.WriteLine("5- Voltar");
    Console.Write("Opção desejada ");
    int option2 = Convert.ToInt32(Console.ReadLine());

    if (option2 == 1)
    {
      crescente(numI, numF);
    }

    if (option2 == 2)
    {
      decrescente(numI, numF);
    }

    if (option2 == 3)
    {
      impares(numI, numF);
    }
    if (option2 == 4)
    {
      somatorio(numI, numF);
    }
  }
}



