using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogueEntry
{
    public string name;
    
    [TextArea(2, 10)]
    public string sentence;

    public AudioClip audioClip;
}

[System.Serializable]
public class Dialogue
{
    public List<DialogueEntry> dialogueEntries = new List<DialogueEntry>();
}
