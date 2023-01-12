using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persona : MonoBehaviour
{
  protected string Nombre = "Dummy";
  protected int Edad;
  protected int ID;
  protected float Ahorro;
  // Constructor vacio
  public Persona()
  {
   
  }

  // Constructor por parametros 
  public Persona(string nombre, int edad)
  {
    Nombre = nombre;
    Edad = edad;
  }

  /// <summary>
  /// Esta funcion esta encargada de asgniar un nombre al objeto
  /// </summary>
  /// <param name="_name"> Este parametro esta encargado de recibir un datos de tipo
  /// string que sea para el nombre.</param>
  public void SetName(string _name)
  {
    Nombre = _name;
  }

  public string GetName()
  {
    return Nombre;
  }

  public virtual void GetInfo()
  {
    Debug.Log("Nombre: " + Nombre);
    Debug.Log("ID: " + ID);
  }

  public virtual void SetAhorro(float ahorro)
  {
    Ahorro += ahorro;
    Debug.Log("Se agrego al ahorro la cantidad de: " + ahorro);
    Debug.Log("Cantidad Total de Ahorro: " + Ahorro);
  }

  private void Start()
  {
   Debug.Log("Nombre del objeto: " + GetName());
  }
}
