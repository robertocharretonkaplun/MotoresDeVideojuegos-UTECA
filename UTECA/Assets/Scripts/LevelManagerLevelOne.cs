using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManagerLevelOne : MonoBehaviour
{
  public static LevelManagerLevelOne instance;

  public GameObject MenuContainer;
  public GameObject PauseMenu;
  public GameObject ConfigMenu;


  [Header("LEVEL ATTRIBUTES")]
  public TMP_Text ScorePlayer;
  public TMP_Text ScoreEnemy;
  // Level Configu
  [Header("LEVEL CONFIGURATIONS")]
  public bool EneableDamage = true;
  public bool EneableEnemyAttacks = true;
  [Header("GAME ATTRIBUTES")]
  public int PlayerScoreValue = 0;
  public int EnemyScoreValue = 0;
  // Start is called before the first frame update
  void Awake()
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

  private void Start()
  {
    ScorePlayer.text = "-";
    ScoreEnemy.text = "-";
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKey(KeyCode.Escape))
    {
      MenuContainer.SetActive(true);
    }
  }

  public void EnableConfigMenu()
  {
    PauseMenu.SetActive(false);
    ConfigMenu.SetActive(true);
  }

  public void DisableConfigMenu()
  {
    PauseMenu.SetActive(true);
    ConfigMenu.SetActive(false);
  }

  public void UpdateScore()
  {
    ScorePlayer.text = PlayerScoreValue.ToString();
    ScoreEnemy.text = EnemyScoreValue.ToString();
  }

  public void CloseGame()
  {
    Application.Quit();
  }
}
