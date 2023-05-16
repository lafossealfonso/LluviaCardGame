using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneDeckManager : MonoBehaviour
{
    public List<ZoneCardObject> zoneCards;
    private int currentIndex;
    public string nextCardName;




    // Start is called before the first frame update
    void Start()
    {
        ShuffleZoneDeck(zoneCards);
        foreach (ZoneCardObject card in zoneCards)
        {
            Debug.Log(card);
        }


    }

    public ZoneCardObject GetNextZoneCard()
    {

        // Get the next item in the list
        ZoneCardObject nextCard = zoneCards[currentIndex];

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



    public static void ShuffleZoneDeck(List<ZoneCardObject> list)
    {
        int currentIndex = list.Count;

        while (currentIndex > 1)
        {
            currentIndex--;

            int randomIndex = Random.Range(0, currentIndex + 1);

            ZoneCardObject currentItem = list[currentIndex];
            ZoneCardObject randomItem = list[randomIndex];

            list[currentIndex] = randomItem;
            list[randomIndex] = currentItem;
        }
    }
}
