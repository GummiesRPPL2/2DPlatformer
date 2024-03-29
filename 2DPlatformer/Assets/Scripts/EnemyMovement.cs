using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] float moveDistance = 2f;

    private Vector3 startPosition;
    private bool movingRight = true;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        //Moves the enemy left and right within a certain distance
        if (movingRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }

        //Change direction when reaching the moveDistance
        if (Mathf.Abs(transform.position.x - startPosition.x) > moveDistance) 
        {
            movingRight = !movingRight;
        }
    }
}
