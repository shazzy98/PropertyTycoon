

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventTeslaPowerCo13 : MonoBehaviour
{
    string Group = "Utilities";
    string Action = "";
    string canBeBought = "Yes";
    public static string OwnedBy = "none";
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
            Debug.Log("Player Moved to ");
        }
        if (other.CompareTag ("Player2"))
        {
            Debug.Log("Player2 Moved to ");
        }
        if (other.CompareTag ("Player3"))
        {
            Debug.Log("Player3 Moved to ");
        }
        if (other.CompareTag ("Player4"))
        {
            Debug.Log("Player4 Moved to ");
        }
        if (other.CompareTag ("Player5"))
        {
            Debug.Log("Player5 Moved to ");
        }
        if (other.CompareTag ("Player6"))
        {
            Debug.Log("Player6 Moved to ");
        }   
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Exit Square");
        }
        if (other.CompareTag ("Player2"))
        {
            Debug.Log("Player2 Exit Square");
        }
        if (other.CompareTag ("Player3"))
        {
            Debug.Log("Player3 Exit Square");
        }        
        if (other.CompareTag ("Player4"))
        {
            Debug.Log("Player4 Exit Square");
        }
        if (other.CompareTag ("Player5"))
        {
            Debug.Log("Player5 Exit Square");
        }
        if (other.CompareTag ("Player6"))
        {
            Debug.Log("Player6 Exit Square");
        }        
    }
}