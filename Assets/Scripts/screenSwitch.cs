using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class screenSwitch : MonoBehaviour {

    public void startGame() {

        SceneManager.LoadScene("Main");
    }

    public void endGame()
    {
        SceneManager.LoadScene("Newspaper");
    }
}
