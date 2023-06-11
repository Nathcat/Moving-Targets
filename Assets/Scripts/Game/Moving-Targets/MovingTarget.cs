using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingTarget : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public Camera camera;
    private Rigidbody2D rb;
    public Text scoreText;

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
