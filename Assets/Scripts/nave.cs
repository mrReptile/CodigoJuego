using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nave : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D body;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    void fixedUpdate()
    {
        body.MovePosition(body.position + movement * speed * Time.fixedDeltaTime);
    }

}
