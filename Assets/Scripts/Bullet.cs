using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private float speed;
    [SerializeField] private Vector2 direction;
    [SerializeField] private float destroyTime;
    [SerializeField] private int damage;

    public void SetBullet(Vector2 bulletDirection, float bulletSpeed, float bulletDestroyTime, int bulletDamage)
    {
        speed = bulletSpeed;
        direction = bulletDirection;
        destroyTime = bulletDestroyTime;
        damage = bulletDamage;
    }
    public void LaunchBullet()
    {
        //bullets launch only in one way, fix later
        rb2d.AddForce(direction * speed);
        
        StartCoroutine(SelfDestroyCoroutine());
    }

    private IEnumerator SelfDestroyCoroutine()
    {
        yield return new WaitForSeconds(destroyTime);

        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Enemy enemy = other?.GetComponent<Enemy>();
        if(enemy)
        {
            enemy.SetHealth(damage);
            Destroy(gameObject);
        }
    }
}
