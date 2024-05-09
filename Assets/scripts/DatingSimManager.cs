using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DatingSimManager : MonoBehaviour
{
    public Text dialogueText;
    public Text characterNameText;
    public Button[] choiceButtons;


    private int affectionlevel = 0;
    private int currentDialogueIndex = 0;


    private Dialogue currentDialogue;
    private Character currentCharacter;


   private void Start()
    {
        // Initialize starting dialogue and character
        LoadCharacter("CharacterName");


        LoadDialogue("StartingDialogue");
            DisplayDialogue();
    }
    private void LoadCharacter(string characterName)
    {
        // Load character data from a scriptable onject or other data source
        // For simplicity, we'll use a placeholder Character class
            currentCharacter= new
            Character(characterName);
    }
   private void LoadDialogue(string dialogueName)
    {
        // Load dialogue data from a scriptable object or other data source
        // For simplicity, we'll use a placeholder Dialogue class
            currentDialogue= new
            Dialogue(dialogueName);
    }
    private void DisplayDialogue()
    {
        dialogueText.text= currentDialogue.dialogueLines[current-DialogueIndex];
            characterNameText.text = currentCharacter.characterName;
            // Enable choice buttons if there are choicers aviable
            for (int i = 0; i < choiceButtons.Length; i++)
            {


                choiceButtons[i].gameObject.SetActive(currentDialogue.choices.Length > i);
                if(currentDialogue.choices.Length > i);
            }
    }
    choiceButtons[i].GetComponentInChildren<Text>().text = currentDialogue.choices[i];








    public void ChooseOption(int choiceIndex)
    {
    // Handle player's choice
    // For simplicity, just move to the next dialogue index
    currentDialogueIndex++;


    // Update affection level based on players choice
    affectionlevel += currentDialogue.affectionModifiers[choiceIndex];


    // Load next dialogue


    LoadDialogue(currentDialogue.nextDialogue[choiceIndex]);


    // Display next dialogue
    DisplayDialogue();
    }
}
[System.Serializeable]
public class Character
{
    public string[] dialogueLines;
    public string[] choices;
    public string[] nextDialogue;
    public int[] affectionModifiers;


    public Dialogue(string dialogueName)
    {
        // Load dialogue data from a scriptable object or other data source
        // For simplicity, we'll hardcode the data here
        dialogueLines = new string[]
        {"Hello there!", "How are you?"};
        choices = new string[]
        {"Good", "Bad"};
        nextDialogue = new string[]
        {"GoodResponse", "BadResponse"};
        affectionModifiers = new int []
        { 1,-1 };
    }
}    

