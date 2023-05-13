using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaPortal : MonoBehaviour {

    Animator animator;
    private bool portal = false;

    // Use this for initialization
    void Start () {

        animator = GetComponent<Animator>();
		
	}	
	// Update is called once per frame
	void Update () {

        if(BauOrientadaAObjeto.bauOrientadaObjetoAberto && BauLogica.bauLogicaAberto && BauFuncional.bauFuncionalAberto && BauImperativo.bauImperativoAberto)
        {
            Invoke("ativarPlataforma", 1f);
        }
    }

    void ativarPlataforma()
    {
        portal = true;
        animator.SetBool("Portal", portal);
    }

}
