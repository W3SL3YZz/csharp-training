using System;
/* Faça o algoritmo (diagrama de blocos e português estruturado) para calcular o valor monetário do desconto (D), sendo que o preço do produto (PR) é fornecido pelo usuário e o desconto é de 5%. Apresentar o valor do desconto.*/
class Program {
  public static void Main (string[] args) {
  double D, PR, PF;
  Console.Write("Digite o valor do preço do Produto: R$ ");
  PR = Double.Parse(Console.ReadLine());
  D = PR*0.05;  
  PF = PR-D;
  Console.WriteLine("O valor de desconsto será de: R$ {0}", D); 
  Console.WriteLine();
  Console.Write ("O valor total do produto com desconto é de: R$ {0}", PF);
  }
}
