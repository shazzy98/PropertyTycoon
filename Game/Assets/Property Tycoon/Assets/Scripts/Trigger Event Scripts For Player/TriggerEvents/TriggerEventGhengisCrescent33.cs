using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventGhengisCrescent33 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player moved to Ghengis Crescent");
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
        Debug.Log("Player is at Ghengis Crescent");
    }

}