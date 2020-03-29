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

  
    
    


    void Start()
    {
  
        balance = 1300;
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




    void tax()
    {
        if (stay == true)
        {
            Debug.Log("Income Tax 200");
            subtractMoney(40);
            stay = false;
        }
    }

    public void goToJail()
    {
        Debug.Log("Going to Jail");
        transform.position = WarpExit.transform.position;
    }
}





    






