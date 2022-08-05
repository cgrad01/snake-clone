using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D snake;
    public Vector2 movement;

    void Start()
    {
        snake = this.GetComponent<Rigidbody2D>();
        snake.velocity = new Vector2(1, 0) * speed * Time.fixedDeltaTime;
    }
    void Update()
    {
        snake.AddForce(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        // movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        // snake.velocity += (movement * Time.fixedDeltaTime);
    }

}
