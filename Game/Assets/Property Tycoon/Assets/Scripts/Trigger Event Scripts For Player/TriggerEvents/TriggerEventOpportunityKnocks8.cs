using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventOpportunityKnocks8 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player moved to Opportunity Knocks 8");
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
        Debug.Log("Player is at Opportunity Knocks 8");
    }

}