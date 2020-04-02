

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventCrusherCreek30 : MonoBehaviour
{

    string Group = "Yellow";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 280;
    int unimprovedRent = 22;
    int PropertyOne = 120;
    int PropertyTwo = 360;
    int PropertyThree = 850;
    int PropertyFour = 1025;
    int hotel = 1200;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player moved to CrusherCreek");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Exit CrusherCreek");
        }
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log("Player is at Crusher Creek");
    }

}