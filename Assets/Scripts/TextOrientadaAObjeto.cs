using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextOrientadaAObjeto : MonoBehaviour {

    public GameObject OrientadaAObjetoText;
    private bool aberto = false;
    	
	// Update is called once per frame
	void Update () {

        if(BauOrientadaAObjeto.OrientadaAObjetosText)
        {
            Invoke("MostrarTexto", 0.3f);
        }
        else if(Input.GetKeyDown(KeyCode.Escape))
        {
            Voltar();
        }		
	}

    void MostrarTexto()
    {
        if (!aberto) {

            OrientadaAObjetoText.SetActive(true);
            Time.timeScale = 0f;
            BauOrientadaAObjeto.OrientadaAObjetosText = false;
            aberto = true;
        }
    }
    void Voltar()
    {
        OrientadaAObjetoText.SetActive(false);
        Time.timeScale = 1f;
    }
}
