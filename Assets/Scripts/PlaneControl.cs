using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneControl : MonoBehaviour
{
    public static GameObject box;
    public GameObject _box;
    private Vector3 direction;
    void Start()
    {

        box = _box;
        for(int i = 0 ; i < 32 ; i++){
                
            box = boxSpawn(box);
            
            }
        
    }

    
    void Update()
    {
        
    }
    
    public static GameObject boxSpawn(GameObject box )
    {
        Vector3 direction;
        if (Random.Range(0, 2) == 0)
        {
            direction = Vector3.right;    
        }
        else
        {
            direction = Vector3.forward;
        }
        box = Instantiate(box, box.transform.position + direction, box.transform.rotation);
        return box;
    }
}
