using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DebateScript : MonoBehaviour
{
    // This details your current audience approval
    public int PlayerAudienceApproval = 50;
    // This represents the audiences current mood 1 = Serious, 2 = Humourous, 3 = Sad, 4 = Passionate, and 5 = Angry
    public int AudienceMood = 1;
    // This represents the players speech
    public Text PlayerSpeech; 
    // This represents the thought bubble
    public Image ThoughtBubble;
    // This is an empty string that will be filled with a random phrase to start a sentence with
    public string RandomConversationStarter;

    // The deck for those arguing for the legalisation of weed
    public Image Deck001_C1;
    public Button Deck001_A1;
    void Start()
    {
        // Checks to see if any of the cards have been selected for use
        Deck001_A1.onClick.AddListener(Deck001_C1_Selected);
    }

    void Update()
    {
    }
        // If Deck 001 Card 1 is selected its effects will activate
        void Deck001_C1_Selected() {
        StartCoroutine(UI_Timer());
        float RandomConversationStarterSelect;
        RandomConversationStarterSelect = (Mathf.Ceil(Random.Range(1, 5)));
        // Selects a random piece of text to put in front of your argument to make it fell more organic
        if (RandomConversationStarterSelect == 1)
        {
            RandomConversationStarter = ("Any moral person would agree that ");
        }
        if (RandomConversationStarterSelect == 2)
        {
            RandomConversationStarter = ("What about the concept that ");
        }
        if (RandomConversationStarterSelect == 3)
        {
            RandomConversationStarter = ("I would say that ");
        }
        if (RandomConversationStarterSelect == 4)
        {
            RandomConversationStarter = ("What about the argument that ");
        }
        if (RandomConversationStarterSelect == 5)
        {
            RandomConversationStarter = ("Well, ");
        }
        // Turns off the thought bubble
        ThoughtBubble.gameObject.SetActive(false);
        // Turns off the current card
        Deck001_C1.gameObject.SetActive(false);
        Deck001_A1.gameObject.SetActive(false);
        if (AudienceMood == 4)
        {
            PlayerAudienceApproval = PlayerAudienceApproval + 2;
        }
        else if (AudienceMood == 1)
        {
        }
        else
        {
            PlayerAudienceApproval = PlayerAudienceApproval + 1;
        }
        PlayerSpeech.text = (RandomConversationStarter + "whether weed is dangerous or not it shouldn’t matter. It’s your body you should be allowed to do what you want with it." + PlayerAudienceApproval).ToString();
    }
    // A timer which makes the UI reappear after an action has taken place after a specific amount of time
    IEnumerator UI_Timer()
    {
        yield return new WaitForSeconds(2);
        ThoughtBubble.gameObject.SetActive(true);
    }
}
