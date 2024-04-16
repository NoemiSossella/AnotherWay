using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public bool dentroCasa;
    Vector2 movement;


    // Update is called once per frame
    void Update()
    {
        /*if(!Input.GetAxis("Horizontal").Equals(0)){

        }*/

        muoviOrizzontale();
       //movement.x = Input.GetAxis("Horizontal");
       //movement.y = Input.GetAxis("Vertical");
    }
void muoviOrizzontale(){
        //float spostamento = Input.GetAxis("Horizontal");
        if(dentroCasa){            
            Vector3 spostato = new Vector3(Input.GetAxis("Horizontal") , 0 , 0) * moveSpeed * Time.deltaTime;
            transform.Translate(spostato , Space.Self);
        } else {
            Vector3 spostato = new Vector3(Input.GetAxis("Horizontal") , Input.GetAxis("Vertical") , 0) * moveSpeed * Time.deltaTime;
            transform.Translate(spostato , Space.Self);
        }
    }
    void FixedUpdate()
    {
        //rb.MovePosition(rb.position + movement * moveSpeed *Time.fixedDeltaTime);
        //gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position , movement , moveSpeed*Time.deltaTime);
    }
}
