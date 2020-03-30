using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventCrapperStrBrown2 : MonoBehaviour
{
    string Group = "Brown";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 60;
    int unimprovedRent = 2;
    int PropertyOne = 10;
    int PropertyTwo = 30;
    int PropertyThree = 90;
    int PropertyFour = 160;
    int hotel = 250;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player moved to CrapperStrBrown");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Exit CrapperStrBrown");
        }
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log("Player at CrapperStrBrown");
    }

}