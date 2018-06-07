using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public GameObject PainelPause;

    private bool mostrarPause = false;
	
	// Update is called once per frame
	void Update ()
    {
        if (mostrarPause == false && Input.GetKeyDown(KeyCode.Escape))
        {
            Invoke("aparecePause", 0.3f);
        }

        if (mostrarPause == true && Input.GetKeyDown(KeyCode.Escape))
        {
            Voltar();
        }
    }

    void aparecePause()
    {
        if (!mostrarPause)
        {
            PainelPause.SetActive(true);
            mostrarPause = true;
            Time.timeScale = 0f;
        }
    }

    void Voltar()
    {
        PainelPause.SetActive(false);
        mostrarPause = false;
        Time.timeScale = 1f;
    }
}
