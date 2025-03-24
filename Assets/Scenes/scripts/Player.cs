using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rBody;
    private float speed = 5;
    private float horizontalInput;

    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        rBody.velocity = new Vector2(horizontalInput * speed, rBody.velocity.y);
    }
}
