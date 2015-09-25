using UnityEngine;
using System.Collections.Generic;

public class FSM_Unit : MonoBehaviour
{
    public enum STATE
    {
        INIT,
        IDLE,
        ACTIVE,
        ATTACK,
        SPECIAL,
        END,
    }

    public FSM<STATE> _fsm = new FSM<STATE>();
    
    void Awake()
    {
        _fsm.AddState(STATE.INIT);
        _fsm.AddState(STATE.IDLE);
        _fsm.AddState(STATE.ACTIVE);
        _fsm.AddState(STATE.ATTACK);
        _fsm.AddState(STATE.SPECIAL);
        _fsm.AddState(STATE.END);

        _fsm.AddTransition(STATE.INIT, STATE.IDLE);
        _fsm.AddTransition(STATE.IDLE, STATE.ACTIVE);
        _fsm.AddTransition(STATE.ACTIVE, STATE.ATTACK);
        _fsm.AddTransition(STATE.ACTIVE, STATE.SPECIAL);
        _fsm.AddTransition(STATE.ACTIVE, STATE.END);
        _fsm.AddTransition(STATE.ATTACK, STATE.END);
        _fsm.AddTransition(STATE.SPECIAL, STATE.END);
        _fsm.AddTransition(STATE.END, STATE.IDLE);

        _fsm.currentState = STATE.INIT;
        ToIdle();
    }

    public void ToIdle()
    {
        _fsm.Transition(STATE.IDLE);
    }

    public void ToActive()
    {
        _fsm.Transition(STATE.ACTIVE);
    }

    public void ToEnd()
    {
        _fsm.Transition(STATE.END);
        ToIdle();
    }
}