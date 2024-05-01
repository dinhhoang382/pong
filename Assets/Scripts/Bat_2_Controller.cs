using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat_2_Controller : MonoBehaviour
{
   private Rigidbody2D rb;
    public float speed;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            rb.velocity = new Vector2(0f,speed);
        } else if (Input.GetKey(KeyCode.DownArrow)){
            rb.velocity = new Vector2(0f,-speed);
        }else {
            rb.velocity = new Vector2(0f,0f);
        }
    }
}
