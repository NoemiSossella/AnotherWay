using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Inventario/Item", fileName = "Inventario/Item")]
public class Item : ScriptableObject
{
   public string nome;
   [TextArea]
   public string descrizione;
   public Sprite iconaInventario;
}
