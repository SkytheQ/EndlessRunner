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
		GameObject Player = GameObject.Find ("Player");
		PlayerMovement playermovement = Player.GetComponent<PlayerMovement> ();

        if (Input.GetButtonDown("Pause"))
        {
            _paused = !_paused;
        }

        if (_paused)
        {
			
            pauseUI.SetActive(true);
            Time.timeScale = 0;
            AudioListener.pause = true;
			playermovement.RunSpeed = 0f;
            
        }

        if (!_paused)
        {
            pauseUI.SetActive(false);
            Time.timeScale = 1;
            AudioListener.pause = false;
			playermovement.RunSpeed = 0.08f;

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
