/*
* William Nomikos
* Weapon.cs
* Assignment #1
* Abstract weapon class is superclass for all weapon types to inherit from. Includes getter and setter functions
* for each weapon's name, damage, and rate of damage.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Weapon
{
    protected string name;
    protected float damage;
    protected float rateOfDamage;

    public abstract void DamageTarget(float damageModifier, float damageRate);

    public string GetName()
    {
        Debug.Log("Weapon name is " + name + ". ");
        return name;
    }

    public void SetName(string newName)
    {
        Debug.Log("Weapon name set to " + newName + ". ");
        name = newName;
    }

    public float GetDamage()
    {
        Debug.Log(name + " damage = " + damage);
        return damage;
    }

    public void SetDamage(float newDamage)
    {
        Debug.Log("Damage on " + name + " set to " + newDamage + ". ");
        damage = newDamage;
    }

    public float GetDamageRate()
    {
        Debug.Log(name + " Rate Of Damage = " + rateOfDamage);
        return rateOfDamage;
    }

    public void SetDamageRate(float newDamageRate)
    {
        Debug.Log("Damage rate on " + name + " set to " + newDamageRate + ". ");
        rateOfDamage = newDamageRate;
    }

}
