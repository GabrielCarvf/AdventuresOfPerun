using UnityEngine;
using UnityEngine.UI;

public class BauOrientadaAObjeto : MonoBehaviour
{

    Animator animator;
    public Transform PersonagemChek;
    public LayerMask EhPersonagem;
    public Text OrientadaAObjetotext;
    public static bool bauOrientadaObjetoAberto = false;
    public static bool OrientadaAObjetoText = false;
    private bool bauAberto = false;
    private bool personagemPerto = false;
    private float bauCheckRaio = 0.7f;

    private void Start()
    {
        personagemPerto = false;
        bauAberto = false;
        OrientadaAObjetoText = false;
        bauOrientadaObjetoAberto = false;
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        personagemPerto = Physics2D.OverlapCircle(PersonagemChek.position, bauCheckRaio, EhPersonagem);
        OrientadaAObjetoText = false;
        if (personagemPerto && Input.GetKeyDown(KeyCode.E) && (ColetarItens.qntChaves > 0) && !bauAberto)
        {
            DiminuirChaves();
            animator.SetBool("abrirBau", true);
            OrientadaAObjetoText = true;
            var audioBau = GetComponent<AudioSource>();
            if (!GetComponent<AudioSource>().isPlaying)
                audioBau.Play();
            bauAberto = true;
            bauOrientadaObjetoAberto = true;
        }
    }
    protected void DiminuirChaves()
    {
        if (bauAberto == false)
            ColetarItens.qntChaves = ColetarItens.qntChaves - 1;
    }
}