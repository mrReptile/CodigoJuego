using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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