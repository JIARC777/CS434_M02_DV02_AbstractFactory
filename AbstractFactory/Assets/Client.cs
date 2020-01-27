using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public bool engine;
    public int howManyEngines;
    public int howManyWings;

    public Text numWings;
    public Text numEngines;
    public Text containEngine;
    public AbstractFactory factory;
    // Update is called once per frame
    void Update()
    {
        // Every Frame update the requirements to ensure all info is being sent when requested
        if (Input.GetKeyDown("s"))
        {
            Requirements requirements = new Requirements();
            requirements.hasEngine = engine;
            requirements.numberOfEngines = howManyEngines;
            requirements.numberOfWings = howManyWings;

            // Send Requirements to factory;
            factory.SpawnItem(requirements);
        }
        // Increment the number of wings with the + -   Clip values between 0 and 4
        if (Input.GetKeyDown("="))
        {
            howManyWings++;
            if (howManyWings > 4)
                howManyWings = 4;
        }
        if (Input.GetKeyDown("-"))
        {
            howManyWings--;
            if (howManyWings < 0)
                howManyWings = 0;
        }
        if (Input.GetKeyDown("e"))
            engine = !engine;
        if (Input.GetKeyDown("]"))
        {
            howManyEngines++;
            if (howManyEngines > 2)
                howManyEngines = 2;
        }
        if (Input.GetKeyDown("["))
        {
            howManyEngines--;
            if (howManyEngines < 0)
                howManyEngines = 0;
        }
        numWings.text = howManyWings.ToString();
        numEngines.text = howManyEngines.ToString();
        containEngine.text = engine.ToString();

    }
}

