/*
* William Nomikos
* SwordOfManySwords.cs
* Assignment #1
* Script handles behavior for the Sword of Many Swords item, including its sound effects, its visual effects, and its damage output.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordOfManySwords : Weapon, IAttackVisualEffects, IAttackSoundEffects
{
    private int swordMultiplicationAmount;

    public void CreateSound()
    {
        Debug.Log("The sword did not simply make one clink sound when it hit. Oh no... it made many sword clink sounds when it hit. Wow. ");
    }
    public override void DamageTarget(float damageModifier, float damageRate)
    {
        Debug.Log("Target damaged by " + damageModifier + "at a rate of " + damageRate + " per second.");
    }

    public void InstantiateHitParticles()
    {
        Debug.Log("Beautiful particles were just created due to the epic Sword of Many Swords. Where? In your imagination. ");
    }

    public void ScreenShake()
    {
        Debug.Log("Oh no the screen is shaking due to the Sword of Many Swords oh no. ");
    }

    public void SetSwordMultiplicationAmount(int newMultiplicationAmount)
    {
        swordMultiplicationAmount = newMultiplicationAmount;
    }

}
