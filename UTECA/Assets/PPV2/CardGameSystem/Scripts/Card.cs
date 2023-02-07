using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
  Crear una clase base "Card" que contenga las propiedades basicas de todas las 
  cartas, como el nombre, el valor, el tipo etc....
 */

public class Card
{
  public string name;
  public int value;
  public string type; // Un enum
  public Sprite image;

  public void DisplayCard()
  {
    Debug.Log("Name: " + name + "Value: " + value + "Type: " + type);
  }
}
