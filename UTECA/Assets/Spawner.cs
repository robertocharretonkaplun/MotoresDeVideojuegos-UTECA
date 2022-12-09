using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
  public static Spawner instance;
  public GameObject Item;
  public int WaveIndex = 0;
  public float TimeOfWaves = 6.5f;
  public float Timer = 2.5f;
  public Transform[] Points;
  public List<GameObject> Asteroids;
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

    Debug.Log("Amount of Childs: " + transform.childCount);
    Points = new Transform[transform.childCount];

    for (int i = 0; i < Points.Length; i++)
    {
      Points[i] = transform.GetChild(i);
    }
  }
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (WaveIndex != 25)
    {
      if (Timer <= 0.0f)
      {
        // New Wave
        SpawnItem();
        Timer = TimeOfWaves;
      }
    }

    Timer -= Time.deltaTime;
  }

  public IEnumerator Wave()
  {
    yield return new WaitForSeconds(0.8f);
  }

  public void SpawnItem()
  {
    int randomPoint = Random.Range(0, Points.Length);
    var Obj = Instantiate(Item, Points[randomPoint].position, transform.rotation);
  }
}
