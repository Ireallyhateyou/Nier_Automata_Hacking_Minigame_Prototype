using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Audio;

public class Enemy_Life : MonoBehaviour
{
    public int Life = 3;
    public AudioSource DeathSound;
    public AudioSource HitSound;


    void Update()
    {
        if (Life < 0)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter(Collider collider) {
        if (collider.tag == "Player_Projectile")
        {
            Life -= 1;
            HitSound.Play();
        }
    }
    private void OnDestroy() {
        Debug.Log("fff");

    }

 
}
