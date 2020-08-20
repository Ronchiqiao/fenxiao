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
	public class mljDaoTest : CommonDaoTest<mlj, ImljDao, mljDdlBuilder>
	{
		public mljDaoTest() : base(mljTestData.Createmlj())
		{
		}

		[TestCase]
		public void SelectAllTest()
		{
			Assert.AreEqual(mljTestData.mljCount, this.Dao.SelectAll(this.Context).Count);
		}

		[TestCase]
		public void SelectByIdTest()
		{
			mlj item = mljTestData.Createmlj1();
			mlj find = this.Dao.SelectById(this.Context, item);

			Assert.AreEqual(item.Id, find.Id);
			mljTestData.AssertAreEqual(item, find);
		}

		[TestCase]
		public void InsertTest()
		{
			mlj item = new mlj
			{
				mkl = string.Empty, 
				Description = string.Empty, 
				Name = string.Empty, 
			};
			int affectedRows = this.Dao.Insert(this.Context, item);
			Assert.AreEqual(1, affectedRows);

			mlj find = this.Dao.SelectById(this.Context, item);
			mljTestData.AssertAreEqual(item, find);

			List<mlj> items = this.Dao.SelectAll(this.Context);
			Assert.AreEqual(mljTestData.mljCount + 1, items.Count);
		}

		[TestCase]
		public void UpdateTest()
		{
			mlj item = mljTestData.Createmlj1();
			mlj beforeUpdate = this.Dao.SelectById(this.Context, item);
			Assert.IsNotNull(beforeUpdate);
			beforeUpdate.mkl = string.Empty;

			this.Dao.Update(this.Context, beforeUpdate);

			mlj afterUpdate = this.Dao.SelectById(this.Context, beforeUpdate);
			mljTestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}

		[TestCase]
		public void DeleteTest()
		{
			mlj item = mljTestData.Createmlj1();
			mlj beforedelete = this.Dao.SelectById(this.Context, item);
			Assert.IsNotNull(beforedelete);

			int affectedRows = this.Dao.Delete(this.Context, beforedelete);
			Assert.AreEqual(1, affectedRows);

			mlj afterDelete = this.Dao.SelectById(this.Context, beforedelete);
			Assert.IsNull(afterDelete);

			List<mlj> items = this.Dao.SelectAll(this.Context);
			Assert.AreEqual(mljTestData.mljCount - 1, items.Count);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
