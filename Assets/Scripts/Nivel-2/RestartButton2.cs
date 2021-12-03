using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frsame
    void Update()
    {
        
    }

    public void restartScene()
    {
        
        SceneManager.LoadScene("Nivel-2");
    }
}
