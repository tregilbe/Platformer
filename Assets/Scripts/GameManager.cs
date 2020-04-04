using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int currentScene = 0;

    public int playerScore = 0;

    public int playerLives = 3;

    // Set up checkpoint system
    public Vector2 lastCheckPointPos;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
            Debug.Log("Warning: A second game manager was detected and destroyed.");
        }
    }

    void Update()
    {

        if (GameManager.instance.playerLives == 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (GameManager.instance.playerScore >= 100 && GameManager.instance.playerLives < 3)
        {
            GameManager.instance.playerScore -= 100;
            GameManager.instance.playerLives += 1;
        }
    }

    public void LoadLevel(string levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad);
        // Potentially Dangerous
        currentScene++;
    }

    public void loadLevel(int indexToLoad)
    {
        SceneManager.LoadScene(indexToLoad);
        currentScene = indexToLoad;
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentScene += 1);
    }
}
