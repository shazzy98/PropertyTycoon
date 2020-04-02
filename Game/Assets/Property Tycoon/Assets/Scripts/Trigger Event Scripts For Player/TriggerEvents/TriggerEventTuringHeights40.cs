

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventTuringHeights40 : MonoBehaviour
{

    string Group = "Deep blue";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 400;
    int unimprovedRent = 50;
    int PropertyOne = 200;
    int PropertyTwo = 600;
    int PropertyThree = 1400;
    int PropertyFour = 1700;
    int hotel = 2000;


    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player moved to Turing Heights");
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
        Debug.Log("Player is at Turing Heights");
    }

}