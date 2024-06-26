using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{   
    private Rigidbody2D player;
    private float Speed =0.15f;
    private float xBound=2.5f;
    private Touch touch;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        
    }
   
    void FixedUpdate()
    { 
        float  input = Input.GetAxisRaw("Horizontal");

        if (Input.touchCount > 0){
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved){

            }
            player.velocity = Vector2.right * Speed * touch.deltaPosition.x;
        }
        else{
            player.velocity = Vector2.zero;
        }

        transform.position = new Vector2(Mathf.Clamp(transform.position.x,-xBound,xBound),transform.position.y);
    }
}