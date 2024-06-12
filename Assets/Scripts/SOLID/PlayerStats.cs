using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class PlayerStats 
{
    [SerializeField] private int health;
    [SerializeField] private int mana;

    public void TakeManaPotion(int value)
    {
        mana += value;
    }

    public void TakeHealthPotion(int value)
    {
        health += value;
    }

}
