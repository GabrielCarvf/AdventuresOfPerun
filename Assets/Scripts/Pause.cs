using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public GameObject pause;

    private bool mostrarPause = false;
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Invoke("aparecePause", 0.3f);
        }

        else if (mostrarPause == true && Input.GetKeyDown(KeyCode.Escape))
        {
            Voltar();
        }
    }

    void aparecePause()
    {
        if(!mostrarPause)
        {
            pause.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    void Voltar()
    {
        pause.SetActive(false);
        Time.timeScale = 1f;
    }
}
