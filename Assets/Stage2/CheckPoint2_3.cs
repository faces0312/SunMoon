using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint2_3 : MonoBehaviour
{
    public Fail2 fail;
    public GameObject ballon;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sun" || collision.gameObject.tag == "Moon")
        {
            fail.check_point = 3;
            StartCoroutine(nameof(Up));

            Data.Instance.gameData.stage2_checkpoint = 3;
            if (Data.Instance.gameData.stage2_bestcheck < Data.Instance.gameData.stage2_checkpoint)
            {
                Data.Instance.gameData.stage2_bestcheck = Data.Instance.gameData.stage2_checkpoint;
            }
            Data.Instance.SaveGameData();
        }
    }

    IEnumerator Up()
    {
        for (int i = 0; i < 100; i++)
        {
            ballon.transform.Translate(0, 5 * Time.deltaTime, 0);
            yield return new WaitForSeconds(0.03f);
        }
    }
}
