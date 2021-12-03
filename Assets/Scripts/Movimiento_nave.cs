using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_nave : MonoBehaviour
{
	public float Speed;
	Rigidbody2D body;
	
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
		body.velocity = new Vector2(moveX * Speed, body.velocity.y);
		
		float moveY = Input.GetAxis("Vertical");
		body.velocity = new Vector2(moveY * Speed, body.velocity.x);
    }
}
