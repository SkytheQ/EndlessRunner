using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {

    [SerializeField]
    private GameObject pauseUI;

    private bool _paused = false;

    void Start()
    {
        pauseUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            _paused = !_paused;
        }

        if (_paused)
        {
            pauseUI.SetActive(true);
            Time.timeScale = 0;
            AudioListener.pause = true;
            
        }

        if (!_paused)
        {
            pauseUI.SetActive(false);
            Time.timeScale = 1;
            AudioListener.pause = false;
        }
    }

    public void Resume()
    {
        _paused = false;
    }

    public void Restart(string _restart)
    {
        SceneManager.LoadScene(_restart);

    }

    public void MainMenu(string _mainMenu)
    {
        SceneManager.LoadScene(_mainMenu);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
