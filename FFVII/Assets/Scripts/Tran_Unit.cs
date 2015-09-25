using UnityEngine;
using System.Collections;

public class Tran_Unit : MonoBehaviour, baseClass
{
    public Color m_color;
    public int target_heath;
    public int unit_health;
    public int attack_damages;
    public int ability_damages;
    string name_of_ability;

    void Start()
    {
        createAbility("slapping");
        Debug.Log(name_of_ability);
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
        target.GetComponent<Tran_Unit>().takeDamage(ability_damages);
        gameObject.GetComponent<Renderer>().material.color = m_color;
    }

    public void attack(GameObject target)
    {
        target.GetComponent<Tran_Unit>().takeDamage(attack_damages);
    }

    public void takeDamage(int damage)
    {
        health -= damage;
    }

    public void createAbility(string ability_name)
    {
        name_of_ability = ability_name;
        ability_damages = Random.Range(20, 50);
    }
}
