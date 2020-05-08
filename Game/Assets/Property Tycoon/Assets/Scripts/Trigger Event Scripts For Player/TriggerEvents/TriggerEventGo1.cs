

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventGo1 : MonoBehaviour
{

    float timer = 0;
    public money Money;
    public Bank bank;



    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Money.GetComponent<money>().addMoney(200);
            bank.GetComponent<Bank>().subtractBank(200);
        }

        if (other.CompareTag("Player2"))
        {
            Money.GetComponent<money>().addMoney(200);
            bank.GetComponent<Bank>().subtractBank(200);
        }

        if (other.CompareTag("Player3"))
        {
            Money.GetComponent<money>().addMoney(200);
            bank.GetComponent<Bank>().subtractBank(200);
        }

        if (other.CompareTag("Player4"))
        {
            Money.GetComponent<money>().addMoney(200);
            bank.GetComponent<Bank>().subtractBank(200);
        }

        if (other.CompareTag("Player5"))
        {
            Money.GetComponent<money>().addMoney(200);
            bank.GetComponent<Bank>().subtractBank(200);
        }

        if (other.CompareTag("Player6"))
        {
            Money.GetComponent<money>().addMoney(200);
            bank.GetComponent<Bank>().subtractBank(200);
        }

    }


    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player Moved to Go");
            }
        }
        if (other.CompareTag ("Player2"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player2 Moved to Go");
            }
        }
        if (other.CompareTag ("Player3"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player3 Moved to Go");
            }
        }
        if (other.CompareTag ("Player4"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player4 Moved to Go");
            }
        }
        if (other.CompareTag ("Player5"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player5 Moved to Go");
            }
        }
        if (other.CompareTag ("Player6"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player6 Moved to Go");
            }
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
