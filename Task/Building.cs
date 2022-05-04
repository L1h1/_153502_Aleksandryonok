namespace Task;

public abstract class EducationEstablishment
{
    public EducationEstablishment(string name)
    {
        Name = name;
        Console.WriteLine("сработал родительский класс для "+Name);
    }

    public virtual string PrintName()
    {
        return "учреждение образования "+Name;
    }

    public abstract string PrintInfo();

    public void Change(string newName)
    {
        Name = newName;
    }
    

    public void ShowRepairStatus()
    {
        string str = "здание сейчас " + (IsOnRepair ? "на ремонте" : "не на ремонте");
        Console.WriteLine(str);
    }
    public string Name {get;set;}
    public bool IsOnRepair { get; set; } = false;
}

public sealed class University : EducationEstablishment
{
    
    public University(string name, int num):base(name)
    {
        failCount = num;
    }

    public override string PrintInfo()
    {
        return "число несдавших лабы: "+FailCount;
    }

    public override string PrintName()
    {
        return"Добро пожаловать в университет " + Name+"!";
    }



    public int GetFailDynamic()
    {
        return failCount - PreFailCount;
    }



    private int failCount;
    public int FailCount
    {
        get { return failCount; }
        set
        {
            if (failCount < value)
            {
                PreFailCount = failCount;
                failCount = value;
            }
            
        }
    }

    public int PreFailCount{ get; set; }
}


public class School : EducationEstablishment
{
    public School(string name, int numOfClasses, int studCount):base(name)
    {
        ClassNum = numOfClasses;
        Count = studCount;
    }

    public override string PrintInfo()
    {
        return"В школе обучается "+Count+" учеников в "+ClassNum+" дисциплинах.";
    }
    

    public void Change(string name, int counter, int num)
    {
        base.Change(name);
        Count = counter;
        ClassNum = num;
    }

    public new void ShowRepairStatus()
    {
        Console.WriteLine("Меня не ремонтировали десять тысяч лет!");
    }
    public int Count { get; set; }
    public int ClassNum{ get; set; }
}