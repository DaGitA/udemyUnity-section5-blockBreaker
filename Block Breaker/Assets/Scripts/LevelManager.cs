using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void loadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void quitGame()
    {
        //Seulement pour PC
        Application.Quit();
    }
}
