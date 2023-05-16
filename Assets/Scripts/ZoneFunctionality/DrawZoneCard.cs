using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawZoneCard : MonoBehaviour
{
    [SerializeField] private GameObject zoneCardPrefab;
    private int numZoneCards = 1;

    [SerializeField] private Transform zoneDeckSlot;
    public GameObject currentZoneCard;
    public ZoneDeckSlotManager zoneDeckSlotManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DrawZoneCardToSlot()
    {
        numZoneCards++;
        for (int i= 0; i < numZoneCards; i++)
        {

        }
    }
}
