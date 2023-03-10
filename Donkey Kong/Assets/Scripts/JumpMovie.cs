using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpMovie : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float jumpStrength = 4f;
    public Player player;
    public bool jumping = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (player.grounded)
        {
            jumping = true;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        jumping = false;
    }

    void FixedUpdate()
    {
        if (jumping)
        {
            player.direction = Vector2.up * jumpStrength;
            jumping = false;
        }
    }
}
