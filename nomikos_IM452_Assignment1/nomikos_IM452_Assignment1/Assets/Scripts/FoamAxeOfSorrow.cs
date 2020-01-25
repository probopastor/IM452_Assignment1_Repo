/*
* William Nomikos
* FoamAxeOfSorrow.cs
* Assignment #1
* Script handles behavior for the Foam Axe of Sorrow item, including its sound effects, its visual effects, and its damage output.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoamAxeOfSorrow : Weapon, IAttackVisualEffects, IAttackSoundEffects
{
    private float weepTime;
    private bool canAttack;

    public void CreateSound()
    {
        Debug.Log("A sorrowful sound came from the Foam Axe of Sorrow. ");
    }

    public override void DamageTarget(float damageModifier, float damageRate)
    {
        Debug.Log("Target damaged by " + damageModifier + " by the Foam Axe of Sorrow at a rate of " + damageRate + " per second.");
    }

    public void InstantiateHitParticles()
    {
        Debug.Log("Beautiful particles were just created due to the miserable Foam Axe of Sorrow. Where? In your imagination. What type of particles? Literal tears. Tear shaped particles. It's sad. Your axe is sad. ): ");
    }

    public bool IsWeeping()
    {
        if(weepTime > 0)
        {
            canAttack = false;
            Debug.Log("Axe is weeping, " + canAttack + ". ");
            return true;
        }
        else
        {
            canAttack = true;
            Debug.Log("Axe is not weeping, " + canAttack + ". ");
            return false;
        }
    }

    public void SetWeepTime(float newWeepTime)
    {
        Debug.Log("Weep time set to " + newWeepTime + ". ");
        weepTime = newWeepTime;
    }

    public void ShakeScreen()
    {
        Debug.Log("Oh no the screen is shaking due to the Foam Axe of Sorrow. oh no. ");
    }
}
