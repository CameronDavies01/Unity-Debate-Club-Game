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
    GameObject AudienceResponseSpeechPro;
    GameObject AudienceResponseSpeechCon;
    GameObject CardType;
    GameObject GestureEffect;
    GameObject AudienceResponseProPlus;
    GameObject AudienceResponsePlus;
    GameObject AudienceResponseConPlus;
    GameObject AudienceResponseProPlusPlus;
    GameObject AudienceResponsePlusPlus;
    GameObject AudienceResponseConPlusPlus;

    public GameObject PlayerSpotlight;
    public GameObject OpponentSpotlight;

    public GameObject QM1;
    public GameObject QM2;
    public GameObject QM3;
    public GameObject QM4;
    public GameObject QM5;
    public GameObject QM6;

    public GameObject Emotion1;
    public GameObject Emotion2;
    public GameObject Emotion3;
    public GameObject Emotion4;
    public GameObject Emotion5;
    public Sprite Serious;
    public Sprite Humourous;
    public Sprite Sad;
    public Sprite Passionate;
    public Sprite Angry;

    public ParticleSystem PlayerDamaged;
    public ParticleSystem OpponentDamaged;

    public int OpponentMove;
    public GameObject OCard;

    GameObject DCard1;
    GameObject DCard2;
    GameObject DCard3;
    GameObject DCard4;
     GameObject DCard5;
     GameObject DCard6;
     GameObject DCard7;
     GameObject DCard8;
     GameObject DCard9;
     GameObject DCard10;
     GameObject DCard11;
     GameObject DCard12;
     GameObject DCard13;
     GameObject DCard14;
     GameObject DCard15;
     GameObject DCard16;
     GameObject DCard17;
     GameObject DCard18;
     GameObject DCard19;
    GameObject DCard20;
    GameObject DCard21;
    GameObject DCard22;
    GameObject DCard23;
    GameObject DCard24;
    GameObject DCard25;
    GameObject DCard26;
    GameObject DCard27;
    GameObject DCard28;
    GameObject DCard29;
    GameObject DCard30;
    GameObject DCard31;
    GameObject DCard32;
    GameObject DCard33;
    GameObject DCard34;
    GameObject DCard35;
    GameObject DCard36;
    GameObject DCard37;
    GameObject DCard38;
    GameObject DCard39;

    GameObject OCard1;
    GameObject OCard2;
    GameObject OCard3;
    GameObject OCard4;
    GameObject OCard5;
    GameObject OCard6;
    GameObject OCard7;
    GameObject OCard8;
    GameObject OCard9;
    GameObject OCard10;
    GameObject OCard11;
    GameObject OCard12;
    GameObject OCard13;
    GameObject OCard14;
    GameObject OCard15;
    GameObject OCard16;
    GameObject OCard17;
    GameObject OCard18;
    GameObject OCard19;
    GameObject OCard20;
    GameObject OCard21;
    GameObject OCard22;
    GameObject OCard23;
    GameObject OCard24;
    GameObject OCard25;
    GameObject OCard26;
    GameObject OCard27;
    GameObject OCard28;
    GameObject OCard29;
    GameObject OCard30;
    GameObject OCard31;
    GameObject OCard32;
    GameObject OCard33;
    GameObject OCard34;
    GameObject OCard35;
    GameObject OCard36;
    GameObject OCard37;
    GameObject OCard38;
    GameObject OCard39;

    public GameObject AudienceOpinion;


    // The Cards
    GameObject Card1;
    GameObject Card2;
    GameObject Card3;
    GameObject Card4;
    GameObject Card5;
    GameObject OpponentCard;

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
    public AudioSource YoureWrong;
    public AudioSource YoureOn;
    public AudioSource MaybeImWrong;
    public AudioSource MaleVoice1;
    public AudioSource MaleVoice2;
    public AudioSource Ha;
    public AudioSource TheStateOfThisWorld;
    public AudioSource YouDisgustMe;
    public AudioSource YesYes;
    public AudioSource WeWillDoThis;

    Button CardButton1;
    Button CardButton2;
    Button CardButton3;
    Button CardButton4;
    Button CardButton5;

    public GameObject DummyCard;
    public GameObject OpponentDummyCard;
    public GameObject AudienceSpeechBubble;

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

    public int OCardPosition;


