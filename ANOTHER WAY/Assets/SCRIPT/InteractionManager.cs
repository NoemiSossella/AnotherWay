using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public ItemInteractions ItemLibrary;

    public void CheckItemAndInteraction(string itemToSearch, string interactor){
        if(ItemLibrary != null){
            var slot = ItemLibrary.GetSlotWithItemAndInteractor(itemToSearch, interactor);

            if(slot != null){
                Debug.Log("Interaction exists, result is: "+slot.ResultingItem);
            }
        }
    }
}
