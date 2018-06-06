﻿using UnityEngine;
using UnityEngine.UI;

public class BauFuncional : MonoBehaviour
{

    Animator animator;
    public Transform PersonagemChek;
    public LayerMask EhPersonagem;
    public Text Funcionaltext;
    public static bool funcionalText = false;
    private bool bauAberto = false;
    private bool personagemPerto = false;
    private float bauCheckRaio = 0.7f;

    public BauFuncional()
    {
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        personagemPerto = Physics2D.OverlapCircle(PersonagemChek.position, bauCheckRaio, EhPersonagem);
        funcionalText = false;
        if (personagemPerto && Input.GetKeyDown(KeyCode.E) && (ColetarItens.qntChaves > 0))
        {
            DiminuirChaves();
            DefinirTexto();
            animator.SetBool("abrirBau", true);
            funcionalText = true;
            bauAberto = true;
            var audioBau = GetComponent<AudioSource>();
            if (!GetComponent<AudioSource>().isPlaying)
                audioBau.Play();
        }
    }
    protected void DiminuirChaves()
    {
        if (bauAberto == false)
            ColetarItens.qntChaves = ColetarItens.qntChaves - 1;
    }
    void DefinirTexto()
    {
        Funcionaltext.text = "Funcional";
    }
}