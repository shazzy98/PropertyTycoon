

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventEdisonWater29 : MonoBehaviour
{
    public const string group = "Utilities";
    public const string Action = "";
    public const string canBeBought = "Yes";
    public static string OwnedBy = "non";
    public static int Cost = 150;
    public int rent = 0;

    private static string TeslaPowerOwnedBy;
    void FixedUpdate() 
    {
        if (TriggerEventTeslaPowerCo13.OwnedBy == OwnedBy) 
        {
            if (OwnedBy != "none")
            {
                //Debug.Log("EW utilities rent is 10* dice roll");
                Debug.Log(PlayerToken.moveQueueIndex);
                rent = PlayerToken.moveQueueIndex * 10;
                //rent = diceRoll * 10 
            }
        }
        if (TriggerEventTeslaPowerCo13.OwnedBy != OwnedBy)
        {
            if (OwnedBy != "none")
            {
                Debug.Log("EW utilities rent is 4* dice roll");
                rent = PlayerToken.moveQueueIndex * 4;
            //rent = diceRoll * 4;
            }
        }
    }
    

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player Moved to Edison Water");

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Exit Square");
        }
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log("Player is ad Edison Water");
    }

}