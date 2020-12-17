using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour

{
    public float moveSpeed = 10f;    
        
    

    // Update is called once per frame
    void fixedUpdate()
    {
    	float moveX = Input.GetAxis ("Horizontal");
    	float moveZ = Input.GetAxis ("Vertical");


        //Actual Movement
        Vector3 movement = new  Vector3(moveX,0f,moveZ);
        GetComponent<Rigidbody>().velocity = movement * moveSpeed * Time.deltaTime;
    }
}
