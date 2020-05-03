using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventCooperDrive17 : MonoBehaviour
{
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