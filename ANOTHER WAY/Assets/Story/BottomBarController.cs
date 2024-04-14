using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class BottomBarController : MonoBehaviour
{
    public TextMeshProUGUI barText;
    public TextMeshProUGUI personNameText;

    private int sentenceIndex = -1;
    private StoryScene currentScene; 
    private DialogueState state = DialogueState.COMPLETED;

    private enum DialogueState
    {
        PLAYING,
        COMPLETED
    }

    public void PlayScene(StoryScene scene) 
    {
        currentScene = scene;
        sentenceIndex = -1; 
        PlayNextSentence();
    }
    public void SetScene(StoryScene scene){
        currentScene = scene;
        sentenceIndex = -1; 
    }

    // Start is called before the first frame update
    public void PlayNextSentence()
    {
        sentenceIndex++;
        var currentSentence = currentScene.sentences[sentenceIndex];
        StartCoroutine(TypeText(currentSentence));
    }

    public bool IsCompleted()
    {
        return state == DialogueState.COMPLETED;
    }

    public bool IsLastSentence()
     {
        return sentenceIndex + 1 == currentScene.sentences.Count;
    }

    private IEnumerator TypeText(Sentence sentence)
    {
        barText.text = "";
        state = DialogueState.PLAYING;
        int wordIndex = 0;
        personNameText.text = sentence.speaker.speakerName;

        while (state != DialogueState.COMPLETED)
        {
            barText.text += sentence.text[wordIndex];
            yield return new WaitForSeconds(0.05f);

            wordIndex++;
            if(wordIndex == sentence.text.Length) 
            {
                state = DialogueState.COMPLETED;
            }
        }
    }

}
