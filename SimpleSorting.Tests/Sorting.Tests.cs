
using NUnit.Framework;

namespace SimpleSorting.Tests {

  public class SortingTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InsertSort()
        {
            //Assign 
            var array = new int[] {5, 3, 4, 2, 1};
            
            var sut = new Sorting();

            //Act
            var result = sut.InsertSort(array);

            //Assert
            for(int i = 0; i < array.Length - 1; i++) 
            {
                var first = array[i];
                var second = array[i+1];
                if (first > second) {
                    Assert.Fail("Array doesn't sorted");
                }
            }
            
        }

        [Test]
        public void SelectionSort()
        {
            //Assign 
            var array = new int[] {5, 3, 4, 2, 1};
            
            var sut = new Sorting();

            //Act
            var result = sut.SelectionSort(array);

            //Assert
            for(int i = 0; i < array.Length - 1; i++) 
            {
                var first = array[i];
                var second = array[i+1];
                if (first > second) {
                    Assert.Fail("Array doesn't sorted");
                }
            }
        }

        [Test]
        public void BubbleSort()
        {
            //Assign 
            var array = new int[] {5, 3, 4, 2, 1};
            
            var sut = new Sorting();

            //Act
            var result = sut.BubbleSort(array);

            //Assert
            for(int i = 0; i < array.Length - 1; i++) 
            {
                var first = array[i];
                var second = array[i+1];
                if (first > second) {
                    Assert.Fail("Array doesn't sorted");
                }
            }
            
        }

    }

}
