using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct Card
{
    public string Name;
    public Sprite Logo;
    public int Attack, Defence;

    public Card(string name, string logoPath, int attack, int defence)
    {
        Name = name;
        Logo = Resources.Load<Sprite>(logoPath);
        Attack = attack;
        Defence = defence;
    }
}

public static class CardManager
{
    public static List<Card> AllCards = new List<Card>();
}


public class CardManagerScr : MonoBehaviour
{

    public void Awake()
    {

        CardManager.AllCards.Add(new Card("smile", "Sprites/Cards/smile", 4, 3));
        CardManager.AllCards.Add(new Card("face", "Sprites/Cards/face", 5, 5));
        CardManager.AllCards.Add(new Card("hmm", "Sprites/Cards/hmm", 3, 3));
        CardManager.AllCards.Add(new Card("micro", "Sprites/Cards/micro", 2, 1));
        CardManager.AllCards.Add(new Card("pominki", "Sprites/Cards/pominki", 8, 1));
        CardManager.AllCards.Add(new Card("pomoika", "Sprites/Cards/pomoika", 1, 1));
    }
}
