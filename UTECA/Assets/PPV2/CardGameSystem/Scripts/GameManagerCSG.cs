using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerCSG : MonoBehaviour
{
  public static GameManagerCSG instance;
  public List<Card> PlayerDeck;
  public List<Card> EnemyDeck;

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
  }

  void Start()
  {
    // Inicializar el mazo del jugador
    PlayerDeck = new List<Card>();
    foreach (Card card in PlayerDeck)
    {
      PlayerDeck.Add(card);
    }

    // Inicializar el mazo del enemigo
    EnemyDeck = new List<Card>();
    foreach (Card card in EnemyDeck)
    {
      EnemyDeck.Add(card);
    }
  }

  public void PlayCard(Card card)
  {
    if (card.type == "Monster")
    {
      MonsterCard monster = (MonsterCard)card;
      monster.Attack();
    }
    else if(card.type == "Spell")
    {
      SpellCard spell = (SpellCard)card;
      spell.Heal();
    }
  }
}
