// Контрольная работа
string[] mass = { "Hello",  "Привет",  "How are you",  "Hi", "Bye" };
string[] GetNewMassIf (string[] mass)
{
    string [] newMass = new string[mass.Length];
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length <= 3)
        {
            newMass[i] = mass[i];
        }
    }
    return newMass;
}
void PrintArray(string[] mass)
{
    foreach (string i in mass)
        Console.Write($"{i} ");
}
string [] newMass = GetNewMassIf(mass);
PrintArray(newMass);