using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public GameObject HitEffect;

    private void Start()
    {
        //GameObject player = GameObject.FindGameObjectWithTag("EnemyBullet");
        //Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }

    private void OnCollisionEnter2D(Collision2D other){
        GameObject effect = Instantiate(HitEffect, transform.position, Quaternion.identity);
        Destroy(effect, .2f);
        Destroy(gameObject);
    }
}
