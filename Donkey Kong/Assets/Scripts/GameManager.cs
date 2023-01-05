using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int level;
    private int lives;
    private int score;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        NewGame();
    }

    private void NewGame()
    {
        SceneManager.LoadScene("Menu");

        lives = 3;
        HeartSystem.lives = lives;
        level = 0;
        ScoreScript.scoreValue = 0;
    }

    private void LoadLevel(int index)
    {

        level = index;

        Camera camera = Camera.main;

        // Don't render anything while loading the next scene to create
        // a simple scene transition effect
        if (camera != null)
        {
            camera.cullingMask = 0;
        }

        Invoke(nameof(LoadScene), 1f);
    }
    private void LoadScene()
    {
        SceneManager.LoadScene(level);
    }


    public void LevelComplete()
    {
        ScoreScript.scoreValue += 500;
        int nextLevel = level + 1;

        if (nextLevel < SceneManager.sceneCountInBuildSettings)
        {
            LoadLevel(nextLevel);
        }
        else
        {
            LoadLevel(2);
        }
    }

    public void LevelFailed()
    {
        lives--;
        HeartSystem.lives = lives;
        ScoreScript.scoreValue -= 250;

        if (lives <= 0)
        {
            SceneManager.LoadScene("Menu");
            NewGame();
        }
        else
        {
            Debug.Log(lives);
            LoadLevel(2);
        }
    }

}
