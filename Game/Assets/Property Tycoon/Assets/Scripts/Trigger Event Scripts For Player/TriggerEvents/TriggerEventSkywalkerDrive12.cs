using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventSkywalkerDrive12 : MonoBehaviour
{   

    string Group = "Purple";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 140;
    int unimprovedRent = 10;
    int PropertyOne = 50;
    int PropertyTwo = 150;
    int PropertyThree = 450;
    int PropertyFour = 625;
    int hotel = 750;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player Moved to Skywalker Drive");
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
        Debug.Log("Player is at Skywalker Drive");
    }

}