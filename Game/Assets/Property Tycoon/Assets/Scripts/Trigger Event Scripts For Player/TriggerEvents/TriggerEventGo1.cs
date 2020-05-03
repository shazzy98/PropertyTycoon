using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventGo1 : MonoBehaviour
{
    public money Money;
    public Bank bank;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Money.GetComponent<money>().addMoney(200);
            bank.GetComponent<Bank>().subtractBank(200);

            Debug.Log("Player moved to GO");
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
        Debug.Log("On Square GO");
    }

}