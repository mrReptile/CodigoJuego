using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int EnemyHP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Bullet") && EnemyHP < 2 && EnemyHP > 0)
        {
            EnemyHP = EnemyHP - 1;
        }
        else if (col.gameObject.tag.Equals("Bullet") && EnemyHP == 0)
        {
            Sounds.PlaySound("Enemy_Death_Sound");
            Destroy(gameObject);
            //Instantiate(loot, transform.position, Quaternion.identity);
        }
    }
}
