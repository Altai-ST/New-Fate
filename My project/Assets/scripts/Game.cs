using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FateFramework;

public class Game : MonoBehaviour
{
    public Match Match {get; set;}
    void Start()
    {
        var assasinStats = new Stats()
        {
            Armor = 1,
            Damage = 6,
            Hp = 30,
        };

        var paladinStats = new Stats()
        {
            Armor = 1,
            Damage = 2,
            Hp = 30,
        };

        Match = new Match();

        Match.Opponent = new Player(paladinStats.Clone(), Weapon.Shield, Weapon.Shield);
        Match.Proponent = new Player(assasinStats.Clone(), Weapon.Sword, Weapon.Sword);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
