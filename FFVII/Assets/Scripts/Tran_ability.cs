using UnityEngine;
using System.Collections;

public class Tran_ability : MonoBehaviour
{
    string name_of_ability;
    int damages;

	void creatAbility(string ability_name, Color a_color)
    {
        name_of_ability = ability_name;
        damages = Random.Range(20, 50);
        gameObject.GetComponent<Renderer>().material.color = a_color;
    }
    
}
