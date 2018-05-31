using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour {

    public Animator animator;
	
	// Update is called once per frame
	void Update () {

        if (Heroi.fadeOut)
        {
            FadeOutOn();
        }		
	}

    public void FadeOutOn()
    {
        animator.SetTrigger("FadeOut");
    }
}
