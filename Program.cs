Console.Write("Números pares entre 0 e ? ");

int numeroInformado = Convert.ToInt32(Console.ReadLine());

if (numeroInformado >= 1)
{

    int numeroPar = 0;

    while (numeroPar <= numeroInformado)
    {
        Console.Write($"{numeroPar} ");
        numeroPar += 2;
 
    }
}

else
{
 
    Console.WriteLine($"O número {numeroInformado} não é inteiro positivo.");

}