using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGhostMovement : MonoBehaviour
{
    public Transform player;
    [SerializeField] float moveSpeed = 2f;

    private void Update()
    {
        if (player != null)
        {
            Vector3 direction = (player.position - transform.position).normalized;

            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }
}
