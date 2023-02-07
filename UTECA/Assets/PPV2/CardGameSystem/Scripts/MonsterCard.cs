using UnityEngine;

/*
 Crear una clase derivada para cada tipo de carta distinto.
 */

public class MonsterCard : Card
{
  public int attack;
  public int defense;

  public void Attack()
  {
    Debug.Log(name + " attacks with " + attack + " points of damage.");
  }
  
  public void Defense()
  {
    Debug.Log(name + " defense with " + defense + " points of defense.");
  }

}
