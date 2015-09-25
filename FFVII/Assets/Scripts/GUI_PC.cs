using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUI_PC : MonoBehaviour
{
    public Slider player1Health;
    //public Slider player2Health;
    //public Slider player3Health;

    public Button buttonAttack;
    public Button buttonSpecialAttack;
    //public Button buttonEndTurn;

    //float health = 100;

    void Start()
    {
        player1Health.value = GetComponent<Tran_Unit>().target_heath;
    }

    //player2Health.value = unit_health;
    //player3Health.value = unit_health;

    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.A))
    //    {
    //        health_Bar1();
    //    }

    //    if (Input.GetKeyDown(KeyCode.S))
    //    {
    //        health_Bar2();
    //    }

    //    if (Input.GetKeyDown(KeyCode.D))
    //    {
    //        health_Bar3();
    //    }
    //}

    //public void health_Bar1()
    //{
    //    health = player1Health.value;
    //    health -= 1;
    //    player1Health.value = health;
    //    print("IS IT WORKING?!?");
    //}

    //public void health_Bar2()
    //{
    //    health = player2Health.value;
    //    health -= 1;
    //    player2Health.value = health;
    //    print("IS IT WORKING?!? NOW?!?? I'm super CUTE!");
    //}

    //public void health_Bar3()
    //{
    //    health = player3Health.value;
    //    health -= 1;
    //    player3Health.value = health;
    //    print("IS IT WORKING?!? YET?");
    //}

    //public void attackSomeBody()
    //{
    //    if (buttonAttack)
    //    {
    //        print("Attack somebody!");
    //    }
    //}

    //public void special_Attack()
    //{
    //    if (buttonSpecialAttack)
    //    {
    //        print("Charging up my SUPER POWER!");
    //    }
    //}

    //public void turn()
    //{
    //    if (buttonEndTurn)
    //    {
    //        print("Ending my turn");
    //    }
    //}
}
