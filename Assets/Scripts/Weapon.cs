using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject shellPrefab;
    public Transform bulletSpawn;
    public Transform shellSpawn;
    public int bulletCount;
    public float bulletVelocity = 30f;
    public float shellVelocity = 1f;
    public float lifeTime = 3f;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.Instance;
        bulletCount = gameManager.bullet;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            if (bulletCount > 0)
            {
                bulletCount -= 1;
                FireWeapon();
            }

        }
    }
 
    private void FireWeapon()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward.normalized * bulletVelocity, ForceMode.Impulse);
        GameObject bulletShell = Instantiate(shellPrefab, shellSpawn.position, Quaternion.identity);
        bulletShell.GetComponent<Rigidbody>().AddForce(shellSpawn.forward.normalized * shellVelocity, ForceMode.Impulse);
 
        DestroyBulletAfterTime(bullet, bulletShell, lifeTime);
 
 
 
    }
 
    private IEnumerator DestroyBulletAfterTime(GameObject bullet, GameObject bulletShell, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(bulletShell);
        Destroy(bullet);
    }
}