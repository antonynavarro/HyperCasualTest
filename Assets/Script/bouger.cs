using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouger : MonoBehaviour
{
    bool clique = false;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    


    // Update is called once per frame
    void Update()
    {
        
        // si la souris est appuyé et que l'objet est cliqué alors la position de l'objet devient celle de la souris
        if (Input.GetMouseButton(0))
        {
            // on recupere la position de la souris

            Vector2 souris = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            souris.y = -3.65f;
            // on met l'objet a la meme position que la souris
            float xP = transform.position.x;
            float yP = transform.position.y;
            float moveX = souris.x - xP;
           

            Vector2 move = new Vector2(moveX, 0);
            rb.velocity = move;
        }
        // si la souris est relachée alors clique est faux
        

    }

}


