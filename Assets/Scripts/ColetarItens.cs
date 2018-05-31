using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ColetarItens : MonoBehaviour {

    public static int qntChaves;
    private int qntDiamantes;
    public Text qntDiamantestext, qntChavestext;
    
	// Use this for initialization
	void Start () {
        qntDiamantes = 0;
        qntChaves = 0;
	}

    // Update is called once per frame
    void Update ()
    {
        SetcontadorChaves();
        SetcontadorDiamantes();        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "diamante")
        {
            collision.gameObject.SetActive(false);
            qntDiamantes++;
        }
        if (collision.tag == "chave")
        {
            collision.gameObject.SetActive(false);
            qntChaves++;
        }
    }
    void SetcontadorChaves()
    {
        qntChavestext.text = qntChaves.ToString();
    }
    void SetcontadorDiamantes()
    {
        qntDiamantestext.text = qntDiamantes.ToString();
    }
}
