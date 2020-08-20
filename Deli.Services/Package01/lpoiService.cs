using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using Deli.Entities.Package01;
using MetaShare.Common.Core.Services;
using Deli.Daos.Interfaces.Package01;
using Deli.Services.Interfaces.Package01;

/*add customized code between this region*/
/*add customized code between this region*/

namespace Deli.Services.Package01
{
	public class lpoiService : Service<lpoi>, IlpoiService
	{
		public lpoiService() : base(typeof (IlpoiDao))
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
