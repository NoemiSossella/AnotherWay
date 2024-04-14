using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CharacterDialogue : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
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

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("click on "+name);
       if(eventData.button == PointerEventData.InputButton.Left)
       {
            GameController controller = GetComponent<GameController>();
            if (controller != null)
            {
                controller.SetStoria();
                if(controller.bottomBar != null){
                    controller.bottomBar.transform.parent.gameObject.SetActive(true);
                    controller.CanStart = true;
                }
            }
       }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }
}

