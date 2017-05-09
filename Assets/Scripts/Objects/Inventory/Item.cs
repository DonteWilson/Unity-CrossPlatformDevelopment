using UnityEngine;

public abstract class Item : ScriptableObject, IExecutable
{
    public int ID;
    public string Name = "Item";
    public Sprite sprite;

    public abstract void Initialize(GameObject obj);


    public virtual void AddTo(BackPack backpack)
    {
    }

    public virtual void RemoveFrom(BackPack backpack)
    {
    }

    public abstract void Execute();
}

public abstract class Supplies : Item
{
    
}

public abstract class Weapon : Supplies
{
    public int Damage;
}

public abstract class Armor : Supplies
{
    public int ArmorRating;
}

public abstract class Medic: Supplies
{
    public int Healing;
}

#region Interfaces

public interface IShootable
{
    void Shoot(GameObject Target);
}

public interface ISwingable
{
    void Swing();
}

#endregion