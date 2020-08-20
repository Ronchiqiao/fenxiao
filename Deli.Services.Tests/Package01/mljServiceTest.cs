using System;
using System.Collections.Generic;
using NUnit.Framework;
using Deli.Entities.Package01;
using Deli.TestData.Package01;
using Deli.Services.Tests.Common;
using Deli.Services.Interfaces.Package01;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Deli.Services.Tests.Package01
{

	[TestFixture]
	public class mljServiceTest : CommonServiceTest<mlj, ImljService>
	{
		[TestCase]
		public void SelectAllTest()
		{
			List<mlj> items = this.Service.SelectAll();
			Assert.AreEqual(mljTestData.mljCount, items.Count);
		}

		[TestCase]
		public void SelectByTest()
		{
			mlj itemTest = mljTestData.Createmlj1();

			List<mlj> find = this.Service.SelectBy(new mlj {mkl = itemTest.mkl}, new List<string> {"mkl"});
			Assert.IsNotNull(find);

			foreach (mlj item in find)
			{
				Assert.AreEqual(itemTest.mkl, item.mkl);
			}
		}

		[TestCase]
		public void SelectByIdTest()
		{
			mlj itemTest = mljTestData.Createmlj1();

			mlj find = this.Service.SelectById(new mlj {Id = itemTest.Id});
			Assert.IsNotNull(find);

			mljTestData.AssertAreEqual(itemTest, find);
		}

		[TestCase]
		public void DeleteTest()
		{
			mlj itemTest = mljTestData.Createmlj2();
			int affectedRows = this.Service.Delete(itemTest, true);

			List<mlj> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, mljTestData.mljCount - 1);
			Assert.AreEqual(-1, affectedRows);
		}

		[TestCase]
		public void InsertTest()
		{
			mlj itemTest = new mlj
			{
				mkl = string.Empty, 
				Description = string.Empty, 
				Name = string.Empty, 
			};

			int affectedRows = this.Service.Insert(itemTest, true);

			List<mlj> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, mljTestData.mljCount + 1);
			Assert.AreEqual(1, affectedRows);
		}

		[TestCase]
		public void UpdateTest()
		{
			mlj itemTest = mljTestData.Createmlj1();

			mlj beforeUpdate = this.Service.SelectById(new mlj {Id = itemTest.Id});
			beforeUpdate.mkl = string.Empty ;
			this.Service.Update(beforeUpdate, true);

			mlj afterUpdate = this.Service.SelectById(new mlj {Id = itemTest.Id});
			mljTestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}

}
