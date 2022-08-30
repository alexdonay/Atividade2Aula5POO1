using System;

public class Terrestre : Transporte
{	
	public int QuantidadeRodas { get; set; }
	public Terrestre(int Capacidade, int QuantidadeRodas) : base (Capacidade)
    {
        this.Capacidade = Capacidade;
    }
}


