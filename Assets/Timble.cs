using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timble : Equipment
{ 
    public Timble()
    {
        name = "Timble";
        Attack = 69;
        Defense = 420;
        Rarity = ItemRarity.Legendary;
        Slot = ItemSlot.Hand;
    }
}
