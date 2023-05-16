using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ZoneCardPrefab : MonoBehaviour
{
    public TextMeshProUGUI zoneCardName;
    public TextMeshProUGUI zoneCardDescription;
    public ZoneDeckManager zoneDeckManager;

    public ZoneCardObject newZoneCardObject;
    public GameManager gameManager;

    private void Start()
    {
        zoneDeckManager = FindObjectOfType<ZoneDeckManager>();
        if(zoneDeckManager == null)
        {
            Debug.LogError("Zone Deck Missing");
        }

        newZoneCardObject = zoneDeckManager.GetNextZoneCard();
    }
}
