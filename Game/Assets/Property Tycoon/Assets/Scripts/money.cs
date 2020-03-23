using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class money : MonoBehaviour
{
    public int balance;
    public Text balanceText;
    float timer = 0;
    public GameObject WarpExit;
    public bool stay = false;
    public Image customImage;
  
    
    


    void Start()
    {
        customImage.enabled = false;
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

    }



    void OnTriggerStay(Collider other)
    {
       
        if (other.gameObject.CompareTag("tax"))
        {
            timer = timer + Time.deltaTime;
            if ((timer > 1) && timer <1.1)
            {
                stay = true;
                tax();
                
            }

           
        }

        if (other.gameObject.CompareTag("jail"))
        {
            timer = timer + Time.deltaTime;
            if (timer > 1) 
            { 
            Debug.Log("Going to Jail");
            transform.position = WarpExit.transform.position;
            }
        }


        if (other.gameObject.CompareTag("NardoleDriveBlue"))
        {
            timer = timer + Time.deltaTime;
            if (timer > 1)
            {
                Debug.Log("NardoleDriveBlue");
                customImage.enabled = true;
                


            }
        }






    }



    void tax()
    {
        if (stay == true)
        {
            Debug.Log("Income Tax 200");
            subtractMoney(40);
            stay = false;
        }
    }



    }






