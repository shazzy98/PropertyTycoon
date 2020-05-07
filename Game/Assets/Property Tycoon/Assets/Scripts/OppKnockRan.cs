using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OppKnockRan : MonoBehaviour
{
    public Sprite[] cardFaces;
    public GameObject cardPrefab;
    public GameObject[] bottomPos;
    public GameObject[] topPos;
    public static string[] values = new string[] {"OK1", "OK2", "OK3", "OK4", "OK5", "OK6", "OK7", "OK8", "OK9", "OK10", "OK11", "OK12", "OK13", "OK14", "OK15"};
    public List<string> deck;

    public List<string>[] bottom;
    public List<string>[] tops;

    private List<string> bottom0 = new List<string>();

    void Start()
    {
        // Start is called before the first frame update
        //bottom = new List<string>[]  {bottom0};

        PlayCards();
        Deal();
        PickUpOKCard();

    }

    public static List<string> GenerateDeck() 
    {
        List<string> newDeck = new List<string>();
        foreach (string v in values)
        {
            newDeck.Add(v);
        }

        return newDeck;
    }

    public void PlayCards()
    {
        deck = GenerateDeck();
        Shuffle(deck);

    }

    public void PickUpOKCard()
    {
        Debug.Log(deck.Count);
        int deckLength = deck.Count;
        //This is the last card dealt, it will be added to the back of the deck
        string card = deck[0];
        //string card = "OK1";
        switch(card)
        {
            case "OK1":
                Debug.Log("OK1");
                GameObject.Find ("OK1").GetComponent<Selectable>().faceUp = true;
                break;           
            case "OK2":
                Debug.Log("OK2");
                GameObject.Find ("OK2").GetComponent<Selectable>().faceUp = true;
                break;          
            case "OK3":
                Debug.Log("OK3");
                GameObject.Find ("OK3").GetComponent<Selectable>().faceUp = true;
                break;           
            case "OK4":
                Debug.Log("OK4");
                GameObject.Find ("OK4").GetComponent<Selectable>().faceUp = true;
                break;           
            case "OK5":
                Debug.Log("OK5");
                GameObject.Find ("OK5").GetComponent<Selectable>().faceUp = true;
                break;           
            case "OK6":
                Debug.Log("OK6");
                GameObject.Find ("OK6").GetComponent<Selectable>().faceUp = true; 
                break;          
            case "OK7":
                Debug.Log("OK7");
                GameObject.Find ("OK7").GetComponent<Selectable>().faceUp = true; 
                break;          
            case "OK8":
                Debug.Log("OK8"); 
                GameObject.Find ("OK8").GetComponent<Selectable>().faceUp = true; 
                break;         
            case "OK9":
                Debug.Log("OK9"); 
                GameObject.Find ("OK9").GetComponent<Selectable>().faceUp = true;   
                break;       
            case "OK10":
                Debug.Log("OK10");  
                GameObject.Find ("OK10").GetComponent<Selectable>().faceUp = true;
                break;         
            case "OK11":
                Debug.Log("OK11");  
                GameObject.Find ("OK11").GetComponent<Selectable>().faceUp = true;
                break;         
            case "OK12":
                Debug.Log("OK12"); 
                GameObject.Find ("OK12").GetComponent<Selectable>().faceUp = true;
                break;          
            case "OK13":
                Debug.Log("OK13");  
                GameObject.Find ("OK13").GetComponent<Selectable>().faceUp = true; 
                break;        
            case "OK14":
                Debug.Log("OK14"); 
                GameObject.Find ("OK14").GetComponent<Selectable>().faceUp = true;
                break;          
            case "OK15":
                Debug.Log("OK15");
                GameObject.Find ("OK15").GetComponent<Selectable>().faceUp = true;
                break;           
            case "OK16":
                Debug.Log("OK16");
                GameObject.Find ("OK16").GetComponent<Selectable>().faceUp = true;
                break;
        }
        deck.RemoveAt(0);
        Debug.Log(deck.Count);
        deck.Add(card);
        Debug.Log(deck.Count);
        foreach (string cardy in deck)
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
        foreach (string card in deck)
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
