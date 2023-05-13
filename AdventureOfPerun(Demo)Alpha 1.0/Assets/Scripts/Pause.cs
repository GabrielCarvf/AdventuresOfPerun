using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Pause : MonoBehaviour {

    Animator animator;
    public AudioMixer audioMixerMusicas, audioMixerSons;

    public GameObject PainelPause;
    public GameObject MostrarParadigmas;
    public GameObject ImperativaText;
    public GameObject OrientadaText;
    public GameObject LogicaText;
    public GameObject FuncionalText;

    public static bool mostrarPause = false;
    public static bool mostrarParadigmas = false;

    private void Start()
    {
        mostrarPause = false;
    }

    // Update is called once per frame
    void Update ()
    {
        if (mostrarPause == false && Input.GetKeyDown(KeyCode.P))
        {
            Invoke("AparecePause", 0.3f);
        }

        if (mostrarPause == true && Input.GetKeyDown(KeyCode.P))
        {
            Resume();
        }
        if (mostrarParadigmas == true && (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Return)))
        {
            FecharParadigmas();
        }
        
    }

    void AparecePause()
    {
        if (!mostrarPause)
        {
            PainelPause.SetActive(true);
            mostrarPause = true;
            Time.timeScale = 0f;
        }
    }

    public void Resume()
    {
        PainelPause.SetActive(false);
        mostrarPause = false;
        FecharParadigmas();
        Time.timeScale = 1f;
    }

    public void AbrirParadigmas()
    {
        MostrarParadigmas.SetActive(true);
        mostrarParadigmas = true;
        Time.timeScale = 0f;

        if (BauImperativo.bauImperativoAberto)
            AparecerImperativa();
        if (BauOrientadaAObjeto.bauOrientadaObjetoAberto)
            AparecerOrientadaaObjeto();
        if (BauLogica.bauLogicaAberto)
            AparecerLogica();
        if (BauFuncional.bauFuncionalAberto)
            AparecerFuncional();

    }

    public void FecharParadigmas()
    {
        MostrarParadigmas.SetActive(false);
        mostrarParadigmas = false;
        Time.timeScale = 0f;

    }

    public void RetornaMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void DefinirVolumeMusica(float volume)
    {
        audioMixerMusicas.SetFloat("volume", volume);
    }

    public void DefinirVolumeSons(float volume)
    {
        audioMixerSons.SetFloat("volume", volume);
    }

    void AparecerImperativa()
    {
        ImperativaText.SetActive(true);
        Time.timeScale = 0f;        
    }

    void AparecerOrientadaaObjeto()
    {
        OrientadaText.SetActive(true);
       Time.timeScale = 0f;
    }

    void AparecerFuncional()
    {
        FuncionalText.SetActive(true);
        Time.timeScale = 0f;
    }

    void AparecerLogica()
    {
        LogicaText.SetActive(true);
        Time.timeScale = 0f;
    }

}
