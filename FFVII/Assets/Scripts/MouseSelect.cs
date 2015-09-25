using UnityEngine;
using System.Collections;

public class MouseSelect : MonoBehaviour
{
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
                    TurnManager.currentTurn.GetComponent<Tran_Unit>();
                }
            }
        }
    }
}
