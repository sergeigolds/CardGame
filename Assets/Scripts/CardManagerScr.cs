using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct Card
{
    public string Name;
    public Sprite Logo;
    public int Attack, Defence;

    public Card(string name, string LogoPath, int attack, int defence)
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
        CardManager.AllCards.Add(new Card("Card1", "Sprite/Cards/Card1", 5, 5));
        CardManager.AllCards.Add(new Card("Card2", "Sprite/Cards/Card2", 4, 3));
        CardManager.AllCards.Add(new Card("Card3", "Sprite/Cards/Card3", 3, 3));
        CardManager.AllCards.Add(new Card("Card4", "Sprite/Cards/Card4", 2, 1));
        CardManager.AllCards.Add(new Card("Card5", "Sprite/Cards/Card5", 8, 1));
        CardManager.AllCards.Add(new Card("Card6", "Sprite/Cards/Card6", 1, 1));
    }
}
