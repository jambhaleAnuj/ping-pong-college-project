using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float speed;
    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        Play();
        
    }
    public void Reset()
    {
        rigidbody.velocity = Vector2.zero;
        transform.position = startPosition;
        Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Play()
    {

        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rigidbody.velocity = new Vector2(speed * x, speed * y);
    }
}
