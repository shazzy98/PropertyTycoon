using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventIncomeTax5 : MonoBehaviour
{
    float timer = 0;
    public money Money;
    public Bank bank;
  



    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log("Player moved to Income Tax");
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
          
            Money.GetComponent<money>().subtractMoney(40);
            bank.GetComponent<Bank>().addBank(40);
            Debug.Log("Player is at Income Tax");
        }
    }



}