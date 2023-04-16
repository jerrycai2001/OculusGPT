using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatGPT35Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var convo = ChatGPTConversation.Start(this); // start a conversation
        convo.Say("Hello ChatGPT"); // say hello
        comes.Say("Teach me how to win at cornhole");        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
