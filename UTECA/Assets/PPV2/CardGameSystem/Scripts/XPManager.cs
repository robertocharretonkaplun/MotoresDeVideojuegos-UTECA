using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPManager : MonoBehaviour
{
  public static XPManager instance;
  public int playerXP;
  public int level;

  private void Awake()
  {
    if (instance != null)
    {
      return;
    }
    else
    {
      instance = this;
    }
  }

  void CheckLevelUp()
  {
    if (playerXP >= 100 * level)
    {
      level++;
      Debug.Log("Player leveled up " + level);

      // Agregar logica para desbloquear nuevas cartas o mejorar las existentes
    }
  }

  public void EarnXP(int amount)
  {
    playerXP += amount;
    CheckLevelUp();
  }
}
