using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class EventHandle : MonoBehaviour
{
  public TMP_Text Notification;
  public int counter = 0;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }


  public void GivePoint()
  {
    UpdateEvents();
    counter++;
    Debug.Log("New Point");
  }


  public void UpdateEvents()
  {
    Debug.Log("UpdateEvents");
    

    if (counter == 15)
    {
      Notification.text = "New Goal 15 XP";
      Debug.Log("New Goal 15 XP - Event Reached");
      PlayerPrefs.SetString("Logros", Notification.text);
    }


    if (counter == 25)
    {
      Notification.text = "New Goal 25 XP";
      Debug.Log("New Goal 25 XP - Event Reached");
      PlayerPrefs.SetString("Logros", Notification.text);
    }


  }

  public void LeaveGame()
  {
    PlayerPrefs.SetInt("Points", counter);
    SceneManager.LoadScene("Leaderboard");
  }
}
