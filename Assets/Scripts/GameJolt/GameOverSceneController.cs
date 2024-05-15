using GameJolt.UI;
using GameJolt.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Trophies.TryUnlock(233078,(trophyResult)=>
        {
            GameJoltUI.Instance.ShowTrophies();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
