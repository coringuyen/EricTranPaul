using UnityEngine;
using System.Collections;
using System;

public interface baseClass
{
    int health
    {
        get; set;
    }

    void attack();

    void takeDamage(int damage);

    void specialAbility();

    void createAbility(string ability_name);
}

