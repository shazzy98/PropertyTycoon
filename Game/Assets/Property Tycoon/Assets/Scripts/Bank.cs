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

        bankBalance = 5000;
        bankBalanceText.text = bankBalance.ToString();

    }



    public void subtractBank(int subtractedMoney)
    {

        bankBalance -= subtractedMoney;
        bankBalanceText.text = bankBalance.ToString();

    }


}












