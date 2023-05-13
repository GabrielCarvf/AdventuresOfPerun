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
        personagemPerto = false;
        bauAberto = false;
        bauImperativoAberto = false;
        imperativaText = false;
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        personagemPerto = Physics2D.OverlapCircle(PersonagemChek.position, bauCheckRaio, EhPersonagem);
        imperativaText = false;

        if (personagemPerto && Input.GetKeyDown(KeyCode.E) && (ColetarItens.qntChaves > 0) && !bauAberto)
        {
            DiminuirChaves();
            AbriuBau();
        }
    }
    void AbriuBau()
    {
        animator.SetBool("abrirBau", true);
        imperativaText = true;
        bauAberto = true;
        var audioBau = GetComponent<AudioSource>();
        if (!GetComponent<AudioSource>().isPlaying)
            audioBau.Play();
        bauImperativoAberto = true;
        TextosParadigmas.QuantidadeParadigmas = TextosParadigmas.QuantidadeParadigmas + 1;
    }
    protected void DiminuirChaves()
    {
        if (bauAberto == false)
            ColetarItens.qntChaves = ColetarItens.qntChaves - 1;
    }
}
