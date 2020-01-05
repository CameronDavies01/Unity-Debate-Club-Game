using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScene : MonoBehaviour
{
    int TalkSequence;
    public Text OpponentSpeech;
    public GameObject OpponentSpeechBubble;
    // Start is called before the first frame update
    void Start()
    {
        TalkSequence = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (TalkSequence == 1)
        {
            OpponentSpeechBubble.SetActive(true);
            OpponentSpeech.text = "Hey, so you wanna join the debate club?";
        }
    }
}
