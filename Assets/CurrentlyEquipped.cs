using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemRarity {Common, Rare, Epic, Legendary }
public enum ItemSlot { Hand,Head, leg }
[Serializable]
public class Equipment
{
    public string name;
    public int Attack;
    public int Defense;
    public ItemRarity Rarity;
    public ItemSlot Slot;
}


public class CurrentlyEquipped : MonoBehaviour
{
    public Equipment[] Currently_Equipped = new Equipment[] {new Sword(), new Helmet(), new Larmor(), new Timble()};
    

}
