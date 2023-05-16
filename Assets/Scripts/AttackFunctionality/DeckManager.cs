using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public List<CardObject> cards;
    private int currentIndex;
    public string nextCardName;
    [SerializeField] int deckCount = 15;
   

    

    // Start is called before the first frame update
    void Start()
    {
        while(cards.Count < deckCount)
        {
            DuplicateRandomCard();
        }


        Shuffle(cards);
        foreach (CardObject card in cards)
        {
            Debug.Log(card);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public CardObject GetNext()
    {

        // Get the next item in the list
        CardObject nextCard = cards[currentIndex];

        // Increment the current index so we get a different item next time
        currentIndex++;

        if (currentIndex < 0)
        {
            return null;
        }

        else
        {
            nextCardName = nextCard.name;

            // Return the next item
            return nextCard;
        }



        // Return the next item


    }



    public static void Shuffle(List<CardObject> list)
    {
        int currentIndex = list.Count;

        while (currentIndex > 1)
        {
            currentIndex--;

            int randomIndex = Random.Range(0, currentIndex + 1);

            CardObject currentItem = list[currentIndex];
            CardObject randomItem = list[randomIndex];

            list[currentIndex] = randomItem;
            list[randomIndex] = currentItem;
        }
    }

    public void DuplicateRandomCard()
    {
        int randomIndex = Random.Range(0, cards.Count);

        CardObject itemToDuplicate = cards[randomIndex];
        cards.Insert(randomIndex, itemToDuplicate);
    }


}
