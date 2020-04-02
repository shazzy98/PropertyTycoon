

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventPennyLane20 : MonoBehaviour
{

    string Group = "Orange";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 200;
    int unimprovedRent = 16;
    int PropertyOne = 80;
    int PropertyTwo = 220;
    int PropertyThree = 600;
    int PropertyFour = 800;
    int hotel = 1000;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player moved to Penny Lane 20");
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
        Debug.Log("Player is at Penny Lane");
    }

}