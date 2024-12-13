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
    public float bulletVelocity = 30f;
    public float shellVelocity = 1f;
    public float lifeTime = 3f;
 
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            FireWeapon();
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