using UnityEngine;
using UnityEngine.UI;

public class ColetarItens : MonoBehaviour {

    public static bool coletouChave = false;
    public static bool coletouDiamante = false;
    public static int qntChaves;
    private int qntDiamantes;
    public Text qntDiamantestext, qntChavestext;
    
	// Use this for initialization
	void Start () {

        coletouDiamante = false;
        coletouChave = false;
        qntDiamantes = 0;
        qntChaves = 0;
	}

    // Update is called once per frame
    void Update ()
    {
        SetcontadorChaves();
        SetcontadorDiamantes();        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "diamante")
        {
            collision.gameObject.SetActive(false);
            qntDiamantes++;
            coletouDiamante = true;

        }
        if (collision.tag == "chave")
        {
            collision.gameObject.SetActive(false);
            qntChaves++;
            coletouChave = true;
        }
    }
    void SetcontadorChaves()
    {
        qntChavestext.text = qntChaves.ToString();
    }
    void SetcontadorDiamantes()
    {
        qntDiamantestext.text = qntDiamantes.ToString();
    }
}
