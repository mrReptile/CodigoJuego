using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endless : MonoBehaviour
{

    public GameObject[] levels;
    private Camera mainCamera;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {   
        mainCamera = gameObject.GetComponent<Camera>();
        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));
        foreach(GameObject obj in levels){
            loadChildObjects(obj);
        }
        
    }

    // Update is called once per frame
    void loadChildObjects(GameObject obj)
    {
        //Debug.Log(obj.name);
        float ObjectWidth = obj.GetComponent<SpriteRenderer>().bounds.size.x;
        int childNeeed = (int)Mathf.Ceil(screenBounds.x * 2 / ObjectWidth);
        GameObject clone = Instantiate(obj) as GameObject;

        for(int i = 0; i<=childNeeed; i++){
            GameObject c = Instantiate(clone) as GameObject;
            c.transform.SetParent(obj.transform);
            c.transform.position = new Vector3(ObjectWidth * i, obj.transform.position.y, obj.transform.position.z);
            c.name = obj.name + 1;
            }
            Destroy(clone);
    }
    
}
