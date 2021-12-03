using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStats : MonoBehaviour
{
    public int BossHP;
    public GameObject winButton, winText;
    [SerializeField] GameObject winMenu;

    public bool playSound = false;

    // Start is called before the first frame update
    void Start()
    {
        winButton.SetActive(false);
        winText.SetActive(false);
        winMenu.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!playSound) {
            Sounds.PlaySound("I_am_Sinistar");
            playSound = true;
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            if(BossHP > 0)
            {
                BossHP--;
            }
            else
            {
                winButton.SetActive(true);
                winText.SetActive(true);
                winMenu.SetActive(true);
                var clones = GameObject.FindGameObjectsWithTag("EnemyBullet");
                foreach (GameObject clone in clones)
                {
                    Destroy(clone);
                }
                gameObject.SetActive(false);
                Time.timeScale = 0f;
                
            }
        }
    }
}
