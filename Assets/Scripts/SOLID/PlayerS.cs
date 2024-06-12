using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerS : MonoBehaviour
{
    [SerializeField] private PlayerStats playerStats;
    private List<IPotion> potionList;

    private void Awake()
    {
        potionList = new List<IPotion>();
        potionList.Add(new HealthPotion());
        potionList.Add(new ManaPotion());
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            potionList[0].UsePotion(playerStats);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            potionList[1].UsePotion(playerStats);
        }
    }


}
