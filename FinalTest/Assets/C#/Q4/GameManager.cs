using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Runner runner;
    public CanvasGroup GameOver_S;

    public void GameOver()
    {
        GameOver_S.alpha = 1;
    }

    

    void Start()
    {
        runner.OnGoal += GameOver;
    }

   
}
