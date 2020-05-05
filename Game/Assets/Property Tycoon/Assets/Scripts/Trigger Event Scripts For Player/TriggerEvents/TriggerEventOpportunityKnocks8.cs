using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEventOpportunityKnocks8 : MonoBehaviour
{
    float timer = 0;
    int cardPulled = 0;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            //Debug.Log("Player Moved to Opportunity Knocks");
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player Moved to Opportunity Knocks");
                cardPulled = 0;
                if (cardPulled == 1);
                {
                    GameObject.Find ("ShuffleDeckOK").GetComponent<OppKnockRan>().PickUpOKCard();
                }
            }
        }
        if (other.CompareTag ("Player2"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player2 Moved to Opportunity Knocks");
                GameObject.Find ("ShuffleDeckOK").GetComponent<OppKnockRan>().PickUpOKCard();
            }
        }
        if (other.CompareTag ("Player3"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player3 Moved to Opportunity Knocks");
                GameObject.Find ("ShuffleDeckOK").GetComponent<OppKnockRan>().PickUpOKCard();
            }
        }
        if (other.CompareTag ("Player4"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player4 Moved to Opportunity Knocks");
                GameObject.Find ("ShuffleDeckOK").GetComponent<OppKnockRan>().PickUpOKCard();
            }
            
        }
        if (other.CompareTag ("Player5"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player5 Moved to Opportunity Knocks");
                GameObject.Find ("ShuffleDeckOK").GetComponent<OppKnockRan>().PickUpOKCard();
            }
        }
        if (other.CompareTag ("Player6"))
        {
            if ((timer > 1) && timer <1.1)
            {
                Debug.Log("Player6 Moved to Opportunity Knocks");
                GameObject.Find ("ShuffleDeckOK").GetComponent<OppKnockRan>().PickUpOKCard();
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