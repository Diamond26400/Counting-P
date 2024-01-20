using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MailManager : MonoBehaviour
{
    public HermonyData harmonyManager;
    public TextMeshPro messageText;
     private string[] positiveMessages = { "Lovely garden!", "Beautiful arrangement!", "Harmony at its best!" }
    // Start is called before the first frame update
   public void RecieveMessage()
   {
        // Get a random positive message
        string message = GetRandomPositiveMessage();

        // Display the message in the UI
        DisplayMessage(message);

        // Award additional harmony points
        harmonyManager.AddHarmonyPoints(5);
   }
   private string GetRandomPositiveMessage()
    {
        // Get a random index for the positiveMessages array
        int randomIndex = Random.Range(0, positiveMessages.Length);

        // Return the random positive message
        return positiveMessages[randomIndex];
    }
 private void DisplayMessage(string message)
    {
        // Display the message in the UI (you can customize this based on your UI setup)
        if (messageText != null)
        {
            messageText.text = message;
        }
}
}