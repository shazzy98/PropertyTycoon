using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventHawkingWay38 : MonoBehaviour
{

    string Group = "Deep blue";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 350;
    int unimprovedRent = 35;
    int PropertyOne = 175;
    int PropertyTwo = 500;
    int PropertyThree = 1100;
    int PropertyFour = 1300;
    int hotel = 1500;

    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player moved to Hawking Way");
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
        Debug.Log("Player is at Hawking Way");
    }

}