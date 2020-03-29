using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bank : MonoBehaviour
{
    public int bankBalance;
    public Text bankBalanceText;


    void Start()
    {

        bankBalance = 5200;
        bankBalanceText.text = bankBalance.ToString();

    }



    public void subtractBank(int subtractedMoney2)
    {

        bankBalance -= subtractedMoney2;
        bankBalanceText.text = bankBalance.ToString();

    }


    public void addBank(int addedMoney2)
    {
        bankBalance += addedMoney2;
        bankBalanceText.text = bankBalance.ToString();
    }

}












