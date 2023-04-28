using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InstantiateCard : MonoBehaviour
{
    public GameObject cardPrefab;
    public Transform locationSlot;
    public AttackDeck attackDeck;

    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        



    }

    public void DrawCard()
    {
        //instantiates a card to location slot
        GameObject newCard = Instantiate(cardPrefab, locationSlot.transform);
    }
}
