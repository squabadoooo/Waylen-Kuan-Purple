using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float yForce;
    private Rigidbody2D enemyRigidBody;

    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (transform.position.x <= -8)
        {
            
        }
        
        if (transform.position.x >= 8)
        {
            
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") 
        {
            Vector2 jumpForce = new Vector2(0, yForce);
            enemyRigidBody.AddForce(jumpForce);
        }
    }
}
