using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addScore1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Find("Player1").GetComponent<Score>().AddScore1(1);
    }
}
