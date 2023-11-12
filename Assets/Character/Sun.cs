using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public AdMobManager ad;

    public GameObject fail_Page;

    public Button button;

    public Animator ani;

    public Rigidbody2D rigidbody;

    public bool filp_mood;

    public int jumpPower;// 점프 정도
    public bool is_jump;

    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        jumpPower = 15;
        is_jump = false;

        speed = 5;

        filp_mood = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);

        if(filp_mood == false)
        {
            if(button.is_change == false)
            {
                if (Input.GetKeyDown(KeyCode.W))
                    Jump();
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                    Jump();
            }
        }
        else
        {
            if(button.is_change == false)
            {
                if (Input.GetKeyDown(KeyCode.W))
                    Filp();
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                    Filp();
            }
        }
    }

    public void Jump()
    {
        if (is_jump == false)
        {
            ani.SetTrigger("Jump");
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, 0f);
            rigidbody.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            is_jump = true;
        }
        else
            return;
    }

    public void Filp()
    {
        if (rigidbody.gravityScale == 0)
        {
            if (gameObject.transform.localScale.y > 0)
            {
                gameObject.transform.localScale = new Vector3(0.7f, -0.7f, 1);
                gameObject.transform.position =
                    new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1.2f, gameObject.transform.position.z);
                gameObject.layer = 14;
            }
            else
            {
                gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 1);
                gameObject.transform.position =
                    new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1.2f, gameObject.transform.position.z);
                gameObject.layer = 9;
            }
        }
        else
            return;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Arrow" )
        {
            fail_Page.gameObject.SetActive(true);
            Data.Instance.gameData.death_cnt++;
            if (Data.Instance.gameData.death_cnt % 8 == 0)
            {
                ad.ShowFrontAd();
            }
        }

        if (collision.gameObject.tag == "Die")
        {
            fail_Page.gameObject.SetActive(true);
            Data.Instance.gameData.death_cnt++;
            if (Data.Instance.gameData.death_cnt % 8 == 0)
            {
                ad.ShowFrontAd();
            }
        }

        /*if (collision.gameObject.tag == "Flower")
        {
            collision.gameObject.SetActive(false);

            if (button.is_change == false)
            {
                button.sun_jump.gameObject.transform.position = button.right_pos.gameObject.transform.position;
                button.sun_flip.gameObject.transform.position = button.right_pos.gameObject.transform.position;

                button.moon_jump.gameObject.transform.position = button.left_pos.gameObject.transform.position;
                button.moon_flip.gameObject.transform.position = button.left_pos.gameObject.transform.position;
            }
            else
            {
                button.sun_jump.gameObject.transform.position = button.left_pos.gameObject.transform.position;
                button.sun_flip.gameObject.transform.position = button.left_pos.gameObject.transform.position;

                button.moon_jump.gameObject.transform.position = button.right_pos.gameObject.transform.position;
                button.moon_flip.gameObject.transform.position = button.right_pos.gameObject.transform.position;
            }

            if(button.is_change == false)
                button.is_change = true;
            else
                button.is_change = false;
        }*/
    }

}
