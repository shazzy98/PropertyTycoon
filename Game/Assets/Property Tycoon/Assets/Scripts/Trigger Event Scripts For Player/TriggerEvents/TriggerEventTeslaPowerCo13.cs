

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventTeslaPowerCo13 : MonoBehaviour
{
    string Group = "Utilities";
    string Action = "";
    string canBeBought = "Yes";
    public static string OwnedBy = "non";
    static int Cost = 150;
    public int rent = 0;

    private static string EdisonWaterOwnedBy;
    void FixedUpdate() 
    {
        if (TriggerEventEdisonWater29.OwnedBy == OwnedBy) 
        {
            if (OwnedBy != "none")
            {
                Debug.Log("TP utilities rent is 10* dice roll");
                rent = PlayerToken.moveQueueIndex * 10;
                //rent = diceRoll * 10 
            }
        }
        if (TriggerEventEdisonWater29.OwnedBy != OwnedBy)
        {
            if (OwnedBy != "none")
            {
                Debug.Log("TP utilities rent is 4* dice roll");
                rent = PlayerToken.moveQueueIndex * 4;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player moved to Tesla Power Co");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Exit Square");
        }
    }
    //void OnTriggerStay(Collider other)
    //{
    //    Debug.Log("Player is at Tesla Power Co");

    //}

}