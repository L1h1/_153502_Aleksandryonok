using Task;
//demo
University uni = new University("БГУИР", 13465);
Console.WriteLine(uni.PrintInfo());
Console.WriteLine(uni.PrintName());

uni.FailCount=14000;
Console.WriteLine("Динамика несдавших лабы "+uni.GetFailDynamic());
uni.ShowRepairStatus();//не скрыт

Console.WriteLine("-----------------");
School sch = new School("GYMN2",40,1400);
Console.WriteLine(sch.PrintInfo());
Console.WriteLine(sch.PrintName());
sch.ShowRepairStatus();//скрыт здесь