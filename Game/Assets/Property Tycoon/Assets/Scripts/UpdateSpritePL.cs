﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateSpritePL : MonoBehaviour
{
    public Sprite cardFace;
    public Sprite cardBack;
    private SpriteRenderer spriteRenderer;
    private Selectable selectable;
    private PotLuckRan PotLuckRan;

    // Start is called before the first frame update
    void Start()
    {
        List<string> deck = PotLuckRan.GenerateDeck();
        PotLuckRan = FindObjectOfType<PotLuckRan>();

        int i = 0;
        foreach (string card in deck)
        {
            if (this.name == card)
            {
                cardFace = PotLuckRan.cardFaces[i];
                break;
            }
            i++;
        }
        spriteRenderer = GetComponent<SpriteRenderer>();
        selectable = GetComponent<Selectable>();

    }

    // Update is called once per frame
    void Update()
    {
        if (selectable.faceUp == true)
        {
            spriteRenderer.sprite = cardFace;
        }
        else
        {
            spriteRenderer.sprite = cardBack;
        }
    }
}
