using UnityEngine;

public class CustomObject : ScriptableObject
{
   public int ID;
   public string Name;
     
public CustomObject (int id ,string name){
        ID = id;
        Name = name;
}
public override string ToString()
    {
        return $"Object [ID: {ID}, Name: {Name}]";
    }
    //   public override bool Equals(object obj)
    //     {
    //         if (obj is CustomObject other)
    //         {
    //             return ID == other.ID && Name == other.Name;
    //         }
    //         return false;
    //     }
        public static bool operator ==(CustomObject obj1, CustomObject obj2)
        {
            if (obj1 is null && obj2 is null) return true;
            if (obj1 is null || obj2 is null) return false;
            return obj1.ID == obj2.ID && obj1.Name == obj2.Name;
        }
        public static bool operator !=(CustomObject obj1, CustomObject obj2)
        {
            return !(obj1 == obj2);
        }
}
