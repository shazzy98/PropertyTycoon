using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventSuperTax39 : MonoBehaviour
{

    float timer = 0;
    public money Money;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player moved to Super Tax");
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
        timer = timer + Time.deltaTime;
        if ((timer > 1) && timer < 1.1)
        {

            Money.GetComponent<money>().subtractMoney(20);
            Debug.Log("Player is at Super Tax");
        }
    }

}