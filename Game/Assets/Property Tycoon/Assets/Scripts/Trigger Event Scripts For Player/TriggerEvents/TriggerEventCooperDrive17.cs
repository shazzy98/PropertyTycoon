using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventCooperDrive17 : MonoBehaviour
{
    string Group = "Orange";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 180;
    int unimprovedRent = 14;
    int PropertyOne = 70;
    int PropertyTwo = 200;
    int PropertyThree = 550;
    int PropertyFour = 750;
    int hotel = 950;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Moved to Cooper Drive");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Exit Cooper Drive");
        }
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log("On Square Cooper Drive");
    }

}