using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird1 : MonoBehaviour

{
    Rigidbody2D rb2d;
    public float speed = 5f;
    [SerializeField]
    private float flapForce = 20f;

    // Start is called before the first frame update
    void Start()

    {
        rb2d.velocity = Vector2.right * speed * Time.deltaTime;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))

            rb2d.velocity = Vector2.right * speed * Time.deltaTime;
        rb2d.AddForce(Vector2.up * flapForce);

    }
}

