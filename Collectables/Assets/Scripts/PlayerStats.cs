using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //added this line



namespace HB { 
public class PlayerStats : MonoBehaviour
{
        public int healthLevel = 30;
        public int maxHealth;
        public int currentHealth;

        public HealthBar barOfHealth;
        private Animator animator;
       

    // Start is called before the first frame update
    void Start()
    {
            animator = GetComponent<Animator>();
            maxHealth = SetMaxHealthFromHealthLevel();
            currentHealth = maxHealth; //start game with max health
            barOfHealth.SetMaxHealth(maxHealth);//set value of health bar max value to the max health of the player 

    }
        //used to determine max health of the player 
    public int SetMaxHealthFromHealthLevel()
        {
            maxHealth = healthLevel + 20; //arbitrary value 
            return maxHealth;

        }

        //when method called deduct damage from currrent health of the player 
        public void TakeDamage(int damage)
        {
            currentHealth = currentHealth - damage;

            barOfHealth.SetCurrentHealth(currentHealth);//after player receives damage current health changes passing current health onto healthBar updating it 
            
        }
        public void ReactionAnimator()
        {
            if (currentHealth != maxHealth) {

                animator.SetBool("IsReacting", true);
            }
            else
            {
                animator.SetBool("IsReacting", false);
            }

            
        }
}//end class

}//end namespace
