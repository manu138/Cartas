using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


public static class Deck

{

    public static Stack<Carta> cards = new Stack<Carta>();
  
    public static void GetaCard(Stack<Carta> cards)
    {
       Debug.Log( cards.Peek());
    }

         public static Stack<Carta> Shuffle(this Stack<Carta> cards)
         {
         return new Stack<Carta>(cards.OrderBy(x => Random.Range(0,52)));
          }


    static Deck()
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
