using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q3 : MonoBehaviour
{
    public GameObject bulid;
    IEnumerator Move()
    {
        WaitForSecondsRealtime WAS = new WaitForSecondsRealtime(0.01f);
        int q = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Instantiate(bulid, new Vector3(i, q, 0), Quaternion.identity);
                Instantiate(bulid, new Vector3(i, -q + 2, 0), Quaternion.identity);
                Instantiate(bulid, new Vector3(8 - i, q, 0), Quaternion.identity);
                Instantiate(bulid, new Vector3(8 - i, -q + 2, 0), Quaternion.identity);

                yield return WAS;
                q++;
            }
        }

        /*
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 2*i +1 ; j++)
            {
                Instantiate(bulid, new Vector3(i-15, j, 0), Quaternion.identity);
                Instantiate(bulid, new Vector3(-7-i, j, 0), Quaternion.identity);
                Instantiate(bulid, new Vector3(i-15, -j, 0), Quaternion.identity);
                Instantiate(bulid, new Vector3(-7-i, -j, 0), Quaternion.identity);

                yield return WAS;

            }
        }
        */

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 4*i +1 ; j++)
            {
                Instantiate(bulid, new Vector3(i-15, j-2*i, 0), Quaternion.identity);
                Instantiate(bulid, new Vector3(-7-i, j-2*i, 0), Quaternion.identity);

                yield return WAS;

            }
        }


      
    }

    void Start()
    {
        StartCoroutine(Move());

    }


}
