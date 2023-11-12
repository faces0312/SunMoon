using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate1 : MonoBehaviour
{
    public GameObject camera;

    public float zRotation;

    private void Start()
    {
        zRotation = 0f;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sun" || collision.gameObject.tag == "Moon")
        {
            StartCoroutine(nameof(Rotate));
        }
    }

    IEnumerator Rotate()
    {
        /*for (int i = 0; i < 100; i++)
        {
            camera.transform.Rotate(new Vector3(0, 0, - 20 * Time.deltaTime));
            yield return new WaitForSeconds(0.001f);
        }*/
        while (zRotation >= -90)
        {
            camera.gameObject.transform.eulerAngles = new Vector3(0, 0, zRotation);
            zRotation -= 0.03f;
            yield return new WaitForSeconds(0.009f);
        }
        camera.gameObject.transform.eulerAngles = new Vector3(0, 0, -90f);
        /*camera.transform.Rotate(new Vector3(0, 0, -5));

        float st = camera.gameObject.transform.eulerAngles.z;
        float er = -90f;

        float t = 0f;

        while (t < 10f)
        {
            t += Time.deltaTime;
            float speed = t;
            float zRotation = Mathf.Lerp(st, er, speed) % 360.0f;

            camera.gameObject.transform.eulerAngles = new Vector3(0, 0, zRotation);
            // Debug.Log(yRotation + " " + transform.eulerAngles.y);

            yield return null;
        }*/

    }
}
