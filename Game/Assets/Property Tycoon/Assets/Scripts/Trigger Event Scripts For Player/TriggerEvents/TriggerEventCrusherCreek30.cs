

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
            Debug.Log("Player Moved to ");
        }
        if (other.CompareTag ("Player2"))
        {
            Debug.Log("Player2 Moved to ");
        }
        if (other.CompareTag ("Player3"))
        {
            Debug.Log("Player3 Moved to ");
        }
        if (other.CompareTag ("Player4"))
        {
            Debug.Log("Player4 Moved to ");
        }
        if (other.CompareTag ("Player5"))
        {
            Debug.Log("Player5 Moved to ");
        }
        if (other.CompareTag ("Player6"))
        {
            Debug.Log("Player6 Moved to ");
        }   
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Exit Square");
        }
        if (other.CompareTag ("Player2"))
        {
            Debug.Log("Player2 Exit Square");
        }
        if (other.CompareTag ("Player3"))
        {
            Debug.Log("Player3 Exit Square");
        }        
        if (other.CompareTag ("Player4"))
        {
            Debug.Log("Player4 Exit Square");
        }
        if (other.CompareTag ("Player5"))
        {
            Debug.Log("Player5 Exit Square");
        }
        if (other.CompareTag ("Player6"))
        {
            Debug.Log("Player6 Exit Square");
        }        
    }

}