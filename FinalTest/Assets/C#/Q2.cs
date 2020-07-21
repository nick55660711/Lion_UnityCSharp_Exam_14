using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q2 : MonoBehaviour
{
    public List<Sprite> AllPrize = new List<Sprite>();
    public Image Prize;
    public Text Message;

    public void Draw() {
        Sprite tmp = AllPrize[Random.Range(0, 23)];
        Prize.sprite = tmp;
        Message.text = "You got " + tmp.name;

    }
}
