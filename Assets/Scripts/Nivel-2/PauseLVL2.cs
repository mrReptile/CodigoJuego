using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseLVL2 : MonoBehaviour
{
    [SerializeField] public GameObject PausePanel;
    public GameObject PauseText;
    public GameObject PauseButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Resume()
    {
        PausePanel.SetActive(false);
        PauseText.SetActive(false);
        PauseButton.SetActive(false);
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
