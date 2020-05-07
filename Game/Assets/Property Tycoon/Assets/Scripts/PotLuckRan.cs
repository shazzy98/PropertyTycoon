using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotLuckRan : MonoBehaviour
{
    public Sprite[] cardFaces;
    public GameObject cardPrefab;
    public static string[] valuesPL = new string[] {"PL1", "PL2", "PL3", "PL4", "PL5", "PL6", "PL7", "PL8", "PL9", "PL10", "PL11", "PL12", "PL13", "PL14", "PL15", "PL16", "PL17"};
    public List<string> deckPL;

    void Start()
    {
        // Start is called before the first frame update
        PlayCards();
        Deal();
        PickUpPLCard();
    }

    public static List<string> GenerateDeck() 
    {
        List<string> newDeck = new List<string>();
        foreach (string v in valuesPL)
        {
            newDeck.Add(v);
        }

        return newDeck;
    }

    public void PlayCards()
    {
        deckPL = GenerateDeck();
        Shuffle(deckPL);
        foreach (string card in deckPL)
        {
            print(card);
        }
        //Deal();
    }

    public void PickUpPLCard()
    {
        Debug.Log(deckPL.Count);
        int deckLength = deckPL.Count;
        //This is the last card dealt, it will be added to the back of the deck
        string card = deckPL[0];
        //string card = "OK1";
        switch(card)
        {
            case "PL1":
                Debug.Log("PL1");
                GameObject.Find ("PL1").GetComponent<Selectable>().faceUp = true;
                break;           
            case "PL2":
                Debug.Log("PL2");
                GameObject.Find ("PL2").GetComponent<Selectable>().faceUp = true;
                break;          
            case "PL3":
                Debug.Log("PL3");
                GameObject.Find ("PL3").GetComponent<Selectable>().faceUp = true;
                break;           
            case "PL4":
                Debug.Log("PL4");
                GameObject.Find ("PL4").GetComponent<Selectable>().faceUp = true;
                break;           
            case "PL5":
                Debug.Log("PL5");
                GameObject.Find ("PL5").GetComponent<Selectable>().faceUp = true;
                break;           
            case "PL6":
                Debug.Log("PL6");
                GameObject.Find ("PL6").GetComponent<Selectable>().faceUp = true; 
                break;          
            case "PL7":
                Debug.Log("PL7");
                GameObject.Find ("PL7").GetComponent<Selectable>().faceUp = true; 
                break;          
            case "PL8":
                Debug.Log("PL8"); 
                GameObject.Find ("PL8").GetComponent<Selectable>().faceUp = true; 
                break;         
            case "PL9":
                Debug.Log("PL9"); 
                GameObject.Find ("PL9").GetComponent<Selectable>().faceUp = true;   
                break;       
            case "PL10":
                Debug.Log("PL10");  
                GameObject.Find ("PL10").GetComponent<Selectable>().faceUp = true;
                break;         
            case "PL11":
                Debug.Log("PL11");  
                GameObject.Find ("PL11").GetComponent<Selectable>().faceUp = true;
                break;         
            case "PL12":
                Debug.Log("PL12"); 
                GameObject.Find ("PL12").GetComponent<Selectable>().faceUp = true;
                break;          
            case "PL13":
                Debug.Log("PL13");  
                GameObject.Find ("PL13").GetComponent<Selectable>().faceUp = true; 
                break;        
            case "PL14":
                Debug.Log("PL14"); 
                GameObject.Find ("PL14").GetComponent<Selectable>().faceUp = true;
                break;          
            case "PL15":
                Debug.Log("PL15");
                GameObject.Find ("PL15").GetComponent<Selectable>().faceUp = true;
                break;           
            case "PL16":
                Debug.Log("PL16");
                GameObject.Find ("PL16").GetComponent<Selectable>().faceUp = true;
                break;
            case "PL17":
                Debug.Log("PL17");
                GameObject.Find ("PL17").GetComponent<Selectable>().faceUp = true;
                break;
        }
        deckPL.RemoveAt(0);
        Debug.Log(deckPL.Count);
        deckPL.Add(card);
        Debug.Log(deckPL.Count);
        foreach (string cardy in deckPL)
        {
            print(cardy);
        }
        
        Deal();
    }

    void Shuffle<T>(List<T> list)
    {
        System.Random random = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            int k = random.Next(n);
            n--;
            T temp = list[k];
            list[k] = list[n];
            list[n] = temp;
        }
    }

    void Deal()
    {
        float yOffset = 0;
        float zOffset = 0.03f;
        foreach (string card in deckPL)
        {
            GameObject newCard = Instantiate(cardPrefab, new Vector3(transform.position.x, transform.position.y - yOffset, transform.position.z - zOffset), Quaternion.identity);
            newCard.name = card;
            newCard.GetComponent<Selectable>().faceUp = false;
            

            yOffset = yOffset + 5f;
            zOffset = zOffset + 0.03f;
        }
    }



    // Update is called once per frame
    void Update()
    {
    }

}
