using System.Collections.Generic;
using NUnit.Framework;
using System;
using Deli.Daos.Interfaces.Package01;
using Deli.Daos.DataSchema.Package01;
using Deli.TestData.Package01;
using Deli.Daos.Tests.Common;
using Deli.Entities.Package01;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Deli.Daos.Tests.Package01
{
	public class lpoiDaoTest : CommonDaoTest<lpoi, IlpoiDao, lpoiDdlBuilder>
	{
		public lpoiDaoTest() : base(lpoiTestData.Createlpoi())
		{
		}

		[TestCase]
		public void SelectAllTest()
		{
			Assert.AreEqual(lpoiTestData.lpoiCount, this.Dao.SelectAll(this.Context).Count);
		}

		[TestCase]
		public void SelectByIdTest()
		{
			lpoi item = lpoiTestData.Createlpoi1();
			lpoi find = this.Dao.SelectById(this.Context, item);

			Assert.AreEqual(item.Id, find.Id);
			lpoiTestData.AssertAreEqual(item, find);
		}

		[TestCase]
		public void InsertTest()
		{
			lpoi item = new lpoi
			{
				Description = string.Empty, 
				klj = string.Empty, 
				Name = string.Empty, 
			};
			int affectedRows = this.Dao.Insert(this.Context, item);
			Assert.AreEqual(1, affectedRows);

			lpoi find = this.Dao.SelectById(this.Context, item);
			lpoiTestData.AssertAreEqual(item, find);

			List<lpoi> items = this.Dao.SelectAll(this.Context);
			Assert.AreEqual(lpoiTestData.lpoiCount + 1, items.Count);
		}

		[TestCase]
		public void UpdateTest()
		{
			lpoi item = lpoiTestData.Createlpoi1();
			lpoi beforeUpdate = this.Dao.SelectById(this.Context, item);
			Assert.IsNotNull(beforeUpdate);
			beforeUpdate.Description = string.Empty;

			this.Dao.Update(this.Context, beforeUpdate);

			lpoi afterUpdate = this.Dao.SelectById(this.Context, beforeUpdate);
			lpoiTestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}

		[TestCase]
		public void DeleteTest()
		{
			lpoi item = lpoiTestData.Createlpoi1();
			lpoi beforedelete = this.Dao.SelectById(this.Context, item);
			Assert.IsNotNull(beforedelete);

			int affectedRows = this.Dao.Delete(this.Context, beforedelete);
			Assert.AreEqual(1, affectedRows);

			lpoi afterDelete = this.Dao.SelectById(this.Context, beforedelete);
			Assert.IsNull(afterDelete);

			List<lpoi> items = this.Dao.SelectAll(this.Context);
			Assert.AreEqual(lpoiTestData.lpoiCount - 1, items.Count);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
