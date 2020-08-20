using MetaShare.Common.Core.Daos;
using Deli.Entities.Package01;
using Deli.Daos.Interfaces.Package01;
using Deli.TestData.Package01;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Deli.Daos.Mocks.Package01
{
	public class lpoiDaoMock : MockDao<lpoi>, IlpoiDao
	{
		public lpoiDaoMock() : base(lpoiTestData.Createlpoi())
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
