using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q1 : MonoBehaviour
{
    public Text No;
   IEnumerator Move()
    {
        WaitForSecondsRealtime WAS = new WaitForSecondsRealtime(0.2f);
        for (int i = 0; i < 10; i++)
        {
        yield return WAS;
        transform.Translate(Vector3.forward);
            No.text =(i + 1).ToString();
        }

    }

    void Start()
    {
        StartCoroutine(Move());
    }

   
}
