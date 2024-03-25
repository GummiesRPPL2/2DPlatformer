using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public Sprite closedDoorSprite;
    public Sprite openDoorSprite;
    public SpriteRenderer doorRenderer;
    [SerializeField] bool isOpen = false;
    public Collider2D doorCollider;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isOpen = !isOpen;
            doorRenderer.sprite = isOpen ? openDoorSprite : closedDoorSprite;

            doorCollider.enabled = !isOpen;
        }
    }
}
