using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowe : MonoBehaviour
{
    public Transform ball;
    private Vector3 distance;
    void Start()
    {
        distance = gameObject.transform.position - ball.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!BallControl.ballIsFall)
        {
            gameObject.transform.position = distance + ball.position;
        }
    }
}
