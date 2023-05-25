using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balle : MonoBehaviour

{
    public float maxSpeed = 1500f;
    //public float minSpeed = 0f;
    float coeff = 0.1f;
    public float Speed = 1.5f;

    Rigidbody2D rb;
    GameObject baballe;
    [SerializeField]
    private GameObject gameOverUI;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
       if (rb.velocity.magnitude < Speed)
        {
            rb.velocity = rb.velocity.normalized * Speed;
        }
        
        /*if (coeff < 1)
        {
            coeff *= 1.06; //find by how much you want to rise it at each frame
                           // or coeff = Mathf.Sqrt(1.5f * coeff)
                           // ... it depends on which shape of accel you want
        }
        rigidbody.AddForce(new Vector3(0, 0, coeff * rb.velocity), ForceMode.Impulse);*/
    }





    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "lave")
        {
            Debug.Log("GameOver");
            FindObjectOfType<GameManager>().EndGame();
            Destroy(gameObject);

        }
    }
}







   