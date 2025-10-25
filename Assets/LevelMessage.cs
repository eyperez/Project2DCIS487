using UnityEngine;
using TMPro;

public class LevelMessage : MonoBehaviour
{

    public TextMeshProUGUI dialogueText;
    public Canvas dialogueCanvas;

    public void ShowMessage(string message, float duration = 5f)
    {
        dialogueText.text = message;
        dialogueCanvas.enabled = true;
        CancelInvoke(nameof(HideMessage));
        Invoke(nameof(HideMessage), duration);
    }

    public void HideMessage()
    {
        dialogueCanvas.enabled=false;
    }


}
