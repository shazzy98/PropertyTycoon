using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmartphonePlayer2 : MonoBehaviour 
{
    public Tile startingTile;
    Tile currentTile;
    Tile finalTile;
    Tile[] moveQueue;
    public static int moveQueueIndex;
    
    public DiceManager diceManager;
    public Text valueText;

    Vector3 targetPosition;
    Vector3 velocity;
	
    void Awake()
    {
        finalTile = startingTile;
        targetPosition = this.transform.position;
    }

	
	void Update () 
    {
        if (Vector3.Distance(this.transform.position, targetPosition) > 0.03f)
        {
            this.transform.position = Vector3.SmoothDamp(this.transform.position, targetPosition, ref velocity, 0.2f);
        }
        else
        {
            if (moveQueue != null && moveQueueIndex < moveQueue.Length)
            {
                Tile nextTile = moveQueue[moveQueueIndex];
                SetNewTargetPosition(nextTile.transform.position);
                moveQueueIndex++;
            }
        }
	}

    void SetNewTargetPosition(Vector3 pos)
    {
        targetPosition = pos;
        velocity = Vector3.zero;
    }

    public void MovePlayerToken()
    {
        int spacesToMove = diceManager.totalValue;
        valueText.text = "Value: " + spacesToMove.ToString();

        if (spacesToMove == 0)
        {
            return;
        }

        moveQueue = new Tile[spacesToMove];

        for (int i = 0; i < spacesToMove; i++)
        {
            finalTile = finalTile.nextTile;
            moveQueue[i] = finalTile;
        }
        moveQueueIndex = 0;
    }


  
   
}