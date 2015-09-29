using UnityEngine;
using System.Collections;

public class Tran_Unit : MonoBehaviour, baseClass
{
    public Color m_color; // change color when Unit use special ability
    public int unit_health;
    public int attack_damages;
    public int ability_damages;

    public string name_of_ability; 

    void Start()
    {
        createAbility();
        unit_health = health;
    }

    public int health
    {
        get
        {
            return unit_health;
        }

        set
        {
            unit_health = value;
        }
    }

    public void specialAbility(GameObject target)
    {
        // take target health away depend on however much special ability damage is
        target.GetComponent<Tran_Unit>().takeDamage(ability_damages);
        gameObject.GetComponent<Renderer>().material.color = m_color; // change color
        Debug.Log(name_of_ability); // print out to console the name of the special ability
    }

    public void attack(GameObject target)
    {
        // take target health away depend on however much attack damage is
        target.GetComponent<Tran_Unit>().takeDamage(attack_damages);
    }

    // take away health by subtracting from damage 
    public void takeDamage(int damage) 
    {
        health -= damage;
    }

    // generate a random number for special ability damage
    public void createAbility()
    {
        ability_damages = Random.Range(20, 50);
    }
}
