using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventOpportunityKnocks8 : MonoBehaviour
{
    float timer = 0;
    public int random;
    public money Money;
    public Bank bank;
    public GameObject WarpExit;

    private void Start()
    {
        random = Random.Range(1, 4);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            Debug.Log("Player moved to Pot Luck 3");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Exit Square");
        }
    }
    void OnTriggerStay(Collider other)
    {
        timer = timer + Time.deltaTime;
        if ((timer > 1) && timer < 1.1)
        {
            if (random == 1)
            {
                Debug.Log("The Bank has made an accounting mistake, Recive $100");
                Money.GetComponent<money>().addMoney(20);
                bank.GetComponent<Bank>().subtractBank(20);
            }

            if (random == 2)
            {
                Debug.Log("Advance to GO");
                transform.position = WarpExit.transform.position;
            }

            if (random == 3)
            {
                Debug.Log("Hospital Fees, pay $50");
                Money.GetComponent<money>().subtractMoney(10);
            }

            if (random == 4)
            {
                Debug.Log("4");
            }
            Debug.Log("Player is at Opportunity Knocks 8");
        }

    }
}