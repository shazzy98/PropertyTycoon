

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventHanXinGardens25 : MonoBehaviour
{

    string Group = "Red";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 240;
    int unimprovedRent = 20;
    int PropertyOne = 100;
    int PropertyTwo = 300;
    int PropertyThree = 750;
    int PropertyFour = 925;
    int hotel = 1100;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player Moved to Han Xin Gardens");
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
        Debug.Log("Player Is at Han Xin Gardens");
    }

}