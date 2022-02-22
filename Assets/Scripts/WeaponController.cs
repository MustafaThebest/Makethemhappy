using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] private Bullet bulletPrefab;
    [SerializeField] private Transform firepoint;
    [SerializeField] private float fireRate;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float bulletDestroyTime;

    private bool isShooting;
    void Start()
    {

    }


    void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetButton("Fire1") && !isShooting)
        {
            StartCoroutine(ShootCoroutine());
        }
    }
    private IEnumerator ShootCoroutine()
    {
        isShooting = true;
        yield return new WaitForSeconds(fireRate);
        //without bulletprefab.gameobject script can cause errors
        Bullet bulletPrefab = Instantiate(this.bulletPrefab, firepoint.position, firepoint.rotation);
        bulletPrefab.SetBullet(transform.right, bulletSpeed, bulletDestroyTime);
        bulletPrefab.LaunchBullet();
        isShooting = false;
    }


}
