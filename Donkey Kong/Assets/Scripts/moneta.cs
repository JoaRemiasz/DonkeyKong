using UnityEngine;

public class moneta : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            // Pozw�l obiektom przenika� si� pomi�dzy sob�
            Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), other, true);
        }
    }
}