using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : MonoBehaviour
{
    public PauseMenu pauseMenu;

    public void OnContinueButtonClick()
    {
        pauseMenu.TogglePauseMenu(false);
    }
}
