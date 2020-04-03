using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //DiceManager = this;
        //DiceManager.RollAllDie();
        DiceManager example = new DiceManager();
        example.RollAllDie();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
