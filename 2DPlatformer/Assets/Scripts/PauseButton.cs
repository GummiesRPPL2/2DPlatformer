using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    public PauseMenu pauseMenu;

    public void OnPauseButtonClick()
    {
        bool isPaused = !pauseMenu.pauseMenuUI.activeSelf;
        pauseMenu.TogglePauseMenu(isPaused);
    }
}
