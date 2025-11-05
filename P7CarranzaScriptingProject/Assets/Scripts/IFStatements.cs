using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class IFStatements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();
        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        //If the coffee's temperature is greater than the hottest drinking temperature...
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ...do this
            print("Coffee is too hot.");
        }
    }
    // If It isn't, but the coffee temperature is less than the coldest drinking temperature... 
    
} 
