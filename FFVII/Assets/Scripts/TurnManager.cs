using UnityEngine;
using System.Collections.Generic;

public class TurnManager : MonoBehaviour
{
    public int turnNumber;
    public List<GameObject> players;
    public GameObject currentTurn;

    public void NextTurn()
    {
        currentTurn.GetComponent<FSM_Unit>().ToEnd();
        turnNumber++;
        if (turnNumber >= players.Count)
        {
            turnNumber = 0;
        }
        currentTurn = players[turnNumber];
        currentTurn.GetComponent<FSM_Unit>().ToActive();
    }
    
    public void Attack()
    {
        currentTurn.GetComponent<FSM_Unit>().ToAttack();
    }

    public void Special()
    {
        currentTurn.GetComponent<FSM_Unit>().ToSpecial();
    }

    void Awake()
    {
        currentTurn = players[0];
        currentTurn.GetComponent<FSM_Unit>().ToActive();
    }

    void Update()
    {
        
    }
}