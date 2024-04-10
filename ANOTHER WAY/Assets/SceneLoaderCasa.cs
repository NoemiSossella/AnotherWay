using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderCasa : MonoBehaviour
{
    public string sceneToLoad; // Nome della scena da caricare

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && gameObject.CompareTag("CasaVittima")) // Controlla se il player collide con l'oggetto CasaVittima
        {
            LoadScene();
        }
    }

    void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad); // Carica la scena specificata
    }
}

