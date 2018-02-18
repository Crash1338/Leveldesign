using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour {

    public Image startScreen;
    public Image endScreen;
    public Image creditScreen;
    public GameObject particleDoor; 

    private bool start = true, ende = false;

    void Start()
    {
        endScreen.canvasRenderer.SetAlpha(0f);
        creditScreen.canvasRenderer.SetAlpha(0f);
    }



    void FixedUpdate()
    {
        if (start == true && Input.anyKeyDown)
        {
            FadeIn();
            start = false;
        }

        if (ende == true && Input.anyKeyDown)
        {            
            Credits();            
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "magicCircle_finish" && particleDoor.activeSelf == true)
        {
            FadeOut();
        }
    }

    public void FadeIn()
    {
        startScreen.CrossFadeAlpha(0, 3, false);
    }

    public void FadeOut()
    {
        endScreen.CrossFadeAlpha(1, 2, false);
        ende = true;
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeAll;
    }

    public void Credits()
    {
        creditScreen.CrossFadeAlpha(1, 1, false);
    }

}
