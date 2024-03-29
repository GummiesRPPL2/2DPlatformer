using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenButton : MonoBehaviour
{
    public void OnReturnToTitleButtonClick()
    {
        SceneManager.LoadScene("Menu");
    }
}
