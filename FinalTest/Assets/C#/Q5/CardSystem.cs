using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class CardSystem : MonoBehaviour
{
    public List<GameObject> cards = new List<GameObject>();
    private string[] type = { "Spades", "Diamond", "Heart", "Club" };
    public Button Odd_B;

    private void GetAllCard()
    {
        if (cards.Count == 52) return;

        for (int i = 0; i < type.Length; i++)
        {
            for (int j = 1; j < 14; j++)
            {
                string number = j.ToString();


                switch (j)
                {
                    case 1:
                        number = "A";
                        break;
                    case 11:
                        number = "J";
                        break;
                    case 12:
                        number = "Q";
                        break;
                    case 13:
                        number = "K";
                        break;


                }


                GameObject card = Resources.Load<GameObject>("PlayingCards_" + number + type[i]);

                cards.Add(card);


            }
        }

    }
    public void sort()
    {
        DeleteAllChild();

        var sort = from card in cards
                   where card.name.Contains(type[3]) || card.name.Contains(type[2]) || card.name.Contains(type[1]) || card.name.Contains(type[0])
                   select card;

        foreach (var item in sort)
        {
            Instantiate(item, transform);
        }

        StartCoroutine(SetChildPosition());
    }


    IEnumerator SetChildPosition()
    {
        yield return new WaitForSeconds(0.1f);

        for (int i = 0; i < transform.childCount; i++)
        {
            int x = i % 13;
            int y = i / 13;
            Transform child = transform.GetChild(i);
            child.eulerAngles = new Vector3(180, 0, 0);
            child.localScale = Vector3.one * 20;
            child.position = new Vector3((x - 6) * 1.3f, 4 - y * 2, 0);
            yield return null;
        }
        Odd_B.interactable = true;
    }


    void DeleteAllChild()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }

    }

    public void Odd()
    {
        for (int i = 0; i < type.Length; i++)
        {
            for (int j = 1; j < 7; j++)
            {
                string number = (2*j).ToString();


                switch (2*j)
                {
                    case 1:
                        number = "A";
                        break;
                    case 11:
                        number = "J";
                        break;
                    case 12:
                        number = "Q";
                        break;
                    case 13:
                        number = "K";
                        break;


                }

                GameObject tmp = GameObject.Find("PlayingCards_" + number + type[i]+"(Clone)");
                Destroy(tmp);
            }


        }

    }

    private void Start()
    {

        GetAllCard();
        sort();
    }



}