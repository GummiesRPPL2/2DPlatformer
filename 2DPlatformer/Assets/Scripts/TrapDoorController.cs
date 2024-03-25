using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoorController : MonoBehaviour
{
    public GameObject trapDoor;
    public GameObject rock;

    public void OpenTrapDoor()
    {
       trapDoor.SetActive(false);

        rock.SetActive(true);
    }
}
