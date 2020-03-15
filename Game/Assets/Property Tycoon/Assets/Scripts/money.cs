using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class money : MonoBehaviour
{
    public int balance;
    public Text balanceText;
    float timer = 0;


    void Start()
    {
        balance = 1500;
        balanceText.text = balance.ToString();
    }


    void Update()
    {
        
    }


    public void addMoney(int addedMoney)
    {
        balance += addedMoney;
        balanceText.text = balance.ToString();
    }

    public void subtractMoney (int subtractedMoney)
    {
        
            balance -= subtractedMoney;
            balanceText.text = balance.ToString();

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
          
            addMoney(200);
        }

        if (other.gameObject.CompareTag("tax"))
        {

            addMoney(1000);
        }

    }



    void OnTriggerStay(Collider other)
    {
       
        if (other.gameObject.CompareTag("tax"))
        {
            timer = timer + Time.deltaTime;
            if (timer > 1)
            {
                addMoney(500);
            }
        }
    }





}
