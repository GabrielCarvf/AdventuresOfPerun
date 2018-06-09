using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDiamante : MonoBehaviour {
	
	// Update is called once per frame
	void Update ()
    {
        if(ColetarItens.coletouDiamante)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            ColetarItens.coletouDiamante = false;
        }
	}
}
