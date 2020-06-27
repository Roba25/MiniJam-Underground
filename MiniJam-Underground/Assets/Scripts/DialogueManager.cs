using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
[SerializeField]
TextMeshProUGUI dialogueText;
[SerializeField]
GameObject dialoguePanel;


public void TriggerDialogue(string text)
{
dialogueText.text = text;
dialoguePanel.SetActive(true);
Invoke("ResetDialogue", 5f);
}
public void ResetDialogue()
{
dialogueText.text = null;
dialoguePanel.SetActive(false);
}


}
