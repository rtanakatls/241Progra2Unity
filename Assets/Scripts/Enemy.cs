using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody rb;
    private float speed;
    private int life;
    private int damage;
    private int count;
    private EnemyData enemyData;

    void Awake()
    {
        enemyData = Resources.Load<EnemyData>("EnemyData");
        rb = GetComponent<Rigidbody>();
        life = enemyData.Life;
        damage = enemyData.Damage;
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
        rb.velocity = transform.forward * speed * enemyData.Speed;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            enemyData.enemyName = $"Enemy {count}";
            count++;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            life--;
        }
    }
}
