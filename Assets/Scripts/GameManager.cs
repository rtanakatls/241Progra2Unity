using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (elapsedTime > progression*5)
        {
            progression++;
            OnProgressionChanged?.Invoke(progression);
        }
    }
}
