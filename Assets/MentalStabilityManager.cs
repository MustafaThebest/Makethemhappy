using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentalStabilityManager : MonoBehaviour
{
    [SerializeField] private float mentalHealth;
    [SerializeField] private float decreasingRate;

    private void Start() {
        Enemy.OnEnemyKill += SetHealth;
    }

    private void Update()
    {
        DecreaseHealth();
        CheckHealth();
    }

    public float GetHealth()
    {
        return mentalHealth;
    }

    public void SetHealth(float health)
    {
        mentalHealth += health;
    }

    public void CheckHealth()
    {
        if (mentalHealth <= 0)
        {
            Debug.Log("GameOver!");
        }
        else if (mentalHealth > 100)
        {
            mentalHealth = 100;
        }
    }

    private void DecreaseHealth()
    {
        mentalHealth -= decreasingRate;
    }
}
