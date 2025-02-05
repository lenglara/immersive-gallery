using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private LeftHeadAnimator leftHeadAnimator;
    [SerializeField] private RightHeadAnimator rightHeadAnimator;

    [SerializeField] private GameObject dialogueBoxLeft;
    [SerializeField] private GameObject dialogueBoxRight;

    [SerializeField] private AudioSource audioSource;

    public TextMeshProUGUI dialogueTextLeft;
    public TextMeshProUGUI dialogueTextRight;

    private Queue<(string name, string sentence, AudioClip clip)> sentences;

    private void Start()
    {
        leftHeadAnimator.ToggleTalking(false);
        rightHeadAnimator.ToggleTalking(false);
        dialogueBoxLeft.GameObject().SetActive(false);
        dialogueBoxRight.GameObject().SetActive(false);
    }

    public void StartDialogue(Dialogue dialogue)
    {
        sentences = new Queue<(string name, string sentence, AudioClip clip)>();

        foreach (DialogueEntry entry in dialogue.dialogueEntries)
        {
            sentences.Enqueue((entry.name, entry.sentence, entry.audioClip));
        }


        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        var entry = sentences.Dequeue();
        
        if (entry.clip != null)
        {
            audioSource.PlayOneShot(entry.clip);
        }
        
        if (entry.name == "LeftHead")
        {
            Debug.Log("LeftHeads turn to talk");
            // Aktualisieren des Textes in der Dialogbox
            dialogueTextLeft.text = entry.sentence;
            
            // Deaktivieren der Animation und der Dialogbox des rechten Kopfes
            dialogueBoxRight.GameObject().SetActive(false);
            rightHeadAnimator.ToggleTalking(false);
            
            // Aktivieren der Animation und der Dialogbox des linken Kopfes
            leftHeadAnimator.ToggleTalking(true);
            dialogueBoxLeft.GameObject().SetActive(true);
        }
        else
        {
            // Aktualisieren des Textes in der Dialogbox
            dialogueTextRight.text = entry.sentence;
            
            // Deaktivieren der Animation und der Dialogbox des linken Kopfes
            dialogueBoxLeft.GameObject().SetActive(false);
            leftHeadAnimator.ToggleTalking(false);
            
            // Aktivieren der Animation und der Dialogbox des rechten Kopfes
            rightHeadAnimator.ToggleTalking(true);
            dialogueBoxRight.GameObject().SetActive(true);
        }
    }

    public void EndDialogue()
    {
        dialogueBoxRight.GameObject().SetActive(false);
        dialogueBoxLeft.GameObject().SetActive(false);
        
        rightHeadAnimator.ToggleTalking(false);
        leftHeadAnimator.ToggleTalking(false);
    }
}
