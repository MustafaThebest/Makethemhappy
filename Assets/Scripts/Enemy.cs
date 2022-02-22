using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private float killReward;
    public static Action<float> OnEnemyKill;
    public void SetHealth(int hp)
    {
        health += hp;
        CheckHealth();
    }

    public void CheckHealth()
    {
        if (health <= 0)
        {
            OnEnemyKill?.Invoke(killReward);
            
            Destroy(gameObject);
        }
        else if (health > 100)
        {
            health = 100;
        }
    }
}
