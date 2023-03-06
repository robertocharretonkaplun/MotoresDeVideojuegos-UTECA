using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Diamante : BloqueBase
{
  private void Start()
  {
    GetComponent<SpriteRenderer>().sprite = textura;
  }

  public override void destruir()
  {
    soltarItem();
    soltarXP();
    sonidoRoptura();
  }

  public void soltarItem()
  {

  }
  public void soltarXP()
  {

  }
  public void sonidoRoptura()
  {

  }

}
