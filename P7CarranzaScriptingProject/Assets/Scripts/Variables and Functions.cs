using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesandFunctions : MonoBehaviour
{
    //Creating an Integer variable
    int myInt = 6;

    // Start is called before the first frame update
    void Start()
    {
        //running my int variable thru the function
        myInt = MultiplyByTwo(myInt);

       //displaying the results on the console
        Debug.Log(myInt); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int MulitplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
