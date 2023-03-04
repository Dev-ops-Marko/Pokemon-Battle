using System;

class Pokemon {
    public string Name;
    public int HP;
    public int Attack;
    public int Defense;

    public Pokemon(string name, int hp, int attack, int defense) {
        Name = name;
        HP = hp;
        Attack = attack;
        Defense = defense;
    }

    public void Scratch(Pokemon enemy) {
        int damage = Attack - enemy.Defense * 5;
        enemy.HP = enemy.HP - damage;
        Console.WriteLine("{0} used Scratch! He dealed {1} damage to {2}", Name, damage, enemy.Name);
    }
}