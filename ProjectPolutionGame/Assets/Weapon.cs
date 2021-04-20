using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public AudioSource effect;
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
    }

    void Shoot()
    {
        //shooting logic
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        effect.Play();
    }
}
