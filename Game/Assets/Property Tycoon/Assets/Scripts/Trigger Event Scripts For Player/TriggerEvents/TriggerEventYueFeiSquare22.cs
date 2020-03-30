using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventYueFeiSquare22 : MonoBehaviour
{

    string Group = "Red";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 220;
    int unimprovedRent = 18;
    int PropertyOne = 90;
    int PropertyTwo = 250;
    int PropertyThree = 700;
    int PropertyFour = 875;
    int hotel = 1050;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player moved to Yue Fei Square");
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
        Debug.Log("Player is at Yue Fei Square");
    }

}