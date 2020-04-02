

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventGangstersParadise4 : MonoBehaviour
{
    string Group = "Brown";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 60;
    int unimprovedRent = 4;
    int PropertyOne = 20;
    int PropertyTwo = 60;
    int PropertyThree = 180;
    int PropertyFour = 320;
    int hotel = 450;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player moved to Gansters Paradise");
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
        Debug.Log("Player is at Gangsters Paradise");
    }

}