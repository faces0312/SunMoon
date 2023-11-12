using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon_Boss : MonoBehaviour
{
    public Animator ani;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Moon")
        {
            ani.SetTrigger("End");
        }
    }
}
