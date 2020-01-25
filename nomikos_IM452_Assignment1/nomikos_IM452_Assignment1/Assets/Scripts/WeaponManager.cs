﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public List<Weapon> weaponsList = new List<Weapon>();
    public List<IAttackVisualEffects> visualEffectsList = new List<IAttackVisualEffects>();

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Testing sword and axe object functionality: ");

        Debug.Log("----------------------------------------------");

        //Test of all functions of Sword of Many Swords item.
        SwordOfManySwords firstSword = new SwordOfManySwords();
        firstSword.SetName("swordy");
        firstSword.GetName();

        firstSword.SetDamage(1f);
        firstSword.GetDamage();

        firstSword.SetDamageRate(2f);
        firstSword.GetDamageRate();

        firstSword.SetSwordMultiplicationAmount(2);

        firstSword.InstantiateHitParticles();
        firstSword.CreateSound();
        firstSword.ScreenShake();

        firstSword.DamageTarget(2, 2);


        //Test of all functions of Foam Axe of Sorrow item.
        FoamAxeOfSorrow firstAxe = new FoamAxeOfSorrow();
        firstAxe.SetName("axy");
        firstAxe.GetName();

        firstAxe.SetDamage(1f);
        firstAxe.GetDamage();

        firstAxe.SetDamageRate(2f);
        firstAxe.GetDamageRate();

        firstAxe.SetWeepTime(2f);
        firstAxe.IsWeeping();

        firstAxe.SetWeepTime(0f);
        firstAxe.IsWeeping();

        firstAxe.InstantiateHitParticles();
        firstAxe.CreateSound();
        firstAxe.ScreenShake();

        firstAxe.DamageTarget(2, 2);

        Debug.Log("----------------------------------------------");

        //Creates 2 Sword of Many Sword objects.
        SwordOfManySwords firstSwordPart2 = new SwordOfManySwords();
        SwordOfManySwords secondSwordPart2 = new SwordOfManySwords();

        //Creates 2 Foam Axe of Sorrow objects.
        FoamAxeOfSorrow firstAxePart2 = new FoamAxeOfSorrow();
        FoamAxeOfSorrow secondAxePart2 = new FoamAxeOfSorrow();

        //Add weapons to Weapon list
        weaponsList.Add(firstSwordPart2);
        weaponsList.Add(secondSwordPart2);
        weaponsList.Add(firstAxePart2);
        weaponsList.Add(secondAxePart2);

        //Add weapons to Visual Effects List
        visualEffectsList.Add(firstSwordPart2);
        visualEffectsList.Add(secondSwordPart2);
        visualEffectsList.Add(firstAxePart2);
        visualEffectsList.Add(secondAxePart2);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach(Weapon weapon in weaponsList)
            {
                weapon.DamageTarget(1f, 2f);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (IAttackVisualEffects weaponEffect in visualEffectsList)
            {
                weaponEffect.InstantiateHitParticles();
            }
        }
    }
}
