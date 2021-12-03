using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    public float speed;
    private Transform playerPosition;

    private void Awake()
    {
        if (Time.timeScale == 1f)
        {
            playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1f)
        {
            // esta linea ayua a mantener a distancia a los enemigos
            if (Vector2.Distance(transform.position, playerPosition.position) > 0f)
                transform.position = Vector2.MoveTowards(transform.position, playerPosition.position, speed * Time.fixedDeltaTime);
        }
    }
}
