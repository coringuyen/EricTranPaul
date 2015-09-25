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

    public void specialAbility()
    {
        takeDamage(ability_damages);
        gameObject.GetComponent<Renderer>().material.color = m_color;
    }

    public void attack()
    {
        takeDamage(attack_damages);
    }

    public void takeDamage(int damage)
    {
        target_heath -= damage;
    }

    public void createAbility(string ability_name)
    {
        name_of_ability = ability_name;
        ability_damages = Random.Range(20, 50);
    }
}
