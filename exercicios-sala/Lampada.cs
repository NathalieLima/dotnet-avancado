namespace Models;

class Lampada
{
    private bool ligada;

    public Lampada(bool valorLampada) 
    {
        this.ligada = valorLampada;
    }

    public void Ligar()
    {
        this.ligada = true;
    }

    public void Desligar()
    {
        this.ligada = false;
    }

    public void Imprimir()
    {
        string valor = this.ligada ? "ligada" : "desligada";

        Console.WriteLine($"Lâmpada {valor}");
    }
}