using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_Enemy_Projectile : MonoBehaviour
{
    public Rigidbody PurpleProjectile;
    public Rigidbody OrangeProjectile;
    public Transform Target;
    private float timestamp;
    private bool PurpleShot = false;
    public float Time_Between_Shots = 0.3333f;
    public float ProjectileSpeed;
    void Update()
    {
        if (Time.time >= timestamp)
        {
            if (PurpleShot == false)
            {
                Shoot_Purple();
            }
        }
        if (Time.time >= timestamp)
        {
            if (PurpleShot == true)
            {
                Shoot_Orange();
            }
        }

    }
    void Shoot_Purple()
    {
        Rigidbody Projectile = Instantiate(PurpleProjectile, transform.position, transform.rotation);
        Projectile.transform.LookAt(Target);
        Projectile.velocity = transform.forward * ProjectileSpeed;
        PurpleShot = true;
        timestamp = Time.time + Time_Between_Shots;
    }

    void Shoot_Orange()
    {
        Debug.Log("orange");
        Rigidbody Projectile = Instantiate(OrangeProjectile, transform.position, transform.rotation);
        Projectile.transform.LookAt(Target);
        Projectile.velocity = transform.forward * ProjectileSpeed;
        PurpleShot = false;
        timestamp = Time.time + Time_Between_Shots;
    }
}
