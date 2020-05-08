

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventCrapperStrBrown2 : MonoBehaviour
{
    string Group = "Brown";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    string CurrentlyOwned = "";
    int Cost = 60;
    int unimprovedRent = 2;
    int PropertyOne = 10;
    int PropertyTwo = 30;
    int PropertyThree = 90;
    int PropertyFour = 160;
    int hotel = 250;
    float timer = 0;


    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag ("Player"))
        {  
            //string Player = GameObject.Find ("Boot (Tag 'Player')");
            timer = timer + Time.deltaTime;
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player Moved to Crapper Str Brown");
                string Player = "Boot (Tag 'Player')";
                if (((OwnedBy == "") || OwnedBy == "Player") && (CurrentlyOwned != "hotel"))
                {
                    int balance = GameObject.Find (Player).GetComponent<money>().balance;
                    Debug.Log("would player like to buy property");//waiting on user interface

                    int yes = 1;
                    if (yes == 1)
                    //Debug.Log("How many properties would you like to buy?"); // DISPLAY PRICES
                    {
                        switch(CurrentlyOwned)
                        {
                            case "":
                                CurrentlyOwned = "unimprovedRent";
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "unimprovedRent":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyOne":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyTwo":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyThree":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyFour":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                        }
                    }
                }
                if ((OwnedBy != null))
                {
                    Debug.Log("you have been charged with rent");
                    switch (CurrentlyOwned)
                    {
                        case "unimprovedRent":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(unimprovedRent);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(unimprovedRent);
                            break;
                        case "PropertyOne":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyOne);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyOne);
                            break;
                        case "PropertyTwo":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyTwo);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyTwo);
                            break;
                        case "PropertyThree":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyThree);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyThree);
                            break;
                        case "PropertyFour":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyFour);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyFour);
                            break;
                        case "hotel":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(hotel);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(hotel);
                            break;

                    }
                }
            }
        }
        if (other.CompareTag ("Player2"))
        {
           //string Player = GameObject.Find ("Boot (Tag 'Player')");
            timer = timer + Time.deltaTime;
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player Moved to Falmer Station");
                string Player = "Smartphone (Tag 'Player2')";
                if (((OwnedBy == "") || OwnedBy == "Player") && (CurrentlyOwned != "hotel"))
                {
                    int balance = GameObject.Find (Player).GetComponent<money>().balance;
                    Debug.Log("would player like to buy property");//waiting on user interface

                    int yes = 1;
                    if (yes == 1)
                    //Debug.Log("How many properties would you like to buy?"); // DISPLAY PRICES
                    {
                        switch(CurrentlyOwned)
                        {
                            case "":
                                CurrentlyOwned = "unimprovedRent";
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "unimprovedRent":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyOne":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyTwo":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyThree":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyFour":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                        }
                    }
                }
                if ((OwnedBy != null))
                {
                    Debug.Log("you have been charged with rent");
                    switch (CurrentlyOwned)
                    {
                        case "unimprovedRent":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(unimprovedRent);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(unimprovedRent);
                            break;
                        case "PropertyOne":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyOne);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyOne);
                            break;
                        case "PropertyTwo":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyTwo);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyTwo);
                            break;
                        case "PropertyThree":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyThree);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyThree);
                            break;
                        case "PropertyFour":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyFour);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyFour);
                            break;
                        case "hotel":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(hotel);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(hotel);
                            break;

                    }
                }
            }
        }
        
        if (other.CompareTag ("Player3"))
        {
           //string Player = GameObject.Find ("Boot (Tag 'Player')");
            timer = timer + Time.deltaTime;
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player Moved to Falmer Station");
                string Player = "Smartphone (Tag 'Player2')";
                if (((OwnedBy == "") || OwnedBy == "Player") && (CurrentlyOwned != "hotel"))
                {
                    int balance = GameObject.Find (Player).GetComponent<money>().balance;
                    Debug.Log("would player like to buy property");//waiting on user interface

                    int yes = 1;
                    if (yes == 1)
                    //Debug.Log("How many properties would you like to buy?"); // DISPLAY PRICES
                    {
                        switch(CurrentlyOwned)
                        {
                            case "":
                                CurrentlyOwned = "unimprovedRent";
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "unimprovedRent":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyOne":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyTwo":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyThree":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyFour":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                        }
                    }
                }
                if ((OwnedBy != null))
                {
                    Debug.Log("you have been charged with rent");
                    switch (CurrentlyOwned)
                    {
                        case "unimprovedRent":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(unimprovedRent);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(unimprovedRent);
                            break;
                        case "PropertyOne":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyOne);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyOne);
                            break;
                        case "PropertyTwo":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyTwo);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyTwo);
                            break;
                        case "PropertyThree":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyThree);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyThree);
                            break;
                        case "PropertyFour":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyFour);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyFour);
                            break;
                        case "hotel":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(hotel);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(hotel);
                            break;

                    }
                }
            }
        }
        
        if (other.CompareTag ("Player4"))
        {
           //string Player = GameObject.Find ("Boot (Tag 'Player')");
            timer = timer + Time.deltaTime;
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player Moved to Falmer Station");
                string Player = "Hatstand (Tag 'Player4')";
                if (((OwnedBy == "") || OwnedBy == "Player") && (CurrentlyOwned != "hotel"))
                {
                    int balance = GameObject.Find (Player).GetComponent<money>().balance;
                    Debug.Log("would player like to buy property");//waiting on user interface

                    int yes = 1;
                    if (yes == 1)
                    //Debug.Log("How many properties would you like to buy?"); // DISPLAY PRICES
                    {
                        switch(CurrentlyOwned)
                        {
                            case "":
                                CurrentlyOwned = "unimprovedRent";
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "unimprovedRent":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyOne":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyTwo":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyThree":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyFour":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                        }
                    }
                }
                if ((OwnedBy != null))
                {
                    Debug.Log("you have been charged with rent");
                    switch (CurrentlyOwned)
                    {
                        case "unimprovedRent":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(unimprovedRent);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(unimprovedRent);
                            break;
                        case "PropertyOne":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyOne);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyOne);
                            break;
                        case "PropertyTwo":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyTwo);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyTwo);
                            break;
                        case "PropertyThree":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyThree);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyThree);
                            break;
                        case "PropertyFour":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyFour);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyFour);
                            break;
                        case "hotel":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(hotel);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(hotel);
                            break;

                    }
                }
            }
        }
        if (other.CompareTag ("Player5"))
        {
           //string Player = GameObject.Find ("Boot (Tag 'Player')");
            timer = timer + Time.deltaTime;
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player Moved to Falmer Station");
                string Player = "Cat (Tag 'Player5')";
                if (((OwnedBy == "") || OwnedBy == "Player") && (CurrentlyOwned != "hotel"))
                {
                    int balance = GameObject.Find (Player).GetComponent<money>().balance;
                    Debug.Log("would player like to buy property");//waiting on user interface

                    int yes = 1;
                    if (yes == 1)
                    //Debug.Log("How many properties would you like to buy?"); // DISPLAY PRICES
                    {
                        switch(CurrentlyOwned)
                        {
                            case "":
                                CurrentlyOwned = "unimprovedRent";
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "unimprovedRent":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyOne":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyTwo":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyThree":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyFour":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                        }
                    }
                }
                if ((OwnedBy != null))
                {
                    Debug.Log("you have been charged with rent");
                    switch (CurrentlyOwned)
                    {
                        case "unimprovedRent":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(unimprovedRent);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(unimprovedRent);
                            break;
                        case "PropertyOne":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyOne);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyOne);
                            break;
                        case "PropertyTwo":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyTwo);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyTwo);
                            break;
                        case "PropertyThree":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyThree);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyThree);
                            break;
                        case "PropertyFour":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyFour);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyFour);
                            break;
                        case "hotel":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(hotel);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(hotel);
                            break;

                    }
                }
            }
        }
        if (other.CompareTag ("Player6"))
        {
           //string Player = GameObject.Find ("Boot (Tag 'Player')");
            timer = timer + Time.deltaTime;
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player Moved to Falmer Station");
                string Player = "Spoon (Tag 'Player6')";
                if (((OwnedBy == "") || OwnedBy == "Player") && (CurrentlyOwned != "hotel"))
                {
                    int balance = GameObject.Find (Player).GetComponent<money>().balance;
                    Debug.Log("would player like to buy property");//waiting on user interface

                    int yes = 1;
                    if (yes == 1)
                    //Debug.Log("How many properties would you like to buy?"); // DISPLAY PRICES
                    {
                        switch(CurrentlyOwned)
                        {
                            case "":
                                CurrentlyOwned = "unimprovedRent";
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "unimprovedRent":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyOne":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyTwo":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyThree":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                            case "PropertyFour":
                                GameObject.Find (Player).GetComponent<money>().subtractMoney(Cost);
                                balance = GameObject.Find (Player).GetComponent<money>().balance;
                                if (balance < 0)
                                {
                                    GameObject.Find (Player).GetComponent<money>().addMoney(Cost);
                                    Debug.Log("You do not have the funds to purchase this property");
                                    break;
                                }
                                GameObject.Find ("Bank").GetComponent<money>().addMoney(Cost);
                                OwnedBy = Player;
                                break;
                        }
                    }
                }
                if ((OwnedBy != null))
                {
                    Debug.Log("you have been charged with rent");
                    switch (CurrentlyOwned)
                    {
                        case "unimprovedRent":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(unimprovedRent);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(unimprovedRent);
                            break;
                        case "PropertyOne":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyOne);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyOne);
                            break;
                        case "PropertyTwo":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyTwo);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyTwo);
                            break;
                        case "PropertyThree":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyThree);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyThree);
                            break;
                        case "PropertyFour":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(PropertyFour);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(PropertyFour);
                            break;
                        case "hotel":
                            GameObject.Find (Player).GetComponent<money>().subtractMoney(hotel);
                            GameObject.Find (OwnedBy).GetComponent<money>().addMoney(hotel);
                            break;

                    }
                }
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