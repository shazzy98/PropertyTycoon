using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public int PlayerTurn = 1;
    public void PlayerTurnGame()
    {
        GameObject.Find ("Boot (Tag 'Player')").GetComponent<BootPlayer>().MovePlayerToken();
        /*switch(PlayerTurn)
        {
            case 1:
                GameObject.Find ("Boot (Tag 'Player')").GetComponent<BootPlayer>().MovePlayerToken();
                PlayerTurn += 1;
                break;
            case 2:
                GameObject.Find ("Boot (Tag 'Player')").GetComponent<SmartphonePlayer2>().MovePlayerToken();
                PlayerTurn += 1;
                break;
            case 3:
                GameObject.Find ("Boot (Tag 'Player')").GetComponent<GobletPlayer3>().MovePlayerToken();
                PlayerTurn += 1;
                break;
            case 4:
                GameObject.Find ("Boot (Tag 'Player')").GetComponent<HatstandPlayer4>().MovePlayerToken();
                PlayerTurn += 1;
                break;
            case 5:
                GameObject.Find ("Boot (Tag 'Player')").GetComponent<CatPlayer5>().MovePlayerToken();
                PlayerTurn += 1;
                break;
            case 6:
                GameObject.Find ("Boot (Tag 'Player')").GetComponent<SpoonPlayer6>().MovePlayerToken();
                PlayerTurn += 1;
                break;
            case 7:
                PlayerTurn = 1;
                break;

        }
        */
    }
}

