using UnityEngine;
using UnityEngine.UI;

public class BauFuncional : MonoBehaviour
{

    Animator animator;
    public Transform PersonagemChek;
    public LayerMask EhPersonagem;
    public Text Funcionaltext;
    public static bool funcionalText = false;
    public static bool bauFuncionalAberto = false;
    private bool bauAberto = false;
    private bool personagemPerto = false;
    private float bauCheckRaio = 0.7f;

    private void Start()
    {
        personagemPerto = false;
        bauAberto = false;
        bauFuncionalAberto = false;
        funcionalText = false;
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        personagemPerto = Physics2D.OverlapCircle(PersonagemChek.position, bauCheckRaio, EhPersonagem);
        funcionalText = false;
        if (personagemPerto && Input.GetKeyDown(KeyCode.E) && (ColetarItens.qntChaves > 0) && !bauAberto)
        {
            DiminuirChaves();
            DefinirTexto();
            animator.SetBool("abrirBau", true);
            funcionalText = true;
            bauAberto = true;
            var audioBau = GetComponent<AudioSource>();
            if (!GetComponent<AudioSource>().isPlaying)
                audioBau.Play();
            bauFuncionalAberto = true;
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