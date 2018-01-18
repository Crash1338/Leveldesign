using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

    public GameObject player;
    public float turnspeed;
    public Vector3 offset;

    void Start ()
    {
        
    }

    void LateUpdate () {

        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform.position);

    }
}
