

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventSiratMews32 : MonoBehaviour
{

    string Group = "Green";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 300;
    int unimprovedRent = 26;
    int PropertyOne = 130;
    int PropertyTwo = 390;
    int PropertyThree = 900;
    int PropertyFour = 1100;
    int hotel = 1275;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player moved to Sirat Mews");
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
        Debug.Log("Player is at Sirat Mews");
    }

}