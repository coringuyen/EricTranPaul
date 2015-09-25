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

    void displayHealth(int damage, int health)
    {
        player1Health.value = health;
    }

}
