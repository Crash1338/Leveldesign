using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offOnSwitch : MonoBehaviour {

    public GameObject butMid;
    public GameObject butLeft;
    public GameObject butRight;
    public GameObject particleDoor;
    public AudioSource buttonSound;
    public AudioSource doorSound;

    private int buttons = 3;
    private int buttonCount = 0;
    private bool mid = false, left = false, right = false;

	// Use this for initialization
	void Start ()
    {   
        
	}

    void PlaySound()
    {
        if (buttonCount < buttons)
        {
            buttonSound.Play();
        }
        else
        {
            doorSound.Play();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "magicCircleMid" && mid == false)
        {
            butMid.SetActive(false);
            mid = true;
            buttonCount++;
            PlaySound();
        }

        if (other.gameObject.name == "magicCircleLeft" && left == false)
        {
            butLeft.SetActive(false);
            left = true;
            buttonCount++;
            PlaySound();
        }

        if (other.gameObject.name == "magicCircleRight" && right == false)
        {
            butRight.SetActive(false);
            right = true;
            buttonCount++;
            PlaySound();
        }
    }

        // Update is called once per frame
        void FixedUpdate ()
    {   
        if (buttonCount == buttons)
        {
            particleDoor.SetActive(true);
        }
    }
}
