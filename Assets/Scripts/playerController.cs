using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public float ballSpeed;
    public int jumpPower;
    public Transform Kamara;
    public GameObject PlayerContainer;

    private Rigidbody body;
    private int jump;
    private bool InAir = false;
    

    // Use this for initialization
    void Start ()
    {
        body = GetComponent<Rigidbody>();    
               
    }

    //"Grounded" -> Jump possible? 
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Untagged" && InAir == true)
        {
            InAir = false;
        }
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Untagged" && InAir == true)
        {
            InAir = false;
        }
    }

    void OnCollisionExit(Collision other)
    {
        InAir = true;
    }


    //Move it

    void FixedUpdate()
    {
        float xSpeed = Input.GetAxis("Horizontal");
        float ySpeed = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump") && InAir==false)
        {
            jump = jumpPower;            
        }

        else
        {
            jump = 0;
        }

        
        Vector3 cam = new Vector3(0, Kamara.transform.eulerAngles.y, 0);
        
        Quaternion rot = Quaternion.Euler(cam);              

        Vector3 movement = new Vector3(xSpeed, jump, ySpeed);

        Vector3 rotatedMove = rot * movement;
        

        body.AddForce (rotatedMove * ballSpeed * Time.deltaTime);
        
    } 
	
}
