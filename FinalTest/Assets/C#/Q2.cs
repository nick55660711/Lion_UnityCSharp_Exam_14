using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q2 : MonoBehaviour
{
    public List<Sprite> AllPrize = new List<Sprite>();
    public Image Prize;
    public Text Message;
    public Button Draw_B;
    IEnumerator Change()
        {
        WaitForSecondsRealtime WAS = new WaitForSecondsRealtime(0.03f);

        for (int i = 0; i < 22; i++)
        {
            Sprite tmp = AllPrize[Random.Range(0, 23)];
            Prize.sprite = tmp;
            yield return WAS;
        }
        Sprite tmp1 = AllPrize[Random.Range(0, 23)];
            Prize.sprite = tmp1;
        Message.text = "You got " + tmp1.name;
        Draw_B.interactable = true;
    }

    public void Draw() {
        Draw_B.interactable = false;
        StartCoroutine(Change());
       

    }
}
