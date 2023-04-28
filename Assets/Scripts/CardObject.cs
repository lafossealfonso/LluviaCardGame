using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Card", menuName = "Card")]

public class CardObject : ScriptableObject
{
    public string cardName;
    public string cardDescription;
    public Image cardImage; 
    public int cardAtkValue;
    public int cardDefValue;
    public int excitementCostValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
