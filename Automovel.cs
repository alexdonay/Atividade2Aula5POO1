using System;

public class Automovel : Terrestre
{
    public string cor { get; set; }
    public int quantidadePortas { get; set; }
    public string placa { get; set; }

    public Automovel(int quantidadeRodas, string cor, int quantidadePortas, string placa) : base(quantidadeRodas)
    {
        this.cor = cor;
        this.quantidadePortas = quantidadePortas;
        this.placa = placa;
    }


}
