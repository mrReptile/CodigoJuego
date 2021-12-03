using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats2 : MonoBehaviour
{
    public static PlayerStats2 playerStats2;

    public GameObject gameOverText, restartButton, BulletPool;
    public int PlayerHP;
    public int ItemBomb;

    [SerializeField] GameObject pauseMenu;
    public GameObject HitEffect;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && ItemBomb > 0)
        {
            ItemBomb--;
            var clones = GameObject.FindGameObjectsWithTag("EnemyBullet");
            foreach (GameObject clone in clones)
            {
                Destroy(clone);
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(Time.timeScale == 1)
            {
                Paused();
            }
            else if (Time.timeScale == 0)
            {
                Resume();
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("tocado");

        if (col.gameObject.tag.Equals("EnemyBullet"))
        {
            GameObject effect = Instantiate(HitEffect, transform.position, Quaternion.identity);
            Destroy(effect, .2f);
            gameObject.SetActive(false);
            var clones = GameObject.FindGameObjectsWithTag("EnemyBullet");
            foreach (GameObject clone in clones)
            {
                Destroy(clone);
            }
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            Sounds.PlaySound("Game_Over");
            Time.timeScale = 0f;
        }
    }

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

    public void Home(int scedeneID) { }
}
