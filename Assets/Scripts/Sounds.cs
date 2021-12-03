using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public static AudioClip GameOverSound, FireSound, EnemyDeathSound, Boss1;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        GameOverSound = Resources.Load<AudioClip>("Game_Over");
        FireSound = Resources.Load<AudioClip>("Fire_Sound");
        EnemyDeathSound = Resources.Load<AudioClip>("Enemy_Death_Sound");
        Boss1 = Resources.Load<AudioClip>("Boss1");

        audioSrc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Game_Over":
                audioSrc.PlayOneShot(GameOverSound);
                break;

            case "Fire_Sound":
                audioSrc.PlayOneShot(FireSound);
                break;

            case "Enemy_Death_Sound":
                audioSrc.PlayOneShot(EnemyDeathSound);
                break;

            case "I_am_Sinistar":
                audioSrc.PlayOneShot(Boss1);
                break;
        }
    }

}
