using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RightMovie : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    bool isPressed = false;
    public GameObject Player;
    public float moveSpeed = 3f; // nowa zmienna moveSpeed
    private Vector2 direction; // nowa zmienna direction
    private SpriteRenderer spriteRenderer;
    public Sprite[] runSprites;
    private int spriteIndex;

    void Start()
    {
        spriteRenderer = Player.GetComponent<SpriteRenderer>();

    }

    private void AnimateSprite()
    {
        if (isPressed)
        {
            spriteIndex++;

            if (spriteIndex >= runSprites.Length)
            {
                spriteIndex = 0;
            }

            spriteRenderer.sprite = runSprites[spriteIndex];
        }
    }
    // Update is called once per frame
    void Update()
    {


        if (isPressed)
        {
            direction.x = moveSpeed; // ruch w prawo
            if (direction.x > 0f)
            {
                Player.transform.eulerAngles = Vector3.zero;
              
            }
            else if (direction.x < 0f)
            {
                Player.transform.eulerAngles = new Vector3(0f, 180f, 0f);
                spriteIndex++;

            }


        }
        else // brak ruchu
        {
            direction.x = 0;

        }

        float x = direction.x * Time.deltaTime;
        float y = 0;
        float z = 0;

        Player.transform.Translate(x, y, z);

        AnimateSprite();
    }




    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}