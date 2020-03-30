using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventPottsAvenue9 : MonoBehaviour
{
    string Group = "Blue";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 100;
    int unimprovedRent = 6;
    int PropertyOne = 30;
    int PropertyTwo = 90;
    int PropertyThree = 270;
    int PropertyFour = 400;
    int hotel = 550;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player moved to Potts Avenue ");
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
        Debug.Log("Player is at Potts Avenue");
    }

}