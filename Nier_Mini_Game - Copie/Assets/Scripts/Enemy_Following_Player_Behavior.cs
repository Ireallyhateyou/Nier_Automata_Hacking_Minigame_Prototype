using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Following_Player_Behavior : MonoBehaviour
{
    public Rigidbody rb;
    public Transform Target;
    private Vector3 Direction;
    private Vector3 RotateAmount;
    public float RotationSpeed;
    public float Speed;
    void Update()
    {
        if (gameObject.name != "Enemy_Type_1")
        {
          FollowTarget();
        }
    }

    void FollowTarget()
    {
        Direction = Target.position - rb.position;
        Direction.Normalize();
        RotateAmount = Vector3.Cross(transform.forward, Direction);
        rb.angularVelocity = RotateAmount * RotationSpeed;
        rb.velocity= transform.forward * Speed;
    }
}
