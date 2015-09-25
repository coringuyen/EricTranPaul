using UnityEngine;
using System.Collections;
using System;

public class Tran_Unit : MonoBehaviour, baseClass
{
    public int unit_health;
    public int attack_damages;
    public int ability_damages;

    void Start()
    {
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

    public void ability()
    {
        takeDamage(ability_damages);
    }

    public void attack()
    {
        takeDamage(attack_damages);
    }

    public void takeDamage(int damage)
    {
        health -= damage;
    }
}
