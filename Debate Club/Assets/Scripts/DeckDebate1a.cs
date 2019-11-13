using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DeckDebate1a : MonoBehaviour
{
    public Image DCard1;
    public Image DCard2;
    public Image DCard3;
    public Image DCard4;
    public Image DCard5;
    public Image DCard6;
    public Image DCard7;
    public Image DCard8;
    public Image DCard9;
    public Image DCard10;

    public Button DButton1;
    public Button DButton2;
    public Button DButton3;
    public Button DButton4;
    public Button DButton5;
    public Button DButton6;
    public Button DButton7;
    public Button DButton8;
    public Button DButton9;
    public Button DButton10;

    public Text DCardDescription1;
    public Text DCardDescription2;
    public Text DCardDescription3;
    public Text DCardDescription4;
    public Text DCardDescription5;
    public Text DCardDescription6;
    public Text DCardDescription7;
    public Text DCardDescription8;
    public Text DCardDescription9;
    public Text DCardDescription10;

    public Text DEmotionPro1;
    public Text DEmotionPro2;
    public Text DEmotionPro3;
    public Text DEmotionPro4;
    public Text DEmotionPro5;
    public Text DEmotionPro6;
    public Text DEmotionPro7;
    public Text DEmotionPro8;
    public Text DEmotionPro9;
    public Text DEmotionPro10;

    public Text DEmotionCon1;
    public Text DEmotionCon2;
    public Text DEmotionCon3;
    public Text DEmotionCon4;
    public Text DEmotionCon5;
    public Text DEmotionCon6;
    public Text DEmotionCon7;
    public Text DEmotionCon8;
    public Text DEmotionCon9;
    public Text DEmotionCon10;

    public Text DAA1;
    public Text DAA2;
    public Text DAA3;
    public Text DAA4;
    public Text DAA5;
    public Text DAA6;
    public Text DAA7;
    public Text DAA8;
    public Text DAA9;
    public Text DAA10;

    public Text DAAPro1;
    public Text DAAPro2;
    public Text DAAPro3;
    public Text DAAPro4;
    public Text DAAPro5;
    public Text DAAPro6;
    public Text DAAPro7;
    public Text DAAPro8;
    public Text DAAPro9;
    public Text DAAPro10;

    public Text DAACon1;
    public Text DAACon2;
    public Text DAACon3;
    public Text DAACon4;
    public Text DAACon5;
    public Text DAACon6;
    public Text DAACon7;
    public Text DAACon8;
    public Text DAACon9;
    public Text DAACon10;

    // The Cards
    Image Card1;
    Image Card2;
    Image Card3;
    Image Card4;
    Image Card5;

    Button Button1;
    Button Button2;
    Button Button3;
    Button Button4;
    Button Button5;
   
    Text CardDescription1;
    Text CardDescription2;
    Text CardDescription3;
    Text CardDescription4;
    Text CardDescription5;

    Text EmotionPro1;
    Text EmotionPro2;
    Text EmotionPro3;
    Text EmotionPro4;
    Text EmotionPro5;

    Text EmotionCon1;
    Text EmotionCon2;
    Text EmotionCon3;
    Text EmotionCon4;
    Text EmotionCon5;

    Text AA1;
    Text AA2;
    Text AA3;
    Text AA4;
    Text AA5;

    Text AAPro1;
    Text AAPro2;
    Text AAPro3;
    Text AAPro4;
    Text AAPro5;

    Text AACon1;
    Text AACon2;
    Text AACon3;
    Text AACon4;
    Text AACon5;

    // This details your current audience approval
    public int PlayerAudienceApproval = 50;
    // This represents the audiences current mood 1 = Serious, 2 = Humourous, 3 = Sad, 4 = Passionate, and 5 = Angry
    public int AudienceMood = 1;
    // This represents the players speech
    public Text PlayerSpeech;
    // This represents the thought bubble
    public Image ThoughtBubble;

    public int CardPosition = 5;

    // Start is called before the first frame update
    void Start()
    {
        Card1 = DCard1;
        Button1 = DButton1;
        CardDescription1 = DCardDescription1;
        EmotionPro1 = DEmotionPro1;
        EmotionCon1 = DEmotionCon1;
        AA1 = DAA1;
        AAPro1 = DAAPro1;
        AACon1 = DAACon1;

        Card2 = DCard2;
        Button2 = DButton2;
        CardDescription2 = DCardDescription2;
        EmotionPro2 = DEmotionPro2;
        EmotionCon2 = DEmotionCon2;
        AA2 = DAA2;
        AAPro2 = DAAPro2;
        AACon2 = DAACon2;

        Card3 = DCard3;
        Button3 = DButton3;
        CardDescription3 = DCardDescription3;
        EmotionPro3 = DEmotionPro3;
        EmotionCon3 = DEmotionCon3;
        AA3 = DAA3;
        AAPro3 = DAAPro3;
        AACon3 = DAACon3;

        Card4 = DCard4;
        Button4 = DButton4;
        CardDescription4 = DCardDescription4;
        EmotionPro4 = DEmotionPro4;
        EmotionCon4 = DEmotionCon4;
        AA4 = DAA4;
        AAPro4 = DAAPro4;
        AACon4 = DAACon4;

        Card5 = DCard5;
        Button5 = DButton5;
        CardDescription5 = DCardDescription5;
        EmotionPro5 = DEmotionPro5;
        EmotionCon5 = DEmotionCon5;
        AA5 = DAA5;
        AAPro5 = DAAPro5;
        AACon5 = DAACon5;

        Button1.onClick.AddListener(Button1Clicked);
        Button2.onClick.AddListener(Button2Clicked);
        Button3.onClick.AddListener(Button3Clicked);
        Button4.onClick.AddListener(Button4Clicked);
        Button5.onClick.AddListener(Button5Clicked);
      

    }

    // Update is called once per frame
    void Update()
    {
            transform.position = Card1.transform.position = new Vector3(-0.5f, -0.38f, 1);
            transform.position = Card2.transform.position = new Vector3(-0.25f, -0.38f, 1);
            transform.position = Card3.transform.position = new Vector3(-0f, -0.38f, 1);
            transform.position = Card4.transform.position = new Vector3(0.25f, -0.38f, 1);
            transform.position = Card5.transform.position = new Vector3(0.5f, -0.38f, 1);
    }

    void Button1Clicked()
    {
        StartCoroutine(UI_Timer());
        CardPosition = CardPosition + 1;
        transform.position = Card1.transform.position = new Vector3(100, 100, 100);
        if (CardPosition == 1) {
            Card1 = DCard1;
            Button1 = DButton1;
            CardDescription1 = DCardDescription1;
            EmotionPro1 = DEmotionPro1;
            EmotionCon1 = DEmotionCon1;
            AA1 = DAA1;
            AAPro1 = DAAPro1;
            AACon1 = DAACon1;
        }
        if (CardPosition == 2)
        {
            Card1 = DCard2;
            Button1 = DButton2;
            CardDescription1 = DCardDescription2;
            EmotionPro1 = DEmotionPro2;
            EmotionCon1 = DEmotionCon2;
            AA1 = DAA2;
            AAPro1 = DAAPro2;
            AACon1 = DAACon2;
        }
        if (CardPosition == 3)
        {
            Card1 = DCard3;
            Button1 = DButton3;
            CardDescription1 = DCardDescription3;
            EmotionPro1 = DEmotionPro3;
            EmotionCon1 = DEmotionCon3;
            AA1 = DAA3;
            AAPro1 = DAAPro3;
            AACon1 = DAACon3;
        }
        if (CardPosition == 4)
        {
            Card1 = DCard4;
            Button1 = DButton4;
            CardDescription1 = DCardDescription4;
            EmotionPro1 = DEmotionPro4;
            EmotionCon1 = DEmotionCon4;
            AA1 = DAA4;
            AAPro1 = DAAPro4;
            AACon1 = DAACon4;
        }
        if (CardPosition == 5)
        {
            Card1 = DCard5;
            Button1 = DButton5;
            CardDescription1 = DCardDescription5;
            EmotionPro1 = DEmotionPro5;
            EmotionCon1 = DEmotionCon5;
            AA1 = DAA5;
            AAPro1 = DAAPro5;
            AACon1 = DAACon5;
        }
        if (CardPosition == 6)
        {
            Card1 = DCard6;
            Button1 = DButton6;
            CardDescription1 = DCardDescription6;
            EmotionPro1 = DEmotionPro6;
            EmotionCon1 = DEmotionCon6;
            AA1 = DAA6;
            AAPro1 = DAAPro6;
            AACon1 = DAACon6;
        }
        if (CardPosition == 7)
        {
            Card1 = DCard7;
            Button1 = DButton7;
            CardDescription1 = DCardDescription7;
            EmotionPro1 = DEmotionPro7;
            EmotionCon1 = DEmotionCon7;
            AA1 = DAA7;
            AAPro1 = DAAPro7;
            AACon1 = DAACon7;
        }
        if (CardPosition == 8)
        {
            Card1 = DCard8;
            Button1 = DButton8;
            CardDescription1 = DCardDescription8;
            EmotionPro1 = DEmotionPro8;
            EmotionCon1 = DEmotionCon8;
            AA1 = DAA8;
            AAPro1 = DAAPro8;
            AACon1 = DAACon8;
        }
        if (CardPosition == 9)
        {
            Card1 = DCard9;
            Button1 = DButton9;
            CardDescription1 = DCardDescription9;
            EmotionPro1 = DEmotionPro9;
            EmotionCon1 = DEmotionCon9;
            AA1 = DAA9;
            AAPro1 = DAAPro9;
            AACon1 = DAACon9;
        }
        if (CardPosition == 10)
        {
            Card1 = DCard10;
            Button1 = DButton10;
            CardDescription1 = DCardDescription10;
            EmotionPro1 = DEmotionPro10;
            EmotionCon1 = DEmotionCon10;
            AA1 = DAA10;
            AAPro1 = DAAPro10;
            AACon1 = DAACon10;
        }

        // Turns off the thought bubble
        ThoughtBubble.gameObject.SetActive(false);
        int TempProMood = int.Parse(EmotionPro1.text);
        int TempConMood = int.Parse(EmotionCon1.text);
        if (AudienceMood == TempProMood)
        {
            int TempPro = int.Parse(AAPro1.text);
            PlayerAudienceApproval = PlayerAudienceApproval + TempPro;
        }
        else if (AudienceMood == TempConMood)
        {
            int TempCon = int.Parse(AACon1.text);
            PlayerAudienceApproval = PlayerAudienceApproval + TempCon; 
        }
        else
        {
            int Temp = int.Parse(AA1.text);
            PlayerAudienceApproval = PlayerAudienceApproval + Temp;
        }
        PlayerSpeech.text = CardDescription1.text.ToString();
    }

    void Button2Clicked()
    {
        StartCoroutine(UI_Timer());
        CardPosition = CardPosition + 1;
        transform.position = Card2.transform.position = new Vector3(100, 100, 100);
        if (CardPosition == 1)
        {
            Card2 = DCard1;
            Button2 = DButton1;
            CardDescription2 = DCardDescription1;
            EmotionPro2 = DEmotionPro1;
            EmotionCon2 = DEmotionCon1;
            AA2 = DAA1;
            AAPro2 = DAAPro1;
            AACon2 = DAACon1;
        }
        if (CardPosition == 2)
        {
            Card2 = DCard2;
            Button2 = DButton2;
            CardDescription2 = DCardDescription2;
            EmotionPro2 = DEmotionPro2;
            EmotionCon2 = DEmotionCon2;
            AA2 = DAA2;
            AAPro2 = DAAPro2;
            AACon2 = DAACon2;
        }
        if (CardPosition == 3)
        {
            Card2 = DCard3;
            Button2 = DButton3;
            CardDescription2 = DCardDescription3;
            EmotionPro2 = DEmotionPro3;
            EmotionCon2 = DEmotionCon3;
            AA2 = DAA3;
            AAPro2 = DAAPro3;
            AACon2 = DAACon3;
        }
        if (CardPosition == 4)
        {
            Card2 = DCard4;
            Button2 = DButton4;
            CardDescription2 = DCardDescription4;
            EmotionPro2 = DEmotionPro4;
            EmotionCon2 = DEmotionCon4;
            AA2 = DAA4;
            AAPro2 = DAAPro4;
            AACon2 = DAACon4;
        }
        if (CardPosition == 5)
        {
            Card2 = DCard5;
            Button2 = DButton5;
            CardDescription2 = DCardDescription5;
            EmotionPro2 = DEmotionPro5;
            EmotionCon2 = DEmotionCon5;
            AA2 = DAA5;
            AAPro2 = DAAPro5;
            AACon2 = DAACon5;
        }
        if (CardPosition == 6)
        {
            Card2 = DCard6;
            Button2 = DButton6;
            CardDescription2 = DCardDescription6;
            EmotionPro2 = DEmotionPro6;
            EmotionCon2 = DEmotionCon6;
            AA2 = DAA6;
            AAPro2 = DAAPro6;
            AACon2 = DAACon6;
        }
        if (CardPosition == 7)
        {
            Card2 = DCard7;
            Button2 = DButton7;
            CardDescription2 = DCardDescription7;
            EmotionPro2 = DEmotionPro7;
            EmotionCon2 = DEmotionCon7;
            AA2 = DAA7;
            AAPro2 = DAAPro7;
            AACon2 = DAACon7;
        }
        if (CardPosition == 8)
        {
            Card2 = DCard8;
            Button2 = DButton8;
            CardDescription2 = DCardDescription8;
            EmotionPro2 = DEmotionPro8;
            EmotionCon2 = DEmotionCon8;
            AA2 = DAA8;
            AAPro2 = DAAPro8;
            AACon2 = DAACon8;
        }
        if (CardPosition == 9)
        {
            Card2 = DCard9;
            Button2 = DButton9;
            CardDescription2 = DCardDescription9;
            EmotionPro2 = DEmotionPro9;
            EmotionCon2 = DEmotionCon9;
            AA2 = DAA9;
            AAPro2 = DAAPro9;
            AACon2 = DAACon9;
        }
        if (CardPosition == 10)
        {
            Card2 = DCard10;
            Button2 = DButton10;
            CardDescription2 = DCardDescription10;
            EmotionPro2 = DEmotionPro10;
            EmotionCon2 = DEmotionCon10;
            AA2 = DAA10;
            AAPro2 = DAAPro10;
            AACon2 = DAACon10;
        }

        // Turns off the thought bubble
        ThoughtBubble.gameObject.SetActive(false);
        int TempProMood = int.Parse(EmotionPro2.text);
        int TempConMood = int.Parse(EmotionCon2.text);
        if (AudienceMood == TempProMood)
        {
            int TempPro = int.Parse(AAPro2.text);
            PlayerAudienceApproval = PlayerAudienceApproval + TempPro;
        }
        else if (AudienceMood == TempConMood)
        {
            int TempCon = int.Parse(AACon2.text);
            PlayerAudienceApproval = PlayerAudienceApproval + TempCon;
        }
        else
        {
            int Temp = int.Parse(AA2.text);
            PlayerAudienceApproval = PlayerAudienceApproval + Temp;
        }
        PlayerSpeech.text = CardDescription2.text.ToString();
    }

    void Button3Clicked()
    {
        StartCoroutine(UI_Timer());
        CardPosition = CardPosition + 1;
        transform.position = Card3.transform.position = new Vector3(100, 100, 100);
        if (CardPosition == 1)
        {
            Card3 = DCard1;
            Button3 = DButton1;
            CardDescription3 = DCardDescription1;
            EmotionPro3 = DEmotionPro1;
            EmotionCon3 = DEmotionCon1;
            AA3 = DAA1;
            AAPro3 = DAAPro1;
            AACon3 = DAACon1;
        }
        if (CardPosition == 2)
        {
            Card3 = DCard2;
            Button3 = DButton2;
            CardDescription3 = DCardDescription2;
            EmotionPro3 = DEmotionPro2;
            EmotionCon3 = DEmotionCon2;
            AA3 = DAA2;
            AAPro3 = DAAPro2;
            AACon3 = DAACon2;
        }
        if (CardPosition == 3)
        {
            Card3 = DCard3;
            Button3 = DButton3;
            CardDescription3 = DCardDescription3;
            EmotionPro3 = DEmotionPro3;
            EmotionCon3 = DEmotionCon3;
            AA3 = DAA3;
            AAPro3 = DAAPro3;
            AACon3 = DAACon3;
        }
        if (CardPosition == 4)
        {
            Card3 = DCard4;
            Button3 = DButton4;
            CardDescription3 = DCardDescription4;
            EmotionPro3 = DEmotionPro4;
            EmotionCon3 = DEmotionCon4;
            AA3 = DAA4;
            AAPro3 = DAAPro4;
            AACon3 = DAACon4;
        }
        if (CardPosition == 5)
        {
            Card3 = DCard5;
            Button3 = DButton5;
            CardDescription3 = DCardDescription5;
            EmotionPro3 = DEmotionPro5;
            EmotionCon3 = DEmotionCon5;
            AA3 = DAA5;
            AAPro3 = DAAPro5;
            AACon3 = DAACon5;
        }
        if (CardPosition == 6)
        {
            Card3 = DCard6;
            Button3 = DButton6;
            CardDescription3 = DCardDescription6;
            EmotionPro3 = DEmotionPro6;
            EmotionCon3 = DEmotionCon6;
            AA3 = DAA6;
            AAPro3 = DAAPro6;
            AACon3 = DAACon6;
        }
        if (CardPosition == 7)
        {
            Card3 = DCard7;
            Button3 = DButton7;
            CardDescription3 = DCardDescription7;
            EmotionPro3 = DEmotionPro7;
            EmotionCon3 = DEmotionCon7;
            AA3 = DAA7;
            AAPro3 = DAAPro7;
            AACon3 = DAACon7;
        }
        if (CardPosition == 8)
        {
            Card3 = DCard8;
            Button3 = DButton8;
            CardDescription3 = DCardDescription8;
            EmotionPro3 = DEmotionPro8;
            EmotionCon3 = DEmotionCon8;
            AA3 = DAA8;
            AAPro3 = DAAPro8;
            AACon3 = DAACon8;
        }
        if (CardPosition == 9)
        {
            Card3 = DCard9;
            Button3 = DButton9;
            CardDescription3 = DCardDescription9;
            EmotionPro3 = DEmotionPro9;
            EmotionCon3 = DEmotionCon9;
            AA3 = DAA9;
            AAPro3 = DAAPro9;
            AACon3 = DAACon9;
        }
        if (CardPosition == 10)
        {
            Card3 = DCard10;
            Button3 = DButton10;
            CardDescription3 = DCardDescription10;
            EmotionPro3 = DEmotionPro10;
            EmotionCon3 = DEmotionCon10;
            AA3 = DAA10;
            AAPro3 = DAAPro10;
            AACon3 = DAACon10;
        }
        // Turns off the thought bubble
        ThoughtBubble.gameObject.SetActive(false);
        int TempProMood = int.Parse(EmotionPro3.text);
        int TempConMood = int.Parse(EmotionCon3.text);
        if (AudienceMood == TempProMood)
        {
            int TempPro = int.Parse(AAPro3.text);
            PlayerAudienceApproval = PlayerAudienceApproval + TempPro;
        }
        else if (AudienceMood == TempConMood)
        {
            int TempCon = int.Parse(AACon3.text);
            PlayerAudienceApproval = PlayerAudienceApproval + TempCon;
        }
        else
        {
            int Temp = int.Parse(AA3.text);
            PlayerAudienceApproval = PlayerAudienceApproval + Temp;
        }
        PlayerSpeech.text = CardDescription3.text.ToString();
    }

    void Button4Clicked()
    {
        StartCoroutine(UI_Timer());
        CardPosition = CardPosition + 1;
        transform.position = Card4.transform.position = new Vector3(100, 100, 100);
        if (CardPosition == 1)
        {
            Card4 = DCard1;
            Button4 = DButton1;
            CardDescription4 = DCardDescription1;
            EmotionPro4 = DEmotionPro1;
            EmotionCon4 = DEmotionCon1;
            AA4 = DAA1;
            AAPro4 = DAAPro1;
            AACon4 = DAACon1;
        }
        if (CardPosition == 2)
        {
            Card4 = DCard2;
            Button4 = DButton2;
            CardDescription4 = DCardDescription2;
            EmotionPro4 = DEmotionPro2;
            EmotionCon4 = DEmotionCon2;
            AA4 = DAA2;
            AAPro4 = DAAPro2;
            AACon4 = DAACon2;
        }
        if (CardPosition == 3)
        {
            Card4 = DCard3;
            Button4 = DButton3;
            CardDescription4 = DCardDescription3;
            EmotionPro4 = DEmotionPro3;
            EmotionCon4 = DEmotionCon3;
            AA4 = DAA3;
            AAPro4 = DAAPro3;
            AACon4 = DAACon3;
        }
        if (CardPosition == 4)
        {
            Card4 = DCard4;
            Button4 = DButton4;
            CardDescription4 = DCardDescription4;
            EmotionPro4 = DEmotionPro4;
            EmotionCon4 = DEmotionCon4;
            AA4 = DAA4;
            AAPro4 = DAAPro4;
            AACon4 = DAACon4;
        }
        if (CardPosition == 5)
        {
            Card4 = DCard5;
            Button4 = DButton5;
            CardDescription4 = DCardDescription5;
            EmotionPro4 = DEmotionPro5;
            EmotionCon4 = DEmotionCon5;
            AA4 = DAA5;
            AAPro4 = DAAPro5;
            AACon4 = DAACon5;
        }
        if (CardPosition == 6)
        {
            Card4 = DCard6;
            Button4 = DButton6;
            CardDescription4 = DCardDescription6;
            EmotionPro4 = DEmotionPro6;
            EmotionCon4 = DEmotionCon6;
            AA4 = DAA6;
            AAPro4 = DAAPro6;
            AACon4 = DAACon6;
        }
        if (CardPosition == 7)
        {
            Card4 = DCard7;
            Button4 = DButton7;
            CardDescription4 = DCardDescription7;
            EmotionPro4 = DEmotionPro7;
            EmotionCon4 = DEmotionCon7;
            AA4 = DAA7;
            AAPro4 = DAAPro7;
            AACon4 = DAACon7;
        }
        if (CardPosition == 8)
        {
            Card4 = DCard8;
            Button4 = DButton8;
            CardDescription4 = DCardDescription8;
            EmotionPro4 = DEmotionPro8;
            EmotionCon4 = DEmotionCon8;
            AA4 = DAA8;
            AAPro4 = DAAPro8;
            AACon4 = DAACon8;
        }
        if (CardPosition == 9)
        {
            Card4 = DCard9;
            Button4 = DButton9;
            CardDescription4 = DCardDescription9;
            EmotionPro4 = DEmotionPro9;
            EmotionCon4 = DEmotionCon9;
            AA4 = DAA9;
            AAPro4 = DAAPro9;
            AACon4 = DAACon9;
        }
        if (CardPosition == 10)
        {
            Card4 = DCard10;
            Button4 = DButton10;
            CardDescription4 = DCardDescription10;
            EmotionPro4 = DEmotionPro10;
            EmotionCon4 = DEmotionCon10;
            AA4 = DAA10;
            AAPro4 = DAAPro10;
            AACon4 = DAACon10;
        }
        // Turns off the thought bubble
        ThoughtBubble.gameObject.SetActive(false);
        int TempProMood = int.Parse(EmotionPro4.text);
        int TempConMood = int.Parse(EmotionCon4.text);
        if (AudienceMood == TempProMood)
        {
            int TempPro = int.Parse(AAPro4.text);
            PlayerAudienceApproval = PlayerAudienceApproval + TempPro;
        }
        else if (AudienceMood == TempConMood)
        {
            int TempCon = int.Parse(AACon4.text);
            PlayerAudienceApproval = PlayerAudienceApproval + TempCon;
        }
        else
        {
            int Temp = int.Parse(AA4.text);
            PlayerAudienceApproval = PlayerAudienceApproval + Temp;
        }
        PlayerSpeech.text = CardDescription4.text.ToString();
    }

    void Button5Clicked()
    {
        StartCoroutine(UI_Timer());
        CardPosition = CardPosition + 1;
        transform.position = Card5.transform.position = new Vector3(100, 100, 100);
        if (CardPosition == 1)
        {
            Card5 = DCard1;
            Button5 = DButton1;
            CardDescription5 = DCardDescription1;
            EmotionPro5 = DEmotionPro1;
            EmotionCon5 = DEmotionCon1;
            AA5 = DAA1;
            AAPro5 = DAAPro1;
            AACon5 = DAACon1;
        }
        if (CardPosition == 2)
        {
            Card5 = DCard2;
            Button5 = DButton2;
            CardDescription5 = DCardDescription2;
            EmotionPro5 = DEmotionPro2;
            EmotionCon5 = DEmotionCon2;
            AA5 = DAA2;
            AAPro5 = DAAPro2;
            AACon5 = DAACon2;
        }
        if (CardPosition == 3)
        {
            Card5 = DCard3;
            Button5 = DButton3;
            CardDescription5 = DCardDescription3;
            EmotionPro5 = DEmotionPro3;
            EmotionCon5 = DEmotionCon3;
            AA5 = DAA3;
            AAPro5 = DAAPro3;
            AACon5 = DAACon3;
        }
        if (CardPosition == 4)
        {
            Card5 = DCard4;
            Button5 = DButton4;
            CardDescription5 = DCardDescription4;
            EmotionPro5 = DEmotionPro4;
            EmotionCon5 = DEmotionCon4;
            AA5 = DAA4;
            AAPro5 = DAAPro4;
            AACon5 = DAACon4;
        }
        if (CardPosition == 5)
        {
            Card5 = DCard5;
            Button5 = DButton5;
            CardDescription5 = DCardDescription5;
            EmotionPro5 = DEmotionPro5;
            EmotionCon5 = DEmotionCon5;
            AA5 = DAA5;
            AAPro5 = DAAPro5;
            AACon5 = DAACon5;
        }
        if (CardPosition == 6)
        {
            Card5 = DCard6;
            Button5 = DButton6;
            CardDescription5 = DCardDescription6;
            EmotionPro5 = DEmotionPro6;
            EmotionCon5 = DEmotionCon6;
            AA5 = DAA6;
            AAPro5 = DAAPro6;
            AACon5 = DAACon6;
        }
        if (CardPosition == 7)
        {
            Card5 = DCard7;
            Button5 = DButton7;
            CardDescription5 = DCardDescription7;
            EmotionPro5 = DEmotionPro7;
            EmotionCon5 = DEmotionCon7;
            AA5 = DAA7;
            AAPro5 = DAAPro7;
            AACon5 = DAACon7;
        }
        if (CardPosition == 8)
        {
            Card5 = DCard8;
            Button5 = DButton8;
            CardDescription5 = DCardDescription8;
            EmotionPro5 = DEmotionPro8;
            EmotionCon5 = DEmotionCon8;
            AA5 = DAA8;
            AAPro5 = DAAPro8;
            AACon5 = DAACon8;
        }
        if (CardPosition == 9)
        {
            Card5 = DCard9;
            Button5 = DButton9;
            CardDescription5 = DCardDescription9;
            EmotionPro5 = DEmotionPro9;
            EmotionCon5 = DEmotionCon9;
            AA5 = DAA9;
            AAPro5 = DAAPro9;
            AACon5 = DAACon9;
        }
        if (CardPosition == 10)
        {
            Card5 = DCard10;
            Button5 = DButton10;
            CardDescription5 = DCardDescription10;
            EmotionPro5 = DEmotionPro10;
            EmotionCon5 = DEmotionCon10;
            AA5 = DAA10;
            AAPro5 = DAAPro10;
            AACon5 = DAACon10;
        }


        // Turns off the thought bubble
        ThoughtBubble.gameObject.SetActive(false);
        int TempProMood = int.Parse(EmotionPro5.text);
        int TempConMood = int.Parse(EmotionCon5.text);
        if (AudienceMood == TempProMood)
        {
            int TempPro = int.Parse(AAPro5.text);
            PlayerAudienceApproval = PlayerAudienceApproval + TempPro;
        }
        else if (AudienceMood == TempConMood)
        {
            int TempCon = int.Parse(AACon5.text);
            PlayerAudienceApproval = PlayerAudienceApproval + TempCon;
        }
        else
        {
            int Temp = int.Parse(AA5.text);
            PlayerAudienceApproval = PlayerAudienceApproval + Temp;
        }
        PlayerSpeech.text = CardDescription1.text.ToString();
    }

    IEnumerator UI_Timer()
{
    yield return new WaitForSeconds(2);
        ThoughtBubble.gameObject.SetActive(true);
}
}
