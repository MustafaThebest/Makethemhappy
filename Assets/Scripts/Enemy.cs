using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float health;

    public void SetHealth(int hp)
    {
        health += hp;
        CheckHealth();
    }

    public void CheckHealth()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        else if (health > 100)
        {
            health = 100;
        }
    }
}
