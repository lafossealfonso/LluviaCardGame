using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Zone Card", menuName = "Zone Card")]

public class ZoneCardObject : ScriptableObject
{
    public string zoneCardName;
    public Image zoneCardImage;
    public zoneCardType zoneCardType = zoneCardType.Monster;
    public string zoneCardDesc;
    public int itemValue;
}

public enum zoneCardType { Monster, Rubbish, Item, Equipment, Weapon }
