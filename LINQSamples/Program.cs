using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQSamples
{
  class Program
  {
    static void Main(string[] args)
    {
            // Instantiate the Samples ViewModel
            SamplesViewModel vm = new SamplesViewModel
            {
                // Use Query or Method Syntax?
                UseQuerySyntax = true
            };

            // Call a sample method
            //vm.GetAllLooping();
            //vm.GetAll();
            //vm.GetSingleColumn();
            //vm.GetSpecificColumns();
            //vm.AnonymousClass();
            //vm.OrderBy();
            //vm.OrderByTwoFields();
            //vm.WhereExpression();
            //vm.WhereTwoFields();
            //vm.WhereExtensionMethod();
            //vm.First();
            //vm.FirstOrDefault();
            //vm.Last();
            //vm.LastOrDefault();
            //vm.FirstOrDefault();
            //vm.ForEach();
            //vm.ForEachCallingMethod();
            //vm.Take(); //return n number from list alphabetical equivalent to a SELECT TOP in SQL
            //vm.TakeWhile();//Take a certain amount of elements as long as a condition is met.
            //vm.Skip();//skip specific amount of elements
            //vm.SkipWhile();// skip all elements withs tarting name A.
            //vm.Distinct(); //eliminates duplicates, lists only unique elements.
            //vm.Any(); //Show any and all elements that match the search value;
            //vm.LINQContains();//Easy for simple types (strings, ints, etc) But reference objects is more complicated see next method
            //vm.LINQContainsUsingComparer(); //Default is to compare object reference, but you most likely want VALUE of the property object.
            // to do this, you need a Equality object comparer class. override equality and hashcode.
            //vm.SequenceEqualIntegers();
            //vm.SequenceEqualUsingComparer();
            //vm.ExceptIntegers();
            //vm.Except();
            //vm.Intersect();
            //vm.Union();
            //vm.LINQConcat();
            //vm.InnerJoin();
            //vm.InnerJoinTwoFields();
            //vm.GroupJoin();
            //vm.LeftOuterJoin();
            //vm.GroupBy();
            //vm.GroupByIntoSelect();
            //vm.GroupByOrderByKey();
            //vm.GroupByWhere();
            //vm.GroupedSubquery();
            //vm.Count();
            //vm.CountFiltered();
            //vm.Minimum();
            //vm.Maximum();
            //vm.Average();
            //vm.Sum();
            //vm.AggregateSum();
            //vm.AggregateCustom();
            vm.AggregateUsingGrouping();


            // Display Product Collection
            //foreach (var item in vm.Products) {
            //   Console.Write(item.ToString());
            //}

            // Display Result Text
            Console.WriteLine(vm.ResultText);
    }
  }
}
