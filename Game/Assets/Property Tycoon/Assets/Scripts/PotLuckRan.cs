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
