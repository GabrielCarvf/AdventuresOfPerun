using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaPortal : MonoBehaviour {

    Animator animator;
    private bool portal = false;
    public GameObject collider1, collider2;

    // Use this for initialization
    void Start () {

        animator = GetComponent<Animator>();
		
	}	
	// Update is called once per frame
	void Update () {

        if(BauOrientadaAObjeto.bauOrientadaObjetoAberto && BauLogica.bauLogicaAberto && BauFuncional.bauFuncionalAberto && BauImperativo.bauImperativoAberto)
        {
            portal = true;
            animator.SetBool("Portal", portal);
            collider1.SetActive(true);
            collider2.SetActive(true);
        }

    }
}
