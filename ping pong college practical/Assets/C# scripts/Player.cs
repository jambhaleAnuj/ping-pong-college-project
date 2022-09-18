using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Rigidbody2D rigidbody2D;

    public Vector3 startposition;
    private float movement;

    public bool isPlayer1;
    void Start()
    {
        startposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        rigidbody2D.velocity = new Vector2(0, movement * speed);
    }

    public void Reset()
    {
        rigidbody2D.velocity = Vector2.zero;
        transform.position = startposition;
    }
}
