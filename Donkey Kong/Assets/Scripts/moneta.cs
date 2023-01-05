using UnityEngine;

public class moneta : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            // Pozwól obiektom przenikaæ siê pomiêdzy sob¹
            Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), other, true);
        }
    }
}