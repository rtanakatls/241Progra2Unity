using GameJolt.API;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public event Action<int> OnProgressionChanged;
    private int progression;
    private float elapsedTime;
    public static GameManager Instance { get => instance; }

    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if(elapsedTime >= 10)
        {
            Trophies.TryUnlock(233077, (trophyResult) =>
            {
                SceneManager.LoadScene("GameOverScene");
            });
            
        }
        if (elapsedTime > progression*5)
        {
            progression++;
            OnProgressionChanged?.Invoke(progression);
        }
    }
}
