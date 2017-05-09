using UnityEngine;

public abstract class Item : ScriptableObject, IExecutable
{
    public int ID;
    public string Name = "Item";
    public Sprite sprite;
    protected GameObject _owner;
    public abstract void Initialize(GameObject obj);


    public virtual void AddTo(BackPack backpack)
    {
    }

    public virtual void RemoveFrom(BackPack backpack)
    {
    }

    public abstract void Execute();
}
public abstract class Equipment : Item
{

}
public abstract class Potion : Item , IConsumable
{
    public abstract void Consume(GameObject owner);
}

public abstract class Weapon : Equipment
{
    public int Damage;
}

public abstract class Armor : Equipment
{
    public int ArmorRating;
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