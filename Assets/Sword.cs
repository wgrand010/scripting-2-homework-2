using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Sword : Equipment
{
    // Start is called before the first frame update
    public Sword()
        {
        name = "Sword of Swordiness";
        Attack = 10;
        Defense = 5;
        Rarity = ItemRarity.Common;
        Slot = ItemSlot.Hand;
        }
      

}
