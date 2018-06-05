using UnityEngine;
using UnityEngine.UI;

public class BauOrientadaAObjeto : MonoBehaviour
{

    Animator animator;
    public Transform PersonagemChek;
    public LayerMask EhPersonagem;
    public Text OrientadaAObjetotext;
    public static bool OrientadaAObjetosText = false;
    private bool bauAberto = false;
    private bool personagemPerto = false;
    private float bauCheckRaio = 0.7f;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        personagemPerto = Physics2D.OverlapCircle(PersonagemChek.position, bauCheckRaio, EhPersonagem);
        OrientadaAObjetosText = false;
        if (personagemPerto && Input.GetKeyDown(KeyCode.E) && (ColetarItens.qntChaves > 0))
        {
            DiminuirChaves();
            DefinirTexto();
            animator.SetBool("abrirBau", true);
            OrientadaAObjetosText = true;
            var audioBau = GetComponent<AudioSource>();
            if (!GetComponent<AudioSource>().isPlaying)
                audioBau.Play();
            bauAberto = true;
        }
    }
    protected void DiminuirChaves()
    {
        if (bauAberto == false)
            ColetarItens.qntChaves = ColetarItens.qntChaves - 1;
    }
    void DefinirTexto()
    {
        OrientadaAObjetotext.text = "Orientada a Objeto";
    }
}