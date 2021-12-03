using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
public Transform target;
    public float smoothSpeed = 0.125f;

    void Update(){
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
    }
}

