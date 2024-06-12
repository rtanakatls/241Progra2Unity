using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaPotion : IPotion
{
    public void UsePotion(PlayerStats playerStats)
    {
        playerStats.TakeManaPotion(50);
    }
}
