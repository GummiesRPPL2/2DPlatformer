using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartManager : MonoBehaviour
{
    [SerializeField] GameObject heartPrefab;
    public Transform heartsContainer;
    public Health playerHealth;

    private void Start()
    {
        UpdateHearts();
    }

    public void UpdateHearts()
    {
        foreach (Transform child in heartsContainer)
        {
            Destroy(child.gameObject);
        }

        for (int i = 0; i < playerHealth.currentHealth; i++)
        {
            Instantiate(heartPrefab, heartsContainer);
        }
    }

}
