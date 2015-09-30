using UnityEngine;
using System.Collections;

public class MouseSelect : MonoBehaviour
{
    public TurnManager t;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                if(hit.transform.gameObject.GetComponent<Tran_Unit>())
                {
                    if(t.currentTurn.GetComponent<FSM_Unit>()._fsm.currentState == FSM_Unit.STATE.ATTACK)
                    {
                        t.currentTurn.GetComponent<Tran_Unit>().attack(hit.transform.gameObject);
                        t.NextTurn();
                    }

                    if (t.currentTurn.GetComponent<FSM_Unit>()._fsm.currentState == FSM_Unit.STATE.SPECIAL)
                    {
                        t.currentTurn.GetComponent<Tran_Unit>().specialAbility(hit.transform.gameObject);
                        t.NextTurn();
                    }
                }
            }
        }
    }
}
