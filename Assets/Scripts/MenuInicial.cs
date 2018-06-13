using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour {

    Animator animator;
    public GameObject telaCreditos;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            FecharSobre();
            FecharCreditos();
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void MostrarCreditos()
    {
        animator.SetBool("AbrirCreditos", true);
        animator.SetBool("FecharCreditos", false);
    }
    public void FecharCreditos()
    {
        animator.SetBool("FecharCreditos", true);
        animator.SetBool("AbrirCreditos", false);
    }
    public void MostrarSobre()
    {
        animator.SetBool("AbrirSobre", true);
        animator.SetBool("FecharSobre", false);
    }
    public void FecharSobre()
    {
        animator.SetBool("FecharSobre", true);
        animator.SetBool("AbrirSobre", false);
    }

}