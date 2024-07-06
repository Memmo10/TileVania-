using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    Rigidbody2D myRigidBody2D;
    BoxCollider2D myBoxCollider2D;
    void Start()
    {
        myRigidBody2D= GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        myRigidBody2D.velocity = new Vector2 (moveSpeed, 0f);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        moveSpeed = -moveSpeed;
        FlipSpriteFacing();
    }

    void FlipSpriteFacing ()
    {
        transform.localScale = new Vector2(-(Mathf.Sign(myRigidBody2D.velocity.x)), 1f);
    }
}
