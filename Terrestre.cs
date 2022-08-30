using System;

public class Terrestre : Transporte
{	
	public int QuantidadeRodas { get; set; }
	public Terrestre(int quantidadeRodas)
    {
        QuantidadeRodas = quantidadeRodas;
    }
}


