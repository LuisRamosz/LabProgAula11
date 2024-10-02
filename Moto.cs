public class Moto : Veiculo
{
    private bool temBagageiro;

    public Moto(string marca, string modelo, int ano, bool temBagageiro) 
    :base(marca, modelo, ano)
    {
        this.temBagageiro = temBagageiro;
    }

    public void darGrau()
    {
        Console.WriteLine("Randandandan");
    }

    public void exibirInformacoes()
    {
        Console.WriteLine($"A marca da moto é {Marca}");
        Console.WriteLine($"O modelo da moto é {Modelo}");
        Console.WriteLine($"O carro tem bagageiro {temBagageiro}");

    }
}