using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class P2LevelManager : MonoBehaviour
{
  public int score = 0;
  public TMP_Text scoreTxt;
  // Start is called before the first frame update
  void Start()
  {
    score = 0;
    scoreTxt.text = "Score: " + score.ToString();
  }

  // Update is called once per frame
  void Update()
  {
    scoreTxt.text = "Score: " + score.ToString();

  }

  public void ResetScore()
  {
    score = 0;
  }

  public void RestarLevel()
  {
    SceneManager.LoadScene("EjemplosP2");
  }
}
