using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SwordOfManySwords firstSword = new SwordOfManySwords();

        firstSword.SetDamage(1f);
        firstSword.GetDamage();

        firstSword.SetDamageRate(2f);
        firstSword.GetDamageRate();

        firstSword.SetName("swordy");
        firstSword.GetName();

        firstSword.SetSwordMultiplicationAmount(2);

        firstSword.CreateSound();
        firstSword.DamageTarget(2, 2);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
