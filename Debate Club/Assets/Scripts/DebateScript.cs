using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DebateScript : MonoBehaviour
{
    // This details your current audience approval
    public int PlayerAudienceApproval = 1000;
    // This details the current audience approval of your opponent
    public int OpponentAudienceApproval = 1000;
    // This represents the audiences current mood 1 = Serious, 2 = Humourous, 3 = Sad, 4 = Passionate, and 5 = Angry
    public int AudienceMood = 1;
    // This represents the players speech
    public Text PlayerSpeech; 
    // This represents the thought bubble
    public Image ThoughtBubble;
    // This is an empty string that will be filled with a random phrase to start a sentence with
    public string RandomConversationStarter;
    // The deck for those arguing against the death penalty
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
    void Deck001_C1_Selected()
    {
        StartCoroutine(UI_Timer());
        float RandomConversationStarterSelect;
        RandomConversationStarterSelect = (Mathf.Ceil(Random.Range(1, 5)));
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
            OpponentAudienceApproval = OpponentAudienceApproval - 40;
        }
        else
        {
            OpponentAudienceApproval = OpponentAudienceApproval - 20;
        }
            


        PlayerSpeech.text = (RandomConversationStarter + "everyone has a right to life; we have no right to take away somebodies’ life").ToString();
        AudienceMood = 4;
        
    }
    // A timer which makes the UI reappear after an action has taken place after a specific amount of time
    IEnumerator UI_Timer()
    {
        yield return new WaitForSeconds(2);
        ThoughtBubble.gameObject.SetActive(true);
    }
}
