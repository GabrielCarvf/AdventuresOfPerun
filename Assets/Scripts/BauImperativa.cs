using UnityEngine;
using UnityEngine.UI;

public class BauImperativa : MonoBehaviour {

    Animator animator;    
    public Transform PersonagemChek;
    public LayerMask EhPersonagem;
    public Text Imperativatext;
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

        if (personagemPerto && Input.GetKeyDown(KeyCode.E) && (ColetarItens.qntChaves > 0))
        {
            DiminuirChaves();
            animator.SetBool("abrirBau", true);
            DefinirTexto();
            bauAberto = true;
            var audioBau = GetComponent<AudioSource>();
            if (!GetComponent<AudioSource>().isPlaying)
                audioBau.Play();
        }               
    }
   protected void DiminuirChaves()
    {
        if(bauAberto == false)
        ColetarItens.qntChaves = ColetarItens.qntChaves - 1;
    }
    void DefinirTexto()
    {        
        Imperativatext.text = "Imperativa";
    }
}
