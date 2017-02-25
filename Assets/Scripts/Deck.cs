using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


public class Deck

{

    public  Stack<Carta> cards = new Stack<Carta>();
  
 



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
