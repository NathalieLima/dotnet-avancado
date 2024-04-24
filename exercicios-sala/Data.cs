namespace Models;

class Data
{
    public static string FORMATO_24H = "24h";
    public static string FORMATO_12H = "12h";
    private int dia;
    private int mes;
    private int ano;
    public readonly int Dia { get; private set; }
    public readonly int Mes { get; private set; }
    public readonly int Ano { get; private set; }

    public Data(int dia, int mes, int ano)
    {
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;

        this.Dia = dia;
        this.Mes = mes;
        this.Ano = ano;
    }

    public Data(int dia, int mes, int ano, int hora, int minuto, int segundo)
    {
        if ( hora < 0 || hora > 23 )
        {
            Console.WriteLine("A hora fornecida deve estar entre 0 e 23.");
        }


    }

    public Imprimir()
    {}
}