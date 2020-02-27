using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant
{
	public const short parameterMax = 10;
	public const short parameterMin = 0;

	public Plant[] parents;
	public short growSpeed;
	public short productYield;
	public Resistance[] resistances;
}
