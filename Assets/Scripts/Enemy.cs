using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody rb;
    private float speed;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        GameManager.Instance.OnProgressionChanged += Execute;        
    }

    private void Execute(int value)
    {
        speed = value;
    }

    void Update()
    {
        rb.velocity = transform.forward * speed;
    }
}
