using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    // How much to damage or "Hurt" the player. negative value means "Heal"
    void Hurt(float amount);
}
