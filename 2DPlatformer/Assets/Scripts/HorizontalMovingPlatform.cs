using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovingPlatform : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    [SerializeField] float minX = 0f;
    [SerializeField] float maxX = 10f;

    [SerializeField] bool movingRight = true;

    private void Update()
    {
        float moveAmount = speed * Time.deltaTime;
        if (movingRight)
        {
            transform.Translate(Vector3.right * moveAmount);
            if (transform.position.x >= maxX)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(Vector3.left * moveAmount);
            if (transform.position.x <= minX)
            {
                movingRight = true;
            }
        }
    }
}
