using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFinal : MonoBehaviour {
	

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}
