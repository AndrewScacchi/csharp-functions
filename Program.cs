// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//void StampaArray(int[] array):
//che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“.
//Potete prendere quella fatta in classe questa mattina

void StampaArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine(" ]");
}


//int Quadrato(int numero):
//che vi restituisca il quadrato del numero passato come parametro.
int Quadrato(int numero)
{
    return numero * numero;
}

//int Quadrato(int numero):
//che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.
//Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
int[] ArrayAlQuadrato(int[] array)
{
    int[] arrayQuadrato = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayQuadrato[i] = Quadrato(array[i]);
    }
    return arrayQuadrato;
}

//int SommaElementiArray(int[] array):
//che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
int SommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }
    return somma;
}

//Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
//Stampare l’array di numeri fornito a video
//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
//Stampare la somma di tutti i numeri
//Stampare la somma di tutti i numeri elevati al quadrati

//int[] arrayStatico = { 2, 6, 7, 5, 3, 9 };

Console.WriteLine("How many numbers you wanna insert in the Array?");

int num1 = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num1];
for (int i = 0; i < num1; i++)
{
    Console.WriteLine("Inserisci the " + (i + 1) + "^ number");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Your Array is:");
StampaArray(array);

int[] arrayQuadrato = ArrayAlQuadrato(array);

Console.WriteLine("Array al quadrato is:");
StampaArray(arrayQuadrato);

Console.WriteLine("Sum of Array Elements is:");
Console.WriteLine(SommaElementiArray(array));

Console.WriteLine("Sum of Array Elements al quadrato is:");
Console.WriteLine(SommaElementiArray(arrayQuadrato));