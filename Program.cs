
string op = "0";
while(op != "3"){
  Console.WriteLine("Menu");
  Console.WriteLine("1- Funções sem vetor");
  Console.WriteLine("2- Função com Vetor");
  Console.WriteLine("3- Sair");
  op= Console.ReadLine();

  if(op == "1"){
    int numI;
    int numF;
    Console.WriteLine("Numero Inicial");
    numI = Console.ReadLine();
    Console.WriteLine("Numero Final");
    numF = Console.ReadLine();
    Console.WriteLine("Menu 2");
    Console.WriteLine("1-Crescente");
    Console.WriteLine("2-Descrecente");
    Console.WriteLine("3-Impares");
    Console.WriteLine("4- Somatorio");
    Console.WriteLine("5-Voltar");
    string op2 =  Console.ReadLine();

    if(op2 == "1"){
      crescente(numI, numF)
    }else if (op === "2"){
      
    } 
}
}