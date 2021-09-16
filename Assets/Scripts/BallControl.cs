using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BallControl : MonoBehaviour
{
    public float speed;
    public float aceleration;
    public static bool ballIsFall;
    private Vector3 direction;
    void Start()
    {
        ballIsFall = false;
        direction = new Vector3(0f,0f,0f);
    }
    
    
    void Update()
    {
        ballIsFall = isFall(gameObject.transform);
        if (Input.GetMouseButtonDown(0))
        {
            speed += aceleration;
            if (direction.x == 0f)
            {
                direction = Vector3.right;
            }
            else
            {
                direction = Vector3.forward;
            }
        }
        
        transform.Translate(direction * speed * Time.deltaTime);
        
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Box")
        {
            PlaneControl.box = PlaneControl.boxSpawn(PlaneControl.box);
            other.gameObject.AddComponent<Rigidbody>();
        }

        if (other.gameObject.transform.position.y < -13)
        {
            Destroy(other.gameObject);
        }
    }

    private bool isFall(Transform ball)
    {
        if (ball.position.y < 0.5f)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
