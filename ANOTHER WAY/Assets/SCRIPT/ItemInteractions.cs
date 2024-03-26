using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/ItemInteractions", fileName = "ItemInteractions", order = 1)]
public class ItemInteractions : ScriptableObject
{
  public List<ItemSlot> Items;

  public List<ItemSlot> GetSlotsWithItem(string itemToSearch){
    List<ItemSlot> result = new List<ItemSlot>();

    foreach(var item in Items){
        if(item.Item == itemToSearch){
            result.Add(item);
        }
    }

    return result;
  }

  public ItemSlot GetSlotWithItemAndInteractor(string itemToSearch, string interactor){
    List<ItemSlot> result = new List<ItemSlot>();

    foreach(var item in Items){
        if(item.Item == itemToSearch && item.InteractWith == interactor){
            return item;
        }
    }

    return null;
  }
}

[System.Serializable]
public class ItemSlot{
    public string Item;
    public string InteractWith;

    public string ResultingItem;
}