using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    public delegate void Goal_Delegate();
    public Goal_Delegate OnGoal;
    bool Goal;

    IEnumerator Move()
    {
        WaitForSecondsRealtime WAS = new WaitForSecondsRealtime(0.2f); 
        
        for (int i = 0; !Goal;)
        {
            transform.Translate(transform.right * -1);
            yield return WAS;
        }
    }

    void Start()
    {
        Goal = false;
        StartCoroutine(Move());
    }



    private void OnTriggerEnter(Collider other)
    {
        OnGoal();
        Goal = true;
    }


}
