using System;

public class Automovel : Terrestre
{
    public string cor { get; set; }
    public int quantidadePortas { get; set; }
    public string placa { get; set; }

   
    public Automovel(int Capacidade, int QuantidadeRodas, string cor, string placa, string quantidadePortas):base(Capacidade, QuantidadeRodas)
    {
        this.cor = cor;
        this.quantidadePortas = QuantidadeRodas;
        this .placa = placa;
    }

}
