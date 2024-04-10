using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public GameObject[] slots; // Array di GameObject per rappresentare gli slot dell'inventario
    private GameObject currentItem; // Elemento attualmente selezionato

    void Start()
    {
        // Inizializza l'inventario con gli slot vuoti
        slots = new GameObject[4];
    }

    void Update()
    {
        // Esempio di input per selezionare un elemento dell'inventario
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SelectItem(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SelectItem(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SelectItem(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SelectItem(3);
        }
    }

    void SelectItem(int slotIndex)
    {
        // Deseleziona l'elemento attualmente selezionato se presente
        if (currentItem != null)
        {
            currentItem.SetActive(false);
        }

        // Seleziona il nuovo elemento dall'inventario
        currentItem = slots[slotIndex];

        // Mostra l'elemento selezionato
        if (currentItem != null)
        {
            currentItem.SetActive(true);
        }
    }
}
