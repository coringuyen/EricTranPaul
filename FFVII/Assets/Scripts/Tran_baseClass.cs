using UnityEngine;
using System.Collections;
using System;

public interface baseClass
{
    int health
    {
        get; set;
    }

    void attack(GameObject target);

    void takeDamage(int damage);

    void specialAbility(GameObject target);

    void createAbility(string ability_name);

    
}

