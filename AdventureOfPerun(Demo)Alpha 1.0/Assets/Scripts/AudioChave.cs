using UnityEngine;

public class AudioChave : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        
        if (ColetarItens.coletouChave)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            ColetarItens.coletouChave = false;
        }
    }
}
