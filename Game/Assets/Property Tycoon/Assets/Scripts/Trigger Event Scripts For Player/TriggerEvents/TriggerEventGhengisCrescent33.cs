

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventGhengisCrescent33 : MonoBehaviour
{


    string Group = "Green";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 300;
    int unimprovedRent = 26;
    int PropertyOne = 130;
    int PropertyTwo = 390;
    int PropertyThree = 900;
    int PropertyFour = 1100;
    int hotel = 1275;

    float timer = 0;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player Moved to Ghengis Crescent");
            }
        }
        if (other.CompareTag ("Player2"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player2 Moved to Ghengis Crescent");
            }
        }
        if (other.CompareTag ("Player3"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player3 Moved to Ghengis Crescent");
            }
        }
        if (other.CompareTag ("Player4"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player4 Moved to Ghengis Crescent");
            }
        }
        if (other.CompareTag ("Player5"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player5 Moved to Ghengis Crescent");
            }
        }
        if (other.CompareTag ("Player6"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player6 Moved to Ghengis Crescent");
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