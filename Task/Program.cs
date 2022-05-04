using Task;

Console.WriteLine("");
Station st = new Station("Saratov");
st.AddWNoDiscount("Irpen",140);
st.AddWNoDiscount("Kolyma",80);
st.AddWNoDiscount("Omsk",200);
st.AddWNoDiscount("St-Petersburg",600);
st.AddWithDiscount("Moscow",700,20);
st.AddWithDiscount("Smolensk",140,50);
st.AddWithDiscount("Jitomir",120,30);
st.AddWithDiscount("Novgorod",100,29);
Console.WriteLine(st.GetCheapest());