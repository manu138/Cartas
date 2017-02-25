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
       
        baraja.GetaCard(baraja.cards);
    }
    void TaskOnClick2()
    {

        Utils.Shuffle(baraja.cards);
    }
    // Update is called once per frame
    void Update ()
    {
    }
}

