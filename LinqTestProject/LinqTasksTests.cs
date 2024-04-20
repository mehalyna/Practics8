using NUnit.Framework;
using Practics_8;
using System.Collections.Generic;

namespace LinqTestProject
{
    

    [TestFixture]
    public class LinqTasksTests
    {
        private LinqTasks _tasks;

        [SetUp]
        public void Setup()
        {
            _tasks = new LinqTasks();
        }

        [Test]
        public void TestGetEvenNumbers()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var result = _tasks.GetEvenNumbers(numbers);
            Assert.That(result, Is.EqualTo(new List<int> { 2, 4, 6 }));
        }

        [Test]
        public void TestGetSum()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var result = _tasks.GetSum(numbers);
            Assert.That(result, Is.EqualTo(15));
        }
       
        [Test]
        public void TestGetLongStrings()
        {
            var strings = new List<string> { "hi", "hello", "hey", "welcome" };
            var result = _tasks.GetLongStrings(strings);
            Assert.That(result, Is.EqualTo(new List<string> { "hello", "welcome" }));
        }

        [Test]
        public void TestFindPersonByName()
        {
            var people = new List<Person>
            {
                new Person { Name = "John" },
                new Person { Name = "Jane" }
            };
            var result = _tasks.FindPersonByName(people, "Jane");
            Assert.IsNotNull(result);
            Assert.That(result.Name, Is.EqualTo("Jane"));
        }

        [Test]
        public void TestSortDescending()
        {
            var numbers = new List<int> { 5, 1, 3, 2, 4 };
            var result = _tasks.SortDescending(numbers);
            Assert.That(result, Is.EqualTo(new List<int> { 5, 4, 3, 2, 1 }));
        }

        [Test]
        public void TestGroupByAge()
        {
            var people = new List<Person>
            {
                new Person { Name = "John", Age = 20 },
                new Person { Name = "Jane", Age = 30 },
                new Person { Name = "Doe", Age = 20 }
            };
            var groups = _tasks.GroupByAge(people).ToList();
            Assert.That(groups.Count, Is.EqualTo(2));
            Assert.That(groups.FirstOrDefault(g => g.Key == 20)?.Count(), Is.EqualTo(2));
        }

        [Test]
        public void TestAnyNumberGreaterThanTen()
        {
            var numbers = new List<int> { 9, 10, 11, 1 };
            var result = _tasks.AnyNumberGreaterThanTen(numbers);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestSelectNames()
        {
            var people = new List<Person>
            {
                new Person { Name = "John" },
                new Person { Name = "Jane" }
            };
            var result = _tasks.SelectNames(people);
            Assert.That(result, Is.EqualTo(new List<string> { "John", "Jane" }));
        }

        [Test]
        public void TestAllPositive()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var result = _tasks.AllPositive(numbers);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestConcatenateLists()
        {
            var list1 = new List<int> { 1, 2, 3 };
            var list2 = new List<int> { 4, 5, 6 };
            var result = _tasks.ConcatenateLists(list1, list2);
            Assert.That(result, Is.EqualTo(new List<int> { 1, 2, 3, 4, 5, 6 }));
        }

    }

}