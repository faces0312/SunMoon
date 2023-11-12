using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon_Leg : MonoBehaviour
{
    public Moon moon;

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "MoonWall")
        {
            moon.is_jump = false;
        }
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "Wall" || collision.gameObject.tag == "MoonWall") && moon.gameObject.layer == 10)
        {
            moon.is_jump = false;
        }
        if (collision.gameObject.tag == "Moon_L_Clip" || collision.gameObject.tag == "Moon_M_Clip")
        {
            moon.is_jump = true;
        }
        if (collision.gameObject.tag == "Moon_M_Clip")
        {
            Moon_Lope();
        }
        if (collision.gameObject.tag == "Moon_R_Clip")
        {
            moon.filp_mood = false;
            moon.button.Moon_Jump();
            moon.is_jump = false;
            moon.rigidbody.gravityScale = 5;
        }   
    }

    void Moon_Lope()
    {
        moon.is_jump = true;//а║га ╬х╣й
        moon.button.Moon_Flip();
        moon.rigidbody.velocity = Vector3.zero;
        moon.rigidbody.gravityScale = 0;
        moon.filp_mood = true;
    }
}
