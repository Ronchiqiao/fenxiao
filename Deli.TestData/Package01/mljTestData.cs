using System;
using System.Collections.Generic;
using NUnit.Framework;
using Deli.Entities.Package01;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Deli.TestData.Package01
{
	public class mljTestData
	{
		public const int mljCount = 3;
		/*add customized code between this region*/
		/*add customized code between this region*/

		 public static List<mlj> Createmlj()
		{
			return new List<mlj>
			{
				Createmlj1(),
				Createmlj2(),
				Createmlj3(),
			};
		}

		 public static mlj Createmlj1()
		{
			return new mlj
			{
					Id = 1, 
					mkl = string.Empty, 
					Description = string.Empty, 
					Name = string.Empty, 
			};
		}
		 public static mlj Createmlj2()
		{
			return new mlj
			{
					Id = 2, 
					mkl = string.Empty, 
					Description = string.Empty, 
					Name = string.Empty, 
			};
		}
		 public static mlj Createmlj3()
		{
			return new mlj
			{
					Id = 3, 
					mkl = string.Empty, 
					Description = string.Empty, 
					Name = string.Empty, 
			};
		}
		public static void AssertAreEqual(mlj expected, mlj actual)
		{
			Assert.AreEqual(expected.mkl, actual.mkl);
			Assert.AreEqual(expected.Description, actual.Description);
			Assert.AreEqual(expected.Name, actual.Name);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
