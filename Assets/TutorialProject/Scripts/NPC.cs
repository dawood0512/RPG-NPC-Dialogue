using UnityEngine;

public class NPC : MonoBehaviour
{

    public SO_Dialogue dialogue;
    public DialogueManager dialogueManager;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            dialogueManager.StartDialogue(dialogue);
        }
    }
}
