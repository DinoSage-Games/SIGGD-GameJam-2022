using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldStat : MonoBehaviour
{
    [SerializeField] int shields;

    public void Hurt(int amount)
    {
        shields -= amount;
    }

    public float getShields()
    {
        return shields;
    }

    public int playerShield = 2;
    public ShieldManager shieldManager;
    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Awake()
    {
        shieldManager = player.GetComponent<ShieldManager>();
    }

    private void Start()
    {
        updateShieldUI();
    }
    /*public void startingShield(int startShield)
    {
        playerShield = startShield;
    }*/
    public void decreaseShield()
    {
        playerShield--;
    }

    public int getPlayerShield()
    {
        return playerShield;
    }

    public void updateShieldUI()
    {
        shieldManager.updateShield(playerShield);
    }
}
