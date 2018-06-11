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
}