for (int i = 1; i <= 40; i++)
     
        {
            // Verifica se o número atual é múltiplo de 4.
            if (i % 4 == 0)
            {
                Console.Write("pim");
            }
            else
            {
                Console.Write(i);
            }
 
            // Adiciona um espaço após cada número ou palavra, exceto no final da linha.
            if (i % 10 != 0)
            {
                Console.Write(" ");
            }
            else
            {
                // Quebra a linha após 10 números/palavras.
                Console.WriteLine();
            }
        }
