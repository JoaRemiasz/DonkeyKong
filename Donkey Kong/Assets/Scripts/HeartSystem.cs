using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{

    public GameObject[] hearts;
    public static int lives = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lives < 1)
        {
            Destroy(hearts[0].gameObject);
            Destroy(hearts[1].gameObject);
            Destroy(hearts[2].gameObject);
        }
        else if (lives < 2)
        {
            Destroy(hearts[1].gameObject);
            Destroy(hearts[2].gameObject);
        }
        else if (lives < 3)
        {
            Destroy(hearts[2].gameObject);
        }
    }
}
