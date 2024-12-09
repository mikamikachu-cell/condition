using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuto_condition : MonoBehaviour
{
    public int testInt = 4;
    void Start()
    {
      switch(testInt){
        case 1:
            Debug.Log("we found a one"); 
            break;
        default:
            Debug.Log("we didn't find a matching number");
            break;

      }  
     
    }

    
}
