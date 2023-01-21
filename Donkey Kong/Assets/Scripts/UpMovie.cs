using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UpMovie : MonoBehaviour, IPointerDownHandler
{
    public float moveSpeed = 5f;
    public Player player;
    public bool climbing = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (player.GetComponent<Collider2D>().IsTouchingLayers(LayerMask.GetMask("Ladder")))
        {
            climbing = true;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        climbing = false;
    }

    void FixedUpdate()
    {
        if (climbing)
        {
            player.direction.y = moveSpeed;
                climbing = false;
            
        }
    }
}

