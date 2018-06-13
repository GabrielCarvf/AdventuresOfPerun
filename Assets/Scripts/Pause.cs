﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public GameObject PainelPause;
    public GameObject MostarImperativa;
    public GameObject MostrarOO;
    public GameObject MostrarFuncional;
    public GameObject MostrarLogica;

    public static bool mostrarPause = false;
    private bool mostrarImperativa = false;
    private bool mostrarOO = false;
    private bool mostrarFuncional = false;
    private bool mostrarLogica = false;

    private void Start()
    {
        mostrarPause = false;
    }

    // Update is called once per frame
    void Update ()
    {
        if (mostrarPause == false && Input.GetKeyDown(KeyCode.P))
        {
            Invoke("aparecePause", 0.3f);
        }

        if (mostrarPause == true && Input.GetKeyDown(KeyCode.P))
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

    public void aparecerImperativa()
    {
        MostarImperativa.SetActive(true);
        mostrarImperativa = true;
        Time.timeScale = 0f;
    }

    public void aparecerOrientadaaObjeto()
    {
        MostrarOO.SetActive(true);
        mostrarOO = true;
        Time.timeScale = 0f;
    }

    public void aparecerFuncional()
    {
        MostrarFuncional.SetActive(true);
        mostrarFuncional = true;
        Time.timeScale = 0f;
    }

    public void aparecerLogica()
    {
        MostrarLogica.SetActive(true);
        mostrarLogica = true;
        Time.timeScale = 0f;
    }

    void Voltar()
    {
        PainelPause.SetActive(false);
        mostrarPause = false;
        Time.timeScale = 1f;
    }
}
