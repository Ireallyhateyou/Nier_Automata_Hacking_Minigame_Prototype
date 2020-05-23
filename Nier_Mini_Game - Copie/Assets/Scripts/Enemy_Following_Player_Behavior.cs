using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Following_Player_Behavior : MonoBehaviour
{
    public Rigidbody rb;
    public Transform Target;
    private Vector3 Direction;
    private Vector3 TargetXZ;
    private Vector3 RotateAmount;
    public float RotationSpeed;
    public float Speed;
    private Quaternion Modified_Rotation;
    public GameObject Stop_Area_Around_Player;
    private bool TouchingPlayer = false;
    private void Start() {
        Modified_Rotation = gameObject.transform.rotation;
    }
    void Update()
    {
        if (gameObject.name != "Enemy_Type_1" & TouchingPlayer == false)
        {
          FollowTarget();
        }

    }

    void FollowTarget()
    {
        TargetXZ = new Vector3(Target.position.x, gameObject.transform.position.y, Target.position.z);
        Direction = TargetXZ - rb.position;
        Direction.Normalize();
        RotateAmount = Vector3.Cross(transform.forward, Direction);
        RotateAmount = new Vector3(0, RotateAmount.y, 0);
        rb.angularVelocity = RotateAmount * RotationSpeed;
        Debug.Log(RotateAmount);
        rb.velocity= transform.forward * Speed;
    }
    private void OnTriggerEnter(Collider collider) {
        if (collider.collider.tag == "Player")
        {
            TouchingPlayer = true;
            Debug.Log("touching");
        }
    }
    private void OnTriggerExit(Collider collider) {
        if (collider.collider.tag == "Player")
        {
            TouchingPlayer = false;
            Debug.Log("not touching");
        }
    }
}
