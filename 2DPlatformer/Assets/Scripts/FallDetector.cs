using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            RestartStage();
        }
    }

    private void RestartStage()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
