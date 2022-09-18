using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addScore2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Find("Player2").GetComponent<Score>().AddScore2(1);
    }
}
