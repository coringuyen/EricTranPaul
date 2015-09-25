using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUI_PC : MonoBehaviour
{
    public Slider player1Health;
    public Slider player2Health;
    public Slider player3Health;

    public Button attack;
    public Button specialAttack;
    public Button endTurn;

    float health = 100;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            health_Bar();
        }
    }

    public void health_Bar()
    {
        health = player1Health.value;
        health -= 1;
        player1Health.value = health;
        print("IS IT WORKING?!?");
    }

    public void attackSomeBody()
    {
        if (attack)
        {
            print("Attack somebody!");
        }
    }

    public void special_Attack()
    {
        if (specialAttack)
        {
            print("Charging up my SUPER POWER!");
        }
    }

    public void turn()
    {
        if (endTurn)
        {
            print("Ending my turn");
        }
    }
}
