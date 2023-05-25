using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouger_flleches : MonoBehaviour
{
    public float vitesse = 50f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //  Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = -3.65f;

        Vector2 move = new Vector2(moveX, moveY);

        rb.velocity = move.normalized * vitesse * Time.deltaTime;
    }

}
