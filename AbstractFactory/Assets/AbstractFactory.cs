using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AbstractFactory: MonoBehaviour
{
	public GliderFactory gliderFactory;
	public AircraftFactory aircraftFactory;
	
	public void SpawnItem(Requirements reqs)
	{
		Debug.Log(reqs.hasEngine);
		Debug.Log(reqs.numberOfEngines);
		Debug.Log(reqs.numberOfWings);
		if (reqs.hasEngine)
		{
			aircraftFactory.ManufacturePoweredAircraft(reqs);
		}
		else
		{
			gliderFactory.ManufactureGlider(reqs);
		}
	}
}
