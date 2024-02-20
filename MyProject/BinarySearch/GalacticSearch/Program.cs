/* Представим, что у нас есть массив данных о различных звездных системах, отсортированных по расстоянию от Земли,
и каждая звездная система может содержать уникальный космический артефакт.

Наша задача - использовать бинарный поиск для быстрого определения наличия космического артефакта в звездной 
системе по заданному расстоянию.
*/

using System;
using System.Globalization;

class GalacticSearch
{
    class StarSystem
    {
        public string Name { get; set; }
        public double DistanceFromEarth { get; set; }
        public bool ContainsArtifact { get; set; }
    }

    static StarSystem[] starSystems = new StarSystem[]
    {
        new StarSystem { Name = "Alpha Centauri", DistanceFromEarth = 4.37, ContainsArtifact = false },
        new StarSystem { Name = "Proxima Centauri", DistanceFromEarth = 4.24, ContainsArtifact = true },
        new StarSystem { Name = "Sirius", DistanceFromEarth = 8.58, ContainsArtifact = false },
        new StarSystem { Name = "Vega", DistanceFromEarth = 25.04, ContainsArtifact = true },
        new StarSystem { Name = "Betelgeuse", DistanceFromEarth = 309.78, ContainsArtifact = false }
    };

    static bool FindArtifact(double targetDistance)
    {
        int left = 0;
        int right = starSystems.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (Math.Abs(starSystems[mid].DistanceFromEarth - targetDistance) < 0.0001)
            {
                if (starSystems[mid].ContainsArtifact)
                {
                    Console.WriteLine($"Космический артефакт найден в звездной системе {starSystems[mid].Name}!");
                    return true;
                }
                else
                {
                    Console.WriteLine($"В звездной системе {starSystems[mid].Name} нет космического артефакта.");
                    return false;
                }
            }
            else if (starSystems[mid].DistanceFromEarth < targetDistance)
                left = mid + 1;
            else
                right = mid - 1;
        }

        Console.WriteLine("Космический артефакт не найден в заданном расстоянии.");
        return false;
    }

    static void Main()
    {
        Console.Write("Введите расстояние от Земли для поиска космического артефакта: ");
        string input = Console.ReadLine();

        // Используем культуру, в которой точка (.) является десятичным разделителем
        double targetDistance = double.Parse(input, CultureInfo.InvariantCulture);

        FindArtifact(targetDistance);
    }
}