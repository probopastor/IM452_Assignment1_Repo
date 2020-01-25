/*
* William Nomikos
* BlunderfulMace.cs
* Assignment #1
* Script handles behavior for the BlunderfulMace item, including its sound effects, its visual effects, and its damage output.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlunderfulMace : Weapon, IAttackSoundEffects, IAttackVisualEffects
{
    public void CreateSound()
    {
        Debug.Log("The sound of the mace breaking due to your pathetic mistake echoes across the room. ");
    }

    public override void DamageTarget(float damageModifier, float damageRate)
    {
        Debug.Log("Target damaged by " + damageModifier + " by the Blunderful Mace at a rate of " + damageRate + " per second.");
    }

    public void InstantiateHitParticles()
    {
        Debug.Log("Ugly particles were created when the Blunderful Mace struck its target. You feel bad about this for some reason. ");
    }

    public void ShakeScreen()
    {
        Debug.Log("Oh no the screen is shaking due to the Blunderful Mace. This also shakes the game's world, resulting in two buildings collapsing. " +
            "There were two casualties.");
    }
}
