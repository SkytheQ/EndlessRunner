using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

    public void loadLevel(string _loadLevel)
    {
        SceneManager.LoadScene(_loadLevel);
    }

    public void quit()
    {
        Application.Quit();
    }

}
