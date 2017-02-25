using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Croupier : MonoBehaviour
{
    public Deck baraja = new Deck();
 

    public Button yourButton;
    public Button yourButton2;
    // Use this for initialization
    void Awake ()
    {

        
        

    }
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        Button btn2 = yourButton2.GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnClick2);
    }

    void TaskOnClick()
    {
        GetaCard();
    }
    void TaskOnClick2()
    {

       baraja.cards= Utils.Shuffle(baraja.cards);
    }
    // Update is called once per frame
    void Update ()
    {
    }
    public void GetaCard()
    {
        Carta.CardNumber number = new Carta.CardNumber();
        Carta.CardSuit palo = new Carta.CardSuit();
        Carta card= new Carta(palo,number);
        card = baraja.cards.Peek();
        Debug.Log(card.number);
        Debug.Log(card.Suit);
    }

}

