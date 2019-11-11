using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DeckDebate1a : MonoBehaviour
{
    public Image Card1;
    public Image Card2;
    public Image Card3;
    public Image Card4;
    public Image Card5;
    public Image Card6;
    public Image Card7;
    public Image Card8;
    public Image Card9;
    public Image Card10;
    public string CardPosition;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (CardPosition == "5") 
        {
        }
        else
        {
            transform.position = Card1.transform.position = new Vector3(-0.5f, -0.38f, 1);
            transform.position = Card2.transform.position = new Vector3(-0.25f, -0.38f, 1);
            transform.position = Card3.transform.position = new Vector3(-0f, -0.38f, 1);
            transform.position = Card4.transform.position = new Vector3(0.25f, -0.38f, 1);
            transform.position = Card5.transform.position = new Vector3(0.5f, -0.38f, 1);
            CardPosition = (CardPosition + ("1"));

        }
     

    }
}
