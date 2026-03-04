using System;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    [Header("Dialogues (looping)")]
    public List<SO_Dialogue> dialogues = new List<SO_Dialogue>();
    public DialogueManager dialogueManager;
    private int index = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Talk();
        }
    }

    public void Talk()
    {
        if (dialogues == null || dialogues.Count == 0)
        {
            Debug.LogWarning("No dialogues assigned to NPC.");
            return;
        }

        if (dialogueManager == null)
        {
            Debug.LogError("NPC has no DialogueManager assigned.");
            return;
        }

        dialogueManager.StartDialogue(dialogues[index]);
        index = (index + 1) % dialogues.Count;
    }
}
