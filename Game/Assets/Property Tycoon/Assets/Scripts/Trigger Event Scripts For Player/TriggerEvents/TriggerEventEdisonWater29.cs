

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventEdisonWater29 : MonoBehaviour
{
    public const string group = "Utilities";
    public const string Action = "";
    public const string canBeBought = "Yes";
    public static string OwnedBy = "none";
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
            }
        }
    }
    

    float timer = 0;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player Moved to Edison Water");
            }
        }
        if (other.CompareTag ("Player2"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player2 Moved to Edison Water");
            }
        }
        if (other.CompareTag ("Player3"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player3 Moved to Edison Water");
            }
        }
        if (other.CompareTag ("Player4"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player4 Moved to Edison Water");
            }
        }
        if (other.CompareTag ("Player5"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player5 Moved to Edison Water");
            }
        }
        if (other.CompareTag ("Player6"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player6 Moved to Edison Water");
            }
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