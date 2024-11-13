
using System.Diagnostics;
using System.Collections;
const int NUM_ITENS = 1000000;

const int INITIAL_CAPACITY = 100000;

var stopwatch = new Stopwatch();

stopwatch.Start();

// Lista com tamanho inicial definido

var lista1 = new List<int>(INITIAL_CAPACITY);

for (int i = 0; i < NUM_ITENS; i++)
{
   lista1.Add(i);
}

stopwatch.Stop();

Console.WriteLine($"Tempo para adicionar " + NUM_ITENS + "itens a uma lista com tamanho inicial de " + INITIAL_CAPACITY + ": {stopwatch.ElapsedMilliseconds} ms");

stopwatch.Reset();
stopwatch.Start();

var lista2 = new List<int>();

for (int i = 0; i < NUM_ITENS; i++)
{
   lista2.Add(i);
}

stopwatch.Stop();

Console.WriteLine("Tempo para adicionar " + NUM_ITENS + " itens a uma lista sem tamanho inicial definido: " + stopwatch.ElapsedMilliseconds + " ms");

Console.ReadKey();