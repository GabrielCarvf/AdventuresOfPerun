using UnityEngine;
using UnityEngine.UI;

public class BauLogica : MonoBehaviour
{

    Animator animator;
    public Transform PersonagemChek;
    public LayerMask EhPersonagem;
    public Text Logicatext;
    public static bool logicaText = false;
    public static bool bauLogicaAberto = false;
    private bool bauAberto = false;
    private bool personagemPerto = false;
    private float bauCheckRaio = 0.7f;

    private void Start()
    {
        personagemPerto = false;
        bauAberto = false;
        bauLogicaAberto = false;
        logicaText = false;
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        personagemPerto = Physics2D.OverlapCircle(PersonagemChek.position, bauCheckRaio, EhPersonagem);
        logicaText = false;

        if (personagemPerto && Input.GetKeyDown(KeyCode.E) && (ColetarItens.qntChaves > 0) && !bauAberto)
        {
            DiminuirChaves();
            animator.SetBool("abrirBau", true);
            logicaText = true;
            var audioBau = GetComponent<AudioSource>();
            if (!GetComponent<AudioSource>().isPlaying)
                audioBau.Play();
            bauAberto = true;
            bauLogicaAberto = true;
        }
    }
    protected void DiminuirChaves()
    {
        if (bauAberto == false)
            ColetarItens.qntChaves = ColetarItens.qntChaves - 1;
    }
}