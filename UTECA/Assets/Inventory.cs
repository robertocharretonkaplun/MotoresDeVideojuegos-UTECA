using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum Inventory_Items
{
  NONE,
  SWORD,
  AXE,
  SHIELD,
  HELMET,
}

public class Inventory : MonoBehaviour
{
  public List<Inventory_Items> InventoryList;
  public List<ITEM> Items;
  // Start is called before the first frame update
  void Start()
  {
    GameObject obj = new GameObject();
    obj.AddComponent<ITEM>();
    ITEM I = obj.GetComponent<ITEM>();
    I.ItemType = Inventory_Items.HELMET;
    I.name = "Helmet";
    I.value = 5;
    I.price = 100;
    I.Description = "This is a magic Helmet used by Sebas.";

    Items.Add(I);

    obj.transform.parent = transform;

    foreach (ITEM i in Items)
    {
      if (i.ItemType == Inventory_Items.HELMET)
      {
        Debug.Log("El Jugador tiene un " + i.name);
      }
    }
  }

  // Update is called once per frame
  void Update()
  {
    
  }
}
