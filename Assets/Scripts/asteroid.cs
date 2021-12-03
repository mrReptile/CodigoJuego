using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{

    public int asteroidHP = 4;
    public GameObject loot;

    //public float maxThrust;
    //public float maxTorque;
    //public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //Vector2 thrust = new Vector2(Random.Range(-maxThrust, maxThrust), Random.Range(-maxThrust, maxThrust));
        //float torque = Random.Range (-maxTorque, maxTorque);

        //rb.AddForce(thrust);
        //rb.AddTorque(torque);    
        //gameObject.SetActive(false);
        //transform.gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }

     public void OnCollisionEnter2D(Collision2D col){
         if(col.gameObject.tag.Equals("Bullet") && asteroidHP < 5 && asteroidHP > 0){
            asteroidHP = asteroidHP-1;
         }if(!col.gameObject.tag.Equals("Player") && asteroidHP == 0){
             Destroy(gameObject);
             Instantiate(loot, transform.position, Quaternion.identity);
         }
    }

    
}
