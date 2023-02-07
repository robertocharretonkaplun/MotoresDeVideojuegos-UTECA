using UnityEngine;

public class SpellCard : Card
{
  public int healing;

  public void Heal()
  {
    Debug.Log(name + " heals for " + healing + " Point.");
  }
}
