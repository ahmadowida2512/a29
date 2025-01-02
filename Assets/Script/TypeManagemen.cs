using UnityEngine;

public class TypeManagemen : MonoBehaviour
{
    public class Animal
{
    // Default method for animal sound
    public virtual void MakeSound()
    {
        Debug.Log("Animal sound.");
    }

    // Method for animal movement
    public void Move()
    {
        Debug.Log("Animal's movements.");
    }
}

public class Cat : Animal,ICanFight
{
    
    public override void MakeSound()
    {
        Debug.Log("Meow!");
    }

    
    public new void Move()
    {
        Debug.Log("Cat runs fast.");
    }

    
    public void Attack()
    {
        Debug.Log("Cat attacks with claws!");
    }
}

       void Start()
    {
        Animal animalRef = new Cat();
        animalRef.MakeSound(); 
        animalRef.Move();      
         Cat catRef = animalRef as Cat;
        if (catRef != null)
        {
            catRef.MakeSound(); 
            catRef.Move();      

        }
         if (catRef is ICanFight)
        {
            ICanFight fighter = catRef;
            fighter.Attack(); 
        }
         ICanFight warrior = new Warrior();
        if (warrior is Warrior)
        {
            warrior.Attack(); 
        }
    }

    }
public interface ICanFight
{
    void Attack();
}

public class Warrior : ICanFight
{
    // Implement the Attack method
    public void Attack()
    {
        Debug.Log("Warrior attacks with sword!");
    }
}
