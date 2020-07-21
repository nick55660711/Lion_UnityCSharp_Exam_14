using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public int LevelID;

    private void Start()
    {
        LevelID = SceneManager.GetActiveScene().buildIndex;
    }


    private void Update()
    {
        if (Input.GetKeyDown("o")&& LevelID !=0)
            SceneManager.LoadScene(LevelID-1);
        if (Input.GetKeyDown("p") && LevelID != 4)
            SceneManager.LoadScene(LevelID+1);



    }
}
