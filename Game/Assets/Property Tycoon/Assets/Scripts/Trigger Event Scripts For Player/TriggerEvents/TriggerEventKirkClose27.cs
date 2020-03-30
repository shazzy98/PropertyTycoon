using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventKirkClose27 : MonoBehaviour
{

    string Group = "Yellow";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 260;
    int unimprovedRent = 22;
    int PropertyOne = 110;
    int PropertyTwo = 330;
    int PropertyThree = 800;
    int PropertyFour = 975;
    int hotel = 1150;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player moved to Kirk Close");
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
        Debug.Log("Player is at Kirk Close");
    }

}