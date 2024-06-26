using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D player;
    private float Speed =3f;
    private float xBound=2.5f;

    private float startPosition;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        startPosition = this.transform.position.x;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    { 

        if (startPosition > xBound){
            player.velocity = Vector2.left * Speed;
            if (this.transform.position.x < -xBound){
                Destroy(this.gameObject);
            }
        }
        else if (startPosition < -xBound){
            player.velocity = Vector2.right * Speed;
            if (this.transform.position.x > xBound){
                Destroy(this.gameObject);
            }
        }
        else{
            player.velocity = Vector2.zero;
        }
    }
}
