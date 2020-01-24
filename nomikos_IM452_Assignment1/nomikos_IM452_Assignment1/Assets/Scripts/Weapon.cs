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
        return name;
    }

    public void SetName(string newName)
    {
        name = newName;
    }

    public float GetDamage()
    {
        return damage;
    }

    public void SetDamage(float newDamage)
    {
        damage = newDamage;
    }

    public float GetDamageRate()
    {
        return rateOfDamage;
    }

    public void SetDamageRate(float newDamageRate)
    {
        rateOfDamage = newDamageRate;
    }

}
