using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueBox;
    public TextMeshProUGUI dialogueText;

    Queue<string> lines = new Queue<string>();

    public void StartDialogue(SO_Dialogue dialogue)
    {
        dialogueBox.SetActive(true);
        lines.Clear();

        foreach (string line in dialogue.dialogueLines)
        {
            lines.Enqueue(line);
        }

        DisplayNextLine();
    }

    public void DisplayNextLine()
    {
        if (lines.Count == 0)
        {
            dialogueBox.SetActive(false);
            return;
        }

        dialogueText.text = lines.Dequeue();
    }
}
