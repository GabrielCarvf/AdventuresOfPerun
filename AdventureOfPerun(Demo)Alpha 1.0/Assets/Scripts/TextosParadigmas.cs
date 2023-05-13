using UnityEngine;
using UnityEngine.UI;

public class TextosParadigmas : MonoBehaviour
{

    public GameObject OrientadaAObjetoText;
    public GameObject LogicaText;
    public GameObject FuncionalText;
    public GameObject ImperativaText;
    public Text QuantidadeParadigmasText;
    public static int QuantidadeParadigmas;

    private bool abertoImperativa = false;
    private bool abertoOrientada = false;
    private bool abertoLogica = false;
    private bool abertoFuncional = false;

    private void Start()
    {
        QuantidadeParadigmas = 0;
    }

    // Update is called once per frame
    void Update()
    {

        QuantidadeParadigmasText.text = QuantidadeParadigmas.ToString();

        if (BauImperativo.imperativaText)
        {
            Invoke("MostrarTextoImperativa", 0.3f);
        }
        if (BauFuncional.funcionalText)
        {
            Invoke("MostrarTextoFuncional", 0.3f);
        }
        if (BauLogica.logicaText)
        {
            Invoke("MostrarTextoLogica", 0.3f);
        }
        if (BauOrientadaAObjeto.OrientadaAObjetoText)
        {
            Invoke("MostrarTextoOrientadaAObjeto", 0.3f);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Return))
        {
            Voltar();
        }
    }

    void MostrarTextoImperativa()
    {
        if (!abertoImperativa)
        {
            ImperativaText.SetActive(true);
            Time.timeScale = 0f;
            BauImperativo.imperativaText = false;
            abertoImperativa = true;
        }
    }
    void MostrarTextoFuncional()
    {
        if (!abertoFuncional)
        {
            FuncionalText.SetActive(true);
            Time.timeScale = 0f;
            BauFuncional.funcionalText = false;
            abertoFuncional = true;
        }
    }
    void MostrarTextoLogica()
    {
        if (!abertoLogica)
        {
            LogicaText.SetActive(true);
            Time.timeScale = 0f;
            BauLogica.logicaText = false;
            abertoLogica = true;
        }
    }
    void MostrarTextoOrientadaAObjeto()
    {
        if (!abertoOrientada)
        {

            OrientadaAObjetoText.SetActive(true);
            Time.timeScale = 0f;
            BauOrientadaAObjeto.OrientadaAObjetoText = false;
            abertoOrientada = true;
        }
    }
    void Voltar()
    {
        ImperativaText.SetActive(false);
        LogicaText.SetActive(false);
        OrientadaAObjetoText.SetActive(false);
        FuncionalText.SetActive(false);
        Time.timeScale = 1f;
    }
}
