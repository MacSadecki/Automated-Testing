using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class damage_calculator
{
    [Test]
    public void sets_damage_to_half_with_50_percent_mitigation()
    {
        // ACT
        int finalDamage = DamageCalculator.CalculateDamage(10, 0.5f);

        // ASSERT
        Assert.AreEqual(5, finalDamage);  
    }

    [Test]
    public void calculates_3_damage_from_10_with_70_percent_mitigation()
    {
        // ACT
        int finalDamage = DamageCalculator.CalculateDamage(10, 0.7f);

        // ASSERT
        Assert.AreEqual(3, finalDamage);  
    }
}
