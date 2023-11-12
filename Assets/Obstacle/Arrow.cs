using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(-8 * Time.deltaTime, 0, 0);
    }
}
