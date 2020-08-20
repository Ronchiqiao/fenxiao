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
	public class mljService : Service<mlj>, ImljService
	{
		public mljService() : base(typeof (ImljDao))
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
