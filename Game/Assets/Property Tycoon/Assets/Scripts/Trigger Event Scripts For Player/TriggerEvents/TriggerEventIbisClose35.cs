

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventIbisClose35 : MonoBehaviour
{

    string Group = "Green";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 320;
    int unimprovedRent = 28;
    int PropertyOne = 150;
    int PropertyTwo = 450;
    int PropertyThree = 1000;
    int PropertyFour = 1200;
    int hotel = 1400;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player moved to Ibis Close");
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
        Debug.Log("Player is at Ibis Close");
    }

}