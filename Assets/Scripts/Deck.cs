using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class Deck

{

    private Stack<Carta> cards = new Stack<Carta>();

    public static void GetaCard(Carta[] cards)
    {
        for (int i = 0; i < cards.Length; i++)
        {
            Debug.Log(cards[i]);
        }
    }

   // public static void Shuffle(this Stack<Carta> cards)
      //   {

   // }

   
    public Deck()
    {
       
        Carta.CardSuit[] palos= (Carta.CardSuit[])System.Enum.GetValues(typeof(Carta.CardSuit));
        Carta.CardNumber[] values = (Carta.CardNumber[])System.Enum.GetValues(typeof(Carta.CardNumber));//los trae como T
        foreach (Carta.CardNumber valorCarta in values)
        {
            foreach (Carta.CardSuit palo in palos)
            { 
                cards.Push(new Carta(palo, valorCarta));
            }
        }
    

      


    }






}
