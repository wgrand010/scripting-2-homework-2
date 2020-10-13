using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Larmor : Equipment
{
    public Larmor()
    {
        name = "Larmor (Leg Armor)";
        Attack = 3;
        Defense = 20;
        Rarity = ItemRarity.Epic;
        Slot = ItemSlot.leg;
    }
}
