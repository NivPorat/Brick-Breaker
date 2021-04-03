using System.Collections;

using UnityEngine;

public class racket : MonoBehaviour
{
    public float speed = 150;
    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    }
}
