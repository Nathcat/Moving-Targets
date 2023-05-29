using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTarget : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private Rigidbody2D rb;

    void Start() {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        if (transform.position.y <= -25f) {
            Destroy(gameObject);
        }
    }
}
