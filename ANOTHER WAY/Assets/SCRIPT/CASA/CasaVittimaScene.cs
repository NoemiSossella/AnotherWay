using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CasaVittimaScene : MonoBehaviour
{
    public string sceneToLoad; // Nome della scena da caricare

    private void OnTriggerEnter(Collider other)
    {
        // Controlla se il player ha colliso con l'oggetto
        if (other.CompareTag("Player"))
        {
            LoadScene();
        }
    }

    void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad); // Carica la scena specificata
    }
}



