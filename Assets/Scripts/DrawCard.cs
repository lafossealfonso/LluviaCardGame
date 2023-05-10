using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCard : MonoBehaviour
{
    [SerializeField] private GameObject cardPrefab;
    public int numCards = 2;

    [SerializeField] private Transform deckSlot;
    public GameObject currentCard;
    public DeckSlotManager deckSlotManager;

    private int cardsToDraw = 0;

    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        while (i < numCards)
        {
            if (deckSlotManager.readyToReceiveCard == true)
            {
                //instantiates card for every number in numCards.
                GameObject card = Instantiate(cardPrefab, deckSlot);
                currentCard = card;
                deckSlotManager.SendCardToFreeSlot();
                i++;
            }
            else if (i == 0)
            {
                numCards = 0;
            }
        }
    }

        /*for (int i = 0; i < numCards; i++)
        {
            if (deckSlotManager.readyToReceiveCard == true)
            {
                //instantiates card for every number in numCards.
                GameObject card = Instantiate(cardPrefab, deckSlot);
                currentCard = card;
                deckSlotManager.SendCardToFreeSlot();
            }

            else if(i == 0)
            {
                numCards = 0;
            }

        }
        */



    


    // Update is called once per frame
    void FixedUpdate()
    {

    }

    public void DrawCardToHand()
    {
        numCards++;

        for (int i = 0; i < numCards; i++)
        {
            if (deckSlotManager.readyToReceiveCard == true)
            {
                //instantiates card for every number in numCards.
                GameObject card = Instantiate(cardPrefab, deckSlot);
                currentCard = card;
                deckSlotManager.SendCardToFreeSlot();
            }

            else if (i == 0)
            {
                numCards = 0;
            }

        }

        numCards = 0;
    }
}
