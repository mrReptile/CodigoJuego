using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStat : MonoBehaviour
{
   public static PlayerStat playerStat;

    public GameObject gameOverText, restartButton, pauseButton;

    public int PlayerHP;
    public int ItemBomb;

    private void Awake()
    {
        if(playerStat != null)
        {
            Destroy(playerStat);
        }
        else
        {
            playerStat = this;
        }
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        Time.timeScale = 1f;
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("tocado");
       
        if (col.gameObject.tag.Equals("Enemy"))
        {
            Sounds.PlaySound("Game_Over");
            gameObject.SetActive(false);
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            pauseButton.SetActive(false);
            Time.timeScale = 0f;
            //Instantiate(loot, transform.position, Quaternion.identity);
        }
    }
}
