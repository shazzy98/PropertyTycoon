using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventCrapperStrBrown2 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player moved to CrapperStrBrown");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Exit CrapperStrBrown");
        }
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log("Player at CrapperStrBrown");
    }

}