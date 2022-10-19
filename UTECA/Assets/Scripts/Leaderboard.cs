using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Leaderboard : MonoBehaviour
{
  public int Points = 0;
  public string logros;

  public TMP_Text PointsText;
  public TMP_Text LogrosText;
  // Start is called before the first frame update
  void Start()
  {
    Points = PlayerPrefs.GetInt("Points");
    logros = PlayerPrefs.GetString("Logros");
    PointsText.text = Points.ToString();
    LogrosText.text = logros;
  }

  // Update is called once per frame
  void Update()
  {

  }
}
