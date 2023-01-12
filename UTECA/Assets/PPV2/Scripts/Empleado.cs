using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empleado : Persona
{
  public float MontoDeTransferencia = 500;
  public bool TieneNuevaComision = false;
  // Explicar Pipeline de Unity
  public override void GetInfo()
  {
    Nombre = "Roberto";
    ID = 12345;
    base.GetInfo();
    Debug.Log("El empleado tiene un monto de transferencia de: " + MontoDeTransferencia);
  }

  public override void SetAhorro(float ahorro)
  {
    base.SetAhorro(ahorro);
  }

  public void NuevaComision()
  {
    if (TieneNuevaComision)
    {
      float comision = MontoDeTransferencia * 3.5f / 100;
      SetAhorro(comision);
      TieneNuevaComision = false;
    }
  }

  // Start is called before the first frame update
  void Start()
  {
    GetInfo();
  }

  private void Update()
  {
    NuevaComision();
  }
}
