using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    public float moveSpeed;
    private bool moveRight;
    private bool startMovement = false;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        //si falla algo cambiar de IEnumerator a void
        
        yield return new WaitForSeconds(5f);
        startMovement = true;
        moveSpeed = 1f;
        moveRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (startMovement)
        {

            if (transform.position.x > 5f)
            {
                moveRight = false;
            }
            else if (transform.position.x < -5f)
            {
                moveRight = true;
            }

            if (moveRight)
            {
                transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
            }
            else
            {
                transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
            }

        }
    }
}
