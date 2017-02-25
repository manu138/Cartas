using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta
{
    public CardSuit Suit
    {
        get;
        private set;
    }

    public CardNumber number
    {
        get;
        set;
    }

   public Carta(CardSuit suit, CardNumber value)
    {
       
        Suit = suit;
        number = value;
    }
    public enum CardNumber
    {
        A = 1, dos = 2, tres = 3, cuatro = 4, cinco = 5, seis = 6, siete = 7, ocho = 8, nueve = 9, J = 10, Q = 11, K = 12

    }


    public enum CardSuit
    {
        Spades = 1,
        Hearts = 2,
        Diamonds = 3,
        Clubs = 4
    }

}



