using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;


    // Update is called once per frame
    void Update()
    {
       movement.x = Input.GetAxis("Horizontal");
       movement.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed *Time.fixedDeltaTime);
        //gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position , movement , moveSpeed*Time.deltaTime);
    }
}
