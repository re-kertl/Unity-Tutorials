using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class AddHealthEffect : UsableItem.UsageEffect    // UsableItem.UsageEffect: this is a class written for this Creator Kit, which controls everything related to in-game items.
{
    public int healthValue = 15; 
    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(healthValue);
        return true;
    }
}
