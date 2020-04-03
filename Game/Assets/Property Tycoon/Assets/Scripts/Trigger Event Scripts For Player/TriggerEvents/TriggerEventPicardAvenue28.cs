

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventPicardAvenue28 : MonoBehaviour
{

    string Group = "Yellow";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 260;
    int unimprovedRent = 22;
    int PropertyOne = 110;
    int PropertyTwo = 330;
    int PropertyThree = 800;
    int PropertyFour = 975;
    int hotel = 1150;
    
    float timer = 0;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player Moved to Picard Avenue");
            }
        }
        if (other.CompareTag ("Player2"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player2 Moved to Picard Avenue");
            }
        }
        if (other.CompareTag ("Player3"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player3 Moved to Picard Avenue");
            }
        }
        if (other.CompareTag ("Player4"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player4 Moved to Picard Avenue");
            }
        }
        if (other.CompareTag ("Player5"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player5 Moved to Picard Avenue");
            }
        }
        if (other.CompareTag ("Player6"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player6 Moved to Picard Avenue");
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