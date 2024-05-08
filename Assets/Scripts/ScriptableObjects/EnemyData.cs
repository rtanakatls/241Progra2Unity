using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "EnemyData", menuName = "Progra2/EnemyData")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private int life;
    [SerializeField] private int damage;
    [SerializeField] private int speed;

    public string enemyName;

    public int Life { get => life; }
    public int Damage { get => damage; }
    public int Speed { get => speed; }

}
