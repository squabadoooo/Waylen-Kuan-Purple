using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody u;

    float jumpForce = 5.7f;

    public bool isGrounded;

    float fallmultiplier = 1.5f;

    void Start()
    {
        u = GetComponent<Rigidbody>();
    }

    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, .15f);
        Debug.DrawRay(transform.position, Vector3.down * .15f, Color.red);
        
        if(Input.GetButtonDown("Jump") && isGrounded){
            u.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if(u.velocity.y < 0){
            u.velocity += Physics.gravity * fallmultiplier * Time.deltaTime;
        }
    }
}

