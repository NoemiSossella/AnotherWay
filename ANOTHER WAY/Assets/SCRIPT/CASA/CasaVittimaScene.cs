using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CasaVittimaScene : MonoBehaviour
{
    public string sceneToLoad; // Nome della scena da caricare

    void OnMouseDown()
    {
        if (gameObject.CompareTag("CasaVittima")) // Controlla se l'oggetto è CasaVittima
        {
            LoadScene();
        }
    }

    void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad); // Carica la scena specificata
    }
}
