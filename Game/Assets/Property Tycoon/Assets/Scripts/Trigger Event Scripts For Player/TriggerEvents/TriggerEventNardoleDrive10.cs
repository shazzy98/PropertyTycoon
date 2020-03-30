using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventNardoleDrive10 : MonoBehaviour
{

    string Group = "Blue";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 120;
    int unimprovedRent = 8;
    int PropertyOne = 40;
    int PropertyTwo = 100;
    int PropertyThree = 300;
    int PropertyFour = 450;
    int hotel = 600;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player moved to Nardole Drive");
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
        Debug.Log("Player is at Nardole Drive");
    }

}