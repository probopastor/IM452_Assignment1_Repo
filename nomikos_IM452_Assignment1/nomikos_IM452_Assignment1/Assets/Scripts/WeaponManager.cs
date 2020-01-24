using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
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

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
