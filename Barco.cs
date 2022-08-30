using System;

public class Barco : Aquatico

{
	public List<Motor> motor = new List<Motor>();
	public Barco(int capacidade, List<Motor> motor): base(capacidade)
	{
		this.motor  = motor;
	}
	
}
