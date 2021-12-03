using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public float startTime;
    public Text contador;


    // Start is called before the first frame update
    void Start()
    {
        contador.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (startTime > 0)
        {
            startTime -= Time.deltaTime;
            contador.text = "" + Mathf.Round(startTime);
        }
        else
        {
            Destroy(contador);
        }
    }

}
