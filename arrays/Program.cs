﻿
string [] carro = new string[3];


for (int i = 0; i < carro.Length; i++)
{
     Console.WriteLine($"Digite o nome do carro a ser cadastrado:");
      carro[i] = Console.ReadLine()!;

}

Console.WriteLine($"O carro cadastrado é {carro[0]}, {carro[1]}, {carro[2]} ");