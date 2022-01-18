using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 Player;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float arahY = Input.GetAxisRaw("Vertical");
        float arahX = Input.GetAxisRaw("Horizontal");
        Player = new Vector2(arahX, arahY).normalized;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(Player.x * speed, Player.y * speed);
    }
}
