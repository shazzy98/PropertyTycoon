

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventWolowitzStreet19 : MonoBehaviour
{

    string Group = "Orange";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 180;
    int unimprovedRent = 14;
    int PropertyOne = 70;
    int PropertyTwo = 200;
    int PropertyThree = 550;
    int PropertyFour = 750;
    int hotel = 950;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player moved to Wolowitz Street");
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
        Debug.Log("Player is at Wolowitz Street ");
    }

}