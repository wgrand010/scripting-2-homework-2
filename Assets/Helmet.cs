using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helmet : Equipment
{
    public Helmet()
    {
        name = "Helmet, Just a Helmet";
        Attack = 1;
        Defense = 15;
        Rarity = ItemRarity.Rare;
        Slot = ItemSlot.Head;
    }
}
