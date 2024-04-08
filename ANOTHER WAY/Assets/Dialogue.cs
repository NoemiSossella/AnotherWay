using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public GameObject[] characterCanvases;
    public Button[] characterButtons;

    void Start()
    {
        for (int i = 0; i < characterButtons.Length; i++)
        {
            int characterIndex = i; // Salva l'indice del personaggio per l'evento
            characterButtons[i].onClick.AddListener(() => OpenCharacterDialog(characterIndex));
        }
    }

    void OpenCharacterDialog(int characterIndex)
    {
        // Disattiva tutti i canvas dei personaggi
        foreach (GameObject canvas in characterCanvases)
        {
            canvas.SetActive(false);
        }

        // Attiva il canvas del personaggio selezionato
        characterCanvases[characterIndex].SetActive(true);
    }
}

