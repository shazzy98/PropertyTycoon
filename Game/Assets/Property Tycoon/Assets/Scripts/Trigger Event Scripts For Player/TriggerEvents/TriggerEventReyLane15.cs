using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventReyLane15 : MonoBehaviour
{

    string Group = "Purple";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 160;
    int unimprovedRent = 12;
    int PropertyOne = 60;
    int PropertyTwo = 180;
    int PropertyThree = 500;
    int PropertyFour = 700;
    int hotel = 900;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player moved to Rey Lane");
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
        Debug.Log("Player is at Rey lane");
    }

}