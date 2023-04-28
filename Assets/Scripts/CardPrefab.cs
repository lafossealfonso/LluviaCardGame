using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardPrefab : MonoBehaviour
{
    public TextMeshProUGUI cardName;
    public TextMeshProUGUI cardDescription;
    public TextMeshProUGUI cardATK;
    public TextMeshProUGUI cardDEF;
    public AttackDeck attackDeck;

    public CardObject newAttackCard;
    public GameManager gameManager;

    private void Awake()
    {
        
    }
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        if (gameManager == null)
        {
            Debug.LogError("Game Manager ERROR");
            return;
        }

        attackDeck = FindObjectOfType<AttackDeck>();
        if(attackDeck == null)
        {
            Debug.LogError("Attack Deck ERROR");
            return;
        }

        //grabs the first CardObject and changes the values
        newAttackCard = attackDeck.GetNext();

        if(newAttackCard == null)
        {
            Debug.Log("EmptyDeck");
        }

        else
        {
            cardName.text = newAttackCard.cardName;
            cardDescription.text = newAttackCard.cardDescription;
            cardATK.text = "ATK: " + newAttackCard.cardAtkValue.ToString();
            cardDEF.text = "DEF: " + newAttackCard.cardDefValue.ToString();
            gameManager.currentExcitementValue -= newAttackCard.excitementCostValue;
        }
    }

    private void Update()
    {
        this.name = cardName.text;
    }


}
