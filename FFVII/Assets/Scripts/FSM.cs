using UnityEngine;
using System.Collections.Generic;

public class FSM<T>
{
    private List<T> _stateList = new List<T>();
    private List<string> _validTransistions = new List<string>();

    private T cState;

    public T currentState
    {
        get
        {
            return cState;
        }
        set
        {
            cState = value;
        }
    }
    //add states to the fsm
    public void AddState(T state)
    {
        _stateList.Add(state);
    }

    public void AddTransition(T from, T to)
    {
        string transition = from.ToString() + "->" + to.ToString();
        foreach (string s in _validTransistions)
        {
            if (s == transition)
            {
                return;
            }
        }
        _validTransistions.Add(transition);
    }

    public bool CheckTransition(T from, T to)
    {
        string transition = from.ToString() + "->" + to.ToString();
        foreach (string s in _validTransistions)
        {
            if (s == transition)
            {
                return true;
            }
        }
        //Debug.Log("ERROR, INVALID TRANSITION " + from.ToString() + "->" + to.ToString());
        //Debug.Log("CURRENT STATE: " + from.ToString());
        return false;
    }

    public bool Transition(T to)
    {
        if(CheckTransition(currentState, to))
        {
            currentState = to;
            //Debug.Log("NEW STATE: " + currentState.ToString());
            return true;
        }
        else
        {
            return false;
        }

    }
}