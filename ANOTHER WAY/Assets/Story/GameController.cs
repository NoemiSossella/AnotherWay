using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public StoryScene currentScene;
    public BottomBarController bottomBar;

    private bool canStart = false;
    public bool CanStart { get { return canStart; } set { canStart = value; } }


    // Update is called once per frame
    public void SetStoria(){
        if(bottomBar == null){return;}
            bottomBar.SetScene(currentScene);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if(CanStart){
                if(bottomBar.IsCompleted())
                {
                    if(bottomBar.IsLastSentence())
                    {
                        if(currentScene.nextScene != null){
                            currentScene = currentScene.nextScene;
                            bottomBar.PlayScene(currentScene);
                        }
                        else{
                            bottomBar.transform.parent.gameObject.SetActive(false);
                            CanStart = false;
                            Debug.Log("HO FINITO MAMMA");
                        }
                    } else {
                        bottomBar.PlayNextSentence();
                    }
                    
                }
            }
        }
    }
}
