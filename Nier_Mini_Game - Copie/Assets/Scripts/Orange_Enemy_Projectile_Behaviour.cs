using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange_Enemy_Projectile_Behaviour : MonoBehaviour
{
    public float Time_Before_Destruction;
    private void Start() {
        if (gameObject.name != "Orange_Enemy_Projectile")
        {
            Autodestruct();
        }
    }

    private void OnTriggerEnter(Collider collider) {
        if (collider.tag == "Player_Projectile")
        {
            Debug.Log("Player_Projectile");
            Destroy(gameObject);
        }

        if (collider.tag == "Player")
        {
            Debug.Log("Player");
            Destroy(gameObject);
        }
    }

    public void Autodestruct()
    {
        Destroy(gameObject, Time_Before_Destruction);  
    }
}
