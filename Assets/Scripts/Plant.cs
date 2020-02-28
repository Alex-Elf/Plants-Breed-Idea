using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Plant
{
	public const short ParameterMax = 10;
	public const short ParameterMin = 0;

	public int Id;
	public Plant[] Parents;
	public short GrowSpeed;
	public short ProductYield;
	public Resistance[] Resistances;
	public DateTime TimeWhenPlanted;
	public Product[] products;
	public Modifier[] Modifiers;
}
