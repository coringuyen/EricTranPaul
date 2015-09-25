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

    void Awake()
    {
        currentTurn = players[0];
        currentTurn.GetComponent<FSM_Unit>().ToActive();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            NextTurn();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentTurn.transform.position += currentTurn.transform.forward;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentTurn.transform.position -= currentTurn.transform.forward;
        }
    }
}