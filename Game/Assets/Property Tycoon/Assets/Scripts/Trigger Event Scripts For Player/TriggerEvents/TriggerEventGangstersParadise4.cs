

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventGangstersParadise4 : MonoBehaviour
{
    string Group = "Brown";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    int Cost = 60;
    int unimprovedRent = 4;
    int PropertyOne = 20;
    int PropertyTwo = 60;
    int PropertyThree = 180;
    int PropertyFour = 320;
    int hotel = 450;

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