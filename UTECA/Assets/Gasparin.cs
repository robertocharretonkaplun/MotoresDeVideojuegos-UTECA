using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LEVEL
{
  LEVEL_1,
  LEVEL_2,
  LEVEL_3,
  LEVEL_4,
  LEVEL_5,
}

public class Gasparin : MonoBehaviour
{
  public int level = 10;
  public LEVEL levelenum;
  public int health = 0;
  public P2LevelManager manager;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  public void UpgrateLevel()
  {
    if (level == 0)
    {
      level = 10;
      manager.score++;
    }
    level--;
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.CompareTag("Fantasma"))
    {
      var fantasma = collision.gameObject.GetComponent<Gasparin>();
      if (fantasma.levelenum == levelenum)
      {
        // Disable the Sprite Renderer
        gameObject.SetActive(false);
        collision.gameObject.SetActive(false);
        // Combinar y crear un nuevo fantasma
        var newFantasma = Instantiate(new GameObject(), transform.position, Quaternion.identity);
        // Destruir a el objeto colisionado y a este objeto
        Destroy(collision.gameObject);
        Destroy(this);
      }
    }
  }
}
