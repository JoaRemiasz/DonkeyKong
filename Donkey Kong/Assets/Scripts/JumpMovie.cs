using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpMovie : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float jumpStrength = 4f;
    public Rigidbody2D playerRigidbody;
    public bool jumping = false;
    public bool grounded;
    public void OnPointerDown(PointerEventData eventData)
    {
        if (grounded)
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
            playerRigidbody.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
            jumping = false;
        }
    }
}