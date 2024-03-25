using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinTracker : MonoBehaviour
{
   public static CoinTracker instance;

    public int coinsCollected = 0;
    public TextMeshProUGUI coinText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        if (coinText == null)
        {
            Debug.Log("CoinText reference not assigned");
        }
    }

    public void AddCoin()
    {
        coinsCollected++;
        UpdateCoinUI();
    }

    private void UpdateCoinUI()
    {
        coinText.text = coinsCollected.ToString();
    }
}
