using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GliderFactory : MonoBehaviour
{
	GameObject product;
	public void ManufactureGlider(Requirements gliderReqs)
	{
		switch (gliderReqs.numberOfWings)
		{
			case 1:
				product = Instantiate(Resources.Load("1WingGlider", typeof(GameObject))) as GameObject;
				break;

			case 2:
				product = Instantiate(Resources.Load("2WingGlider", typeof(GameObject))) as GameObject;
				break;

			case 3:
				product = Instantiate(Resources.Load("3WingGlider", typeof(GameObject))) as GameObject;
				break;

			case 4:
				product = Instantiate(Resources.Load("4WingGlider", typeof(GameObject))) as GameObject;
				break;

			default:
				Debug.Log("The factory is unable to create the requested Object");
				break;

		}
	}
}
