using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OppKnockRan : MonoBehaviour
{
    public Sprite[] cardFaces;
    public GameObject cardPrefab;
    public static string[] values = new string[] {"OK1", "OK2", "OK3", "OK4", "OK5", "OK6", "OK7", "OK8", "OK9", "OK10", "OK11", "OK12", "OK13", "OK14", "OK15", "OK16" };
    public List<string> deck;

    void Start()
    {
        // Start is called before the first frame update
        PlayCards();
        Deal();
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
        foreach (string card in deck)
        {
            print(card);
        }
        //Deal();
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
