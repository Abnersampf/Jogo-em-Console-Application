string[,] fundo = new string[20, 40];
Random random = new Random();
int p1 = random.Next(0, 20), p2 = random.Next(0, 40), pts = random.Next(1, 19), pts2 = random.Next(1, 39), score = 0;

while (true)
{
    Console.WriteLine("UTILIZE w-a-s-d PARA JOGAR!");
    fundo[pts, pts2] = "+";
    for (int c = 0; c < 20; c++)
    {
        for (int c2 = 0; c2 < 40; c2++)
        {
            if ((c2 == 0 || c2 == 39) || (c == 0 || c == 19))
            {

                fundo[c, c2] = "#";
            }
            else
            {
                if (c == pts && c2 == pts2)
                {
                    fundo[pts, pts2] = "O";
                }
                else
                {
                    fundo[c, c2] = " ";
                }
            }
            if (c == p1 && c2 == p2)
            {
                Console.Write("*");
                if (p1 == pts && p2 == pts2)
                {
                    fundo[pts, pts2] = " ";
                    score++;
                    pts = random.Next(1, 19);
                    pts2 = random.Next(1, 39);
                }
            }
            else
            {
                Console.Write(fundo[c, c2]);
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine("PONTUAÇÃO: " + score);
    ConsoleKeyInfo letra = Console.ReadKey();
    if (letra.KeyChar == 'w')
    {
        p1 -= 1;
    }
    else if (letra.KeyChar == 'a')
    {
        p2 -= 1;
    }
    else if (letra.KeyChar == 's')
    {
        p1 += 1;
    }
    else
    {
        p2 += 1;
    }
    Console.Clear();
}
