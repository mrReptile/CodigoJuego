using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tiempo : MonoBehaviour
{
    public float startTime;
    public Text contador;
    public GameObject ContinueText, ConButton;
    public GameObject Player;
    public GameObject PauseButton;

    [SerializeField] GameObject ConMenu;

    // Start is called before the first frame update
    void Start()
    {
        contador.GetComponent<Text>();

        ContinueText.SetActive(false);
        ConButton.SetActive(false);
        ConMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(startTime > 0)
        {
            startTime -= Time.deltaTime;
            contador.text = "" + Mathf.Round(startTime);
        }
        else
        {
            Player.SetActive(false);
            PauseButton.SetActive(false);
            ContinueText.SetActive(true);
            ConButton.SetActive(true);
            ConMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
