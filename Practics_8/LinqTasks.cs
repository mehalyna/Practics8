using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_8
{
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }

    public class LinqTasks
    {
        public IEnumerable<int> GetEvenNumbers(List<int> numbers)
        {
            return numbers.Where(x => x % 2 == 0);
        }

        public int GetSum(List<int> numbers)
        {
            return numbers.Sum();
        }

        public IEnumerable<string> GetLongStrings(List<string> strings)
        {
            return strings.Where(s => s.Length > 3);
        }


        public Person FindPersonByName(List<Person> people, string name)
        {
            return people.FirstOrDefault(p => p.Name == name);
        }

        public IEnumerable<int> SortDescending(List<int> numbers)
        {
            return numbers.OrderByDescending(x => x);
        }

        public IEnumerable<IGrouping<int, Person>> GroupByAge(List<Person> people)
        {
            return people.GroupBy(p => p.Age);
        }

        public bool AnyNumberGreaterThanTen(List<int> numbers)
        {
            return numbers.Any(n => n > 10);
        }

        public IEnumerable<string?> SelectNames(List<Person> people)
        {
            return people.Select(p => p.Name);
        }

        public bool AllPositive(List<int> numbers)
        {
            return numbers.All(n => n > 0);
        }

        public IEnumerable<int> ConcatenateLists(List<int> list1, List<int> list2)
        {
            return list1.Concat(list2);
        }


    }

}
