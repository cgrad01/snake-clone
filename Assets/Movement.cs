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
        snake.velocity = Vector3.right;
    }
    void Update()
    {
        Move();
    }

    Vector3 lastDirection = Vector3.right;
    private void Move()
    {
        Vector3 direction = lastDirection;
        if (Input.GetKeyDown(KeyCode.W) && Vector3.Angle(Vector3.up, lastDirection) == 90)
        {
            snake.velocity = Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.S) && Vector3.Angle(Vector3.down, lastDirection) == 90)
        {
            snake.velocity = Vector3.down;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            snake.velocity = Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            snake.velocity = Vector3.right;
        }
    }

}
