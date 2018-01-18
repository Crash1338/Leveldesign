using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public float ballSpeed;
    private Rigidbody body;
    

   
    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float xSpeed = Input.GetAxis("Horizontal");
        float ySpeed = Input.GetAxis("Vertical");
             
        
        body.AddForce (new Vector3(xSpeed, 0, ySpeed) * ballSpeed * Time.deltaTime);
    } 
	
}
