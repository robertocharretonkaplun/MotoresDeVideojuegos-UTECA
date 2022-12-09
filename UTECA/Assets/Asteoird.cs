using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteoird : MonoBehaviour
{
  public GameObject asteriod;
  public List<Transform> SpawnPoints;


  public int health = 1;
  public bool IsDead = false;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (health <= 0)
    {
      DestroyObject();
    }
  }

  public void DestroyObject()
  {
    if (IsDead)
    {
      AudioManager.instance.SetAudioClipSoundtrack(AudioClips_Soundtrack.SONG_1);
      return;
    }
    IsDead = true;
    Destroy(gameObject);
    foreach (var Position in SpawnPoints)
    {
      float Scale = Random.Range(.5f, 3);
      asteriod.transform.localScale = new Vector2(Scale, Scale);
      var newObj = Instantiate(asteriod, Position.position, Quaternion.identity);
      Spawner.instance.Asteroids.Add(newObj);
      //newObj.GetComponent<ParticleSystem>().Play();
    }
  }

}
