using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeckDebate1a : MonoBehaviour
{

    GameObject Description;
    GameObject EmotionPro;
    GameObject EmotionCon;
    GameObject AudienceResponse;
    GameObject AudienceResponsePro;
    GameObject AudienceResponseCon;

    public GameObject DCard1;
    public GameObject DCard2;
    public GameObject DCard3;
    public GameObject DCard4;
    public GameObject DCard5;
    public GameObject DCard6;
    public GameObject DCard7;
    public GameObject DCard8;
    public GameObject DCard9;
    public GameObject DCard10;
    public GameObject DCard11;
    public GameObject DCard12;
    public GameObject DCard13;
    public GameObject DCard14;
    public GameObject DCard15;
    public GameObject DCard16;
    public GameObject DCard17;
    public GameObject DCard18;
    public GameObject DCard19;

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
    public Button DButton11;
    public Button DButton12;
    public Button DButton13;
    public Button DButton14;
    public Button DButton15;
    public Button DButton16;
    public Button DButton17;
    public Button DButton18;
    public Button DButton19;

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
    public Text DCardDescription11;
    public Text DCardDescription12;
    public Text DCardDescription13;
    public Text DCardDescription14;
    public Text DCardDescription15;
    public Text DCardDescription16;
    public Text DCardDescription17;
    public Text DCardDescription18;
    public Text DCardDescription19;

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
    public Text DEmotionPro11;
    public Text DEmotionPro12;
    public Text DEmotionPro13;
    public Text DEmotionPro14;
    public Text DEmotionPro15;
    public Text DEmotionPro16;
    public Text DEmotionPro17;
    public Text DEmotionPro18;
    public Text DEmotionPro19;

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
    public Text DEmotionCon11;
    public Text DEmotionCon12;
    public Text DEmotionCon13;
    public Text DEmotionCon14;
    public Text DEmotionCon15;
    public Text DEmotionCon16;
    public Text DEmotionCon17;
    public Text DEmotionCon18;
    public Text DEmotionCon19;

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
    public Text DAA11;
    public Text DAA12;
    public Text DAA13;
    public Text DAA14;
    public Text DAA15;
    public Text DAA16;
    public Text DAA17;
    public Text DAA18;
    public Text DAA19;

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
    public Text DAAPro11;
    public Text DAAPro12;
    public Text DAAPro13;
    public Text DAAPro14;
    public Text DAAPro15;
    public Text DAAPro16;
    public Text DAAPro17;
    public Text DAAPro18;
    public Text DAAPro19;

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
    public Text DAACon11;
    public Text DAACon12;
    public Text DAACon13;
    public Text DAACon14;
    public Text DAACon15;
    public Text DAACon16;
    public Text DAACon17;
    public Text DAACon18;
    public Text DAACon19;

    // The Cards
    GameObject Card1;
    GameObject Card2;
    GameObject Card3;
    GameObject Card4;
    GameObject Card5;

    Button Button1;
    Button Button2;
    Button Button3;
    Button Button4;
    Button Button5;

    

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

    public Image SpeechBubble;

    public Image OpponentSpeechBubble;

    public Text OpponentSpeech;

    public int CardPosition;

    public GameObject Scoreboard;

    public Material AudienceMaterial;

    public GameObject Deck1;

    public float WhichOpponentReply;

    public Text EndState;





    // Start is called before the first frame update
    void Start()
    {
        AudienceMood = 5;
        PlayerAudienceApproval = 50;
        Card1 = DCard1;
        Button1 = DButton1;
        Card2 = DCard2;
        Button2 = DButton2;
        Card3 = DCard3;
        Button3 = DButton3;
        Card4 = DCard4;
        Button4 = DButton4;
        Card5 = DCard5;
        Button5 = DButton5;
        CardPosition = 5;
        Button1.onClick.AddListener(Button1Clicked);
        Button2.onClick.AddListener(Button2Clicked);
        Button3.onClick.AddListener(Button3Clicked);
        Button4.onClick.AddListener(Button4Clicked);
        Button5.onClick.AddListener(Button5Clicked);
        transform.position = Card1.transform.position = new Vector3(-0.5f, -0.38f, 1);
        transform.position = Card2.transform.position = new Vector3(-0.25f, -0.38f, 1);
        transform.position = Card3.transform.position = new Vector3(-0f, -0.38f, 1);
        transform.position = Card4.transform.position = new Vector3(0.25f, -0.38f, 1);
        transform.position = Card5.transform.position = new Vector3(0.5f, -0.38f, 1);
    }

    // Update is called once per frame
    void Update()
    {
       

        if (PlayerAudienceApproval < 0)
        {
            Scoreboard.GetComponent<Renderer>().material = Material0;
            StartCoroutine(YouLose());
        }
        if (PlayerAudienceApproval == 0)
        {
            Scoreboard.GetComponent<Renderer>().material = Material0;
            StartCoroutine(YouLose());
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
            StartCoroutine(YouWin());
        }
        if (PlayerAudienceApproval > 100)
        {
            Scoreboard.GetComponent<Renderer>().material = Material100;
            StartCoroutine(YouWin());

        }
        if (AudienceMood == 1)
        {
            AudienceMaterial.SetColor("_Color", Color.gray);
        }
        if (AudienceMood == 2)
        {
            AudienceMaterial.SetColor("_Color", Color.green);
        }
        if (AudienceMood == 3)
        {
            AudienceMaterial.SetColor("_Color", Color.cyan);
        }
        if (AudienceMood == 4)
        {
            AudienceMaterial.SetColor("_Color", Color.magenta);
        }
        if (AudienceMood == 5)
        {
            AudienceMaterial.SetColor("_Color", Color.red);
        }

        if (CardPosition > 19)
        {
            CardPosition = 1;
        }
    }

    void Button1Clicked()
    {
        Button1.onClick.RemoveListener(Button1Clicked);
        Button2.onClick.RemoveListener(Button2Clicked);
        Button3.onClick.RemoveListener(Button3Clicked);
        Button4.onClick.RemoveListener(Button4Clicked);
        Button5.onClick.RemoveListener(Button5Clicked);
        Card1.transform.position = new Vector3(100, 100, 100);
        Deck1.gameObject.SetActive(false);
        SpeechBubble.gameObject.SetActive(true);
        ThoughtBubble.gameObject.SetActive(false);
            StartCoroutine(OneAA());
    }
    IEnumerator OneAA()
    {
        
                yield return new WaitForSeconds(0.1f);
                Description = Card1.transform.GetChild(0).GetChild(1).gameObject;
                EmotionPro = Card1.transform.GetChild(0).GetChild(5).gameObject;
                EmotionCon = Card1.transform.GetChild(0).GetChild(6).gameObject;
                AudienceResponse = Card1.transform.GetChild(0).GetChild(3).gameObject;
                AudienceResponsePro = Card1.transform.GetChild(0).GetChild(2).gameObject;
                AudienceResponseCon = Card1.transform.GetChild(0).GetChild(4).gameObject;
                yield return new WaitForSeconds(0.1f);
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePro.GetComponent<Text>().text);
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseCon.GetComponent<Text>().text);
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponse.GetComponent<Text>().text);
                }
                yield return new WaitForSeconds(0.1f);
                CardPosition = CardPosition + 1;
                yield return new WaitForSeconds(0.1f);
                if (CardPosition == 1)
                {
                    Card1 = DCard1;
                    Button1 = DButton1;
                }
                else if (CardPosition == 2)
                {
                    Card1 = DCard2;
                    Button1 = DButton2;
                }
                else if (CardPosition == 3)
                {
                    Card1 = DCard3;
                    Button1 = DButton3;
                }
                else if (CardPosition == 4)
                {
                    Card1 = DCard4;
                    Button1 = DButton4;
                }
                else if (CardPosition == 5)
                {
                    Card1 = DCard5;
                    Button1 = DButton5;
                }
                else if (CardPosition == 6)
                {
                    Card1 = DCard6;
                    Button1 = DButton6;
                }
                else if (CardPosition == 7)
                {
                    Card1 = DCard7;
                    Button1 = DButton7;
                }
                else if (CardPosition == 8)
                {
                    Card1 = DCard8;
                    Button1 = DButton8;
                }
                else if (CardPosition == 9)
                {
                    Card1 = DCard9;
                    Button1 = DButton9;
                }
                else if (CardPosition == 10)
                {
                    Card1 = DCard10;
                    Button1 = DButton10;
                }
                else if (CardPosition == 11)
                {
                    Card1 = DCard11;
                    Button1 = DButton11;
                }
                else if (CardPosition == 12)
                {
                    Card1 = DCard12;
                    Button1 = DButton12;
                }
                else if (CardPosition == 13)
                {
                    Card1 = DCard13;
                    Button1 = DButton13;
                }
                else if (CardPosition == 14)
                {
                    Card1 = DCard14;
                    Button1 = DButton14;
                }
                else if (CardPosition == 15)
                {
                    Card1 = DCard15;
                    Button1 = DButton15;
                }
                else if (CardPosition == 16)
                {
                    Card1 = DCard16;
                    Button1 = DButton16;
                }
                else if (CardPosition == 17)
                {
                    Card1 = DCard17;
                    Button1 = DButton17;
                }
                else if (CardPosition == 18)
                {
                    Card1 = DCard18;
                    Button1 = DButton18;
                }
                else if (CardPosition == 19)
                {
                    Card1 = DCard19;
                    Button1 = DButton19;
                }
                yield return new WaitForSeconds(1);
                transform.position = Card1.transform.position = new Vector3(-0.5f, -0.38f, 1);
                transform.position = Card2.transform.position = new Vector3(-0.25f, -0.38f, 1);
                transform.position = Card3.transform.position = new Vector3(-0f, -0.38f, 1);
                transform.position = Card4.transform.position = new Vector3(0.25f, -0.38f, 1);
                transform.position = Card5.transform.position = new Vector3(0.5f, -0.38f, 1);
                Button1.onClick.AddListener(Button1Clicked);
                Button2.onClick.AddListener(Button2Clicked);
                Button3.onClick.AddListener(Button3Clicked);
                Button4.onClick.AddListener(Button4Clicked);
                Button5.onClick.AddListener(Button5Clicked);
            
        
        StartCoroutine(OpponentReply());   
    }

    void Button2Clicked()
    {
        Button1.onClick.RemoveListener(Button1Clicked);
        Button2.onClick.RemoveListener(Button2Clicked);
        Button3.onClick.RemoveListener(Button3Clicked);
        Button4.onClick.RemoveListener(Button4Clicked);
        Button5.onClick.RemoveListener(Button5Clicked);
        Card2.transform.position = new Vector3(100, 100, 100);
        Deck1.gameObject.SetActive(false);
        SpeechBubble.gameObject.SetActive(true);
        ThoughtBubble.gameObject.SetActive(false);
        StartCoroutine(TwoAA());
    }
    IEnumerator TwoAA()
    {
        yield return new WaitForSeconds(0.1f);
        Description = Card2.transform.GetChild(0).GetChild(1).gameObject;
        EmotionPro = Card2.transform.GetChild(0).GetChild(5).gameObject;
        EmotionCon = Card2.transform.GetChild(0).GetChild(6).gameObject;
        AudienceResponse = Card2.transform.GetChild(0).GetChild(3).gameObject;
        AudienceResponsePro = Card2.transform.GetChild(0).GetChild(2).gameObject;
        AudienceResponseCon = Card2.transform.GetChild(0).GetChild(4).gameObject;
        yield return new WaitForSeconds(0.1f);
        PlayerSpeech.text = Description.GetComponent<Text>().text;
        yield return new WaitForSeconds(0.1f);
        if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePro.GetComponent<Text>().text);
        }
        else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseCon.GetComponent<Text>().text);
        }
        else
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponse.GetComponent<Text>().text);
        }
        yield return new WaitForSeconds(0.1f);
        CardPosition = CardPosition + 1;
        yield return new WaitForSeconds(0.1f);
        if (CardPosition == 1)
        {
            Card2 = DCard1;
            Button2 = DButton1;
        }
        else if (CardPosition == 2)
        {
            Card2 = DCard2;
            Button2 = DButton2;
        }
        else if (CardPosition == 3)
        {
            Card2 = DCard3;
            Button2 = DButton3;
        }
        else if (CardPosition == 4)
        {
            Card2 = DCard4;
            Button2 = DButton4;
        }
        else if (CardPosition == 5)
        {
            Card2 = DCard5;
            Button2 = DButton5;
        }
        else if (CardPosition == 6)
        {
            Card2 = DCard6;
            Button2 = DButton6;
        }
        else if (CardPosition == 7)
        {
            Card2 = DCard7;
            Button2 = DButton7;
        }
        else if (CardPosition == 8)
        {
            Card2 = DCard8;
            Button2 = DButton8;
        }
        else if (CardPosition == 9)
        {
            Card2 = DCard9;
            Button2 = DButton9;
        }
        else if (CardPosition == 10)
        {
            Card2 = DCard10;
            Button2 = DButton10;
        }
        else if (CardPosition == 11)
        {
            Card2 = DCard11;
            Button2 = DButton11;
        }
        else if (CardPosition == 12)
        {
            Card2 = DCard12;
            Button2 = DButton12;
        }
        else if (CardPosition == 13)
        {
            Card2 = DCard13;
            Button2 = DButton13;
        }
        else if (CardPosition == 14)
        {
            Card2 = DCard14;
            Button2 = DButton14;
        }
        else if (CardPosition == 15)
        {
            Card2 = DCard15;
            Button2 = DButton15;
        }
        else if (CardPosition == 16)
        {
            Card2 = DCard16;
            Button2 = DButton16;
        }
        else if (CardPosition == 17)
        {
            Card2 = DCard17;
            Button2 = DButton17;
        }
        else if (CardPosition == 18)
        {
            Card2 = DCard18;
            Button2 = DButton18;
        }
        else if (CardPosition == 19)
        {
            Card2 = DCard19;
            Button2 = DButton19;
        }
        yield return new WaitForSeconds(1);
        transform.position = Card1.transform.position = new Vector3(-0.5f, -0.38f, 1);
        transform.position = Card2.transform.position = new Vector3(-0.25f, -0.38f, 1);
        transform.position = Card3.transform.position = new Vector3(-0f, -0.38f, 1);
        transform.position = Card4.transform.position = new Vector3(0.25f, -0.38f, 1);
        transform.position = Card5.transform.position = new Vector3(0.5f, -0.38f, 1);
        Button1.onClick.AddListener(Button1Clicked);
        Button2.onClick.AddListener(Button2Clicked);
        Button3.onClick.AddListener(Button3Clicked);
        Button4.onClick.AddListener(Button4Clicked);
        Button5.onClick.AddListener(Button5Clicked);
        StartCoroutine(OpponentReply());
    }

    void Button3Clicked()
    {
        Button1.onClick.RemoveListener(Button1Clicked);
        Button2.onClick.RemoveListener(Button2Clicked);
        Button3.onClick.RemoveListener(Button3Clicked);
        Button4.onClick.RemoveListener(Button4Clicked);
        Button5.onClick.RemoveListener(Button5Clicked);
        Card3.transform.position = new Vector3(100, 100, 100);
        Deck1.gameObject.SetActive(false);
        SpeechBubble.gameObject.SetActive(true);
        ThoughtBubble.gameObject.SetActive(false);
        StartCoroutine(ThreeAA());
    }
    IEnumerator ThreeAA()
    {
        yield return new WaitForSeconds(0.1f);
        Description = Card3.transform.GetChild(0).GetChild(1).gameObject;
        EmotionPro = Card3.transform.GetChild(0).GetChild(5).gameObject;
        EmotionCon = Card3.transform.GetChild(0).GetChild(6).gameObject;
        AudienceResponse = Card3.transform.GetChild(0).GetChild(3).gameObject;
        AudienceResponsePro = Card3.transform.GetChild(0).GetChild(2).gameObject;
        AudienceResponseCon = Card3.transform.GetChild(0).GetChild(4).gameObject;
        yield return new WaitForSeconds(0.1f);
        PlayerSpeech.text = Description.GetComponent<Text>().text;
        yield return new WaitForSeconds(0.1f);
        if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePro.GetComponent<Text>().text);
        }
        else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseCon.GetComponent<Text>().text);
        }
        else
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponse.GetComponent<Text>().text);
        }
        yield return new WaitForSeconds(0.1f);
        CardPosition = CardPosition + 1;
        yield return new WaitForSeconds(0.1f);
        if (CardPosition == 1)
        {
            Card3 = DCard1;
            Button3 = DButton1;
        }
        else if (CardPosition == 2)
        {
            Card3 = DCard2;
            Button3 = DButton2;
        }
        else if (CardPosition == 3)
        {
            Card3 = DCard3;
            Button3 = DButton3;
        }
        else if (CardPosition == 4)
        {
            Card3 = DCard4;
            Button3 = DButton4;
        }
        else if (CardPosition == 5)
        {
            Card3 = DCard5;
            Button3 = DButton5;
        }
        else if (CardPosition == 6)
        {
            Card3 = DCard6;
            Button3 = DButton6;
        }
        else if (CardPosition == 7)
        {
            Card3 = DCard7;
            Button3 = DButton7;
        }
        else if (CardPosition == 8)
        {
            Card3 = DCard8;
            Button3 = DButton8;
        }
        else if (CardPosition == 9)
        {
            Card3 = DCard9;
            Button3 = DButton9;
        }
        else if (CardPosition == 10)
        {
            Card3 = DCard10;
            Button3 = DButton10;
        }
        else if (CardPosition == 11)
        {
            Card3 = DCard11;
            Button3 = DButton11;
        }
        else if (CardPosition == 12)
        {
            Card3 = DCard12;
            Button3 = DButton12;
        }
        else if (CardPosition == 13)
        {
            Card3 = DCard13;
            Button3 = DButton13;
        }
        else if (CardPosition == 14)
        {
            Card3 = DCard14;
            Button3 = DButton14;
        }
        else if (CardPosition == 15)
        {
            Card3 = DCard15;
            Button3 = DButton15;
        }
        else if (CardPosition == 16)
        {
            Card3 = DCard16;
            Button3 = DButton16;
        }
        else if (CardPosition == 17)
        {
            Card3 = DCard17;
            Button3 = DButton17;
        }
        else if (CardPosition == 18)
        {
            Card3 = DCard18;
            Button3 = DButton18;
        }
        else if (CardPosition == 19)
        {
            Card3 = DCard19;
            Button3 = DButton19;
        }
        yield return new WaitForSeconds(1);
        transform.position = Card1.transform.position = new Vector3(-0.5f, -0.38f, 1);
        transform.position = Card2.transform.position = new Vector3(-0.25f, -0.38f, 1);
        transform.position = Card3.transform.position = new Vector3(-0f, -0.38f, 1);
        transform.position = Card4.transform.position = new Vector3(0.25f, -0.38f, 1);
        transform.position = Card5.transform.position = new Vector3(0.5f, -0.38f, 1);
        Button1.onClick.AddListener(Button1Clicked);
        Button2.onClick.AddListener(Button2Clicked);
        Button3.onClick.AddListener(Button3Clicked);
        Button4.onClick.AddListener(Button4Clicked);
        Button5.onClick.AddListener(Button5Clicked);
        StartCoroutine(OpponentReply());
    }

    void Button4Clicked()
    {
        Button1.onClick.RemoveListener(Button1Clicked);
        Button2.onClick.RemoveListener(Button2Clicked);
        Button3.onClick.RemoveListener(Button3Clicked);
        Button4.onClick.RemoveListener(Button4Clicked);
        Button5.onClick.RemoveListener(Button5Clicked);
        Card4.transform.position = new Vector3(100, 100, 100);
        Deck1.gameObject.SetActive(false);
        SpeechBubble.gameObject.SetActive(true);
        ThoughtBubble.gameObject.SetActive(false);
        StartCoroutine(FourAA());
    }
    IEnumerator FourAA()
    {
        yield return new WaitForSeconds(0.1f);
        Description = Card4.transform.GetChild(0).GetChild(1).gameObject;
        EmotionPro = Card4.transform.GetChild(0).GetChild(5).gameObject;
        EmotionCon = Card4.transform.GetChild(0).GetChild(6).gameObject;
        AudienceResponse = Card4.transform.GetChild(0).GetChild(3).gameObject;
        AudienceResponsePro = Card4.transform.GetChild(0).GetChild(2).gameObject;
        AudienceResponseCon = Card4.transform.GetChild(0).GetChild(4).gameObject;
        yield return new WaitForSeconds(0.1f);
        PlayerSpeech.text = Description.GetComponent<Text>().text;
        yield return new WaitForSeconds(0.1f);
        if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePro.GetComponent<Text>().text);
        }
        else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseCon.GetComponent<Text>().text);
        }
        else
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponse.GetComponent<Text>().text);
        }
        yield return new WaitForSeconds(0.1f);
        CardPosition = CardPosition + 1;
        yield return new WaitForSeconds(0.1f);
        if (CardPosition == 1)
        {
            Card4 = DCard1;
            Button4 = DButton1;
        }
        else if (CardPosition == 2)
        {
            Card4 = DCard2;
            Button4 = DButton2;
        }
        else if (CardPosition == 3)
        {
            Card4 = DCard3;
            Button4 = DButton3;
        }
        else if (CardPosition == 4)
        {
            Card4 = DCard4;
            Button4 = DButton4;
        }
        else if (CardPosition == 5)
        {
            Card4 = DCard5;
            Button4 = DButton5;
        }
        else if (CardPosition == 6)
        {
            Card4 = DCard6;
            Button4 = DButton6;
        }
        else if (CardPosition == 7)
        {
            Card4 = DCard7;
            Button4 = DButton7;
        }
        else if (CardPosition == 8)
        {
            Card4 = DCard8;
            Button4 = DButton8;
        }
        else if (CardPosition == 9)
        {
            Card4 = DCard9;
            Button4 = DButton9;
        }
        else if (CardPosition == 10)
        {
            Card4 = DCard10;
            Button4 = DButton10;
        }
        else if (CardPosition == 11)
        {
            Card4 = DCard11;
            Button4 = DButton11;
        }
        else if (CardPosition == 12)
        {
            Card4 = DCard12;
            Button4 = DButton12;
        }
        else if (CardPosition == 13)
        {
            Card4 = DCard13;
            Button4 = DButton13;
        }
        else if (CardPosition == 14)
        {
            Card4 = DCard14;
            Button4 = DButton14;
        }
        else if (CardPosition == 15)
        {
            Card4 = DCard15;
            Button4 = DButton15;
        }
        else if (CardPosition == 16)
        {
            Card4 = DCard16;
            Button4 = DButton16;
        }
        else if (CardPosition == 17)
        {
            Card4 = DCard17;
            Button4 = DButton17;
        }
        else if (CardPosition == 18)
        {
            Card4 = DCard18;
            Button4 = DButton18;
        }
        else if (CardPosition == 19)
        {
            Card4 = DCard19;
            Button4 = DButton19;
        }
        yield return new WaitForSeconds(1);
        transform.position = Card1.transform.position = new Vector3(-0.5f, -0.38f, 1);
        transform.position = Card2.transform.position = new Vector3(-0.25f, -0.38f, 1);
        transform.position = Card3.transform.position = new Vector3(-0f, -0.38f, 1);
        transform.position = Card4.transform.position = new Vector3(0.25f, -0.38f, 1);
        transform.position = Card5.transform.position = new Vector3(0.5f, -0.38f, 1);
        Button1.onClick.AddListener(Button1Clicked);
        Button2.onClick.AddListener(Button2Clicked);
        Button3.onClick.AddListener(Button3Clicked);
        Button4.onClick.AddListener(Button4Clicked);
        Button5.onClick.AddListener(Button5Clicked);
        StartCoroutine(OpponentReply());
    }

    void Button5Clicked()
    {
        Button1.onClick.RemoveListener(Button1Clicked);
        Button2.onClick.RemoveListener(Button2Clicked);
        Button3.onClick.RemoveListener(Button3Clicked);
        Button4.onClick.RemoveListener(Button4Clicked);
        Button5.onClick.RemoveListener(Button5Clicked);
        Card5.transform.position = new Vector3(100, 100, 100);
        Deck1.gameObject.SetActive(false);
        SpeechBubble.gameObject.SetActive(true);
        ThoughtBubble.gameObject.SetActive(false);
        StartCoroutine(FiveAA());
    }
    IEnumerator FiveAA()
    {
        yield return new WaitForSeconds(0.1f);
        Description = Card5.transform.GetChild(0).GetChild(1).gameObject;
        EmotionPro = Card5.transform.GetChild(0).GetChild(5).gameObject;
        EmotionCon = Card5.transform.GetChild(0).GetChild(6).gameObject;
        AudienceResponse = Card5.transform.GetChild(0).GetChild(3).gameObject;
        AudienceResponsePro = Card5.transform.GetChild(0).GetChild(2).gameObject;
        AudienceResponseCon = Card5.transform.GetChild(0).GetChild(4).gameObject;
        yield return new WaitForSeconds(0.1f);
        PlayerSpeech.text = Description.GetComponent<Text>().text;
        yield return new WaitForSeconds(0.1f);
        if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePro.GetComponent<Text>().text);
        }
        else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseCon.GetComponent<Text>().text);
        }
        else
        {
            PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponse.GetComponent<Text>().text);
        }
        yield return new WaitForSeconds(0.1f);
        CardPosition = CardPosition + 1;
        yield return new WaitForSeconds(0.1f);
        if (CardPosition == 1)
        {
            Card5 = DCard1;
            Button5 = DButton1;
        }
        else if (CardPosition == 2)
        {
            Card5 = DCard2;
            Button5 = DButton2;
        }
        else if (CardPosition == 3)
        {
            Card5 = DCard3;
            Button5 = DButton3;
        }
        else if (CardPosition == 4)
        {
            Card5 = DCard4;
            Button5 = DButton4;
        }
        else if (CardPosition == 5)
        {
            Card5 = DCard5;
            Button5 = DButton5;
        }
        else if (CardPosition == 6)
        {
            Card5 = DCard6;
            Button5 = DButton6;
        }
        else if (CardPosition == 7)
        {
            Card5 = DCard7;
            Button5 = DButton7;
        }
        else if (CardPosition == 8)
        {
            Card5 = DCard8;
            Button5 = DButton8;
        }
        else if (CardPosition == 9)
        {
            Card5 = DCard9;
            Button5 = DButton9;
        }
        else if (CardPosition == 10)
        {
            Card5 = DCard10;
            Button5 = DButton10;
        }
        else if (CardPosition == 11)
        {
            Card5 = DCard11;
            Button5 = DButton11;
        }
        else if (CardPosition == 12)
        {
            Card5 = DCard12;
            Button5 = DButton12;
        }
        else if (CardPosition == 13)
        {
            Card5 = DCard13;
            Button5 = DButton13;
        }
        else if (CardPosition == 14)
        {
            Card5 = DCard14;
            Button5 = DButton14;
        }
        else if (CardPosition == 15)
        {
            Card5 = DCard15;
            Button5 = DButton15;
        }
        else if (CardPosition == 16)
        {
            Card5 = DCard16;
            Button5 = DButton16;
        }
        else if (CardPosition == 17)
        {
            Card5 = DCard17;
            Button5 = DButton17;
        }
        else if (CardPosition == 18)
        {
            Card5 = DCard18;
            Button5 = DButton18;
        }
        else if (CardPosition == 19)
        {
            Card5 = DCard19;
            Button5 = DButton19;
        }
        yield return new WaitForSeconds(1);
        transform.position = Card1.transform.position = new Vector3(-0.5f, -0.38f, 1);
        transform.position = Card2.transform.position = new Vector3(-0.25f, -0.38f, 1);
        transform.position = Card3.transform.position = new Vector3(-0f, -0.38f, 1);
        transform.position = Card4.transform.position = new Vector3(0.25f, -0.38f, 1);
        transform.position = Card5.transform.position = new Vector3(0.5f, -0.38f, 1);
        Button1.onClick.AddListener(Button1Clicked);
        Button2.onClick.AddListener(Button2Clicked);
        Button3.onClick.AddListener(Button3Clicked);
        Button4.onClick.AddListener(Button4Clicked);
        Button5.onClick.AddListener(Button5Clicked);
        StartCoroutine(OpponentReply());
    }


    IEnumerator OpponentReply()
    {
        // 1 = Serious, 2 = Humourous, 3 = Sad, 4 = Passionate, and 5 = Angry
        // A lot of this is copy and pasted for demo purposes remove it for final release.
        yield return new WaitForSeconds(0.1f);
        SpeechBubble.gameObject.SetActive(false);
        OpponentSpeechBubble.gameObject.SetActive(true);
        WhichOpponentReply = (Mathf.Round(Random.Range(1, 10)));
        if (WhichOpponentReply == 1)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 2;
            OpponentSpeech.text = "Marijuana is bad for your brain, lungs, and heart.";
            yield return new WaitForSeconds(1);
            AudienceMood = 1;
        }
        if (WhichOpponentReply == 2)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 2;
            OpponentSpeech.text = "Weed smokers have a higher risk of developing a mental illness like depression or schizophrenia.";
            yield return new WaitForSeconds(1);
            AudienceMood = 1;
        }
        if (WhichOpponentReply == 3)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 1;
            OpponentSpeech.text = "It's addictive. If it is legal numerous people will suffer financially because they spend all their money on pot. Up to 1 in 10 weed smokers develop a dependency to it over time.";
            yield return new WaitForSeconds(1);
            AudienceMood = 3;
        }
        if (WhichOpponentReply == 4)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 2;
            OpponentSpeech.text = "It's a gateway drug. Research in New Zealand found regular cannabis users were 60 times more likely to try other illicit drugs than young people who had never smoked cannabis.";
            yield return new WaitForSeconds(1);
            AudienceMood = 4;
        }
        if (WhichOpponentReply == 5)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 3;
            OpponentSpeech.text = "Research shows that heavy pot-smokers are several times more likely than non-users to commit violent crime.";
            yield return new WaitForSeconds(1);
            AudienceMood = 1;
        }
        if (WhichOpponentReply == 6)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 1;
            OpponentSpeech.text = "Druggies will see it as a chance to try and get worst drugs legalised.";
            yield return new WaitForSeconds(1);
            AudienceMood = 4;
        }
        if (WhichOpponentReply == 7)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 1;
            OpponentSpeech.text = "A study published by Northwestern University in the journal Hippocampus showed, through MRIs, an oddly shaped hippocampus in adolescents who'd used marijuana heavily at ages 16 or 17 for a period of three years. The hippocampus is the region of the brain most responsible for short- and long-term memory. Not surprisingly, there was also an accompanied average long-term memory test score reduction of 18% for heavy users compared with those who'd not used marijuana before. ";
            yield return new WaitForSeconds(1);
            AudienceMood = 5;
        }
        if (WhichOpponentReply == 8)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 1;
            OpponentSpeech.text = "There aren't adequate parameters to police marijuana use. The government is so slow how long would it take to put these in place?";
            yield return new WaitForSeconds(1);
            AudienceMood = 2;
        }
        if (WhichOpponentReply == 9)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 1;
            OpponentSpeech.text = "A lot of land would have to be used to grow weed which could be used to grow more important things.";
            yield return new WaitForSeconds(1);
            AudienceMood = 5;
        }
        if (WhichOpponentReply == 10)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 1;
            OpponentSpeech.text = "Imagine all the wasted electricity being used to weed. A 2012 study from scientist Evan Mills, Ph.D., at the Lawrence Berkeley National Laboratory found that legal indoor marijuana growing farms were accounting for 1% of our nation's electricity usage, totaling about $6 billion a year. ";
            yield return new WaitForSeconds(1);
            AudienceMood = 5;
        }

        yield return new WaitForSeconds(1);
        ThoughtBubble.gameObject.SetActive(true);
        OpponentSpeechBubble.gameObject.SetActive(false);
        Deck1.gameObject.SetActive(true);
    }

    
    IEnumerator YouWin()
    {
        yield return new WaitForSeconds(1);
        EndState.text = "YOU WIN";
        yield return new WaitForSeconds(1);
        EndState.text = "Resetting In 5";
        yield return new WaitForSeconds(1);
        EndState.text = "Resetting In 4";
        yield return new WaitForSeconds(1);
        EndState.text = "Resetting In 3";
        yield return new WaitForSeconds(1);
        EndState.text = "Resetting In 2";
        yield return new WaitForSeconds(1);
        EndState.text = "Resetting In 1";
        yield return new WaitForSeconds(1);
        Application.LoadLevel(0);
    }
    IEnumerator YouLose()
    {
        yield return new WaitForSeconds(1);
        EndState.text = "YOU LOSE";
        yield return new WaitForSeconds(1);
        EndState.text = "Resetting In 5";
        yield return new WaitForSeconds(1);
        EndState.text = "Resetting In 4";
        yield return new WaitForSeconds(1);
        EndState.text = "Resetting In 3";
        yield return new WaitForSeconds(1);
        EndState.text = "Resetting In 2";
        yield return new WaitForSeconds(1);
        EndState.text = "Resetting In 1";
        yield return new WaitForSeconds(1);
        Application.LoadLevel(0);
    }
}
