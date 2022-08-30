using System;

public class Barco : Aquatico

{
	public List<Motor> motor = new List<Motor>();
	public int quantidadeMotor{ get; set;}
	public Barco(int capacidade, List<Motor> motor, int quantidadeMotor): base(capacidade)
	{
		this.motor  = motor;
		this.quantidadeMotor = quantidadeMotor;
	}
	
}
