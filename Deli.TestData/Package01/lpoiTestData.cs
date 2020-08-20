using System;
using System.Collections.Generic;
using NUnit.Framework;
using Deli.Entities.Package01;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Deli.TestData.Package01
{
	public class lpoiTestData
	{
		public const int lpoiCount = 3;
		/*add customized code between this region*/
		/*add customized code between this region*/

		 public static List<lpoi> Createlpoi()
		{
			return new List<lpoi>
			{
				Createlpoi1(),
				Createlpoi2(),
				Createlpoi3(),
			};
		}

		 public static lpoi Createlpoi1()
		{
			return new lpoi
			{
					Id = 1, 
					Description = string.Empty, 
					klj = string.Empty, 
					Name = string.Empty, 
			};
		}
		 public static lpoi Createlpoi2()
		{
			return new lpoi
			{
					Id = 2, 
					Description = string.Empty, 
					klj = string.Empty, 
					Name = string.Empty, 
			};
		}
		 public static lpoi Createlpoi3()
		{
			return new lpoi
			{
					Id = 3, 
					Description = string.Empty, 
					klj = string.Empty, 
					Name = string.Empty, 
			};
		}
		public static void AssertAreEqual(lpoi expected, lpoi actual)
		{
			Assert.AreEqual(expected.Description, actual.Description);
			Assert.AreEqual(expected.klj, actual.klj);
			Assert.AreEqual(expected.Name, actual.Name);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
