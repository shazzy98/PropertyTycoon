

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventBrightonStation6 : MonoBehaviour
{
    string Group = "Station";
    string Action = "";
    string canBeBought = "Yes";
    string OwnedBy = "";
    string TypeOfPropertyOwned = "";
    int Cost = 200;
    int unimprovedRent = 0;
    int oneStation = 25;
    int twoStation = 50;
    int threeStation = 100;
    int fourStation = 200;
    int hotel = 0;
    float timer = 0;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            timer = timer + Time.deltaTime;
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player Moved to Brighton Station");
                if (OwnedBy == null)
                {
                    Debug.Log("would player like to buy property");//waiting on user interface
                    int yes = 1;
                    if (yes == 1)
                    {
                        GameObject.Find ("Boot (Tag 'Player')").GetComponent<money>().subtractMoney(200);
                        OwnedBy = "Boot (Tag 'Player')";
                        GameObject.Find ("Boot (Tag 'Player')").GetComponent<money>().purchasedStation();
                        int noOfStations = GameObject.Find ("Boot (Tag 'Player')").GetComponent<money>().StationsOwnedBy();
                    }
                }
                if (OwnedBy != null)
                {
                    int noOfStations = GameObject.Find ("Boot (Tag 'Player')").GetComponent<money>().StationsOwnedBy();
                    Debug.Log("you have been charged with rent");
                    switch (noOfStations)
                    {
                        case 0:
                            GameObject.Find ("Boot (Tag 'Player')").GetComponent<money>().subtractMoney(0);
                            break;
                        case 1:
                            GameObject.Find ("Boot (Tag 'Player')").GetComponent<money>().subtractMoney(25);
                            break;
                        case 2:
                            GameObject.Find ("Boot (Tag 'Player')").GetComponent<money>().subtractMoney(50);
                            break;
                        case 3:
                            GameObject.Find ("Boot (Tag 'Player')").GetComponent<money>().subtractMoney(100);
                            break;
                        case 4:
                            GameObject.Find ("Boot (Tag 'Player')").GetComponent<money>().subtractMoney(200);
                            break;

                    }
                }
            }
        }
        if (other.CompareTag ("Player2"))
        {
            timer = timer + Time.deltaTime;
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player2 Moved to Brighton Station");
                if (OwnedBy == null)
                {
                    Debug.Log("would player like to buy property");//waiting on user interface
                    int yes = 1;
                    if (yes == 1)
                    {
                        GameObject.Find ("Smartphone (Tag 'Player2')").GetComponent<money>().subtractMoney(200);
                        OwnedBy = "Smartphone (Tag 'Player2')";
                        GameObject.Find ("Smartphone (Tag 'Player2')").GetComponent<money>().purchasedStation();
                        int noOfStations = GameObject.Find ("Smartphone (Tag 'Player2')").GetComponent<money>().StationsOwnedBy();
                    }
                }
                if (OwnedBy != null)
                {
                    int noOfStations = GameObject.Find ("Smartphone (Tag 'Player2')").GetComponent<money>().StationsOwnedBy();
                    Debug.Log("you have been charged with rent");
                    switch (noOfStations)
                    {
                        case 0:
                            GameObject.Find ("Smartphone (Tag 'Player2')").GetComponent<money>().subtractMoney(0);
                            break;
                        case 1:
                            GameObject.Find ("Smartphone (Tag 'Player2')").GetComponent<money>().subtractMoney(25);
                            break;
                        case 2:
                            GameObject.Find ("Smartphone (Tag 'Player2')").GetComponent<money>().subtractMoney(50);
                            break;
                        case 3:
                            GameObject.Find ("Smartphone (Tag 'Player2')").GetComponent<money>().subtractMoney(100);
                            break;
                        case 4:
                            GameObject.Find ("Smartphone (Tag 'Player2')").GetComponent<money>().subtractMoney(200);
                            break;

                    }
                }
            }
        }
        if (other.CompareTag ("Player3"))
        {
            timer = timer + Time.deltaTime;
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player3 Moved to Brighton Station");
                if (OwnedBy == null)
                {
                    Debug.Log("would player like to buy property");//waiting on user interface
                    int yes = 1;
                    if (yes == 1)
                    {
                        GameObject.Find ("Goblet (Tag 'Player3)").GetComponent<money>().subtractMoney(200);
                        OwnedBy = "Goblet (Tag 'Player3)";
                        GameObject.Find ("Goblet (Tag 'Player3)").GetComponent<money>().purchasedStation();
                        int noOfStations = GameObject.Find ("Goblet (Tag 'Player3)").GetComponent<money>().StationsOwnedBy();
                    }
                }
                if (OwnedBy != null)
                {
                    int noOfStations = GameObject.Find ("Goblet (Tag 'Player3)").GetComponent<money>().StationsOwnedBy();
                    Debug.Log("you have been charged with rent");
                    switch (noOfStations)
                    {
                        case 0:
                            GameObject.Find ("Goblet (Tag 'Player3)").GetComponent<money>().subtractMoney(0);
                            break;
                        case 1:
                            GameObject.Find ("Goblet (Tag 'Player3)").GetComponent<money>().subtractMoney(25);
                            break;
                        case 2:
                            GameObject.Find ("Goblet (Tag 'Player3)").GetComponent<money>().subtractMoney(50);
                            break;
                        case 3:
                            GameObject.Find ("Goblet (Tag 'Player3)").GetComponent<money>().subtractMoney(100);
                            break;
                        case 4:
                            GameObject.Find ("Goblet (Tag 'Player3)").GetComponent<money>().subtractMoney(200);
                            break;
                    }
                }
            }
        }
        if (other.CompareTag ("Player4"))
        {
            timer = timer + Time.deltaTime;
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player3 Moved to Brighton Station");
                if (OwnedBy == null)
                {
                    Debug.Log("would player like to buy property");//waiting on user interface
                    int yes = 1;
                    if (yes == 1)
                    {
                        GameObject.Find ("Hatstand (Tag 'Player4')").GetComponent<money>().subtractMoney(200);
                        OwnedBy = "Hatstand (Tag 'Player4')";
                        GameObject.Find ("Hatstand (Tag 'Player4')").GetComponent<money>().purchasedStation();
                        int noOfStations = GameObject.Find ("Hatstand (Tag 'Player4')").GetComponent<money>().StationsOwnedBy();
                    }
                }
                if (OwnedBy != null)
                {
                    int noOfStations = GameObject.Find ("Hatstand (Tag 'Player4')").GetComponent<money>().StationsOwnedBy();
                    Debug.Log("you have been charged with rent");
                    switch (noOfStations)
                    {
                        case 0:
                            GameObject.Find ("Hatstand (Tag 'Player4')").GetComponent<money>().subtractMoney(0);
                            break;
                        case 1:
                            GameObject.Find ("Hatstand (Tag 'Player4')").GetComponent<money>().subtractMoney(25);
                            break;
                        case 2:
                            GameObject.Find ("Hatstand (Tag 'Player4')").GetComponent<money>().subtractMoney(50);
                            break;
                        case 3:
                            GameObject.Find ("Hatstand (Tag 'Player4')").GetComponent<money>().subtractMoney(100);
                            break;
                        case 4:
                            GameObject.Find ("Hatstand (Tag 'Player4')").GetComponent<money>().subtractMoney(200);
                            break;

                    }
                }
            }
        }
        if (other.CompareTag ("Player5"))
        {
            timer = timer + Time.deltaTime;
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player3 Moved to Brighton Station");
                if (OwnedBy == null)
                {
                    Debug.Log("would player like to buy property");//waiting on user interface
                    int yes = 1;
                    if (yes == 1)
                    {
                        GameObject.Find ("Cat (Tag 'Player5')").GetComponent<money>().subtractMoney(200);
                        OwnedBy = "Cat (Tag 'Player5')";
                        GameObject.Find ("Cat (Tag 'Player5')").GetComponent<money>().purchasedStation();
                        int noOfStations = GameObject.Find ("Cat (Tag 'Player5')").GetComponent<money>().StationsOwnedBy();
                    }
                }
                if (OwnedBy != null)
                {
                    int noOfStations = GameObject.Find ("Cat (Tag 'Player5')").GetComponent<money>().StationsOwnedBy();
                    Debug.Log("you have been charged with rent");
                    switch (noOfStations)
                    {
                        case 0:
                            GameObject.Find ("Cat (Tag 'Player5')").GetComponent<money>().subtractMoney(0);
                            break;
                        case 1:
                            GameObject.Find ("Cat (Tag 'Player5')").GetComponent<money>().subtractMoney(25);
                            break;
                        case 2:
                            GameObject.Find ("Cat (Tag 'Player5')").GetComponent<money>().subtractMoney(50);
                            break;
                        case 3:
                            GameObject.Find ("Cat (Tag 'Player5')").GetComponent<money>().subtractMoney(100);
                            break;
                        case 4:
                            GameObject.Find ("Cat (Tag 'Player5')").GetComponent<money>().subtractMoney(200);
                            break;

                    }
                }
            }
        }
        if (other.CompareTag ("Player6"))
        {
            timer = timer + Time.deltaTime;
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player3 Moved to Brighton Station");
                if (OwnedBy == null)
                {
                    Debug.Log("would player like to buy property");//waiting on user interface
                    int yes = 1;
                    if (yes == 1)
                    {
                        GameObject.Find ("Spoon (Tag 'Player6')").GetComponent<money>().subtractMoney(200);
                        OwnedBy = "Spoon (Tag 'Player6')";
                        GameObject.Find ("Spoon (Tag 'Player6')").GetComponent<money>().purchasedStation();
                        int noOfStations = GameObject.Find ("Spoon (Tag 'Player6')").GetComponent<money>().StationsOwnedBy();
                    }
                }
                if (OwnedBy != null)
                {
                    int noOfStations = GameObject.Find ("Spoon (Tag 'Player6')").GetComponent<money>().StationsOwnedBy();
                    Debug.Log("you have been charged with rent");
                    switch (noOfStations)
                    {
                        case 0:
                            GameObject.Find ("Spoon (Tag 'Player6')").GetComponent<money>().subtractMoney(0);
                            break;
                        case 1:
                            GameObject.Find ("Spoon (Tag 'Player6')").GetComponent<money>().subtractMoney(25);
                            break;
                        case 2:
                            GameObject.Find ("Spoon (Tag 'Player6')").GetComponent<money>().subtractMoney(50);
                            break;
                        case 3:
                            GameObject.Find ("Spoon (Tag 'Player6')").GetComponent<money>().subtractMoney(100);
                            break;
                        case 4:
                            GameObject.Find ("Spoon (Tag 'Player6')").GetComponent<money>().subtractMoney(200);
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
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Exit Square");
            }
        }
        if (other.CompareTag ("Player2"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Exit Square");
            }
        }
        if (other.CompareTag ("Player3"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Exit Square");
            }
        }        
        if (other.CompareTag ("Player4"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Exit Square");
            }
        }
        if (other.CompareTag ("Player5"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Exit Square");
            }
        }
        if (other.CompareTag ("Player6"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Exit Square");
            }
        }        
    }
}