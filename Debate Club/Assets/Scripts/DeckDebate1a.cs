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

    public Material Material0;
    public Material Material1;
    public Material Material2;
    public Material Material3;
    public Material Material4;
    public Material Material5;
    public Material Material6;
    public Material Material7;
    public Material Material8;
    public Material Material9;
    public Material Material10;
    public Material Material11;
    public Material Material12;
    public Material Material13;
    public Material Material14;
    public Material Material15;
    public Material Material16;
    public Material Material17;
    public Material Material18;
    public Material Material19;
    public Material Material20;
    public Material Material21;
    public Material Material22;
    public Material Material23;
    public Material Material24;
    public Material Material25;
    public Material Material26;
    public Material Material27;
    public Material Material28;
    public Material Material29;
    public Material Material30;
    public Material Material31;
    public Material Material32;
    public Material Material33;
    public Material Material34;
    public Material Material35;
    public Material Material36;
    public Material Material37;
    public Material Material38;
    public Material Material39;
    public Material Material40;
    public Material Material41;
    public Material Material42;
    public Material Material43;
    public Material Material44;
    public Material Material45;
    public Material Material46;
    public Material Material47;
    public Material Material48;
    public Material Material49;
    public Material Material50;
    public Material Material51;
    public Material Material52;
    public Material Material53;
    public Material Material54;
    public Material Material55;
    public Material Material56;
    public Material Material57;
    public Material Material58;
    public Material Material59;
    public Material Material60;
    public Material Material61;
    public Material Material62;
    public Material Material63;
    public Material Material64;
    public Material Material65;
    public Material Material66;
    public Material Material67;
    public Material Material68;
    public Material Material69;
    public Material Material70;
    public Material Material71;
    public Material Material72;
    public Material Material73;
    public Material Material74;
    public Material Material75;
    public Material Material76;
    public Material Material77;
    public Material Material78;
    public Material Material79;
    public Material Material80;
    public Material Material81;
    public Material Material82;
    public Material Material83;
    public Material Material84;
    public Material Material85;
    public Material Material86;
    public Material Material87;
    public Material Material88;
    public Material Material89;
    public Material Material90;
    public Material Material91;
    public Material Material92;
    public Material Material93;
    public Material Material94;
    public Material Material95;
    public Material Material96;
    public Material Material97;
    public Material Material98;
    public Material Material99;
    public Material Material100;

    // This details your current audience approval
    public int PlayerAudienceApproval;
    // This represents the audiences current mood 1 = Serious, 2 = Humourous, 3 = Sad, 4 = Passionate, and 5 = Angry
    public int AudienceMood;
    // This represents the players speech
    public Text PlayerSpeech;
    // This represents the thought bubble
    public Image ThoughtBubble;

    public int CardPosition;

    public GameObject Scoreboard;



    // Start is called before the first frame update
    void Start()
    {
        AudienceMood = 5;
        PlayerAudienceApproval = 50;
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

        CardPosition = 5;
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

        if (PlayerAudienceApproval == 0)
        {
            Scoreboard.GetComponent<Renderer>().material = Material0;
        }
        if (PlayerAudienceApproval == 1)
        {
            Scoreboard.GetComponent<Renderer>().material = Material1;
        }
        if (PlayerAudienceApproval == 2)
        {
            Scoreboard.GetComponent<Renderer>().material = Material2;
        }
        if (PlayerAudienceApproval == 3)
        {
            Scoreboard.GetComponent<Renderer>().material = Material3;
        }
        if (PlayerAudienceApproval == 4)
        {
            Scoreboard.GetComponent<Renderer>().material = Material4;
        }
        if (PlayerAudienceApproval == 5)
        {
            Scoreboard.GetComponent<Renderer>().material = Material5;
        }
        if (PlayerAudienceApproval == 6)
        {
            Scoreboard.GetComponent<Renderer>().material = Material6;
        }
        if (PlayerAudienceApproval == 7)
        {
            Scoreboard.GetComponent<Renderer>().material = Material7;
        }
        if (PlayerAudienceApproval == 8)
        {
            Scoreboard.GetComponent<Renderer>().material = Material8;
        }
        if (PlayerAudienceApproval == 9)
        {
            Scoreboard.GetComponent<Renderer>().material = Material9;
        }
        if (PlayerAudienceApproval == 10)
        {
            Scoreboard.GetComponent<Renderer>().material = Material10;
        }

        if (PlayerAudienceApproval == 11)
        {
            Scoreboard.GetComponent<Renderer>().material = Material11;
        }
        if (PlayerAudienceApproval == 12)
        {
            Scoreboard.GetComponent<Renderer>().material = Material12;
        }
        if (PlayerAudienceApproval == 13)
        {
            Scoreboard.GetComponent<Renderer>().material = Material13;
        }
        if (PlayerAudienceApproval == 14)
        {
            Scoreboard.GetComponent<Renderer>().material = Material14;
        }
        if (PlayerAudienceApproval == 15)
        {
            Scoreboard.GetComponent<Renderer>().material = Material15;
        }
        if (PlayerAudienceApproval == 16)
        {
            Scoreboard.GetComponent<Renderer>().material = Material16;
        }
        if (PlayerAudienceApproval == 17)
        {
            Scoreboard.GetComponent<Renderer>().material = Material17;
        }
        if (PlayerAudienceApproval == 18)
        {
            Scoreboard.GetComponent<Renderer>().material = Material18;
        }
        if (PlayerAudienceApproval == 19)
        {
            Scoreboard.GetComponent<Renderer>().material = Material19;
        }
        if (PlayerAudienceApproval == 20)
        {
            Scoreboard.GetComponent<Renderer>().material = Material20;
        }

        if (PlayerAudienceApproval == 21)
        {
            Scoreboard.GetComponent<Renderer>().material = Material21;
        }
        if (PlayerAudienceApproval == 22)
        {
            Scoreboard.GetComponent<Renderer>().material = Material22;
        }
        if (PlayerAudienceApproval == 23)
        {
            Scoreboard.GetComponent<Renderer>().material = Material23;
        }
        if (PlayerAudienceApproval == 24)
        {
            Scoreboard.GetComponent<Renderer>().material = Material24;
        }
        if (PlayerAudienceApproval == 25)
        {
            Scoreboard.GetComponent<Renderer>().material = Material25;
        }
        if (PlayerAudienceApproval == 26)
        {
            Scoreboard.GetComponent<Renderer>().material = Material26;
        }
        if (PlayerAudienceApproval == 27)
        {
            Scoreboard.GetComponent<Renderer>().material = Material27;
        }
        if (PlayerAudienceApproval == 28)
        {
            Scoreboard.GetComponent<Renderer>().material = Material28;
        }
        if (PlayerAudienceApproval == 29)
        {
            Scoreboard.GetComponent<Renderer>().material = Material29;
        }
        if (PlayerAudienceApproval == 30)
        {
            Scoreboard.GetComponent<Renderer>().material = Material30;
        }

        if (PlayerAudienceApproval == 31)
        {
            Scoreboard.GetComponent<Renderer>().material = Material31;
        }
        if (PlayerAudienceApproval == 32)
        {
            Scoreboard.GetComponent<Renderer>().material = Material32;
        }
        if (PlayerAudienceApproval == 33)
        {
            Scoreboard.GetComponent<Renderer>().material = Material33;
        }
        if (PlayerAudienceApproval == 34)
        {
            Scoreboard.GetComponent<Renderer>().material = Material34;
        }
        if (PlayerAudienceApproval == 35)
        {
            Scoreboard.GetComponent<Renderer>().material = Material35;
        }
        if (PlayerAudienceApproval == 36)
        {
            Scoreboard.GetComponent<Renderer>().material = Material36;
        }
        if (PlayerAudienceApproval == 37)
        {
            Scoreboard.GetComponent<Renderer>().material = Material37;
        }
        if (PlayerAudienceApproval == 38)
        {
            Scoreboard.GetComponent<Renderer>().material = Material38;
        }
        if (PlayerAudienceApproval == 39)
        {
            Scoreboard.GetComponent<Renderer>().material = Material39;
        }
        if (PlayerAudienceApproval == 40)
        {
            Scoreboard.GetComponent<Renderer>().material = Material40;
        }

        if (PlayerAudienceApproval == 41)
        {
            Scoreboard.GetComponent<Renderer>().material = Material41;
        }
        if (PlayerAudienceApproval == 42)
        {
            Scoreboard.GetComponent<Renderer>().material = Material42;
        }
        if (PlayerAudienceApproval == 43)
        {
            Scoreboard.GetComponent<Renderer>().material = Material43;
        }
        if (PlayerAudienceApproval == 44)
        {
            Scoreboard.GetComponent<Renderer>().material = Material44;
        }
        if (PlayerAudienceApproval == 45)
        {
            Scoreboard.GetComponent<Renderer>().material = Material45;
        }
        if (PlayerAudienceApproval == 46)
        {
            Scoreboard.GetComponent<Renderer>().material = Material46;
        }
        if (PlayerAudienceApproval == 47)
        {
            Scoreboard.GetComponent<Renderer>().material = Material47;
        }
        if (PlayerAudienceApproval == 48)
        {
            Scoreboard.GetComponent<Renderer>().material = Material48;
        }
        if (PlayerAudienceApproval == 49)
        {
            Scoreboard.GetComponent<Renderer>().material = Material49;
        }
        if (PlayerAudienceApproval == 50)
        {
            Scoreboard.GetComponent<Renderer>().material = Material50;
        }
        if (PlayerAudienceApproval == 51)
        {
            Scoreboard.GetComponent<Renderer>().material = Material51;
        }
        if (PlayerAudienceApproval == 52)
        {
            Scoreboard.GetComponent<Renderer>().material = Material52;
        }
        if (PlayerAudienceApproval == 53)
        {
            Scoreboard.GetComponent<Renderer>().material = Material53;
        }
        if (PlayerAudienceApproval == 54)
        {
            Scoreboard.GetComponent<Renderer>().material = Material54;
        }
        if (PlayerAudienceApproval == 55)
        {
            Scoreboard.GetComponent<Renderer>().material = Material55;
        }
        if (PlayerAudienceApproval == 56)
        {
            Scoreboard.GetComponent<Renderer>().material = Material56;
        }
        if (PlayerAudienceApproval == 57)
        {
            Scoreboard.GetComponent<Renderer>().material = Material57;
        }
        if (PlayerAudienceApproval == 58)
        {
            Scoreboard.GetComponent<Renderer>().material = Material58;
        }
        if (PlayerAudienceApproval == 59)
        {
            Scoreboard.GetComponent<Renderer>().material = Material59;
        }
        if (PlayerAudienceApproval == 60)
        {
            Scoreboard.GetComponent<Renderer>().material = Material60;
        }
        if (PlayerAudienceApproval == 61)
        {
            Scoreboard.GetComponent<Renderer>().material = Material61;
        }
        if (PlayerAudienceApproval == 62)
        {
            Scoreboard.GetComponent<Renderer>().material = Material62;
        }
        if (PlayerAudienceApproval == 63)
        {
            Scoreboard.GetComponent<Renderer>().material = Material63;
        }
        if (PlayerAudienceApproval == 64)
        {
            Scoreboard.GetComponent<Renderer>().material = Material64;
        }
        if (PlayerAudienceApproval == 65)
        {
            Scoreboard.GetComponent<Renderer>().material = Material65;
        }
        if (PlayerAudienceApproval == 66)
        {
            Scoreboard.GetComponent<Renderer>().material = Material66;
        }
        if (PlayerAudienceApproval == 67)
        {
            Scoreboard.GetComponent<Renderer>().material = Material67;
        }
        if (PlayerAudienceApproval == 68)
        {
            Scoreboard.GetComponent<Renderer>().material = Material68;
        }
        if (PlayerAudienceApproval == 69)
        {
            Scoreboard.GetComponent<Renderer>().material = Material69;
        }

        if (PlayerAudienceApproval == 70)
        {
            Scoreboard.GetComponent<Renderer>().material = Material70;
        }
        if (PlayerAudienceApproval == 71)
        {
            Scoreboard.GetComponent<Renderer>().material = Material71;
        }
        if (PlayerAudienceApproval == 72)
        {
            Scoreboard.GetComponent<Renderer>().material = Material72;
        }
        if (PlayerAudienceApproval == 73)
        {
            Scoreboard.GetComponent<Renderer>().material = Material73;
        }
        if (PlayerAudienceApproval == 74)
        {
            Scoreboard.GetComponent<Renderer>().material = Material74;
        }
        if (PlayerAudienceApproval == 75)
        {
            Scoreboard.GetComponent<Renderer>().material = Material75;
        }
        if (PlayerAudienceApproval == 76)
        {
            Scoreboard.GetComponent<Renderer>().material = Material76;
        }
        if (PlayerAudienceApproval == 77)
        {
            Scoreboard.GetComponent<Renderer>().material = Material77;
        }
        if (PlayerAudienceApproval == 78)
        {
            Scoreboard.GetComponent<Renderer>().material = Material78;
        }
        if (PlayerAudienceApproval == 79)
        {
            Scoreboard.GetComponent<Renderer>().material = Material79;
        }

        if (PlayerAudienceApproval == 80)
        {
            Scoreboard.GetComponent<Renderer>().material = Material80;
        }
        if (PlayerAudienceApproval == 81)
        {
            Scoreboard.GetComponent<Renderer>().material = Material81;
        }
        if (PlayerAudienceApproval == 82)
        {
            Scoreboard.GetComponent<Renderer>().material = Material82;
        }
        if (PlayerAudienceApproval == 83)
        {
            Scoreboard.GetComponent<Renderer>().material = Material83;
        }
        if (PlayerAudienceApproval == 84)
        {
            Scoreboard.GetComponent<Renderer>().material = Material84;
        }
        if (PlayerAudienceApproval == 85)
        {
            Scoreboard.GetComponent<Renderer>().material = Material85;
        }
        if (PlayerAudienceApproval == 86)
        {
            Scoreboard.GetComponent<Renderer>().material = Material86;
        }
        if (PlayerAudienceApproval == 87)
        {
            Scoreboard.GetComponent<Renderer>().material = Material87;
        }
        if (PlayerAudienceApproval == 88)
        {
            Scoreboard.GetComponent<Renderer>().material = Material88;
        }
        if (PlayerAudienceApproval == 89)
        {
            Scoreboard.GetComponent<Renderer>().material = Material89;
        }

        if (PlayerAudienceApproval == 90)
        {
            Scoreboard.GetComponent<Renderer>().material = Material90;
        }
        if (PlayerAudienceApproval == 91)
        {
            Scoreboard.GetComponent<Renderer>().material = Material91;
        }
        if (PlayerAudienceApproval == 92)
        {
            Scoreboard.GetComponent<Renderer>().material = Material92;
        }
        if (PlayerAudienceApproval == 93)
        {
            Scoreboard.GetComponent<Renderer>().material = Material93;
        }
        if (PlayerAudienceApproval == 94)
        {
            Scoreboard.GetComponent<Renderer>().material = Material94;
        }
        if (PlayerAudienceApproval == 95)
        {
            Scoreboard.GetComponent<Renderer>().material = Material95;
        }
        if (PlayerAudienceApproval == 96)
        {
            Scoreboard.GetComponent<Renderer>().material = Material96;
        }
        if (PlayerAudienceApproval == 97)
        {
            Scoreboard.GetComponent<Renderer>().material = Material97;
        }
        if (PlayerAudienceApproval == 98)
        {
            Scoreboard.GetComponent<Renderer>().material = Material98;
        }
        if (PlayerAudienceApproval == 99)
        {
            Scoreboard.GetComponent<Renderer>().material = Material99;
        }
        if (PlayerAudienceApproval == 100)
        {
            Scoreboard.GetComponent<Renderer>().material = Material100;
        }

    }
    void Button1Clicked()
    {
        Button1.onClick.RemoveListener(Button1Clicked);
        Button2.onClick.RemoveListener(Button2Clicked);
        Button3.onClick.RemoveListener(Button3Clicked);
        Button4.onClick.RemoveListener(Button4Clicked);
        Button5.onClick.RemoveListener(Button5Clicked);
        StartCoroutine(UI_Timer());
        CardPosition = CardPosition + 1;
        transform.position = Card1.transform.position = new Vector3(100, 100, 100);
        PlayerSpeech.text = CardDescription1.text.ToString();
        StartCoroutine(OneAA());
        if (CardPosition == 1)
        {
            Card1 = DCard1;
            Button1 = DButton1;
            CardDescription1 = DCardDescription1;
            EmotionPro1 = DEmotionPro1;
            EmotionCon1 = DEmotionCon1;
            AA1 = DAA1;
            AAPro1 = DAAPro1;
            AACon1 = DAACon1;
        }
        else if (CardPosition == 2)
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
        else if (CardPosition == 3)
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
        else if (CardPosition == 4)
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
        else if (CardPosition == 5)
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
        else if (CardPosition == 6)
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
        else if (CardPosition == 7)
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
        else if (CardPosition == 8)
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
        else if (CardPosition == 9)
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
        else if (CardPosition == 10)
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

    }

    void Button2Clicked()
    {
        Button1.onClick.RemoveListener(Button1Clicked);
        Button2.onClick.RemoveListener(Button2Clicked);
        Button3.onClick.RemoveListener(Button3Clicked);
        Button4.onClick.RemoveListener(Button4Clicked);
        Button5.onClick.RemoveListener(Button5Clicked);
        StartCoroutine(UI_Timer());
        CardPosition = CardPosition + 1;
        transform.position = Card2.transform.position = new Vector3(100, 100, 100);
        PlayerSpeech.text = CardDescription2.text.ToString();
        StartCoroutine(TwoAA());
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
    }

    void Button3Clicked()
    {
        Button1.onClick.RemoveListener(Button1Clicked);
        Button2.onClick.RemoveListener(Button2Clicked);
        Button3.onClick.RemoveListener(Button3Clicked);
        Button4.onClick.RemoveListener(Button4Clicked);
        Button5.onClick.RemoveListener(Button5Clicked);
        StartCoroutine(UI_Timer());
        CardPosition = CardPosition + 1;
        transform.position = Card3.transform.position = new Vector3(100, 100, 100);
        PlayerSpeech.text = CardDescription3.text.ToString();
        StartCoroutine(ThreeAA());
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
    }

    void Button4Clicked()
    {
        Button1.onClick.RemoveListener(Button1Clicked);
        Button2.onClick.RemoveListener(Button2Clicked);
        Button3.onClick.RemoveListener(Button3Clicked);
        Button4.onClick.RemoveListener(Button4Clicked);
        Button5.onClick.RemoveListener(Button5Clicked);
        StartCoroutine(UI_Timer());
        CardPosition = CardPosition + 1;
        transform.position = Card4.transform.position = new Vector3(100, 100, 100);
        PlayerSpeech.text = CardDescription4.text.ToString();
        StartCoroutine(FourAA());
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
    }

    void Button5Clicked()
    {
        Button1.onClick.RemoveListener(Button1Clicked);
        Button2.onClick.RemoveListener(Button2Clicked);
        Button3.onClick.RemoveListener(Button3Clicked);
        Button4.onClick.RemoveListener(Button4Clicked);
        Button5.onClick.RemoveListener(Button5Clicked);
        StartCoroutine(UI_Timer());
        CardPosition = CardPosition + 1;
        transform.position = Card5.transform.position = new Vector3(100, 100, 100);
        PlayerSpeech.text = CardDescription5.text.ToString();
        StartCoroutine(FiveAA());
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
    }

    IEnumerator UI_Timer()
{
    yield return new WaitForSeconds(2);
        ThoughtBubble.gameObject.SetActive(true);
}
    IEnumerator OneAA()
    {
        yield return new WaitForSeconds(2);
        if (AudienceMood == int.Parse(EmotionPro1.text))
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AAPro1.text);
        }
        else if (AudienceMood == int.Parse(EmotionCon1.text))
        {
            int TempCon = int.Parse(AACon1.text);
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AACon1.text);
        }
        else
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AA1.text);
        }
        Button1.onClick.AddListener(Button1Clicked);
        Button2.onClick.AddListener(Button2Clicked);
        Button3.onClick.AddListener(Button3Clicked);
        Button4.onClick.AddListener(Button4Clicked);
        Button5.onClick.AddListener(Button5Clicked);
    }
    IEnumerator TwoAA()
    {
        yield return new WaitForSeconds(2);
        if (AudienceMood == int.Parse(EmotionPro2.text))
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AAPro2.text);
        }
        else if (AudienceMood == int.Parse(EmotionCon2.text))
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AACon2.text);
        }
        else
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AA2.text);
        }
        Button1.onClick.AddListener(Button1Clicked);
        Button2.onClick.AddListener(Button2Clicked);
        Button3.onClick.AddListener(Button3Clicked);
        Button4.onClick.AddListener(Button4Clicked);
        Button5.onClick.AddListener(Button5Clicked);
    }
    IEnumerator ThreeAA()
    {
        yield return new WaitForSeconds(2);
        if (AudienceMood == int.Parse(EmotionPro3.text))
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AAPro3.text);
        }
        else if (AudienceMood == int.Parse(EmotionCon3.text))
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AACon3.text);
        }
        else
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AA3.text);
        }
        Button1.onClick.AddListener(Button1Clicked);
        Button2.onClick.AddListener(Button2Clicked);
        Button3.onClick.AddListener(Button3Clicked);
        Button4.onClick.AddListener(Button4Clicked);
        Button5.onClick.AddListener(Button5Clicked);

    }
    IEnumerator FourAA()
    {
        yield return new WaitForSeconds(2);
        if (AudienceMood == int.Parse(EmotionPro4.text))
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AAPro4.text);
        }
        else if (AudienceMood == int.Parse(EmotionCon4.text))
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AACon4.text);
        }
        else
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AA4.text);
        }
        PlayerSpeech.text = CardDescription4.text.ToString();
        Button1.onClick.AddListener(Button1Clicked);
        Button2.onClick.AddListener(Button2Clicked);
        Button3.onClick.AddListener(Button3Clicked);
        Button4.onClick.AddListener(Button4Clicked);
        Button5.onClick.AddListener(Button5Clicked);

    }
    IEnumerator FiveAA()
    {
        yield return new WaitForSeconds(2);
        if (AudienceMood == int.Parse(EmotionPro5.text))
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AAPro5.text);
        }
        else if (AudienceMood == int.Parse(EmotionCon5.text))
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AACon5.text);
        }
        else
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AA5.text);
        }
        
        Button1.onClick.AddListener(Button1Clicked);
        Button2.onClick.AddListener(Button2Clicked);
        Button3.onClick.AddListener(Button3Clicked);
        Button4.onClick.AddListener(Button4Clicked);
        Button5.onClick.AddListener(Button5Clicked);
    }

}
