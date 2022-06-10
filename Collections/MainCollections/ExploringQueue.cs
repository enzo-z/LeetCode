// See https://aka.ms/new-console-template for more information
internal class ExploringQueue
{

    public static Queue<string> pedagio = new();
    internal static void MainQueue()
    {
        Enfileirar("carro");
        Enfileirar("moto");
        Enfileirar("picape");
        Enfileirar("guincho");

        LiberarCancela();
        ListarFila();
        LiberarCancela();
        LiberarCancela();
        LiberarCancela();

        Enfileirar("celta");
        
        if (pedagio.Any())
        {
            var proxVeiculo = pedagio.Peek();
            
            if (proxVeiculo == "celta")
                Console.WriteLine("Nao entro em celta");
            else
                Console.WriteLine("Tá mec! Marcha!");
        }


    }

    private static void Enfileirar(string veiculo)
    {
        Console.WriteLine($"Entrou na fila: {veiculo}");
        pedagio.Enqueue(veiculo);
    }

    private static void LiberarCancela()
    {
        string? pagante;
        if(!pedagio.TryDequeue(out pagante))
            Console.WriteLine($"Tem nem veículo na fila! Se liga, rapá!");
        else if(pagante == "guincho")
            Console.WriteLine("GUINCHO NÃO!");
        else
            Console.WriteLine($"Saiu da fila: {pagante}");
    }

    private static void ListarFila()
    {
        foreach (var veic in pedagio)
        {
            Console.WriteLine(veic);
        }
    }
}

