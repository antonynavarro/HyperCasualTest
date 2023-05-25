using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changecouleurballe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Color(0, 0.8f, 0.4f);
    }

    // Update is called once per frame
    void OncollisionEnter2D(Collision2D collision)
    {
        GetComponent<SpriteRenderer>().color = collision.gameObject.GetComponent<SpriteRenderer>().color;
    }
}
