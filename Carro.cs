public class Carro : Veiculo
{
    private int numeroDePortas;
    
    public Carro(int numDePortas, string marca, string modelo, int ano)
    :base(marca, modelo, ano)
    {
        numeroDePortas = numDePortas;
    }
    public void abrirMalas()
    {
        Console.WriteLine("Porta malas está aberto");
    }

    public void exibirInformacoes()
    {
        Console.WriteLine($"A marca do carro é {Marca}");
        Console.WriteLine($"O modelo do carro é {Modelo}");
        Console.WriteLine($"O ano do carro é {Ano}");
        Console.WriteLine($"O carro tem {numeroDePortas} portas");
    }
}