using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D player;
    private float Speed =3f;
    private float xBound=2.5f;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    { 
        float  input = Input.GetAxisRaw("Horizontal");

        if (input > 0){
            player.velocity = Vector2.right * Speed;
        }
        else if (input < 0){
            player.velocity = Vector2.left * Speed;
        }
        else{
            player.velocity = Vector2.zero;
        }

        transform.position = new Vector2(Mathf.Clamp(transform.position.x,-xBound,xBound),transform.position.y);
    }
}