public GameObject Scoreboard;

    public Material AudienceMaterial;

    public GameObject Deck1;

    public float WhichOpponentReply;

    public Text EndState;

    public int TalkCheck;

    public int ReferencePower;
    public int ReferencePower2;
    public int ReferencePower3;
    public int ReferencePower4;

    public Text AudienceSpeech;

    float WhereX;
    float WhereY;
    float WhereZ;

    // Start is called before the first frame update
    void Start()
    {
        OpponentMove = 0;
        //Your Deck List
        List<int> CardShuffle = new List<int>(); 
        for (int c = 0; c < 39; c++)
        {
            CardShuffle.Add(c);
        }
        int index;
        int i;
        index = Random.Range(0, CardShuffle.Count - 1);  
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard1 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard2 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard3 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard4 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard5 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard6 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard7 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard8 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard9 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard10 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard11 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard12 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard13 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard14 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard15 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard16 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard17 = GameObject.Find(i.ToString());  
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard18 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard19 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard20 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard21 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard22 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard23 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard24 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard25 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard26 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard27 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard28 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard29 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard30 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard31 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard32 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard33 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard34 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard35 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard36 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard37 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard38 = GameObject.Find(i.ToString());
        index = Random.Range(0, CardShuffle.Count - 1);
        i = CardShuffle[index];
        CardShuffle.RemoveAt(index);
        DCard39 = GameObject.Find(i.ToString());

        //Your Opponent Deck List
        List<int> OpponentCardShuffle = new List<int>();
        for (int e = 1; e < 41; e++)
        {
            OpponentCardShuffle.Add(e);
        }
        int Oindex;
        int o;
        Oindex = Random.Range(1, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard1 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard2 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard3 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard4 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard5 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard6 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard7 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard8 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard9 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard10 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard11 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard12 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard13 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard14 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard15 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard16 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard17 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard18 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard19 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard20 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard21 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard22 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard23 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard24 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard25 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard26 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard27 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard28 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard29 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard30 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard31 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard32 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard33 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard34 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard35 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard36 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard37 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard38 = GameObject.Find((39 + o).ToString());
        Oindex = Random.Range(0, OpponentCardShuffle.Count - 1);
        o = OpponentCardShuffle[Oindex];
        OpponentCardShuffle.RemoveAt(Oindex);
        OCard39 = GameObject.Find((39 + o).ToString());






        PlayerDamaged.Stop();
        OpponentDamaged.Stop();
        TalkCheck = 2;
        YoureOn.Play();
        MaybeImWrong.Play();
        YoureWrong.Play();
        Ha.Play();
        TheStateOfThisWorld.Play();
        YouDisgustMe.Play();
        YesYes.Play();
        WeWillDoThis.Play();
        YoureOn.mute = true;
        MaybeImWrong.mute = true;
        YoureWrong.mute = true;
        Ha.mute = true;
        TheStateOfThisWorld.mute = true;
        YouDisgustMe.mute = true;
        YesYes.mute = true;
        WeWillDoThis.mute = true;
        AudienceMood = 5;
        PlayerAudienceApproval = int.Parse(AudienceOpinion.GetComponent<Text>().text);
        Card1 = DCard1;
        Card2 = DCard2;
        Card3 = DCard3;
        Card4 = DCard4;
        Card5 = DCard5;
        ReferencePower = 1;
        ReferencePower2 = 1;
        CardPosition = 5;
        CardButton1 = (Card1.transform.GetChild(0).gameObject).GetComponent<Button>();
        CardButton2 = (Card2.transform.GetChild(0).gameObject).GetComponent<Button>();
        CardButton3 = (Card3.transform.GetChild(0).gameObject).GetComponent<Button>();
        CardButton4 = (Card4.transform.GetChild(0).gameObject).GetComponent<Button>();
        CardButton5 = (Card5.transform.GetChild(0).gameObject).GetComponent<Button>();
        CardButton1.onClick.AddListener(Button1Clicked);
        CardButton2.onClick.AddListener(Button2Clicked);
        CardButton3.onClick.AddListener(Button3Clicked);
        CardButton4.onClick.AddListener(Button4Clicked);
        CardButton5.onClick.AddListener(Button5Clicked);
        transform.position = Card1.transform.position = new Vector3(-0.5f, -0.38f, 1);
        transform.position = Card2.transform.position = new Vector3(-0.25f, -0.38f, 1);
        transform.position = Card3.transform.position = new Vector3(-0f, -0.38f, 1);
        transform.position = Card4.transform.position = new Vector3(0.25f, -0.38f, 1);
        transform.position = Card5.transform.position = new Vector3(0.5f, -0.38f, 1);
    }

// Update is called once per frame
void Update()
{
        if (Input.GetMouseButtonDown(0) & TalkCheck == 1)
        {
            StartCoroutine(OpponentReply());
        }
        if (Input.GetMouseButtonDown(0) & TalkCheck == 0)
        {
            StartCoroutine(Final());
        }

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
        if (PlayerAudienceApproval > 55)
            {
            YoureWrong.mute = false;
            YoureOn.mute = true;
            MaybeImWrong.mute = true;


        }
        else if (PlayerAudienceApproval < 45)
        {
            YoureWrong.mute = true;
            YoureOn.mute = true;
            MaybeImWrong.mute = false;

        }
        else
        {
            YoureWrong.mute = true;
            YoureOn.mute = false;
            MaybeImWrong.mute = true;
        }

        if (AudienceMood == 1)
        {
            AudienceMaterial.SetColor("_Color", Color.gray);
            Ha.mute = true;
            TheStateOfThisWorld.mute = true;
            YouDisgustMe.mute = true;
            YesYes.mute = false;
            WeWillDoThis.mute = true;
            Emotion1.gameObject.GetComponent<SpriteRenderer>().sprite = Serious;
            Emotion2.gameObject.GetComponent<SpriteRenderer>().sprite = Serious;
            Emotion3.gameObject.GetComponent<SpriteRenderer>().sprite = Serious;
            Emotion4.gameObject.GetComponent<SpriteRenderer>().sprite = Serious;
            Emotion5.gameObject.GetComponent<SpriteRenderer>().sprite = Serious;
        }
        if (AudienceMood == 2)
        {
            AudienceMaterial.SetColor("_Color", Color.green);
            Ha.mute = false;
            TheStateOfThisWorld.mute = true;
            YouDisgustMe.mute = true;
            YesYes.mute = true;
            WeWillDoThis.mute = true;
            Emotion1.gameObject.GetComponent<SpriteRenderer>().sprite = Humourous;
            Emotion2.gameObject.GetComponent<SpriteRenderer>().sprite = Humourous;
            Emotion3.gameObject.GetComponent<SpriteRenderer>().sprite = Humourous;
            Emotion4.gameObject.GetComponent<SpriteRenderer>().sprite = Humourous;
            Emotion5.gameObject.GetComponent<SpriteRenderer>().sprite = Humourous;
        }
        if (AudienceMood == 3)
        {
            AudienceMaterial.SetColor("_Color", Color.cyan);
            Ha.mute = true;
            TheStateOfThisWorld.mute = false;
            YouDisgustMe.mute = true;
            YesYes.mute = true;
            WeWillDoThis.mute = true;
            Emotion1.gameObject.GetComponent<SpriteRenderer>().sprite = Sad;
            Emotion2.gameObject.GetComponent<SpriteRenderer>().sprite = Sad;
            Emotion3.gameObject.GetComponent<SpriteRenderer>().sprite = Sad;
            Emotion4.gameObject.GetComponent<SpriteRenderer>().sprite = Sad;
            Emotion5.gameObject.GetComponent<SpriteRenderer>().sprite = Sad;
        }
        if (AudienceMood == 4)
        {
            AudienceMaterial.SetColor("_Color", Color.magenta);
            Ha.mute = true;
            TheStateOfThisWorld.mute = true;
            YouDisgustMe.mute = true;
            YesYes.mute = true;
            WeWillDoThis.mute = false;
            Emotion1.gameObject.GetComponent<SpriteRenderer>().sprite = Passionate;
            Emotion2.gameObject.GetComponent<SpriteRenderer>().sprite = Passionate;
            Emotion3.gameObject.GetComponent<SpriteRenderer>().sprite = Passionate;
            Emotion4.gameObject.GetComponent<SpriteRenderer>().sprite = Passionate;
            Emotion5.gameObject.GetComponent<SpriteRenderer>().sprite = Passionate;
        }
        if (AudienceMood == 5)
        {
            AudienceMaterial.SetColor("_Color", Color.red);
            Ha.mute = true;
            TheStateOfThisWorld.mute = true;
            YouDisgustMe.mute = false;
            YesYes.mute = true;
            WeWillDoThis.mute = true;
            Emotion1.gameObject.GetComponent<SpriteRenderer>().sprite = Angry;
            Emotion2.gameObject.GetComponent<SpriteRenderer>().sprite = Angry;
            Emotion3.gameObject.GetComponent<SpriteRenderer>().sprite = Angry;
            Emotion4.gameObject.GetComponent<SpriteRenderer>().sprite = Angry;
            Emotion5.gameObject.GetComponent<SpriteRenderer>().sprite = Angry;
        }

        if ((CardPosition > 34) && (PlayerAudienceApproval > 49))
        {
            StartCoroutine(YouWin());
        }
        if ((CardPosition > 34) && (PlayerAudienceApproval < 50))
        {
            StartCoroutine(YouLose());
        }

    }

    void Button1Clicked()
    {
        MaleVoice2.Play();
        CardButton1.onClick.RemoveListener(Button1Clicked);
        CardButton2.onClick.RemoveListener(Button2Clicked);
        CardButton3.onClick.RemoveListener(Button3Clicked);
        CardButton4.onClick.RemoveListener(Button4Clicked);
        CardButton5.onClick.RemoveListener(Button5Clicked);
        Card1.transform.position = new Vector3(100, 100, 100);
        Deck1.gameObject.SetActive(false);
        SpeechBubble.gameObject.SetActive(true);
        ThoughtBubble.gameObject.SetActive(false);
        PlayerSpotlight.SetActive(true);
        OpponentSpotlight.SetActive(false);
        QM1.SetActive(false);
        QM2.SetActive(false);
        QM3.SetActive(false);
        QM4.SetActive(true);
        QM5.SetActive(true);
        QM6.SetActive(true);
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
        AudienceResponseSpeechPro = Card1.transform.GetChild(0).GetChild(8).gameObject;
        AudienceResponseSpeechCon = Card1.transform.GetChild(0).GetChild(9).gameObject;
        CardType = Card1.transform.GetChild(0).GetChild(7).gameObject;
        yield return new WaitForSeconds(0.1f);
        if (CardType.GetComponent<Text>().text == "Argument")
        {
            PlayerSpeech.text = Description.GetComponent<Text>().text;
            DummyCard.active = true;
            DummyCard.GetComponent<Animation>().Play("CardThrow");
            yield return new WaitForSeconds(0.8f);
            OpponentDamaged.Play();
            DummyCard.active = false;
            yield return new WaitForSeconds(0.1f);
            OpponentDamaged.Stop();
            yield return new WaitForSeconds(0.1f);
            if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
            {
                PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePro.GetComponent<Text>().text);
                AudienceSpeechBubble.active = true;
                AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                AudienceSpeech.GetComponent<Text>().color = Color.blue;
            }
            else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
            {
                PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseCon.GetComponent<Text>().text);
                AudienceSpeechBubble.active = true;
                AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                AudienceSpeech.GetComponent<Text>().color = Color.red;
            }
            else
            {
                PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponse.GetComponent<Text>().text);
            }
            ReferencePower = 1;
            ReferencePower2 = 1;
        }
        else if (CardType.GetComponent<Text>().text == "Gesture")
        {
            GestureEffect = Card1.transform.GetChild(0).GetChild(10).gameObject;
            if (GestureEffect.GetComponent<Text>().text == "0")
            {
                AudienceMood = 3;
                PlayerSpeech.text = "I can't believe you would be so heartless";
            }
            else if (GestureEffect.GetComponent<Text>().text == "1")
            {
                AudienceMood = 1;
                PlayerSpeech.text = "To a fair and respectful debate";
            }
            else if (GestureEffect.GetComponent<Text>().text == "2")
            {
                AudienceMood = 5;
                PlayerSpeech.text = "ARE WE ALL GOING TO TAKE THIS?";
            }
            else if (GestureEffect.GetComponent<Text>().text == "3")
            {
                AudienceMood = 2;
                PlayerSpeech.text = "Ok boomer";
            }
            else if (GestureEffect.GetComponent<Text>().text == "4")
            {
                AudienceMood = 4;
                PlayerSpeech.text = "Come on everyone this is something to be passionate about";
            }
            else if (GestureEffect.GetComponent<Text>().text == "5")
            {
                AudienceMood = 3;
                PlayerSpeech.text = "No matter what you say, I won't give up for what I believe in";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "6")
            {
                AudienceMood = 1;
                PlayerSpeech.text = "Well done, you're good at debating. It's not over yet though!";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "7")
            {
                AudienceMood = 5;
                PlayerSpeech.text = "AHHHHHHHHHHHHHHHHHHHHHH!!!";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "8")
            {
                AudienceMood = 2;
                PlayerSpeech.text = "Wow, I'm not good at this am I?";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "9")
            {
                AudienceMood = 4;
                PlayerSpeech.text = "I'll give youy this, you know what you're doing, I'll almost fell bad for you when I beat you at this debate";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            ReferencePower = 1;
            ReferencePower2 = 1;
        }
        else if (CardType.GetComponent<Text>().text == "Reference 1")
        {
            AudienceResponseProPlus = Card1.transform.GetChild(0).GetChild(10).gameObject;
            AudienceResponsePlus = Card1.transform.GetChild(0).GetChild(11).gameObject;
            AudienceResponseConPlus = Card1.transform.GetChild(0).GetChild(12).gameObject;
            AudienceResponseProPlusPlus = Card1.transform.GetChild(0).GetChild(13).gameObject;
            AudienceResponsePlusPlus = Card1.transform.GetChild(0).GetChild(14).gameObject;
            AudienceResponseConPlusPlus = Card1.transform.GetChild(0).GetChild(15).gameObject;
            if (ReferencePower == 1)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePro.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseCon.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponse.GetComponent<Text>().text);
                }
            }
            else if (ReferencePower == 2)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseProPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseConPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePlus.GetComponent<Text>().text);
                }
            }
            else if (ReferencePower == 3)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseProPlusPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseConPlusPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePlusPlus.GetComponent<Text>().text);
                }
            }
            ReferencePower = ReferencePower + 1;
            ReferencePower2 = 1;
        }
        else if (CardType.GetComponent<Text>().text == "Reference 2")
        {
            AudienceResponseProPlus = Card1.transform.GetChild(0).GetChild(10).gameObject;
            AudienceResponsePlus = Card1.transform.GetChild(0).GetChild(11).gameObject;
            AudienceResponseConPlus = Card1.transform.GetChild(0).GetChild(12).gameObject;
            AudienceResponseProPlusPlus = Card1.transform.GetChild(0).GetChild(13).gameObject;
            AudienceResponsePlusPlus = Card1.transform.GetChild(0).GetChild(14).gameObject;
            AudienceResponseConPlusPlus = Card1.transform.GetChild(0).GetChild(15).gameObject;
            if (ReferencePower2 == 1)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePro.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseCon.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponse.GetComponent<Text>().text);
                }
            }
            else if (ReferencePower2 == 2)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseProPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseConPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePlus.GetComponent<Text>().text);
                }
            }
            else if (ReferencePower2 == 3)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseProPlusPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseConPlusPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePlusPlus.GetComponent<Text>().text);
                }
            }
            ReferencePower2 = ReferencePower2 + 1;
            ReferencePower = 1;
        }
        yield return new WaitForSeconds(0.1f);
            CardPosition = CardPosition + 1;
            yield return new WaitForSeconds(0.1f);
            if (CardPosition == 1)
            {
                Card1 = DCard1;
            }
            else if (CardPosition == 2)
            {
                Card1 = DCard2;
            }
            else if (CardPosition == 3)
            {
                Card1 = DCard3;
            }
            else if (CardPosition == 4)
            {
                Card1 = DCard4;
            }
            else if (CardPosition == 5)
            {
                Card1 = DCard5;
            }
            else if (CardPosition == 6)
            {
                Card1 = DCard6;
            }
            else if (CardPosition == 7)
            {
                Card1 = DCard7;
            }
            else if (CardPosition == 8)
            {
                Card1 = DCard8;
            }
            else if (CardPosition == 9)
            {
                Card1 = DCard9;
            }
            else if (CardPosition == 10)
            {
                Card1 = DCard10;
            }
            else if (CardPosition == 11)
            {
                Card1 = DCard11;
            }
            else if (CardPosition == 12)
            {
                Card1 = DCard12;
            }
            else if (CardPosition == 13)
            {
                Card1 = DCard13;
            }
            else if (CardPosition == 14)
            {
                Card1 = DCard14;
            }
            else if (CardPosition == 15)
            {
                Card1 = DCard15;
            }
            else if (CardPosition == 16)
            {
                Card1 = DCard16;
            }
            else if (CardPosition == 17)
            {
                Card1 = DCard17;
            }
            else if (CardPosition == 18)
            {
                Card1 = DCard18;
            }
            else if (CardPosition == 19)
            {
                Card1 = DCard19;
            }
            else if (CardPosition == 20)
            {
                Card1 = DCard20;
            }
            else if (CardPosition == 21)
            {
                Card1 = DCard21;
            }
            else if (CardPosition == 22)
            {
                Card1 = DCard22;
            }
            else if (CardPosition == 23)
            {
                Card1 = DCard23;
            }
        else if (CardPosition == 24)
        {
            Card1 = DCard24;
        }
        else if (CardPosition == 25)
        {
            Card1 = DCard25;
        }
        else if (CardPosition == 26)
        {
            Card1 = DCard26;
        }
        else if (CardPosition == 27)
        {
            Card1 = DCard27;
        }
        else if (CardPosition == 28)
        {
            Card1 = DCard28;
        }
        else if (CardPosition == 29)
        {
            Card1 = DCard29;
        }
        else if (CardPosition == 30)
        {
            Card1 = DCard30;
        }
        else if (CardPosition == 31)
        {
            Card1 = DCard31;
        }
        else if (CardPosition == 32)
        {
            Card1 = DCard32;
        }
        else if (CardPosition == 33)
        {
            Card1 = DCard33;
        }
        else if (CardPosition == 34)
        {
            Card1 = DCard34;
        }
        else if (CardPosition == 35)
        {
            Card1 = DCard35;
        }
        else if (CardPosition == 36)
        {
            Card1 = DCard36;
        }
        else if (CardPosition == 37)
        {
            Card1 = DCard37;
        }
        else if (CardPosition == 38)
        {
            Card1 = DCard38;
        }
        else if (CardPosition == 39)
        {
            Card1 = DCard39;
        }

        yield return new WaitForSeconds(0.1f);
            CardButton1 = (Card1.transform.GetChild(0).gameObject).GetComponent<Button>();
            transform.position = Card1.transform.position = new Vector3(-0.5f, -0.38f, 1);
            transform.position = Card2.transform.position = new Vector3(-0.25f, -0.38f, 1);
            transform.position = Card3.transform.position = new Vector3(-0f, -0.38f, 1);
            transform.position = Card4.transform.position = new Vector3(0.25f, -0.38f, 1);
            transform.position = Card5.transform.position = new Vector3(0.5f, -0.38f, 1);
            CardButton1.onClick.AddListener(Button1Clicked);
            CardButton2.onClick.AddListener(Button2Clicked);
            CardButton3.onClick.AddListener(Button3Clicked);
            CardButton4.onClick.AddListener(Button4Clicked);
            CardButton5.onClick.AddListener(Button5Clicked);
            TalkCheck = 1;
        
        
    }

    void Button2Clicked()
    {
        MaleVoice2.Play();
        CardButton1.onClick.RemoveListener(Button1Clicked);
        CardButton2.onClick.RemoveListener(Button2Clicked);
        CardButton3.onClick.RemoveListener(Button3Clicked);
        CardButton4.onClick.RemoveListener(Button4Clicked);
        CardButton5.onClick.RemoveListener(Button5Clicked);
        Card2.transform.position = new Vector3(100, 100, 100);
        Deck1.gameObject.SetActive(false);
        SpeechBubble.gameObject.SetActive(true);
        ThoughtBubble.gameObject.SetActive(false);
        PlayerSpotlight.SetActive(true);
        OpponentSpotlight.SetActive(false);
        QM1.SetActive(false);
        QM2.SetActive(false);
        QM3.SetActive(false);
        QM4.SetActive(true);
        QM5.SetActive(true);
        QM6.SetActive(true);
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
        AudienceResponseSpeechPro = Card2.transform.GetChild(0).GetChild(8).gameObject;
        AudienceResponseSpeechCon = Card2.transform.GetChild(0).GetChild(9).gameObject;
        CardType = Card2.transform.GetChild(0).GetChild(7).gameObject;
        yield return new WaitForSeconds(0.1f);
        if (CardType.GetComponent<Text>().text == "Argument")
        {
            PlayerSpeech.text = Description.GetComponent<Text>().text;
            DummyCard.active = true;
            DummyCard.GetComponent<Animation>().Play("CardThrow");
            yield return new WaitForSeconds(0.8f);
            OpponentDamaged.Play();
            DummyCard.active = false;
            yield return new WaitForSeconds(0.1f);
            OpponentDamaged.Stop();
            yield return new WaitForSeconds(0.1f);
            if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
            {
                PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePro.GetComponent<Text>().text);
                AudienceSpeechBubble.active = true;
                AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                AudienceSpeech.GetComponent<Text>().color = Color.blue;
            }
            else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
            {
                PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseCon.GetComponent<Text>().text);
                AudienceSpeechBubble.active = true;
                AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                AudienceSpeech.GetComponent<Text>().color = Color.red;
            }
            else
            {
                PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponse.GetComponent<Text>().text);
            }
            ReferencePower = 1;
            ReferencePower2 = 1;
        }
        else if (CardType.GetComponent<Text>().text == "Gesture")
        {
            GestureEffect = Card2.transform.GetChild(0).GetChild(10).gameObject;
            if (GestureEffect.GetComponent<Text>().text == "0")
            {
                AudienceMood = 3;
                PlayerSpeech.text = "I can't believe you would be so heartless";
            }
            else if (GestureEffect.GetComponent<Text>().text == "1")
            {
                AudienceMood = 1;
                PlayerSpeech.text = "To a fair and respectful debate";
            }
            else if (GestureEffect.GetComponent<Text>().text == "2")
            {
                AudienceMood = 5;
                PlayerSpeech.text = "ARE WE ALL GOING TO TAKE THIS?";
            }
            else if (GestureEffect.GetComponent<Text>().text == "3")
            {
                AudienceMood = 2;
                PlayerSpeech.text = "I can't believe they'd let someone like you on stage";
            }
            else if (GestureEffect.GetComponent<Text>().text == "4")
            {
                AudienceMood = 4;
                PlayerSpeech.text = "Come on everyone this is something to be passionate about";
            }
            else if (GestureEffect.GetComponent<Text>().text == "5")
            {
                AudienceMood = 3;
                PlayerSpeech.text = "No matter what you say, I won't give up for what I believe in";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "6")
            {
                AudienceMood = 1;
                PlayerSpeech.text = "Well done, you're good at debating. It's not over yet though!";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "7")
            {
                AudienceMood = 5;
                PlayerSpeech.text = "AHHHHHHHHHHHHHHHHHHHHHH!!!";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "8")
            {
                AudienceMood = 2;
                PlayerSpeech.text = "Wow, I'm not good at this am I?";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "9")
            {
                AudienceMood = 4;
                PlayerSpeech.text = "I'll give youy this, you know what you're doing, I'll almost fell bad for you when I beat you at this debate";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            ReferencePower = 1;
            ReferencePower2 = 1;
        }
        else if (CardType.GetComponent<Text>().text == "Reference 1")
        {
            AudienceResponseProPlus = Card2.transform.GetChild(0).GetChild(10).gameObject;
            AudienceResponsePlus = Card2.transform.GetChild(0).GetChild(11).gameObject;
            AudienceResponseConPlus = Card2.transform.GetChild(0).GetChild(12).gameObject;
            AudienceResponseProPlusPlus = Card2.transform.GetChild(0).GetChild(13).gameObject;
            AudienceResponsePlusPlus = Card2.transform.GetChild(0).GetChild(14).gameObject;
            AudienceResponseConPlusPlus = Card2.transform.GetChild(0).GetChild(15).gameObject;
            if (ReferencePower == 1)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePro.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseCon.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponse.GetComponent<Text>().text);
                }
            }
            else if (ReferencePower == 2)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseProPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseConPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePlus.GetComponent<Text>().text);
                }
            }
            else if (ReferencePower == 3)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseProPlusPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseConPlusPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePlusPlus.GetComponent<Text>().text);
                }
            }
            ReferencePower = ReferencePower + 1;
            ReferencePower2 = 1;
        }
        else if (CardType.GetComponent<Text>().text == "Reference 2")
        {
            AudienceResponseProPlus = Card2.transform.GetChild(0).GetChild(10).gameObject;
            AudienceResponsePlus = Card2.transform.GetChild(0).GetChild(11).gameObject;
            AudienceResponseConPlus = Card2.transform.GetChild(0).GetChild(12).gameObject;
            AudienceResponseProPlusPlus = Card2.transform.GetChild(0).GetChild(13).gameObject;
            AudienceResponsePlusPlus = Card2.transform.GetChild(0).GetChild(14).gameObject;
            AudienceResponseConPlusPlus = Card2.transform.GetChild(0).GetChild(15).gameObject;
            if (ReferencePower2 == 1)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePro.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseCon.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponse.GetComponent<Text>().text);
                }
            }
            else if (ReferencePower2 == 2)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseProPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseConPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePlus.GetComponent<Text>().text);
                }
            }
            else if (ReferencePower2 == 3)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseProPlusPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseConPlusPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePlusPlus.GetComponent<Text>().text);
                }
            }
            ReferencePower2 = ReferencePower2 + 1;
            ReferencePower = 1;
        }
        yield return new WaitForSeconds(0.1f);
            CardPosition = CardPosition + 1;
            yield return new WaitForSeconds(0.1f);
            if (CardPosition == 1)
            {
                Card2 = DCard1;
            }
            else if (CardPosition == 2)
            {
                Card2 = DCard2;
            }
            else if (CardPosition == 3)
            {
                Card2 = DCard3;
            }
            else if (CardPosition == 4)
            {
                Card2 = DCard4;
            }
            else if (CardPosition == 5)
            {
                Card2 = DCard5;
            }
            else if (CardPosition == 6)
            {
                Card2 = DCard6;
            }
            else if (CardPosition == 7)
            {
                Card2 = DCard7;
            }
            else if (CardPosition == 8)
            {
                Card2 = DCard8;
            }
            else if (CardPosition == 9)
            {
                Card2 = DCard9;
            }
            else if (CardPosition == 10)
            {
                Card2 = DCard10;
            }
            else if (CardPosition == 11)
            {
                Card2 = DCard11;
            }
            else if (CardPosition == 12)
            {
                Card2 = DCard12;
            }
            else if (CardPosition == 13)
            {
                Card2 = DCard13;
            }
            else if (CardPosition == 14)
            {
                Card2 = DCard14;
            }
            else if (CardPosition == 15)
            {
                Card2 = DCard15;
            }
            else if (CardPosition == 16)
            {
                Card2 = DCard16;
            }
            else if (CardPosition == 17)
            {
                Card2 = DCard17;
            }
            else if (CardPosition == 18)
            {
                Card2 = DCard18;
            }
            else if (CardPosition == 19)
            {
                Card2 = DCard19;
            }
            else if (CardPosition == 20)
            {
                Card2 = DCard20;
            }
            else if (CardPosition == 21)
            {
                Card2 = DCard21;
            }
            else if (CardPosition == 22)
            {
                Card2 = DCard22;
            }
            else if (CardPosition == 23)
            {
                Card2 = DCard23;
            }
        else if (CardPosition == 24)
        {
            Card2 = DCard24;
        }
        else if (CardPosition == 25)
        {
            Card2 = DCard25;
        }
        else if (CardPosition == 26)
        {
            Card2 = DCard26;
        }
        else if (CardPosition == 27)
        {
            Card2 = DCard27;
        }
        else if (CardPosition == 28)
        {
            Card2 = DCard28;
        }
        else if (CardPosition == 29)
        {
            Card2 = DCard29;
        }
        else if (CardPosition == 30)
        {
            Card2 = DCard30;
        }
        else if (CardPosition == 31)
        {
            Card2 = DCard31;
        }
        else if (CardPosition == 32)
        {
            Card2 = DCard32;
        }
        else if (CardPosition == 33)
        {
            Card2 = DCard33;
        }
        else if (CardPosition == 34)
        {
            Card2 = DCard34;
        }
        else if (CardPosition == 35)
        {
            Card2 = DCard35;
        }
        else if (CardPosition == 36)
        {
            Card2 = DCard36;
        }
        else if (CardPosition == 37)
        {
            Card2 = DCard37;
        }
        else if (CardPosition == 38)
        {
            Card2 = DCard38;
        }
        else if (CardPosition == 39)
        {
            Card2 = DCard39;
        }

        yield return new WaitForSeconds(0.1f);
            CardButton2 = (Card2.transform.GetChild(0).gameObject).GetComponent<Button>();
            transform.position = Card1.transform.position = new Vector3(-0.5f, -0.38f, 1);
            transform.position = Card2.transform.position = new Vector3(-0.25f, -0.38f, 1);
            transform.position = Card3.transform.position = new Vector3(-0f, -0.38f, 1);
            transform.position = Card4.transform.position = new Vector3(0.25f, -0.38f, 1);
            transform.position = Card5.transform.position = new Vector3(0.5f, -0.38f, 1);
            CardButton1.onClick.AddListener(Button1Clicked);
            CardButton2.onClick.AddListener(Button2Clicked);
            CardButton3.onClick.AddListener(Button3Clicked);
            CardButton4.onClick.AddListener(Button4Clicked);
            CardButton5.onClick.AddListener(Button5Clicked);
            TalkCheck = 1;
        
    }

    void Button3Clicked()
    {
        MaleVoice2.Play();
        CardButton1.onClick.RemoveListener(Button1Clicked);
        CardButton2.onClick.RemoveListener(Button2Clicked);
        CardButton3.onClick.RemoveListener(Button3Clicked);
        CardButton4.onClick.RemoveListener(Button4Clicked);
        CardButton5.onClick.RemoveListener(Button5Clicked);
        Card3.transform.position = new Vector3(100, 100, 100);
        Deck1.gameObject.SetActive(false);
        SpeechBubble.gameObject.SetActive(true);
        ThoughtBubble.gameObject.SetActive(false);
        PlayerSpotlight.SetActive(true);
        OpponentSpotlight.SetActive(false);
        QM1.SetActive(false);
        QM2.SetActive(false);
        QM3.SetActive(false);
        QM4.SetActive(true);
        QM5.SetActive(true);
        QM6.SetActive(true);
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
        AudienceResponseSpeechPro = Card3.transform.GetChild(0).GetChild(8).gameObject;
        AudienceResponseSpeechCon = Card3.transform.GetChild(0).GetChild(9).gameObject;
        CardType = Card3.transform.GetChild(0).GetChild(7).gameObject;
        yield return new WaitForSeconds(0.1f);
        if (CardType.GetComponent<Text>().text == "Argument")
        {
            PlayerSpeech.text = Description.GetComponent<Text>().text;
            DummyCard.active = true;
            DummyCard.GetComponent<Animation>().Play("CardThrow");
            yield return new WaitForSeconds(0.8f);
            OpponentDamaged.Play();
            DummyCard.active = false;
            yield return new WaitForSeconds(0.1f);
            OpponentDamaged.Stop();
            yield return new WaitForSeconds(0.1f);
            if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
            {
                PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePro.GetComponent<Text>().text);
                AudienceSpeechBubble.active = true;
                AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                AudienceSpeech.GetComponent<Text>().color = Color.blue;
            }
            else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
            {
                PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseCon.GetComponent<Text>().text);
                AudienceSpeechBubble.active = true;
                AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                AudienceSpeech.GetComponent<Text>().color = Color.red;
            }
            else
            {
                PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponse.GetComponent<Text>().text);
            }
            ReferencePower = 1;
            ReferencePower2 = 1;
        }
        else if (CardType.GetComponent<Text>().text == "Gesture")
        {
            GestureEffect = Card3.transform.GetChild(0).GetChild(10).gameObject;
            if (GestureEffect.GetComponent<Text>().text == "0")
            {
                AudienceMood = 3;
                PlayerSpeech.text = "I can't believe you would be so heartless";
            }
            else if (GestureEffect.GetComponent<Text>().text == "1")
            {
                AudienceMood = 1;
                PlayerSpeech.text = "To a fair and respectful debate";
            }
            else if (GestureEffect.GetComponent<Text>().text == "2")
            {
                AudienceMood = 5;
                PlayerSpeech.text = "ARE WE ALL GOING TO TAKE THIS?";
            }
            else if (GestureEffect.GetComponent<Text>().text == "3")
            {
                AudienceMood = 2;
                PlayerSpeech.text = "What does it feel like living your life being so wrong?";
            }
            else if (GestureEffect.GetComponent<Text>().text == "4")
            {
                AudienceMood = 4;
                PlayerSpeech.text = "Come on everyone this is something to be passionate about";
            }
            else if (GestureEffect.GetComponent<Text>().text == "5")
            {
                AudienceMood = 3;
                PlayerSpeech.text = "No matter what you say, I won't give up for what I believe in";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "6")
            {
                AudienceMood = 1;
                PlayerSpeech.text = "Well done, you're good at debating. It's not over yet though!";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "7")
            {
                AudienceMood = 5;
                PlayerSpeech.text = "AHHHHHHHHHHHHHHHHHHHHHH!!!";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "8")
            {
                AudienceMood = 2;
                PlayerSpeech.text = "Wow, I'm not good at this am I?";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "9")
            {
                AudienceMood = 4;
                PlayerSpeech.text = "I'll give youy this, you know what you're doing, I'll almost fell bad for you when I beat you at this debate";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            ReferencePower = 1;
            ReferencePower2 = 1;
        }
        else if (CardType.GetComponent<Text>().text == "Reference 1")
        {
            AudienceResponseProPlus = Card3.transform.GetChild(0).GetChild(10).gameObject;
            AudienceResponsePlus = Card3.transform.GetChild(0).GetChild(11).gameObject;
            AudienceResponseConPlus = Card3.transform.GetChild(0).GetChild(12).gameObject;
            AudienceResponseProPlusPlus = Card3.transform.GetChild(0).GetChild(13).gameObject;
            AudienceResponsePlusPlus = Card3.transform.GetChild(0).GetChild(14).gameObject;
            AudienceResponseConPlusPlus = Card3.transform.GetChild(0).GetChild(15).gameObject;
            if (ReferencePower == 1)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePro.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseCon.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponse.GetComponent<Text>().text);
                }
            }
            else if (ReferencePower == 2)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseProPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseConPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePlus.GetComponent<Text>().text);
                }
            }
            else if (ReferencePower == 3)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseProPlusPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseConPlusPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePlusPlus.GetComponent<Text>().text);
                }
            }
            ReferencePower = ReferencePower + 1;
            ReferencePower2 = 1;
        }
        else if (CardType.GetComponent<Text>().text == "Reference 2")
        {
            AudienceResponseProPlus = Card3.transform.GetChild(0).GetChild(10).gameObject;
            AudienceResponsePlus = Card3.transform.GetChild(0).GetChild(11).gameObject;
            AudienceResponseConPlus = Card3.transform.GetChild(0).GetChild(12).gameObject;
            AudienceResponseProPlusPlus = Card3.transform.GetChild(0).GetChild(13).gameObject;
            AudienceResponsePlusPlus = Card3.transform.GetChild(0).GetChild(14).gameObject;
            AudienceResponseConPlusPlus = Card3.transform.GetChild(0).GetChild(15).gameObject;
            if (ReferencePower2 == 1)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePro.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseCon.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponse.GetComponent<Text>().text);
                }
            }
            else if (ReferencePower2 == 2)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseProPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseConPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePlus.GetComponent<Text>().text);
                }
            }
            else if (ReferencePower2 == 3)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseProPlusPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseConPlusPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePlusPlus.GetComponent<Text>().text);
                }
            }
            ReferencePower2 = ReferencePower2 + 1;
            ReferencePower = 1;
        }
        yield return new WaitForSeconds(0.1f);
            CardPosition = CardPosition + 1;
            yield return new WaitForSeconds(0.1f);
            if (CardPosition == 1)
            {
                Card3 = DCard1;
            }
            else if (CardPosition == 2)
            {
                Card3 = DCard2;
            }
            else if (CardPosition == 3)
            {
                Card3 = DCard3;
            }
            else if (CardPosition == 4)
            {
                Card3 = DCard4;
            }
            else if (CardPosition == 5)
            {
                Card3 = DCard5;
            }
            else if (CardPosition == 6)
            {
                Card3 = DCard6;
            }
            else if (CardPosition == 7)
            {
                Card3 = DCard7;
            }
            else if (CardPosition == 8)
            {
                Card3 = DCard8;
            }
            else if (CardPosition == 9)
            {
                Card3 = DCard9;
            }
            else if (CardPosition == 10)
            {
                Card3 = DCard10;
            }
            else if (CardPosition == 11)
            {
                Card3 = DCard11;
            }
            else if (CardPosition == 12)
            {
                Card3 = DCard12;
            }
            else if (CardPosition == 13)
            {
                Card3 = DCard13;
            }
            else if (CardPosition == 14)
            {
                Card3 = DCard14;
            }
            else if (CardPosition == 15)
            {
                Card3 = DCard15;
            }
            else if (CardPosition == 16)
            {
                Card3 = DCard16;
            }
            else if (CardPosition == 17)
            {
                Card3 = DCard17;
            }
            else if (CardPosition == 18)
            {
                Card3 = DCard18;
            }
            else if (CardPosition == 19)
            {
                Card3 = DCard19;
            }
            else if (CardPosition == 20)
            {
                Card3 = DCard20;
            }
            else if (CardPosition == 21)
            {
                Card3 = DCard21;
            }
            else if (CardPosition == 22)
            {
                Card3 = DCard22;
            }
            else if (CardPosition == 23)
            {
                Card3 = DCard23;
            }
        else if (CardPosition == 24)
        {
            Card3 = DCard24;
        }
        else if (CardPosition == 25)
        {
            Card3 = DCard25;
        }
        else if (CardPosition == 26)
        {
            Card3 = DCard26;
        }
        else if (CardPosition == 27)
        {
            Card3 = DCard27;
        }
        else if (CardPosition == 28)
        {
            Card3 = DCard28;
        }
        else if (CardPosition == 29)
        {
            Card3 = DCard29;
        }
        else if (CardPosition == 30)
        {
            Card3 = DCard30;
        }
        else if (CardPosition == 31)
        {
            Card3 = DCard31;
        }
        else if (CardPosition == 32)
        {
            Card3 = DCard32;
        }
        else if (CardPosition == 33)
        {
            Card3 = DCard33;
        }
        else if (CardPosition == 34)
        {
            Card3 = DCard34;
        }
        else if (CardPosition == 35)
        {
            Card3 = DCard35;
        }
        else if (CardPosition == 36)
        {
            Card3 = DCard36;
        }
        else if (CardPosition == 37)
        {
            Card3 = DCard37;
        }
        else if (CardPosition == 38)
        {
            Card3 = DCard38;
        }
        else if (CardPosition == 39)
        {
            Card3 = DCard39;
        }

        yield return new WaitForSeconds(0.1f);
            CardButton3 = (Card3.transform.GetChild(0).gameObject).GetComponent<Button>();
            transform.position = Card1.transform.position = new Vector3(-0.5f, -0.38f, 1);
            transform.position = Card2.transform.position = new Vector3(-0.25f, -0.38f, 1);
            transform.position = Card3.transform.position = new Vector3(-0f, -0.38f, 1);
            transform.position = Card4.transform.position = new Vector3(0.25f, -0.38f, 1);
            transform.position = Card5.transform.position = new Vector3(0.5f, -0.38f, 1);
            CardButton1.onClick.AddListener(Button1Clicked);
            CardButton2.onClick.AddListener(Button2Clicked);
            CardButton3.onClick.AddListener(Button3Clicked);
            CardButton4.onClick.AddListener(Button4Clicked);
            CardButton5.onClick.AddListener(Button5Clicked);
            TalkCheck = 1;
        }
    

    void Button4Clicked()
    {
        MaleVoice2.Play();
        CardButton1.onClick.RemoveListener(Button1Clicked);
        CardButton2.onClick.RemoveListener(Button2Clicked);
        CardButton3.onClick.RemoveListener(Button3Clicked);
        CardButton4.onClick.RemoveListener(Button4Clicked);
        CardButton5.onClick.RemoveListener(Button5Clicked);
        Card4.transform.position = new Vector3(100, 100, 100);
        Deck1.gameObject.SetActive(false);
        SpeechBubble.gameObject.SetActive(true);
        ThoughtBubble.gameObject.SetActive(false);
        PlayerSpotlight.SetActive(true);
        OpponentSpotlight.SetActive(false);
        QM1.SetActive(false);
        QM2.SetActive(false);
        QM3.SetActive(false);
        QM4.SetActive(true);
        QM5.SetActive(true);
        QM6.SetActive(true);
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
        AudienceResponseSpeechPro = Card4.transform.GetChild(0).GetChild(8).gameObject;
        AudienceResponseSpeechCon = Card4.transform.GetChild(0).GetChild(9).gameObject;
        CardType = Card4.transform.GetChild(0).GetChild(7).gameObject;
        yield return new WaitForSeconds(0.1f);
        if (CardType.GetComponent<Text>().text == "Argument")
        {
            PlayerSpeech.text = Description.GetComponent<Text>().text;
            DummyCard.active = true;
            DummyCard.GetComponent<Animation>().Play("CardThrow");
            yield return new WaitForSeconds(0.8f);
            OpponentDamaged.Play();
            DummyCard.active = false;
            yield return new WaitForSeconds(0.1f);
            OpponentDamaged.Stop();
            yield return new WaitForSeconds(0.1f);
            if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
            {
                PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePro.GetComponent<Text>().text);
                AudienceSpeechBubble.active = true;
                AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                AudienceSpeech.GetComponent<Text>().color = Color.blue;
            }
            else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
            {
                PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseCon.GetComponent<Text>().text);
                AudienceSpeechBubble.active = true;
                AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                AudienceSpeech.GetComponent<Text>().color = Color.red;
            }
            else
            {
                PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponse.GetComponent<Text>().text);
            }
            ReferencePower = 1;
            ReferencePower2 = 1;
        }
        else if (CardType.GetComponent<Text>().text == "Gesture")
        {
            GestureEffect = Card4.transform.GetChild(0).GetChild(10).gameObject;
            if (GestureEffect.GetComponent<Text>().text == "0")
            {
                AudienceMood = 3;
                PlayerSpeech.text = "I can't believe you would be so heartless";
            }
            else if (GestureEffect.GetComponent<Text>().text == "1")
            {
                AudienceMood = 1;
                PlayerSpeech.text = "To a fair and respectful debate";
            }
            else if (GestureEffect.GetComponent<Text>().text == "2")
            {
                AudienceMood = 5;
                PlayerSpeech.text = "ARE WE ALL GOING TO TAKE THIS?";
            }
            else if (GestureEffect.GetComponent<Text>().text == "3")
            {
                AudienceMood = 2;
                PlayerSpeech.text = "Can't we settle this over a pint?";
            }
            else if (GestureEffect.GetComponent<Text>().text == "4")
            {
                AudienceMood = 4;
                PlayerSpeech.text = "Come on everyone this is something to be passionate about";
            }
            else if (GestureEffect.GetComponent<Text>().text == "5")
            {
                AudienceMood = 3;
                PlayerSpeech.text = "No matter what you say, I won't give up for what I believe in";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "6")
            {
                AudienceMood = 1;
                PlayerSpeech.text = "Well done, you're good at debating. It's not over yet though!";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "7")
            {
                AudienceMood = 5;
                PlayerSpeech.text = "AHHHHHHHHHHHHHHHHHHHHHH!!!";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "8")
            {
                AudienceMood = 2;
                PlayerSpeech.text = "Wow, I'm not good at this am I?";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "9")
            {
                AudienceMood = 4;
                PlayerSpeech.text = "I'll give youy this, you know what you're doing, I'll almost fell bad for you when I beat you at this debate";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            ReferencePower = 1;
            ReferencePower2 = 1;
        }
        else if (CardType.GetComponent<Text>().text == "Reference 1")
        {
            AudienceResponseProPlus = Card4.transform.GetChild(0).GetChild(10).gameObject;
            AudienceResponsePlus = Card4.transform.GetChild(0).GetChild(11).gameObject;
            AudienceResponseConPlus = Card4.transform.GetChild(0).GetChild(12).gameObject;
            AudienceResponseProPlusPlus = Card4.transform.GetChild(0).GetChild(13).gameObject;
            AudienceResponsePlusPlus = Card4.transform.GetChild(0).GetChild(14).gameObject;
            AudienceResponseConPlusPlus = Card4.transform.GetChild(0).GetChild(15).gameObject;
            if (ReferencePower == 1)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePro.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseCon.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponse.GetComponent<Text>().text);
                }
            }
            else if (ReferencePower == 2)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseProPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseConPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePlus.GetComponent<Text>().text);
                }
            }
            else if (ReferencePower == 3)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseProPlusPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseConPlusPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePlusPlus.GetComponent<Text>().text);
                }
            }
            ReferencePower = ReferencePower + 1;
            ReferencePower2 = 1;
        }
        else if (CardType.GetComponent<Text>().text == "Reference 2")
        {
            AudienceResponseProPlus = Card4.transform.GetChild(0).GetChild(10).gameObject;
            AudienceResponsePlus = Card4.transform.GetChild(0).GetChild(11).gameObject;
            AudienceResponseConPlus = Card4.transform.GetChild(0).GetChild(12).gameObject;
            AudienceResponseProPlusPlus = Card4.transform.GetChild(0).GetChild(13).gameObject;
            AudienceResponsePlusPlus = Card4.transform.GetChild(0).GetChild(14).gameObject;
            AudienceResponseConPlusPlus = Card4.transform.GetChild(0).GetChild(15).gameObject;
            if (ReferencePower2 == 1)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePro.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseCon.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponse.GetComponent<Text>().text);
                }
            }
            else if (ReferencePower2 == 2)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseProPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseConPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePlus.GetComponent<Text>().text);
                }
            }
            else if (ReferencePower2 == 3)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseProPlusPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseConPlusPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePlusPlus.GetComponent<Text>().text);
                }
            }
            ReferencePower2 = ReferencePower2 + 1;
            ReferencePower = 1;
        }
        yield return new WaitForSeconds(0.1f);
            CardPosition = CardPosition + 1;
            yield return new WaitForSeconds(0.1f);
            if (CardPosition == 1)
            {
                Card4 = DCard1;
            }
            else if (CardPosition == 2)
            {
                Card4 = DCard2;
            }
            else if (CardPosition == 3)
            {
                Card4 = DCard3;
            }
            else if (CardPosition == 4)
            {
                Card4 = DCard4;
            }
            else if (CardPosition == 5)
            {
                Card4 = DCard5;
            }
            else if (CardPosition == 6)
            {
                Card4 = DCard6;
            }
            else if (CardPosition == 7)
            {
                Card4 = DCard7;
            }
            else if (CardPosition == 8)
            {
                Card4 = DCard8;
            }
            else if (CardPosition == 9)
            {
                Card4 = DCard9;
            }
            else if (CardPosition == 10)
            {
                Card4 = DCard10;
            }
            else if (CardPosition == 11)
            {
                Card4 = DCard11;
            }
            else if (CardPosition == 12)
            {
                Card4 = DCard12;
            }
            else if (CardPosition == 13)
            {
                Card4 = DCard13;
            }
            else if (CardPosition == 14)
            {
                Card4 = DCard14;
            }
            else if (CardPosition == 15)
            {
                Card4 = DCard15;
            }
            else if (CardPosition == 16)
            {
                Card4 = DCard16;
            }
            else if (CardPosition == 17)
            {
                Card4 = DCard17;
            }
            else if (CardPosition == 18)
            {
                Card4 = DCard18;
            }
            else if (CardPosition == 19)
            {
                Card4 = DCard19;
            }
            else if (CardPosition == 20)
            {
                Card4 = DCard20;
            }
            else if (CardPosition == 21)
            {
                Card4 = DCard21;
            }
            else if (CardPosition == 22)
            {
                Card4 = DCard22;
            }
            else if (CardPosition == 23)
            {
                Card4 = DCard23;
            }
        else if (CardPosition == 24)
        {
            Card4 = DCard24;
        }
        else if (CardPosition == 25)
        {
            Card4 = DCard25;
        }
        else if (CardPosition == 26)
        {
            Card4 = DCard26;
        }
        else if (CardPosition == 27)
        {
            Card4 = DCard27;
        }
        else if (CardPosition == 28)
        {
            Card4 = DCard28;
        }
        else if (CardPosition == 29)
        {
            Card4 = DCard29;
        }
        else if (CardPosition == 30)
        {
            Card4 = DCard30;
        }
        else if (CardPosition == 31)
        {
            Card4 = DCard31;
        }
        else if (CardPosition == 32)
        {
            Card4 = DCard32;
        }
        else if (CardPosition == 33)
        {
            Card4 = DCard33;
        }
        else if (CardPosition == 34)
        {
            Card4 = DCard34;
        }
        else if (CardPosition == 35)
        {
            Card4 = DCard35;
        }
        else if (CardPosition == 36)
        {
            Card4 = DCard36;
        }
        else if (CardPosition == 37)
        {
            Card4 = DCard37;
        }
        else if (CardPosition == 38)
        {
            Card4 = DCard38;
        }
        else if (CardPosition == 39)
        {
            Card4 = DCard39;
        }

        yield return new WaitForSeconds(0.1f);
            CardButton4 = (Card4.transform.GetChild(0).gameObject).GetComponent<Button>();
            transform.position = Card1.transform.position = new Vector3(-0.5f, -0.38f, 1);
            transform.position = Card2.transform.position = new Vector3(-0.25f, -0.38f, 1);
            transform.position = Card3.transform.position = new Vector3(-0f, -0.38f, 1);
            transform.position = Card4.transform.position = new Vector3(0.25f, -0.38f, 1);
            transform.position = Card5.transform.position = new Vector3(0.5f, -0.38f, 1);
            CardButton1.onClick.AddListener(Button1Clicked);
            CardButton2.onClick.AddListener(Button2Clicked);
            CardButton3.onClick.AddListener(Button3Clicked);
            CardButton4.onClick.AddListener(Button4Clicked);
            CardButton5.onClick.AddListener(Button5Clicked);
            TalkCheck = 1;
        
    }

    void Button5Clicked()
    {
        MaleVoice2.Play();
        CardButton1.onClick.RemoveListener(Button1Clicked);
        CardButton2.onClick.RemoveListener(Button2Clicked);
        CardButton3.onClick.RemoveListener(Button3Clicked);
        CardButton4.onClick.RemoveListener(Button4Clicked);
        CardButton5.onClick.RemoveListener(Button5Clicked);
        Card5.transform.position = new Vector3(100, 100, 100);
        Deck1.gameObject.SetActive(false);
        SpeechBubble.gameObject.SetActive(true);
        ThoughtBubble.gameObject.SetActive(false);
        PlayerSpotlight.SetActive(true);
        OpponentSpotlight.SetActive(false);
        QM1.SetActive(false);
        QM2.SetActive(false);
        QM3.SetActive(false);
        QM4.SetActive(true);
        QM5.SetActive(true);
        QM6.SetActive(true);
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
        AudienceResponseSpeechPro = Card5.transform.GetChild(0).GetChild(8).gameObject;
        AudienceResponseSpeechCon = Card5.transform.GetChild(0).GetChild(9).gameObject;
        CardType = Card5.transform.GetChild(0).GetChild(7).gameObject;
        yield return new WaitForSeconds(0.1f);
        if (CardType.GetComponent<Text>().text == "Argument")
        {
            PlayerSpeech.text = Description.GetComponent<Text>().text;
            DummyCard.active = true;
            DummyCard.GetComponent<Animation>().Play("CardThrow");
            yield return new WaitForSeconds(0.8f);
            OpponentDamaged.Play();
            DummyCard.active = false;
            yield return new WaitForSeconds(0.1f);
            OpponentDamaged.Stop();


            yield return new WaitForSeconds(0.1f);
            if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
            {
                PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePro.GetComponent<Text>().text);
                AudienceSpeechBubble.active = true;
                AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                AudienceSpeech.GetComponent<Text>().color = Color.blue;
            }
            else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
            {
                PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseCon.GetComponent<Text>().text);
                AudienceSpeechBubble.active = true;
                AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                AudienceSpeech.GetComponent<Text>().color = Color.red;
            }
            else
            {
                PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponse.GetComponent<Text>().text);
            }
            ReferencePower = 1;
            ReferencePower2 = 1;
        }
        else if (CardType.GetComponent<Text>().text == "Gesture")
        {
            GestureEffect = Card5.transform.GetChild(0).GetChild(10).gameObject;
            if (GestureEffect.GetComponent<Text>().text == "0")
            {
                AudienceMood = 3;
                PlayerSpeech.text = "I can't believe you would be so heartless";
            }
            else if (GestureEffect.GetComponent<Text>().text == "1")
            {
                AudienceMood = 1;
                PlayerSpeech.text = "To a fair and respectful debate";
            }
            else if (GestureEffect.GetComponent<Text>().text == "2")
            {
                AudienceMood = 5;
                PlayerSpeech.text = "ARE WE ALL GOING TO TAKE THIS?";
            }
            else if (GestureEffect.GetComponent<Text>().text == "3")
            {
                AudienceMood = 2;
                PlayerSpeech.text = "Well since we know I'm right how about we end this right now?";
            }
            else if (GestureEffect.GetComponent<Text>().text == "4")
            {
                AudienceMood = 4;
                PlayerSpeech.text = "Come on everyone this is something to be passionate about";
            }
            else if (GestureEffect.GetComponent<Text>().text == "5")
            {
                AudienceMood = 3;
                PlayerSpeech.text = "No matter what you say, I won't give up for what I believe in";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "6")
            {
                AudienceMood = 1;
                PlayerSpeech.text = "Well done, you're good at debating. It's not over yet though!";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "7")
            {
                AudienceMood = 5;
                PlayerSpeech.text = "AHHHHHHHHHHHHHHHHHHHHHH!!!";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "8")
            {
                AudienceMood = 2;
                PlayerSpeech.text = "Wow, I'm not good at this am I?";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "9")
            {
                AudienceMood = 4;
                PlayerSpeech.text = "I'll give youy this, you know what you're doing, I'll almost fell bad for you when I beat you at this debate";
                PlayerAudienceApproval = PlayerAudienceApproval + ((100 - PlayerAudienceApproval) / 10);
            }
            ReferencePower = 1;
            ReferencePower2 = 1;
        }
        else if (CardType.GetComponent<Text>().text == "Reference 1")
        {
            AudienceResponseProPlus = Card5.transform.GetChild(0).GetChild(10).gameObject;
            AudienceResponsePlus = Card5.transform.GetChild(0).GetChild(11).gameObject;
            AudienceResponseConPlus = Card5.transform.GetChild(0).GetChild(12).gameObject;
            AudienceResponseProPlusPlus = Card5.transform.GetChild(0).GetChild(13).gameObject;
            AudienceResponsePlusPlus = Card5.transform.GetChild(0).GetChild(14).gameObject;
            AudienceResponseConPlusPlus = Card5.transform.GetChild(0).GetChild(15).gameObject;
            if (ReferencePower == 1)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePro.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseCon.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponse.GetComponent<Text>().text);
                }
            }
            else if (ReferencePower == 2)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseProPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseConPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePlus.GetComponent<Text>().text);
                }
            }
            else if (ReferencePower == 3)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseProPlusPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseConPlusPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePlusPlus.GetComponent<Text>().text);
                }
            }
            ReferencePower = ReferencePower + 1;
            ReferencePower2 = 1;
        }
        else if (CardType.GetComponent<Text>().text == "Reference 2")
        {
            AudienceResponseProPlus = Card5.transform.GetChild(0).GetChild(10).gameObject;
            AudienceResponsePlus = Card5.transform.GetChild(0).GetChild(11).gameObject;
            AudienceResponseConPlus = Card5.transform.GetChild(0).GetChild(12).gameObject;
            AudienceResponseProPlusPlus = Card5.transform.GetChild(0).GetChild(13).gameObject;
            AudienceResponsePlusPlus = Card5.transform.GetChild(0).GetChild(14).gameObject;
            AudienceResponseConPlusPlus = Card5.transform.GetChild(0).GetChild(15).gameObject;
            if (ReferencePower2 == 1)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePro.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseCon.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponse.GetComponent<Text>().text);
                }
            }
            else if (ReferencePower2 == 2)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseProPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseConPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePlus.GetComponent<Text>().text);
                }
            }
            else if (ReferencePower2 == 3)
            {
                PlayerSpeech.text = Description.GetComponent<Text>().text;
                DummyCard.active = true;
                DummyCard.GetComponent<Animation>().Play("CardThrow");
                yield return new WaitForSeconds(0.8f);
                OpponentDamaged.Play();
                DummyCard.active = false;
                yield return new WaitForSeconds(0.1f);
                OpponentDamaged.Stop();
                yield return new WaitForSeconds(0.1f);
                if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseProPlusPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.blue;
                }
                else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponseConPlusPlus.GetComponent<Text>().text);
                    AudienceSpeechBubble.active = true;
                    AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                    AudienceSpeech.GetComponent<Text>().color = Color.red;
                }
                else
                {
                    PlayerAudienceApproval = PlayerAudienceApproval + int.Parse(AudienceResponsePlusPlus.GetComponent<Text>().text);
                }
            }
            ReferencePower2 = ReferencePower2 + 1;
            ReferencePower = 1;
        }
        yield return new WaitForSeconds(0.1f);
            CardPosition = CardPosition + 1;
            yield return new WaitForSeconds(0.1f);
            if (CardPosition == 1)
            {
                Card5 = DCard1;
            }
            else if (CardPosition == 2)
            {
                Card5 = DCard2;
            }
            else if (CardPosition == 3)
            {
                Card5 = DCard3;
            }
            else if (CardPosition == 4)
            {
                Card5 = DCard4;
            }
            else if (CardPosition == 5)
            {
                Card5 = DCard5;
            }
            else if (CardPosition == 6)
            {
                Card5 = DCard6;
            }
            else if (CardPosition == 7)
            {
                Card5 = DCard7;
            }
            else if (CardPosition == 8)
            {
                Card5 = DCard8;
            }
            else if (CardPosition == 9)
            {
                Card5 = DCard9;
            }
            else if (CardPosition == 10)
            {
                Card5 = DCard10;
            }
            else if (CardPosition == 11)
            {
                Card5 = DCard11;
            }
            else if (CardPosition == 12)
            {
                Card5 = DCard12;
            }
            else if (CardPosition == 13)
            {
                Card5 = DCard13;
            }
            else if (CardPosition == 14)
            {
                Card5 = DCard14;
            }
            else if (CardPosition == 15)
            {
                Card5 = DCard15;
            }
            else if (CardPosition == 16)
            {
                Card5 = DCard16;
            }
            else if (CardPosition == 17)
            {
                Card5 = DCard17;
            }
            else if (CardPosition == 18)
            {
                Card5 = DCard18;
            }
            else if (CardPosition == 19)
            {
                Card5 = DCard19;
            }
            else if (CardPosition == 20)
            {
                Card5 = DCard20;
            }
            else if (CardPosition == 21)
            {
                Card5 = DCard21;
            }
            else if (CardPosition == 22)
            {
                Card5 = DCard22;
            }
            else if (CardPosition == 23)
            {
                Card5 = DCard23;
            }
        else if (CardPosition == 24)
        {
            Card5 = DCard24;
        }
        else if (CardPosition == 25)
        {
            Card5 = DCard25;
        }
        else if (CardPosition == 26)
        {
            Card5 = DCard26;
        }
        else if (CardPosition == 27)
        {
            Card5 = DCard27;
        }
        else if (CardPosition == 28)
        {
            Card5 = DCard28;
        }
        else if (CardPosition == 29)
        {
            Card5 = DCard29;
        }
        else if (CardPosition == 30)
        {
            Card5 = DCard30;
        }
        else if (CardPosition == 31)
        {
            Card5 = DCard31;
        }
        else if (CardPosition == 32)
        {
            Card5 = DCard32;
        }
        else if (CardPosition == 33)
        {
            Card5 = DCard33;
        }
        else if (CardPosition == 34)
        {
            Card5 = DCard34;
        }
        else if (CardPosition == 35)
        {
            Card5 = DCard35;
        }
        else if (CardPosition == 36)
        {
            Card5 = DCard36;
        }
        else if (CardPosition == 37)
        {
            Card5 = DCard37;
        }
        else if (CardPosition == 38)
        {
            Card5 = DCard38;
        }
        else if (CardPosition == 39)
        {
            Card5 = DCard39;
        }

        yield return new WaitForSeconds(0.1f);
            CardButton5 = (Card5.transform.GetChild(0).gameObject).GetComponent<Button>();
            transform.position = Card1.transform.position = new Vector3(-0.5f, -0.38f, 1);
            transform.position = Card2.transform.position = new Vector3(-0.25f, -0.38f, 1);
            transform.position = Card3.transform.position = new Vector3(-0f, -0.38f, 1);
            transform.position = Card4.transform.position = new Vector3(0.25f, -0.38f, 1);
            transform.position = Card5.transform.position = new Vector3(0.5f, -0.38f, 1);
            CardButton1.onClick.AddListener(Button1Clicked);
            CardButton2.onClick.AddListener(Button2Clicked);
            CardButton3.onClick.AddListener(Button3Clicked);
            CardButton4.onClick.AddListener(Button4Clicked);
            CardButton5.onClick.AddListener(Button5Clicked);
            TalkCheck = 1;
        }
    

    IEnumerator OpponentReply()
    {
        OpponentMove = OpponentMove + 1;
        
        // 1 = Serious, 2 = Humourous, 3 = Sad, 4 = Passionate, and 5 = Angry
        yield return new WaitForSeconds(0.1f);
        AudienceSpeechBubble.active = false;
        TalkCheck = 2;
        OpponentSpeechBubble.gameObject.SetActive(true);
        MaleVoice1.Play();
        OpponentDummyCard.active = true;
        OpponentDummyCard.GetComponent<Animation>().Play("OpponentCardThrow");
        
        MaleVoice2.Pause();
        QM1.SetActive(false);
        QM2.SetActive(false);
        QM3.SetActive(false);
        QM4.SetActive(false);
        QM5.SetActive(false);
        QM6.SetActive(false);
        PlayerSpotlight.SetActive(false);
        OpponentSpotlight.SetActive(true);
        SpeechBubble.gameObject.SetActive(false);
        WhichOpponentReply = (Mathf.Round(Random.Range(1, 10)));

        if (OpponentMove == 1)
        {
            OCard = OCard1;
        }
        else if (OpponentMove == 2)
        {
            OCard = OCard2;
        }
        else if (OpponentMove == 3)
        {
            OCard = OCard3;
        }
        else if (OpponentMove == 4)
        {
            OCard = OCard4;
        }
        else if (OpponentMove == 5)
        {
            OCard = OCard5;
        }
        else if (OpponentMove == 6)
        {
            OCard = OCard6;
        }
        else if (OpponentMove == 7)
        {
            OCard = OCard7;
        }
        else if (OpponentMove == 8)
        {
            OCard = OCard8;
        }
        else if (OpponentMove == 9)
        {
            OCard = OCard9;
        }
        else if (OpponentMove == 10)
        {
            OCard = OCard10;
        }
        else if (OpponentMove == 11)
        {
            OCard = OCard11;
        }
        else if (OpponentMove == 12)
        {
            OCard = OCard12;
        }
        else if (OpponentMove == 13)
        {
            OCard = OCard13;
        }
        else if (OpponentMove == 14)
        {
            OCard = OCard14;
        }
        else if (OpponentMove == 15)
        {
            OCard = OCard15;
        }
        else if (OpponentMove == 16)
        {
            OCard = OCard16;
        }
        else if (OpponentMove == 17)
        {
            OCard = OCard17;
        }
        else if (OpponentMove == 18)
        {
            OCard = OCard18;
        }
        else if (OpponentMove == 19)
        {
            OCard = OCard19;
        }
        else if (OpponentMove == 20)
        {
            OCard = OCard20;
        }
        else if (OpponentMove == 21)
        {
            OCard = OCard21;
        }
        else if (OpponentMove == 22)
        {
            OCard = OCard22;
        }
        else if (OpponentMove == 23)
        {
            OCard = OCard23;
        }
        else if (OpponentMove == 24)
        {
            OCard = OCard24;
        }
        else if (OpponentMove == 25)
        {
            OCard = OCard25;
        }
        else if (OpponentMove == 26)
        {
            OCard = OCard26;
        }
        else if (OpponentMove == 27)
        {
            OCard = OCard27;
        }
        else if (OpponentMove == 28)
        {
            OCard = OCard28;
        }
        else if (OpponentMove == 29)
        {
            OCard = OCard29;
        }
        else if (OpponentMove == 30)
        {
            OCard = OCard30;
        }
        else if (OpponentMove == 31)
        {
            OCard = OCard31;
        }
        else if (OpponentMove == 32)
        {
            OCard = OCard32;
        }
        else if (OpponentMove == 33)
        {
            OCard = OCard33;
        }
        else if (OpponentMove == 34)
        {
            OCard = OCard34;
        }
        else if (OpponentMove == 35)
        {
            OCard = OCard35;
        }
        else if (OpponentMove == 36)
        {
            OCard = OCard36;
        }
        else if (OpponentMove == 37)
        {
            OCard = OCard37;
        }
        else if (OpponentMove == 38)
        {
            OCard = OCard38;
        }
        else if (OpponentMove == 39)
        {
            OCard = OCard39;
        }


        Description = OCard.transform.GetChild(0).GetChild(1).gameObject;
        EmotionPro = OCard.transform.GetChild(0).GetChild(5).gameObject;
        EmotionCon = OCard.transform.GetChild(0).GetChild(6).gameObject;
        AudienceResponse = OCard.transform.GetChild(0).GetChild(3).gameObject;
        AudienceResponsePro = OCard.transform.GetChild(0).GetChild(2).gameObject;
        AudienceResponseCon = OCard.transform.GetChild(0).GetChild(4).gameObject;
        AudienceResponseSpeechPro = OCard.transform.GetChild(0).GetChild(8).gameObject;
        AudienceResponseSpeechCon = OCard.transform.GetChild(0).GetChild(9).gameObject;
        CardType = OCard.transform.GetChild(0).GetChild(7).gameObject;
        yield return new WaitForSeconds(0.1f);
        if (CardType.GetComponent<Text>().text == "Argument")
        {
            OpponentSpeech.text = Description.GetComponent<Text>().text;
            OpponentDummyCard.active = true;
            OpponentDummyCard.GetComponent<Animation>().Play("CardThrow");
            yield return new WaitForSeconds(0.8f);
            PlayerDamaged.Play();
            OpponentDummyCard.active = false;
            yield return new WaitForSeconds(0.1f);
            OpponentDamaged.Stop();


            yield return new WaitForSeconds(0.1f);
            if (AudienceMood == int.Parse(EmotionPro.GetComponent<Text>().text))
            {
                PlayerAudienceApproval = PlayerAudienceApproval - int.Parse(AudienceResponsePro.GetComponent<Text>().text);
                AudienceSpeechBubble.active = true;
                AudienceSpeech.text = AudienceResponseSpeechPro.GetComponent<Text>().text;
                AudienceSpeech.GetComponent<Text>().color = Color.blue;
            }
            else if (AudienceMood == int.Parse(EmotionCon.GetComponent<Text>().text))
            {
                PlayerAudienceApproval = PlayerAudienceApproval - int.Parse(AudienceResponseCon.GetComponent<Text>().text);
                AudienceSpeechBubble.active = true;
                AudienceSpeech.text = AudienceResponseSpeechCon.GetComponent<Text>().text;
                AudienceSpeech.GetComponent<Text>().color = Color.red;
            }
            else
            {
                PlayerAudienceApproval = PlayerAudienceApproval - int.Parse(AudienceResponse.GetComponent<Text>().text);
            }
        }
        else if (CardType.GetComponent<Text>().text == "Gesture")
        {
            GestureEffect = OCard.transform.GetChild(0).GetChild(10).gameObject;
            if (GestureEffect.GetComponent<Text>().text == "0")
            {
                AudienceMood = 3;
                OpponentSpeech.text = "I can't believe you would be so heartless";
            }
            else if (GestureEffect.GetComponent<Text>().text == "1")
            {
                AudienceMood = 1;
                OpponentSpeech.text = "To a fair and respectful debate";
            }
            else if (GestureEffect.GetComponent<Text>().text == "2")
            {
                AudienceMood = 5;
                OpponentSpeech.text = "ARE WE ALL GOING TO TAKE THIS?";
            }
            else if (GestureEffect.GetComponent<Text>().text == "3")
            {
                AudienceMood = 2;
                OpponentSpeech.text = "Well since we know I'm right how about we end this right now?";
            }
            else if (GestureEffect.GetComponent<Text>().text == "4")
            {
                AudienceMood = 4;
                OpponentSpeech.text = "Come on everyone this is something to be passionate about";
            }
            else if (GestureEffect.GetComponent<Text>().text == "5")
            {
                AudienceMood = 3;
                OpponentSpeech.text = "No matter what you say, I won't give up for what I believe in";
                PlayerAudienceApproval = PlayerAudienceApproval - ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "6")
            {
                AudienceMood = 1;
                OpponentSpeech.text = "Well done, you're good at debating. It's not over yet though!";
                PlayerAudienceApproval = PlayerAudienceApproval - ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "7")
            {
                AudienceMood = 5;
                OpponentSpeech.text = "AHHHHHHHHHHHHHHHHHHHHHH!!!";
                PlayerAudienceApproval = PlayerAudienceApproval - ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "8")
            {
                AudienceMood = 2;
                OpponentSpeech.text = "Wow, I'm not good at this am I?";
                PlayerAudienceApproval = PlayerAudienceApproval - ((100 - PlayerAudienceApproval) / 10);
            }
            else if (GestureEffect.GetComponent<Text>().text == "9")
            {
                AudienceMood = 4;
                OpponentSpeech.text = "I'll give you this, you know what you're doing, I'll almost fell bad for you when I beat you at this debate";
                PlayerAudienceApproval = PlayerAudienceApproval - ((100 - PlayerAudienceApproval) / 10);
            }
        }
        


        yield return new WaitForSeconds(0.8f);
        PlayerDamaged.Play();
        OpponentDummyCard.active = false;
        yield return new WaitForSeconds(0.1f);
        PlayerDamaged.Stop();
        TalkCheck = 0;

    }

    IEnumerator Final()
    {
        yield return new WaitForSeconds(0.001f);
        PlayerSpeech.text = "";
        OpponentSpeech.text = "";
        MaleVoice1.Pause();
        QM1.SetActive(true);
        QM2.SetActive(true);
        QM3.SetActive(true);
        PlayerSpotlight.SetActive(true);
        OpponentSpotlight.SetActive(false);
        ThoughtBubble.gameObject.SetActive(true);
        OpponentSpeechBubble.gameObject.SetActive(false);
        Deck1.gameObject.SetActive(true);
        TalkCheck = 2;
        AudienceSpeechBubble.active = false;
        AudienceSpeechBubble.transform.position = new Vector3((Random.Range(-18, 18)), (Random.Range(0, 10)), 20);
    }
    
    IEnumerator YouWin()
    {
        yield return new WaitForSeconds(1);
        EndState.text = "YOU WIN";
        yield return new WaitForSeconds(3);
        Application.LoadLevel(0);
    }
    IEnumerator YouLose()
    {
        yield return new WaitForSeconds(1);
        EndState.text = "YOU LOSE";
        yield return new WaitForSeconds(3);
        Application.LoadLevel(0);
    }
}
