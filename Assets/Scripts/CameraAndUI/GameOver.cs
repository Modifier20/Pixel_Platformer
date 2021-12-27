using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUI;

    [SerializeField] private bool isOver;

    private void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            isOver = !isOver;
        }

        if (isOver)
        {
            ActivateMenu();
        }

        else
        {
            DeactivateMenu();
        }
    }

    void ActivateMenu()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;

        gameOverUI.SetActive(true);
    }

    public void DeactivateMenu()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;

        gameOverUI.SetActive(false);
        isOver = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Level 1");
    }

}
