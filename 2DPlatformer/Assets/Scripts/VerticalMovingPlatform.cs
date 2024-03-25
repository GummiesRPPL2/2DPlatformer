using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovingPlatform : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    [SerializeField] float minY = 0f;
    [SerializeField] float maxY = 10f;

    [SerializeField] bool movingUp = true;

    private void Update()
    {
        float moveAmount = speed * Time.deltaTime;
        if (movingUp)
        {
            transform.Translate(Vector3.up * moveAmount);
            if (transform.position.y >= maxY)
            {
                movingUp = false;
            }
        }
        else
        {
            transform.Translate(Vector3.down * moveAmount);
            if (transform.position.y <= minY)
            {
                movingUp = true;
            }
        }
    }
}
