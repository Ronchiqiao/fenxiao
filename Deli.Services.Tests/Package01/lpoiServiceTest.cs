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
	public class lpoiServiceTest : CommonServiceTest<lpoi, IlpoiService>
	{
		[TestCase]
		public void SelectAllTest()
		{
			List<lpoi> items = this.Service.SelectAll();
			Assert.AreEqual(lpoiTestData.lpoiCount, items.Count);
		}

		[TestCase]
		public void SelectByTest()
		{
			lpoi itemTest = lpoiTestData.Createlpoi1();

			List<lpoi> find = this.Service.SelectBy(new lpoi {Description = itemTest.Description}, new List<string> {"Description"});
			Assert.IsNotNull(find);

			foreach (lpoi item in find)
			{
				Assert.AreEqual(itemTest.Description, item.Description);
			}
		}

		[TestCase]
		public void SelectByIdTest()
		{
			lpoi itemTest = lpoiTestData.Createlpoi1();

			lpoi find = this.Service.SelectById(new lpoi {Id = itemTest.Id});
			Assert.IsNotNull(find);

			lpoiTestData.AssertAreEqual(itemTest, find);
		}

		[TestCase]
		public void DeleteTest()
		{
			lpoi itemTest = lpoiTestData.Createlpoi2();
			int affectedRows = this.Service.Delete(itemTest, true);

			List<lpoi> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, lpoiTestData.lpoiCount - 1);
			Assert.AreEqual(-1, affectedRows);
		}

		[TestCase]
		public void InsertTest()
		{
			lpoi itemTest = new lpoi
			{
				Description = string.Empty, 
				klj = string.Empty, 
				Name = string.Empty, 
			};

			int affectedRows = this.Service.Insert(itemTest, true);

			List<lpoi> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, lpoiTestData.lpoiCount + 1);
			Assert.AreEqual(1, affectedRows);
		}

		[TestCase]
		public void UpdateTest()
		{
			lpoi itemTest = lpoiTestData.Createlpoi1();

			lpoi beforeUpdate = this.Service.SelectById(new lpoi {Id = itemTest.Id});
			beforeUpdate.Description = string.Empty ;
			this.Service.Update(beforeUpdate, true);

			lpoi afterUpdate = this.Service.SelectById(new lpoi {Id = itemTest.Id});
			lpoiTestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}

}
