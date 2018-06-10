using UnityEngine;
using UnityEngine.UI;

public class BauImperativo : MonoBehaviour
{

    Animator animator;
    public Transform PersonagemChek;
    public LayerMask EhPersonagem;
    public Text Imperativatext;
    public static bool imperativaText = false;
    public static bool bauImperativoAberto = false;
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
        imperativaText = false;

        if (personagemPerto && Input.GetKeyDown(KeyCode.E) && (ColetarItens.qntChaves > 0) && !bauAberto)
        {
            DiminuirChaves();
            DefinirTexto();
            animator.SetBool("abrirBau", true);
            imperativaText = true;
            bauAberto = true;
            var audioBau = GetComponent<AudioSource>();
            if (!GetComponent<AudioSource>().isPlaying)
                audioBau.Play();
            bauImperativoAberto = true;
        }
    }
    protected void DiminuirChaves()
    {
        if (bauAberto == false)
            ColetarItens.qntChaves = ColetarItens.qntChaves - 1;
    }
    void DefinirTexto()
    {
        Imperativatext.text = "Imperativa";
    }
}
