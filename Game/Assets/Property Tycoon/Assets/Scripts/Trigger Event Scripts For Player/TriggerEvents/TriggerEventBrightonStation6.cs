

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventBrightonStation6 : MonoBehaviour
{
    string Group = "Station";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 200;
    int unimprovedRent = 0;
    int PropertyOne = 25;
    int PropertyTwo = 50;
    int PropertyThree = 100;
    int PropertyFour = 200;
    int hotel = 0;
    float timer = 0;

    void OnTriggerStay(Collider other)
    {
        timer = timer + Time.deltaTime;
        if (other.CompareTag ("Player"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player Moved to Brighton Station");
            }
        }
        if (other.CompareTag ("Player2"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player2 Moved to Brighton Station");
            }
        }
        if (other.CompareTag ("Player3"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player2 Moved to Brighton Station");
            }
        }
        if (other.CompareTag ("Player4"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player2 Moved to Brighton Station");
            }
        }
        if (other.CompareTag ("Player5"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player2 Moved to Brighton Station");
            }
        }
        if (other.CompareTag ("Player6"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player2 Moved to Brighton Station");
            }
        }   
    }
    void OnTriggerExit(Collider other)
    {
        timer = 0;
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Exit Square");
        }
        if (other.CompareTag ("Player2"))
        {
            Debug.Log("Exit Square");
        }
        if (other.CompareTag ("Player3"))
        {
            Debug.Log("Exit Square");
        }        
        if (other.CompareTag ("Player4"))
        {
            Debug.Log("Exit Square");
        }
        if (other.CompareTag ("Player5"))
        {
            Debug.Log("Exit Square");
        }
        if (other.CompareTag ("Player6"))
        {
            Debug.Log("Exit Square");
        }        
    }

}