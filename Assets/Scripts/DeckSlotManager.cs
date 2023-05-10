using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeckSlotManager : MonoBehaviour
{
    public DrawCard drawCardScript;

    [SerializeField] private float lerpSpeed;

    public List<RectTransform> freeCardSlots;
    public List<RectTransform> busyCardSlots;

    private RectTransform currentFreeDeckSlot;

    public RectTransform deckSlot1;
    public RectTransform deckSlot2;
    public RectTransform deckSlot3;
    public RectTransform deckSlot4;

    private RectTransform currentCardTransform;

    private float lerpDuration = 1f;
    private float lerpTimer;

    public bool readyToReceiveCard = true;

    [SerializeField] Button deckButton;

    private void Awake()
    {
        freeCardSlots.Add(deckSlot1);  
        freeCardSlots.Add(deckSlot2);  
        freeCardSlots.Add(deckSlot3);  
        freeCardSlots.Add(deckSlot4);  
    }
    private void Update()
    {
        
        if (freeCardSlots.Count == 0)
        {
            readyToReceiveCard = false;
        }
    }
    public void StartLerp()
    {
        lerpTimer = 0f;
        StartCoroutine(LerpCard());
    }

    private IEnumerator LerpCard()
    {
        //starts the timer
        while (lerpTimer < lerpDuration)
        {
            float t = lerpTimer / lerpDuration;
            //lerps the card to the free slot
            currentCardTransform.position = Vector2.Lerp(currentCardTransform.position, currentFreeDeckSlot.position, t);
            lerpTimer += Time.deltaTime;
            
            yield return null;
        }
        //Adds the free slot to the busy deck slot list
        busyCardSlots.Add(currentFreeDeckSlot);
        //resets the bool KEEP HERE (i think)
        readyToReceiveCard = true;


    }
    //called by draw card by DrawCardToHand()
    public void SendCardToFreeSlot()
    {
        //receives the current card's transform, removes the free slot from the free lot list, triggers Lerp
        readyToReceiveCard = false;
        RectTransform rectTransform = freeCardSlots[0].GetComponent<RectTransform>();
        freeCardSlots.Remove(freeCardSlots[0]);
        currentFreeDeckSlot = rectTransform;
        currentCardTransform = drawCardScript.currentCard.GetComponent<RectTransform>();

        StartLerp();
        

    }
}
