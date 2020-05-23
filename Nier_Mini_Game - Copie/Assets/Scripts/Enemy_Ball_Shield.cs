using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Ball_Shield : MonoBehaviour
{
    public GameObject[] Enemy;
    public GameObject Target;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        FollowTarget();
        Enemy = GameObject.FindGameObjectsWithTag("Enemy");
        if (Enemy.Length == 0)
        {
            AutoDestruct();
        }
    }
    void AutoDestruct()
    {
        Destroy(gameObject);
    }
    void FollowTarget()
    {
        transform.position = Target.transform.position;
    }
}
