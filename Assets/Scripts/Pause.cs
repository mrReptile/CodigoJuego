using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;




    public void Paused()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Home() 
    {
        var player = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject clone in player)
        {
            Destroy(clone);
        }

        SceneManager.LoadScene("MainMenu");
    }



}
