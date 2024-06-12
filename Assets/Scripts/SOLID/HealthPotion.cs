using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : IPotion
{
    public void UsePotion(PlayerStats playerStats)
    {
        playerStats.TakeHealthPotion(50);
    }
}

