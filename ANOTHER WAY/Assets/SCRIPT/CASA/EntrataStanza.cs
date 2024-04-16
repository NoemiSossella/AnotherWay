using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntrataStanza : MonoBehaviour
{
    // Nome della scena da caricare
    public int nomeScenaDaCaricare;
    private bool inside;

    void OnTriggerStay2D(Collider2D coll){
        /*inside = true;
        StartCoroutine("AperturaPorta");        
       */
              if (Input.GetButtonDown("Fire1")) // Tasto sinistro del mouse
        {
            // Carica la nuova scena
            //SceneManager.LoadScene(nomeScenaDaCaricare);
            SceneManager.LoadScene(nomeScenaDaCaricare);
        }
    }

   /* void OnTriggerExit2D(Collider2D coll){
              if (Input.GetButtonDown("Fire1")) // Tasto sinistro del mouse
        {
            // Carica la nuova scena
            //SceneManager.LoadScene(nomeScenaDaCaricare);
            SceneManager.LoadScene(nomeScenaDaCaricare);
        }
    }*/
    /*IEnumerator AperturaPorta(){
        while(inside){
       
        }
        yield return null;
    }*/

    // Metodo chiamato quando il tasto sinistro del mouse viene premuto
    void Update()
    {
       
    }
}
