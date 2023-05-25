using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouger_emplacmt_souris : MonoBehaviour
{
    //IL faut mettre un collider sur l'objet
    //Il faut que la camera soit en mode orthographic
    bool clique = false;
    // Start is called before the first frame update
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clique = true;

        }
    }
    void Update()
    {
        // si la souris est appuyé et que l'objet est cliqué alors la position de l'objet devient celle de la souris
        if (Input.GetMouseButton(0) && clique)
        {
            // on recupere la position de la souris

            Vector2 souris = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            souris.y = -3.65f;

            // on met l'objet a la meme position que la souris
            transform.position = new Vector2(souris.x, souris.y);
        }

    }

}
