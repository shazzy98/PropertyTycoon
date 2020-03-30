using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventEdisonWater29 : MonoBehaviour
{
    string group = "Utilities";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 150;

    int unimprovedRent = 0;
    int PropertyOne = 25;
    int PropertyTwo = 50;
    int PropertyThree = 100;
    int PropertyFour = 200;
    int hotel = 0;

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