using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardUIManager : MonoBehaviour
{
  public List<Card> deck;
  public GameObject cardPrefab;
  public Transform cardParent;
  void DisplayCards()
  {
    foreach (Card card  in deck)
    {
      GameObject newCard = Instantiate(cardPrefab, cardParent);
    }
  }

  public void PlayCard(Card card)
  {
    // Llamar al metodo del GameManager que maneja la logica de la carta
    GameManagerCSG.instance.PlayCard(card);
    // Logica para ganar experiencia
    XPManager.instance.EarnXP(card.value);
    // Actualizar la interfaz del usuario
    DisplayCards();
  }

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }
}
