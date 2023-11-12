using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun_Leg : MonoBehaviour
{
    public Sun sun;

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "SunWall")
        {
            sun.is_jump = false;
        }
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "Wall" || collision.gameObject.tag == "SunWall") && sun.gameObject.layer == 9)
        {
            sun.is_jump = false;
        }
        if (collision.gameObject.tag == "Sun_L_Clip" || collision.gameObject.tag == "Sun_M_Clip")
        {
            sun.is_jump = true;
        }
        if (collision.gameObject.tag == "Sun_M_Clip")
        {
            Sun_Lope();
        }
        if (collision.gameObject.tag == "Sun_R_Clip")
        {
            sun.filp_mood = false;
            sun.button.Sun_Jump();
            sun.is_jump = false;
            sun.rigidbody.gravityScale = 5;
        }
    }

    void Sun_Lope()
    {
        sun.is_jump = true;
        sun.button.Sun_Flip();//버튼 변경
        sun.rigidbody.velocity = Vector3.zero;
        sun.rigidbody.gravityScale = 0;//중력 0
        sun.filp_mood = true;//플립
    }
}
