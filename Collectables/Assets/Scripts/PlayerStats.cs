using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace HB { 
public class PlayerStats : MonoBehaviour
{
        public int healthLevel = 20;
        public int maxHealth;
        public int currentHealth;

        public HealthBar barOfHealth;


    // Start is called before the first frame update
    void Start()
    {
            maxHealth = SetMaxHealthFromHealthLevel();
            currentHealth = maxHealth; //start game with max health
            barOfHealth.SetMaxHealth(maxHealth);//set value of health bar max value to the max health of the player 

    }
        //used to determine max health of the player 
    public int SetMaxHealthFromHealthLevel()
        {
            maxHealth = healthLevel * 20; //arbitrary value 
            return maxHealth;

        }

        //when method called deduct damage from currrent health of the player 
        public void TakeDamage(int damage)
        {
            currentHealth = currentHealth - damage;

            barOfHealth.SetCurrentHealth(currentHealth);//after player receives damage current health changes passing current health onto healthBar updating it 
        }
}//end class

}//end namespace
